using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string UrunAdı = "elma";
            double fiyati = 5;
            string Aciklama = "amasya elmas";
            

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "amasya elması";
            //urun1.stockadedi = 45;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyerbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "çilek";
            urun3.Fiyati = 25;
            urun3.Aciklama = "çilek  gibi çilek";

            Urun urun4 = new Urun();
            urun4.Adi = "telefon";
            urun4.Fiyati = 4000;
            urun4.Aciklama = "samsung a52";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 , urun4};
             
            //foreach (var urun in urunler)
            //{
               //Console.WriteLine(urun1.Adi + "__" + urun1.Fiyati + "__" + urun1.Aciklama);
               //Console.WriteLine("    ");
               //Console.WriteLine(urun2.Adi + "__" + urun2.Fiyati + "__" + urun2.Aciklama);
               //Console.WriteLine("    ");
               //Console.WriteLine(urun3.Adi + "__" + urun3.Fiyati + "__" + urun3.Aciklama);
            //}
           
            
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(" ");
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("  ");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("   ");
                //Console.WriteLine(urun.stockadedi);
                Console.WriteLine("   " );
          
            }

            Console.WriteLine("----------Metodlar------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            SepetManager sepetManager1 = new SepetManager();
            sepetManager.sayfaSonu();

            
            



            Console.ReadLine();

        }
    }
}
