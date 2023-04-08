using System;
using System.Collections.Generic;

namespace Utilidades
{
    public class RedNeuronal
    {
        public double[,] SalidasDeseadas { get; set; }
        public double[,] SalidasReales { get; set; }
        public double[,] Entradas { get; set; }

        public double[] MayoresEntradas { get; set; }
        public double[] MayoresSalidas { get; set; }
        public double RataDinamica { get; set; }
        public int AlgoritmoEntrenamiento { get; set; } //0 Regla Delta, 1 Backpropagation
        public double ErrorMaximo { get; set; }
        public double ErrorEntrenamiento { get; set; } = 5;
        public double RataAprendizaje { get; set; } = 0.0;
        public int Patrones { get; set; }
        public int IteracionesEntrenamiento { get; set; }
        public int IteracionesRequeridas { get; set; }
        public int CantidadEntradas { get; set; }
        public int CantidadSalidas { get; set; }        
        public bool Entrenando { get; set; }
        public List<Capas> Capas { get; set; }
        public bool Entrenada { get; set; }
        public double[] variacionRealDeseada { get; set; }
        public double[] ErroresLinealUltimaCapa { get; set; }

        public RedNeuronal() { }
        public RedNeuronal(double[,] salidasDeseadas, int patrones,
            double[,] entradas, int BackPropagation = 0)
        {            
            this.Patrones = patrones;
            CantidadEntradas = entradas.GetLength(1);
            CantidadSalidas = salidasDeseadas.GetLength(1);
            MapEntradas(entradas);
            MapSalidasDeseadas(salidasDeseadas);            
            ErroresLinealUltimaCapa = new double[CantidadSalidas];
            MayoresEntradas = new double[Entradas.GetLength(1)];
            MayoresSalidas = new double[SalidasDeseadas.GetLength(1)];
            NormalizarPatrones();
            variacionRealDeseada = new double[CantidadSalidas * 2];
            this.AlgoritmoEntrenamiento = BackPropagation;
        }
        public void ParametrosEntrenaiento(double errorMaximo, double rataAprendizaje, int iteracionesRequeridas,
            int[] funcionActivacion, double rataDinamica = 0)
        {            
            this.ErrorMaximo = errorMaximo;
            this.RataAprendizaje = rataAprendizaje;
            this.IteracionesRequeridas = iteracionesRequeridas;
            //this.IteracionesEntrenamiento = 0;
            this.RataDinamica = rataDinamica;            
            for (int i = 0; i < funcionActivacion.Length; i++)
            {
                Capas[i].FuncionActivacion = funcionActivacion[i];
            }
        }
        private void MapSalidasDeseadas(double[,] salidasDeseadas)
        {
            this.SalidasDeseadas = salidasDeseadas;
            SalidasReales = new double[salidasDeseadas.GetLength(0), salidasDeseadas.GetLength(1)];
        }
        private void MapEntradas(double[,] entradas)
        {
            this.Entradas = entradas;            
        }
        private void NormalizarPatrones()
        {
            BuscarMayores();
            for (int i = 0; i < Entradas.GetLength(0); i++)
            {
                for (int j = 0; j < Entradas.GetLength(1); j++)
                {
                    Entradas[i, j] /= MayoresEntradas[j];
                }
            }
            for (int i = 0; i < SalidasDeseadas.GetLength(0); i++)
            {
                for (int j = 0; j < SalidasDeseadas.GetLength(1); j++)
                {
                    SalidasDeseadas[i, j] /= MayoresSalidas[j];
                }
            }
        }
        private void BuscarMayores()
        {            
            for (int i = 0; i < Entradas.GetLength(0); i++)
            {
                for (int j = 0; j < Entradas.GetLength(1); j++)
                {
                    if (Entradas[i,j] > MayoresEntradas[j])
                    {
                        MayoresEntradas[j] = Entradas[i, j];
                    } 
                }
            }
            for (int i = 0; i < SalidasDeseadas.GetLength(0); i++)
            {
                for (int j = 0; j < SalidasDeseadas.GetLength(1); j++)
                {
                    if (Math.Abs(SalidasDeseadas[i, j]) > Math.Abs( MayoresSalidas[j]))
                    {
                        MayoresSalidas[j] = SalidasDeseadas[i, j];
                    }
                }
            }
        }
        public void Entrenar()
        {
            Entrenando = true;
            IteracionesEntrenamiento += 1;
            //Console.WriteLine("Iteracion: " + IteracionesEntrenamiento);
            ErrorEntrenamiento = 0;
            for (int i = 0; i < Patrones; i++)
            {
                double errorPorPatron = 0.0;                
                double[] patronDeEntrenamiento = ObtenerPatron(i,Entradas);                                
                errorPorPatron = GetErrorPatron(RecorrerCapas(patronDeEntrenamiento), i);
                //variacionRealDeseada[i] = Capas[ultimaCapa].Salidas[i];
                errorPorPatron /= CantidadSalidas;
                //Console.WriteLine("Error Por Patron: " + errorPorPatron);
                ErrorEntrenamiento += errorPorPatron;
                if (AlgoritmoEntrenamiento == 1)
                {
                    CalcularErroresNoLineales();
                }
                ActulizarPesosUmbrales(errorPorPatron, patronDeEntrenamiento);
            }
            ErrorEntrenamiento /= Patrones;
            RataDinamica /= IteracionesEntrenamiento;
            //for(int i = 0;i < patrones; i++)
            //Console.WriteLine("Error de Entrenamiento: " + ErrorEntrenamiento);
            //Prueba con error Entrenamiento
            if (ErrorEntrenamiento < ErrorMaximo)
                Entrenando = false;
        }

        private double[] RecorrerCapas(double[] patronDeEntrenamiento, int simulacion = 0)
        {
            //Console.WriteLine("============================ Capa 0 ============================ ");
            Capas[0].CalculaCapa(patronDeEntrenamiento,simulacion);
            for (int j = 1; j < Capas.Count; j++)
            {
                //Console.WriteLine("============================ Capa " + (j).ToString() + " ============================ ");
                Capas[j].CalculaCapa(Capas[j - 1].Salidas, simulacion);
            }
            return Capas[Capas.Count-1].Salidas;
        }

        private double GetErrorPatron(double[] salidasDeCapa,int indicePatron)
        {
            double errorPatron = 0.0;
            for (int i = 0; i < salidasDeCapa.Length; i++)
            {
                ErroresLinealUltimaCapa[i] = -salidasDeCapa[i] + SalidasDeseadas[indicePatron, i];
                SalidasReales[indicePatron, i] = salidasDeCapa[i];
                //Console.WriteLine("Error Lienal[" + i + "]: " + ErroresLinealUltimaCapa[i]);
                errorPatron += Math.Abs(ErroresLinealUltimaCapa[i]);
            }
            Capas[Capas.Count - 1].ErroresLineales = ErroresLinealUltimaCapa;
            return errorPatron;
        }
        private void ActulizarPesosUmbrales(double errorPatron, double[] patronDeEntrenamiento)
        {               
            if (Capas.Count == 1)
            {
                Capas[0].ModificarPesos(patronDeEntrenamiento, RataAprendizaje, errorPatron, RataDinamica,AlgoritmoEntrenamiento);
            }
            else
            {
                //Primera capa se le pasa patrones de entreamiento
                Capas[0].ModificarPesos(patronDeEntrenamiento, RataAprendizaje, errorPatron, RataDinamica,AlgoritmoEntrenamiento);
                for (int i = 1; i < Capas.Count; i++)
                {                                    
                    Capas[i].ModificarPesos(Capas[i - 1].Salidas, RataAprendizaje, errorPatron, RataDinamica,AlgoritmoEntrenamiento);                                                            
                }
            }
        }

        public double[] ObtenerPatron(int indice, double[,] Entradas) 
        {
            double[] vector = new double[CantidadEntradas];
            for (int i = 0; i < Entradas.GetLength(1); i++)
            {
                vector[i] = Entradas[indice,i];
            }
            return vector;
        }

        public double[] SimularRed(double[] patron)
        {
            for (int i = 0; i < CantidadEntradas; i++)
            {
                patron[i] /= MayoresEntradas[i];
            }
            double[] salidaSimulada = RecorrerCapas(patron, 1);
            for (int i = 0; i < CantidadSalidas; i++)
            {
                salidaSimulada[i] *= MayoresSalidas[i];
            }
            return salidaSimulada;
        }
        public void CreaCapas(int[] NeuronasPorCapa, Random azar)
        {
            Capas = new List<Capas>();            
            for (int i = 0; i < NeuronasPorCapa.Length; i++)      
                if(i == 0 && i == (NeuronasPorCapa.Length - 1))
                    Capas.Add(new Capas(NeuronasPorCapa[i], Entradas.GetLength(1),
                        azar,2));
                else if(i==0)
                    Capas.Add(new Capas(NeuronasPorCapa[i], Entradas.GetLength(1),
                        azar, 1));
                else if(i == (NeuronasPorCapa.Length-1))
                    Capas.Add(new Capas(NeuronasPorCapa[i], NeuronasPorCapa[i - 1],
                        azar, 2));
                else
                    Capas.Add(new Capas(NeuronasPorCapa[i], NeuronasPorCapa[i - 1],
                        azar,1));
        }

        /////Metodos y funciones para la BackPropagation
        private void CalcularErroresNoLineales()
        {                                  
            Capas[Capas.Count - 2].CalcularErroresNoLineales(Capas[Capas.Count-1].MatrizPesos,
                Capas[Capas.Count - 1].ErroresLineales);
            for (int i = Capas.Count -3; i >= 0; i--)
            {
                Capas[i].CalcularErroresNoLineales(Capas[i + 1].MatrizPesos, Capas[i + 1].ErroresNoLineales);
            }
        }
    }

}
