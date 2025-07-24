using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elemSum = 0;
            string input = "";
            int[] array = new int[0];
            while (input != "exit")
            {               
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.Write("Введите число или команду: ");
                try
                {
                    input = Console.ReadLine();
                    elemSum += Convert.ToInt32(input);
                    int[] newArray = new int[array.Length + 1];
                    array.CopyTo(newArray, 0);
                    newArray[array.Length] = Convert.ToInt32(input);
                    array = newArray;                   
                }
                catch
                {   
                    if (input == "sum")
                    {
                        Console.WriteLine(elemSum);
                    }
                    else if (input == "exit")
                    {
                        Console.WriteLine("Конец");
                    }
                    else
                    {
                        Console.WriteLine("Данные были введены некорректно, повторите попытку");
                    }
                }
            }                        
        }
    }
}
