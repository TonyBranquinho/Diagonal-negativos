using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_negativos {
    class Program {
        static void Main(string[] args) {

            int n, i, j, negativos;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + j + "," + i + "]: ");
                    matriz[j, i] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (j == i) {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }

            negativos = 0;
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) {
                        negativos = negativos + 1;
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
