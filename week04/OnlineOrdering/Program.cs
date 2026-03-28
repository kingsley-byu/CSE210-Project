using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Address address1 = new Address("123 main street", "New York", "NY","USA");

        Customer customer1 = new Customer("prince kene", address1);
        Product product1 = new Product("Laptop", "P1023",400.9m, 5);
        Product product2 = new Product("Iphone","LP234",800.56m, 56);
        Product product3 = new Product("Shoes","SH305",60.6m, 54);
        Product product4 = new Product("Bags", "BG564", 97.987m, 43);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);


        Address address2 = new Address("43 Jersey Road", "Utah", "UT", "USA");
        Customer customer2 = new Customer("Jorge watt", address2);

        Product product5 = new Product("Refrigerator", "RF123", 389.56m, 12);
        Product product6 = new Product("Electric Iron", "ER345",17.89m,32);
        Product product7 = new Product("Gas Cooker", "GC3465",110.5m,4);
        Product product8 = new Product("Hair Dryer Machine", "HDM458",150.76m, 13);

        Order order2  = new Order(customer2);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);


        Address address3 = new Address("87 kings way", "London","LD", "United Kingdom");
        Customer customer3 = new Customer("Faith", address3);

        Product product9 = new Product("Steel products", "SP870", 121.6m, 80);
        Product product10 = new Product("Doors", "dR5769", 89.56m, 80);
        Product product11 = new Product("Wires", "WR457", 43.5m, 120);
        Product product12 = new Product("Cables","CB104", 2040.8m, 650);

        Order order3  = new Order(customer3);
        order3.AddProduct(product9);
        order3.AddProduct(product10);
        order3.AddProduct(product11);
        order3.AddProduct(product12);

        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine($"Packing label: {order.GetPackingLabel()}\n");
            Console.WriteLine($"Shipping label {order.GetShippingLabel()}\n");
            Console.WriteLine($"Total order {order.GetTotalPrice()}\n");
            Console.WriteLine("---------------------------------------\n");
        }


    }
}