using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"elma" , "armut" , "karpuz" , "çilek" };

            int[] bütçe = new int[] {100 , 500 , 1000 , 5555 , 123456 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(bütçe[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }







            Console.WriteLine("sayfa sonu");

            Console.ReadLine();
        }
    }
}
