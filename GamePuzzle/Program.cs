using System;
using System.Collections.Generic;

namespace GamePuzzle {
    class Program {
        static void Main(string[] args) {

            
             int[,] matriz =  { { 2,3,5},
                                { 1,6,8},
                                { 0,4,7} };
            /*
            int[,] matriz =  { { 1,2,3},    // Estado final
                               { 4,5,6},
                               { 7,8,0} };*/

            int player = 0;
            printMat(matriz);

            bool start_game = true;
            while (start_game) {
                if (finish(matriz)) {
                    start_game = false;
                    Console.WriteLine("Haz completado el 8-Puzzle con " + player+ " movimientos");
                    Console.ReadLine();
                    Environment.Exit(1);
                } else {
                    switch (Console.ReadKey().Key) {
                        case ConsoleKey.Escape: Environment.Exit(1); break;
                        case ConsoleKey.A: Console.Clear(); move_lelf(matriz); player = player + 1; Console.WriteLine("Movimiento: " + player); break;
                        case ConsoleKey.D: Console.Clear(); move_right(matriz); player = player + 1; Console.WriteLine("Movimiento: " + player); break;
                        case ConsoleKey.S: Console.Clear(); move_down(matriz); player = player + 1; Console.WriteLine("Movimiento: " + player); break;
                        case ConsoleKey.W: Console.Clear(); move_up(matriz); player = player + 1; Console.WriteLine("Movimiento: " + player); break;
                    }
                }
                
            }
        }
        private static bool finish(int[,] matriz) {
            bool same= true;
            int[,] finish =  { { 1,2,3},
                               { 4,5,6},
                               { 7,8,0} };
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (finish[i,j] != matriz[i,j]) {
                        same = false;
                    } 
                }
            }

            return same;
        }
        private static void move_lelf(int[,] matriz) { // int[]
            bool possible = true;
            int x = 0;
            int y = 0;

            int[] danger_x = { 0,1,2 };
            int[] danger_y = { 0,0,0 };

            // Recorre y encuentra en Vacío (0)
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                   // Console.WriteLine(matriz[i,j]);
                    if (matriz[i,j] == 0) {
                        x = i;
                        y = j;
                    }
                }
            }
            void if_danger() {
                for (int i = 0; i < 3; i++) {
                    if (danger_x[i] == x && danger_y[i] == y) {
                        //Console.WriteLine("La posición X: " + danger_x[i] + "[" + x + "] /////////////////// La posición Y: " + danger_y[i] + "[" + y + "]");
                        possible = false;
                        printMat(matriz);
                    }
                }
            }
            if_danger();

            if (possible) {
                matriz[x,y] = matriz[x,y - 1];
                matriz[x,y - 1] = 0;

                //Console.WriteLine("La nueva matriz es: ");

                printMat(matriz);


            }

        }
        private static void move_right(int[,] matriz) { // int[]
            bool possible = true;
            int x = 0;
            int y = 0;

            int[] danger_y = { 0,1,2 };
            int[] danger_x = { 2,2,2 };

            // Recorre y encuentra en Vacío (0)
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    //Console.WriteLine(matriz[i,j]);
                    if (matriz[i,j] == 0) {
                        x = i;
                        y = j;
                    }
                }
            }
            void if_danger() {
                for (int i = 0; i < 3; i++) {
                    if (danger_x[i] == y && danger_y[i] == x) {
                        //Console.WriteLine("La posición X: " + danger_x[i] + "[" + x + "] /////////////////// La posición Y: " + danger_y[i] + "[" + y + "]");
                        possible = false;
                        printMat(matriz);
                    }
                }
            }
            if_danger();

            if (possible) {
                matriz[x,y] = matriz[x,y + 1];
                matriz[x,y + 1] = 0;

                //Console.WriteLine("La nueva matriz es: ");
                printMat(matriz);


            }
        }
        private static void move_up(int[,] matriz) { // int[]
            bool possible = true;
            int x = 0;
            int y = 0;

            int[] danger_x = { 0,0,0 };
            int[] danger_y = { 0,1,2 };

            // Recorre y encuentra en Vacío (0)
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    //Console.WriteLine(matriz[i,j]);
                    if (matriz[i,j] == 0) {
                        x = i;
                        y = j;
                    }
                }
            }
            void if_danger() {
                for (int i = 0; i < 3; i++) {
                    if (danger_x[i] == x && danger_y[i] == y) {
                        //Console.WriteLine("La posición X: " + danger_x[i] + "[" + x + "] /////////////////// La posición Y: " + danger_y[i] + "[" + y + "]");
                        possible = false;
                        printMat(matriz);
                    }
                }
            }
            if_danger();

            if (possible) {
                matriz[x,y] = matriz[x-1,y ];
                matriz[x-1 ,y ] = 0;

                //Console.WriteLine("La nueva matriz es: ");
                printMat(matriz);

            }
        }
        private static void move_down(int[,] matriz) { // int[]
            bool possible = true;
            int x = 0;
            int y = 0;

            int[] danger_x = { 2,2,2 };
            int[] danger_y = { 0,1,2 };

            // Recorre y encuentra en Vacío (0)
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    //Console.WriteLine(matriz[i,j]);
                    if (matriz[i,j] == 0) {
                        x = i;
                        y = j;
                    }
                }
            }
            void if_danger() {
                for (int i = 0; i < 3; i++) {
                    if (danger_x[i] == x && danger_y[i] == y) {
                        //Console.WriteLine("La posición X: " + danger_x[i] + "[" + x + "] /////////////////// La posición Y: " + danger_y[i] + "[" + y + "]");
                        possible = false;
                        printMat(matriz);
                    }
                }
            }
            if_danger();

            if (possible) {
                matriz[x,y] = matriz[x + 1,y];
                matriz[x + 1,y] = 0;

                //Console.WriteLine("La nueva matriz es: ");
                printMat(matriz);


            }
        }
        private static void printMat(int[,] matriz) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (matriz[i,j] == 0) {
                        Console.Write("[_]");
                    } else {
                        Console.Write("[" + matriz[i,j] + "]");
                    }
                }
                Console.WriteLine("");
            }
        }
  
    }
}
