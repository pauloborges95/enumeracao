﻿using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using PedidoDeProdutos.Entities.Enum;

namespace PedidoDeProdutos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
            
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }



        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items: ");

            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price $" + Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }


    }
}
