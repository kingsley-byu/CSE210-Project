using System;
public class Product
{
    // Create private attribute of product name, product Id, Price per unit and quantity 
    private string _productName;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;
    /* create a constructor  with the class
    parameters:
    - productName : string
    - productId : string
    - pricePerUnit: decimal
    - Quantity : int */
    public Product(string productName, string productId, decimal pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

   
   // Get the product id by returning the id of the product
    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetTotalCost()
    {
        return _pricePerUnit *_quantity;
    }
}