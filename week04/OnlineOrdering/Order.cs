using System;
using System.Collections.Generic;
using System.ComponentModel;


public class Order
{
    // Create a list of product that will hold all the product
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order( Customer customer)
    {
        _customer = customer;
    }
    // Add the new product to the list of product
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    /* Loop through the list of product and calculate the total cost of the product
    add $5 dollar to the price if the customer live within the USA  or add $35 if the customer live outside */

    public decimal GetTotalPrice()
    {
        decimal total = 0; 
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();

        if (_customer.IsInUSA())
        {
            total += 5;
        }

        else
        {
            total += 35;
        }
        }
        return total;
    }
    /*loop through thr product list and get the packing id and return the product name name 
    And the product id */
    public string GetPackingLabel()
    {
        string id = "";
        foreach (Product product in _products)
        {
            
            id += product.GetName() + " " + product.GetProductId() + "\n";
        } 
        return id;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}

