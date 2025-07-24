using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 5, 5, 5, 3, 3, 3, 3, 7,
                        7, 7, 7, 7, 4, 4, 8, 8, 8, 8,
                        6, 6, 6, 9, 9, 1, 1, 1, 1, 1 };
            Console.WriteLine(array);

            int maxElem = 0;
            int maxCounter = 0;
            int elemCounter = 0;
            int currentElem = array[0]-1;

            foreach (int i in array)
            {
                if (currentElem == i)
                {
                    elemCounter++;
                }
                else
                {
                    if ( maxCounter < elemCounter)
                    {
                        maxCounter = elemCounter;
                        maxElem = currentElem;
                    }
                    currentElem = i;
                    elemCounter = 1;
                }
            }
            Console.WriteLine(maxElem);
            Console.WriteLine(maxCounter);
        }
    }
}
