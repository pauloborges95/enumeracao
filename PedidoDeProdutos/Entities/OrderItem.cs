using System;
using System.Collections.Generic;
using PedidoDeProdutos.Entities.Enum;
using System.Globalization;

namespace PedidoDeProdutos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        //public double SubTotal { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
            
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return "Quantity: "
                + Quantity + ","
                + "Sub Total: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
