using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginDemiroğDersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagoriEtiketi = "kategori";
            int ogrenciSayisi = 1200;
            double okulFiyatı = 1.566;
            bool sistemeGirisYapmısmı = true;

            if (sistemeGirisYapmısmı == true)
            {
                Console.WriteLine("hosgeldiniz");
            }

            if (sistemeGirisYapmısmı == false)
            {
                Console.WriteLine("lütfen giriş yapınız");
            }

            Console.WriteLine(katagoriEtiketi);
            Console.WriteLine("merhaba");
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(okulFiyatı);

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış işareti");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış Butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            
            Console.ReadLine();


        }
    }
}
