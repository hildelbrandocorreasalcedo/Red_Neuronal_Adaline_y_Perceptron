using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class Capas
    {
        public int Tipo { get; set; }
        public int FuncionActivacion { get; set; }
        public double[] Salidas { get; set; }
        public List<Neuronas> Neuronas { get; set; }
        public double[] ErroresNoLineales { get; set; }    
        public double[] ErroresLineales { get; set; }
        public double[,] MatrizPesos { get; set; }
        public Capas(int totalNeuronas, int totalEntradas, Random azar, int tipo)
        {            
            Neuronas = new List<Neuronas>();
            for (int i = 0; i < totalNeuronas; i++) Neuronas.Add(new Neuronas(azar, totalEntradas));
            Salidas = new double[totalNeuronas];            
            ErroresNoLineales = new double[totalNeuronas];
            ErroresLineales = new double[totalNeuronas];
            this.Tipo = tipo;
            MatrizPesos = new double[totalEntradas, totalNeuronas];
        }
        public Capas()
        {

        }
        private void GuardarPesos(int indice,double[] pesosNeurona)
        {
            for (int i = 0; i < pesosNeurona.Length; i++)
            {
                MatrizPesos[i,indice] = pesosNeurona[i];
            }
        }
        public void CalculaCapa(double[] entradas, int simulacion)
        { //Calcula las salidas de la capa             
            //Console.WriteLine("Entra: ");
            for (int cont2 = 0; cont2 < entradas.Length; cont2++) Console.Write("{0:F4}; ", entradas[cont2]);
            for (int i = 0; i < Neuronas.Count; i++)
            {
                GuardarPesos(i, Neuronas[i].Pesos);
                Salidas[i] = Neuronas[i].CalcularSalida(entradas,
                    FuncionActivacion, simulacion);
            }
            //Console.WriteLine(" ");
            //Console.WriteLine("Sale: ");
            //for (int cont2 = 0; cont2 < Salidas.Length; cont2++)
            //{
            //    Console.Write("Neurona " +cont2+": ");
            //    Console.Write("{0:F4}; ", Salidas[cont2]);
            //    Console.WriteLine("\n");
            //}
            //Console.WriteLine(" ");
        }   
        public void ModificarPesos(double[] entradas, double rataAprendizaje,
            double errorPatron = 0, double rataDinamica = 0,int BackPropagation=0)
        {//Error lineal o por patron depende la capa
            int i = 0;
            foreach (var neurona in Neuronas)
            {
                if(Tipo != 2)
                {
                    if(BackPropagation ==1)
                        neurona.ModificarPesos(entradas, rataAprendizaje, ErroresNoLineales[i], rataDinamica,BackPropagation);
                    else
                        neurona.ModificarPesos(entradas, rataAprendizaje, errorPatron, rataDinamica);
                }
                else
                    neurona.ModificarPesos(entradas, rataAprendizaje, ErroresLineales[i],rataDinamica, BackPropagation,Tipo);
                i++;
            }
        }

        public void CalcularErroresNoLineales(double[,] pesosCapaSiguiente,
            double[] errores) //Pueden ser lineales o No lineales
        {
            //ErrorNoLineal = Sumatoria(pesos[i,j]*erroresNolineales[j])
            for (int i = 0; i < ErroresNoLineales.Length; i++)
            {
                ErroresNoLineales[i] = 0;
                for (int j = 0; j < pesosCapaSiguiente.GetLength(1); j++)
                {
                    ErroresNoLineales[i] += pesosCapaSiguiente[i,j]*
                        errores[j];
                }
            }
        }

        private double ErrorNoLineal(double[] pesosNeuronaSiguiente, double error) 
        {
            double errorNoLineal = 0.0;
            for (int i = 0; i < pesosNeuronaSiguiente.Length; i++)
            {
                errorNoLineal += error * pesosNeuronaSiguiente[i];
            }
            return errorNoLineal;
        }
    }
}
