using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 1, 10, 7, 2, 9, 4, 6 };

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int a = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = a;
                    }                
                }
            }
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }           
        }
    }
}
