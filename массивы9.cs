using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "(()(()))";
            string strCopy = str;

            int leftBracketCounter = 0;
            int rightBracketCounter = 0;
            int maxCounter = 0;

            for (int i = 0; i < strCopy.Length - 1; i++)
            {
                for (int j = 1; j < strCopy.Length; j++)
                {
                    if (strCopy[i] == ')')
                    {
                        Console.WriteLine("некорректная строка");
                        Environment.Exit(0);
                    }
                    else if (strCopy[i] == '(')
                    {
                        if (strCopy[j] == ')')
                        {
                            strCopy = strCopy.Remove(i, 1).Insert(i, "0");
                            strCopy = strCopy.Remove(j, 1).Insert(j, "0");
                        }
                    }
                }
            }

            foreach (char c in strCopy)
            {
                if (c != '0')
                {
                    Console.WriteLine("некорректная строка");
                    Environment.Exit(0);
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                leftBracketCounter = 0;
                rightBracketCounter = 0;

                if (str[i] == '(')
                {
                    rightBracketCounter--;
                }
                else if (str[i] == ')')
                {
                    leftBracketCounter--;
                }

                for (int rb = i + 1; rb < str.Length; rb++)
                {
                    if (str[rb] == '(')
                    {
                        rightBracketCounter--;
                    }
                    else if (str[rb] == ')')
                    {
                        rightBracketCounter++;
                    }
                }

                for (int lb = i - 1; lb >= 0; lb--)
                {
                    if (str[lb] == '(')
                    {
                        leftBracketCounter++;
                    }
                    else if (str[lb] == ')')
                    {
                        leftBracketCounter--;
                    }
                }

                if (leftBracketCounter == rightBracketCounter && maxCounter < leftBracketCounter + 1)
                {
                    maxCounter = leftBracketCounter + 1;
                }
            }
            Console.WriteLine("корректная строка");
            Console.WriteLine(maxCounter);

        }
    }
}
