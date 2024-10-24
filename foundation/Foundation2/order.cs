using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double CalculateOrderTotal()
    {
        double total = 0;

        foreach (var product in _productList)
        {
            total += product.TotalCost();
        }

        total += _customer.LivesInUSA() ? 7 : 40; // Shipping costs based on location
        return total;
    }

    public string CreatePackingLabel()
    {
        string label = "=== Packing Label ===\n";
        foreach (var product in _productList)
        {
            label += $"{product.GetProductId()} - {product.GetProductName()} (Quantity: {product.GetQuantity()})\n";
        }
        return label;
    }

    public string CreateShippingLabel()
    {
        return $"=== Shipping Label ===\n{_customer.GetFullName()}\n{_customer.GetAddress()}\n";
    }
}
