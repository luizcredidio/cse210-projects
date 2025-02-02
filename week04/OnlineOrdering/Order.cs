using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;

        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        if (_customer.IsCustomerInTheUSA())
        {
            return totalProductCost + 5;
        }

        return totalProductCost + 35;
    }

    public void DisplayPackagingLabel()
    {
        foreach (var product in _products)
        {
            product.DisplayPackagingLabel();
        }
    }

    public void DisplayShippingLabel()
    {
        _customer.DisplayShippingLabel();
    }
}