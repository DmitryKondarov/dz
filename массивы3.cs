using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] array = { 5, 3, 8, 6, 7, 2, 9, 4, 10, 1,
                        12, 8, 15, 13, 11, 16, 14, 18, 17, 19,
                        20, 22, 21, 23, 25, 24, 26, 27, 29, 28 };

            int leftElem = 0;
            int rightElem = 0;
            bool rightElemFlag = false;
            for ( int i = 1; i < array.Length; i++)
            {
                leftElem = array[i - 1];
                rightElem = array[i];
                if ( leftElem > rightElem)
                {
                    if (rightElemFlag == false)
                    {
                        Console.WriteLine(leftElem);
                    }
                    rightElemFlag = false;
                }
                else
                {
                    Console.WriteLine(rightElem);
                    rightElemFlag = true;
                }
            }
        }
    }
}
