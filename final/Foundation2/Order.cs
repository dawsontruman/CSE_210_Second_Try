using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int TotalCost()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.Cost();
        }
        if (_customer.InUSA())
        {
            total += 500;
        }
        else
        {
            total += 3500;
        }
        return total; // prices in cents
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label = label + product.PackingLabelSegment() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.ShippingLabelSegment();
    }
}