using System;
public class Product
{
    private string _productName;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

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

   

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetTotalCost()
    {
        return _pricePerUnit *_quantity;
    }
}