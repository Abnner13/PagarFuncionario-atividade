using System;
using System.Globalization;
using CSharpMedium.Entities;
using CSharpMedium.Entities.Enums;

namespace CSharpMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter client data: ");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Birth Date(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            

            System.Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus st = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime now = DateTime.Now;

            Client client = new Client(name, email, date);
            Order order = new Order(now, st, client);

            System.Console.Write("How many items to this order?");
            int N = int.Parse(Console.ReadLine());
            
            
            for(int i = 0; i < N; i++ ){
                System.Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string nome = Console.ReadLine();
                Console.Write("Product price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product iproduct = new Product(nome, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem  orderItem = new OrderItem(iproduct, quantity, price);
                order.addItem(orderItem);
            }
            Console.WriteLine();

            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);

        }
    }
}
