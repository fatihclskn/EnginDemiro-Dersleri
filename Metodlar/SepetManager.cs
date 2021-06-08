using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("                       ürün   fiyat");
            Console.WriteLine("sepete eklendi len  : " + urun.Adi + "  " + urun.Fiyati);




        }


        public void sayfaSonu()
        {
            Console.WriteLine("bir sonraki sayfaya geçiniz");
        }
    }
}
