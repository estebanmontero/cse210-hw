using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the first order 
        var address1 = new Address("789 Coral Rd", "Sydney", "NSW", "Australia");
        var customer1 = new Customer("Emma Brown", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("P100", "Water Bottle", 15.00, 2));
        order1.AddProduct(new Product("P101", "Backpack", 45.50, 1));

        // Results for the first order
        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateOrderTotal():F2}");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine(order1.CreateShippingLabel());

        // Creating the second order 
        var address2 = new Address("101 Main St", "Los Angeles", "CA", "USA");
        var customer2 = new Customer("David Green", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("P102", "Smartwatch", 199.99, 1));
        order2.AddProduct(new Product("P103", "Wireless Earbuds", 99.99, 2));

        // Results for the second order
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateOrderTotal():F2}");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine(order2.CreateShippingLabel());
    }
}
