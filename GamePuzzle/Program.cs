using System;

namespace GamePuzzle{
    class Program{
        static void Main(string[] args) {
            int[] list_num = new int[9] {1,2,3,4,5,6,7,8,9};
            int[,] matriz = new int[3,3] { { 1, 2, 3},
                                           { 4, 5, 6},
                                           { 7, 8, 9} };
            for (int i = 0; i < 3 ; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("["+ matriz[i,j]+"]");
                }
                Console.WriteLine("\n");
            }
            //Console.Write("" + matriz[2,1]);


        }
        void print(int[,] matriz) { 
            

        }
    }
}
