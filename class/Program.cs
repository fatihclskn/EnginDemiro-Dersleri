using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "fatih";
            int yas = 18;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "mat";
            kurs1.egitmen = "ahmet";
            kurs1.ızlenmeOranı = 55;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "fizik";
            kurs2.egitmen = "mehmet";
            kurs2.ızlenmeOranı = 33;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "biyoloji";
            kurs3.egitmen = "hüseyin";
            kurs3.ızlenmeOranı = 11;

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " - " + kurs.egitmen + " - " + kurs.ızlenmeOranı);
                
            }




            Console.ReadLine();

        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int ızlenmeOranı { get; set; }
        

        



    }

    

}
