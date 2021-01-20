using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }  //referans anahtarlığı

        public string ProductName { get; set; }

        public double UnitPrice { get; set; } // ürünün birim fiyatı

        public int UnitsStock { get; set; } //ürünün stok adedi

        //CRUD


    }
}
