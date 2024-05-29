using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity; 

    // Constructor method
    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }   

    // Get the product name
    public string GetProductName()
    {
        return _productName;
    }

    // Get the product ID
    public string GetProductID()
    {
        return _productID;
    }

    // Get the product quantity
    public int GetQuantity()
    {
        return _quantity;
    }

    // Compute total cost of product
    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}