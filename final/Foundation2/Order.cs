using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add the provided 'product' to the '_products' list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method that calculates and returns the total cost of the order
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        double shippingCost = _customer.LiveInUSA() ? 5 : 35; // One-time shipping cost
        return totalCost + shippingCost;
    }

    // Method that return a packing label
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder(); // Build efficient string, especially in loops
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"-{product.GetProductName()} (ID: {product.GetProductID()}), Qty:{product.GetQuantity()}"); // Add a string followed by a newline to the 'StringBuilder'
        }
        return packingLabel.ToString(); // Convert 'StringBuilder' to a string representation
    }

    // Method that return a shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}"; // Return the address object of the customer and access the full address detail
    }
}