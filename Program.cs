using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int buffer = array[0];
            for(int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length-1] = buffer;

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
