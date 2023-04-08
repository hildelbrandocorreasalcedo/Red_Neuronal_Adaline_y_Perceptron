<h1 align="center">Red Neuronal Adaline y Perceptron</h1>

<p align="center"><strong>VIDEO DE Red Neuronal Adaline y Perceptron</</strong></p>

https://user-images.githubusercontent.com/63067085/230701548-f76969c6-4b84-4980-a62a-bb763dc0f350.mp4

<p align="center"><strong>IMAGEN DE Red Neuronal Perceptron Multicapa</</strong></p>

![Red Neuronal Adaline y Perceptron](https://user-images.githubusercontent.com/63067085/230701876-65b70baf-9083-41ba-b3a3-62efa8411c5e.jpeg)

<h1 align="center">Guia de Division de interfaz de la Red Neurona Multicapa Perceptron</h1>
<p>
  <ul>
    <li>1) Parametros de entradas: Insertar Dataset (archivo Excel csv).</li>
    <li>2) Configuracion de la Red: Algoritmo de entrenamiento (Regla delta), Numero de neuronas y Funcion de activacion dependiendo si es ADALINE(Lineal) O PERCEPTRON(Escalon)</li>
    <li>3) Inicializacion de pesos y umbrales: Generar pesos y umbrales aleatoriamente o cargar pesos/umbrales.</li>
    <li>4) Parametros de entrenamiento: configurar Numero de iteraciones, rata de aprendizaje y Error maximo.</li>
    <li>5) Fase de entrenamiento: Entrenar, detener y nuevo entrenamiento.</li>
    <li>6) Fase de Simulacion: Aqui despues de los resultados, añadimos solo valores de entrada, esperando resultados de las salidas YR entrenadas.</li>
  </ul>
</p>

<h1 align="center">Concepto de Red Neuronal Adaline</h1>
<p>
Generalmente se compone de una sola capa de n neuronas ( por tanto n valores de salida ) con m entradas con las siguientes características:
  <ul>
    <li>Las m entradas representan un vector x de entrada que pertenece al espacio {\displaystyle R^{m}}</li>
    <li>Por cada neurona, existe un vector w de pesos sinápticos que indican la fuerza de conexión entre los valores de entrada y la neurona. En la práctica representan la ponderación de cada entrada sobre la neurona.</li>
    <li>Una constante �\theta .</li>
    <li>La salida 
�
y de la neurona se representa por la función de activación, que se define como 
�
=
∑
�
=
1
�
�
�
�
�
+
�{\displaystyle y=\sum _{i=1}^{n}x_{i}w_{i}+\theta }</li>
  </ul>
</p>
