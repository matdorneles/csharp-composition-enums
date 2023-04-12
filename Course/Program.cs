using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Aulas
{
    class Aulas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            Order order = new Order(
                DateTime.Now, 
                status, 
                new Client(name, email, date)
            );

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                order.addItem(new OrderItem(
                    quantity, 
                    prodPrice, 
                    new Product(prodName, prodPrice)
                ));
            }

            Console.WriteLine(order);
        }
    }
}
