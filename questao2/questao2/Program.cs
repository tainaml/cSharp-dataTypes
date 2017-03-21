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
            int numero, largura;


            Console.WriteLine("type a number: ");
            numero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("type a largura");
            largura = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("------------------------------------");

            int altura = largura;
            //para altura
            for (int linha = 0; linha<= largura; linha++)
            {
                
                for(int column = 0; column <=largura ; column++)
                {
                    Console.Write($"{numero}");
                }

                Console.WriteLine();
                largura--;
                               
            }


            


            Console.ReadLine();

        }
    }
}


/*
666666                                                      
66666                                                           
6666                                                                  
666                                                        
66                                                                  
6
*/