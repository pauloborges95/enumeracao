using System;
using System.Collections.Generic;
using PedidoDeProdutos.Entities;
using PedidoDeProdutos.Entities.Enum;
using System.Globalization;

namespace PedidoDeProdutos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double  Price { get; set; }
        

     
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

       /* public override string ToString()
        {
            return "Product Name:" +
                Prodname + ", " +
                "R$ " +
                Price.ToString("F2", CultureInfo.InvariantCulture);
        }*/

    }
}
