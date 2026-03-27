using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order( Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        
    }

    public decimal GetTotalPrice()
    {
        
    }

    public string GetPackingLabel()
    {
        
    }

    public string GetShippingLabel()
    {
        
    }
}

