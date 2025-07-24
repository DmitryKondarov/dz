using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[10, 10]
            {
                 { 45, 12, 78, 23, 56, 89, 34,  67, 99, 3 },
                 { 17, 62, 39, 84, 11, 50, 72, 9, 8, 29 },
                 { 88, 5, 41, 76, 19, 54, 80, 7, 36, 61 },
                 { 2, 47, 22, 57, 92, 15, 68, 33, 74, 9 },
                 { 63, 28, 85, 99, 49, 24, 71, 46, 81, 16 },
                 { 30, 75, 14, 51, 86, 21, 58, 93, 38, 65 },
                 { 97, 42, 99,  4, 31, 66, 13, 48, 83, 20 },
                 { 52, 87, 26, 73, 6, 35, 70, 25, 60, 91 },
                 { 18, 53, 96, 27, 64, 1, 44, 79, 32, 55 },
                 { 40, 77, 82, 37, 94, 43, 59, 2, 99, 98 }

            };

            int maxElem = 0;

            foreach (int elem in A)
            {
                if (elem > maxElem)
                {
                    maxElem = elem;
                }
            }

            Console.WriteLine(maxElem);

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == maxElem)
                    {
                        A[i, j] = 0;
                    }
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}