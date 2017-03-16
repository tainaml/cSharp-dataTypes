/* Write a C# Sharp program that takes three letters as input and display them in reverse order. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char letterOne, letterTwo, letterThree;

            Console.WriteLine("please, type one letter: ");
            letterOne = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("type, another letter: ");
            letterTwo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("type, another letter: ");
            letterThree = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{letterThree}, {letterTwo}, {letterOne}");


            Console.ReadLine();

        }
    }
}
