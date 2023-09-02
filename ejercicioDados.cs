using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ejercicioDados
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice =new Random();

            int rollOne = dice.Next(1, 6);
            int rollTwo = dice.Next(1, 6);
            int rollThree = dice.Next(1, 6);
            
            int score=rollOne+rollTwo + rollThree;

            Console.WriteLine("Dado Uno:{0}",rollOne);
            Console.WriteLine("Dado Dos:{0}",rollTwo);
            Console.WriteLine("Dado Tres:{0}",rollThree);

            if((rollOne==rollTwo) || (rollOne==rollThree) || (rollTwo == rollThree))
            {
                Console.WriteLine("Obtienes un doble! 2 puntos extras");
                score += 2;
            }
            if (rollOne == rollTwo)
            {
                if(rollTwo== rollThree)
                {
                    Console.WriteLine("Obtiene un triple! 6 puntos extras ");
                        score += 6;
                    }
            }

            if (score >= 15)
            {
                Console.WriteLine("Usted gano.Puntos {0}", score);
            }
            else
            {
                Console.WriteLine("Usted perdio. Puntos {0} ", score);
            }

            }
   


        }
    }
