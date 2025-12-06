using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
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
        return total;
    }
    public string PackingLabel()
    {
        return $"";
    }
    public string ShippingLabel()
    {
        return $"";
    }
}