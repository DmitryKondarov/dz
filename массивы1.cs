using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int sum = 0;
            int mult = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mult *= matrix[i, 0];
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[1, j];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
            Console.WriteLine(mult);
        }
    }
}