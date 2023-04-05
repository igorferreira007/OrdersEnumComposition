using OrdersEnumComposition.Entities;
using OrdersEnumComposition.Entities.Enums;
using System;

namespace OrdersEnumComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
