using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace probandoCosas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 10;
            int monsterHealth = 10;
            Random damage = new Random();
            int monsterDamage;
            int playerDamage;

            while(playerHealth>0 && monsterHealth > 0)
            {
                playerDamage=damage.Next(1, 10);
                monsterDamage=damage.Next(1, 10);
                playerHealth -= monsterDamage;
                monsterHealth -= playerDamage;
                Console.WriteLine("Jugador golpea por {0} a monstruo. Monstruo vida restante{1}", playerDamage, monsterHealth);
                Console.WriteLine("Monstruo golpea por {0} a jugador. Jugador vida restante{1}", monsterDamage, playerHealth);
               
            }

            if (playerHealth < 0 && playerHealth>monsterHealth) Console.WriteLine("Perdiste");
            else Console.WriteLine("Ganaste");


        }


    }   
}
