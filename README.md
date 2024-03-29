# TRUCO SIMULADOR

## Sobre Mí:

Mi nombre es Francis Romero y tengo 19 años. Actualmente estoy cursando el segundo cuatrimestre de la Tecnicatura en Programación. Durante el desarrollo de este proyecto, he logrado adquirir los nuevos conocimientos que se han puesto en práctica en mi programa de estudios. Tomé la decisión de crear un simulador del conocido y entretenido juego de cartas "Truco", ya que me pareció interesante programar un juego con una amplia variedad de reglas, puntajes y variantes.

En términos generales, el programa que he desarrollado simula una partida entre dos jugadores, con hasta 4 manos, y también brinda la posibilidad de crear un número indeterminado de mesas en las cuales se llevan a cabo partidas diferentes. Además, el programa permite visualizar estadísticas relacionadas con el juego. Para almacenar los datos importantes, he utilizado una base de datos a través de SQL Management Studio, lo cual garantiza la persistencia de dichos datos.

## Resumen

Esta experiencia me ha brindado un amplio conocimiento sobre el concepto de multihilos, excepciones y delegados, los cuales se aplican a lo largo de todo el programa en diferentes aspectos de su gestión.

## DIAGRAMA DE CLASES
![Diagrama de Clases](./DiagramaDeClasesBiblioteca.png)

![Diagrama de Clases](./DiagramaDeClasesTesteos.png)

## Justificación técnica

- **TEMA 1:** MANEJO DE SQL.
  - *Se introduce una capa de almacenamiento permanente mediante el uso de una base de datos en SQL. Esto se utiliza para conservar un registro histórico de los datos de las partidas concluidas de dicho juego.*

- **TEMA 2:** MANEJO DE EXCEPCIONES.
  - *Se utilizaron excepciones en el código para manejar situaciones excepcionales o errores que puedan ocurrir durante la ejecución del programa y tener la capacidad de manipular adecuadamente situaciones imprevistas.*

- **TEMA 3:** PRUEBAS UNITARIAS.
  - *Se incluyeron pruebas unitarias para verificar el funcionamiento correcto de unidades individuales de código, es decir, las clases de mi biblioteca.*

- **TEMA 4:** GENERICS.
  - *Se implementó una clase generica en la cual logre manipular un mazo de cartas de manera personalizada. A su vez, se añadió una clase de serializacion de tipo generica.*

- **TEMA 5:** INTERFACES.
  - *Se utilizaron interfaces para mejorar la flexibilidad del sistema y el ordenamiento del código.*

- **TEMA 6:** DELEGADOS Y EVENTOS.
  - *Se introdujo un delegado personalizado que es utilizado en conjunto con un evento.*

- **TEMA 7:** TASK.
  - *Generación de subprocesos y teniendo la posibilidad de mostrar la hora, actualizándose en tiempo real sin tomar el hilo principal.*
