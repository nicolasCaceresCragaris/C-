using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoftStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sumaSophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int sumaNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int sumaZahira = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int sumaJeong = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            decimal promedioSophia = sumaSophia / (decimal)currentAssignments;
            decimal promedioNicolas= sumaNicolas/ (decimal)currentAssignments;
            decimal promedioZahira= sumaZahira/ (decimal)currentAssignments;
            decimal promedioJeong= sumaJeong/ (decimal)currentAssignments;


            Console.WriteLine("Student\t Grade");
            Console.WriteLine("Sophia \t "+promedioSophia+"\t  A" );
            Console.WriteLine("Nicolas\t "+promedioNicolas+"\t  B");
            Console.WriteLine("Zahirah\t "+promedioZahira+"\t  B");
            Console.WriteLine("Jeong  \t "+promedioJeong+"\t  A");
            

        }
    }
}
