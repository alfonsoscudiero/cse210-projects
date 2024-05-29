using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Create a couple of addresses
        Address address1 = new Address("123 Main St", "Charlotte", "NC", "USA");
        Address address2 = new Address("456 Circle Dr", "Vancouver", "BC", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Dumas", address1);
        Customer customer2 = new Customer("Lois Lane", address2);

        // Create some products
        Product product1 = new Product("Sequoia Tripod System", "32DTC3-AST/s", 525.99, 1);
        Product product2 = new Product("Hunter Tripod System", "FDT5937C3-AST", 585.99, 1);
        Product product3 = new Product("Ranger ASFPL DomeTOP Tripod System", "35DTC3-MIL", 959.99, 1);
        Product product4 = new Product("Pard Night Vision Clip-On Scope", "NV007SP LRF", 699.99, 1);
        Product product5 = new Product("Optics Window Mount PH200 System", "FWM-200", 69.99, 5);


        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order Details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
        Console.WriteLine();
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine();
        Console.WriteLine($"Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");

    }
}