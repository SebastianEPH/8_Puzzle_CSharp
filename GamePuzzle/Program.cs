using System;
using System.Collections.Generic;

namespace GamePuzzle {
    class Program {
        static void Main(string[] args) {

            int[] list_num =  { 1,2,3,4,5,6,7,8,9 };
            int[,] matriz =  { { 3, 1, 3},
                               { 4, 7, 0},
                               { 3, 8, 4} };


            printMat(matriz);

            move_right(matriz);

            Console.ReadKey();
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
                        Console.WriteLine("La posición X: " + danger_x[i] + "[" + x + "] /////////////////// La posición Y: " + danger_y[i] + "[" + y + "]");
                        possible = false;
                    }
                }
            }
            if_danger();

            if (possible) {
                matriz[x,y] = matriz[x,y - 1];
                matriz[x,y - 1] = 0;

                Console.WriteLine("La nueva matriz es: ");
                printMat(matriz);


            } else {
                // return matriz
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
        private static void printArr(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]);
            }
            Console.WriteLine(",");
        }
        private static void generate_random(int[,] matriz, int[] list_num) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("[" + matriz[i,j] + "]");
                }
                Console.WriteLine("");
            }
        }
        
    }
}
