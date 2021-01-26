# 8 Puzzle
8 Puzzle es un juego de desplazamiento de piezas las cuales
tienen un orden inicial. 

<div style="text-align: center;" >
    <img src="https://imgur.com/UygEYjJ.png" alt="">
</div>


El objetivo de este proyecto es realizar este juego por
consola utilizando __C#__, con los siguientes requerimientos:

* El estado inicial del juego es completamente aleatorio,
incluyendo el espacio vacío. Por ejemplo:


<div style="text-align: center;" >
    <img src="https://imgur.com/SY17c0N.png" alt="">
</div>


* El deslizamiento de las piezas se realizará utilizando
las teclas __(A W S D)__.
* Cada tecla desplazará el número respectivo en la
dirección indicada.
* __A__ mueve hacia la izquierda el número que esté
disponible.
* __W__ mueve hacia arriba el número que esté disponible.
* __S__ mueve hacia abajo el número que esté disponible.
* __D__ mueve hacia la derecha el número que esté disponible. 
* Se tiene que tomar en cuenta que el número disponible es aquel que se puede mover hacia el espacio vacío en la dirección indicada. Por ejemplo para la __Fig. 1__ los números disponibles son: 1 hacia la izquierda y 3 hacia arriba, por lo tanto, solo las teclas a y w serán las únicasque mostrarán algún resultado, las teclas restantes __(S y D)__ no alterarán de ningún modo el tablero. 
* El programa debe limpiar la consola en cada iteracióncuando se oprima una tecla. 
* El programa debe mostrar un mensaje __(“Hazcompletado el 8-puzzle”)__ si el jugador ha logrado
llegar al estado final del rompecabezas, el cual sería: 


<div style="text-align: center;" >
    <img src="https://imgur.com/08gbw4T.png" alt="">
</div>


* Adicionalmente el programa debe indicar el número de movimientos que el jugador ha realizado hasta la iteración actual. 