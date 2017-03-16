/*Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, width, i, j;

            Console.WriteLine("type a number: ");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("type a width");
            width = Convert.ToInt16(Console.ReadLine());


            for (j = 1; j <= width; j++)
            {
                Console.WriteLine($"{n}");
                
                for(i=1; i<=width; i++)
                {
                    Console.Write($"{n}");
                }
            }


            Console.ReadLine();

        }
    }
}

