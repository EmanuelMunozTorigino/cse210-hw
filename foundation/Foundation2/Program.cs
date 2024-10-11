using System;

class Program
{
    static void Main(string[] args)
    {
        //   Console.WriteLine("Hello Foundation2 World!");

        RandomGenerator randomGenerator = new RandomGenerator();



        List<Order> orderList = new List<Order>();


        Address address1 = randomGenerator.GetRandomAddress();

        string customerName = randomGenerator.GetRandomCustomer();

        Customer customer1 = new Customer(customerName, address1);

        Order order1 = new Order(customer1);

        Address address2 = randomGenerator.GetRandomAddress();

        string customerName2 = randomGenerator.GetRandomCustomer();

        Customer customer2 = new Customer(customerName2, address2);

        Order order2 = new Order(customer2);


        orderList.Add(order1);
        orderList.Add(order2);

        foreach (Order order in orderList) {
            Random random = new Random();

            int max = random.Next(3,8);

            int quantity = 0;

            while (quantity < max)
            {
                Product product = randomGenerator.GetRandomProduct();
                order.AddProduct(product);
                quantity++;
            }
        }

        foreach (Order order in orderList) {
            Console.WriteLine();
            string shippingLabel = order.GetShippingLabel();

            Console.WriteLine(shippingLabel);

            Console.WriteLine();

            List<string> packinglabelList = order.GetPackingLabel();

            Console.WriteLine("Packing Label: ");
            Console.WriteLine();

            foreach (string packinglabel in packinglabelList) {
                Console.WriteLine(packinglabel);
            }

            decimal totalCost = order.ComputeTotalCost();

            Console.WriteLine();
            Console.WriteLine($"The total cost is: ${totalCost}");
            Console.WriteLine("__________________________________________________________________________");
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for shopping in our online store, we hope to see you soon");


    }
}