using System;

public class Product
{
    private string _productId;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(string productId, string productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost() => _price * _quantity;

    public string GetProductId() => _productId;
    public string GetProductName() => _productName;
    public double GetPrice() => _price;
    public int GetQuantity() => _quantity;
}
