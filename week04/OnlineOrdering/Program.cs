using System;

class Program
{
    static void Main(string[] args)
    {
        /* create a list of order where orders will be added to if new orders are made*/
        List<Order> orders = new List<Order>();
        /* create the object of the address class and pass the following as argument to it
        -Address,
        - city
        - state province and 
        - Country */ 
        Address address1 = new Address("123 main street", "New York", "NY","USA");
        /* create the object of the customer class and pass two argument;
        - Customer's name 
        - address */
        Customer customer1 = new Customer("prince kene", address1);
        Product product1 = new Product("Laptop", "P1023",400.9m, 5);
        Product product2 = new Product("Iphone","LP234",800.56m, 56);
        Product product3 = new Product("Shoes","SH305",60.6m, 54);
        Product product4 = new Product("Bags", "BG564", 97.987m, 43);
        // create the order object and pass the customer object to it as argument
        Order order1 = new Order(customer1);
        // Add the ordered product to the order object by calling the AddProduct method and pass the product to it
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
        /* Loop through the order list and call 
        - GetPacking Label
        -GetShippingLabel
        -TotalPrice*/
        foreach (Order order in orders)
        {
            Console.WriteLine($"Packing label:\n {order.GetPackingLabel()}\n");
            Console.WriteLine($"Shipping label \n{order.GetShippingLabel()}\n");
            Console.WriteLine($"Total order: ${order.GetTotalPrice()}\n");
            Console.WriteLine("---------------------------------------\n");
        }


    }
}