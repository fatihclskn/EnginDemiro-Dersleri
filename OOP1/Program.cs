using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;



            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            //           stack                hip
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //productManager.topla2(3, 6);

            //int toplamaSonucu = productManager.topla(3, 6);
            //Console.WriteLine(toplamaSonucu*5);


            Console.ReadLine();
        }
    }
}
