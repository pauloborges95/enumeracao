using PedidoDeProdutos.Entities;
using PedidoDeProdutos.Entities.Enum;
using System.Globalization;
using System;

namespace PedidoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ENTER ORDER DATA");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order ?");
            int n = int.Parse(Console.ReadLine());
            

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);
            
            
            //OrderItem orderItem = new OrderItem(quantity, price);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string prodname = Console.ReadLine();
                Console.Write("Product price");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(prodname, price);

                Console.Write("Qauntity");
                int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                OrderItem orderItem = new OrderItem(quantity, price);
                


                order.AddItem(orderItem);

            }

           

            Console.WriteLine();
            Console.WriteLine("Order Sumary");
            Console.WriteLine(order);
          
            





        }
    }
}
