using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //mobilyaya karşılık gelsin.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsStock = 3;

            //DİĞER OLUŞTURMA ŞEKLİ

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "KALEM", UnitPrice = 200,UnitsStock=5 };


            // PascalCase  //camelCase
            // case sensitive (büyük küçük harf duyarlıdır.)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            


            


        }
    }
}
