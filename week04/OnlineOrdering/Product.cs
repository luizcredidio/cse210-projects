using System;

class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public void DisplayPackagingLabel()
    {
        Console.WriteLine($"{_name} - {_productID}");
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}