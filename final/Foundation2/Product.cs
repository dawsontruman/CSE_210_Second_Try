using System;

public class Product
{
    private string _name;
    private string _productID;
    private int _unitPrice;
    private int _quantity;
    public Product(string name, string productID, int unitPrice, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }
    public int Cost()
    {
        return _unitPrice*_quantity;
    }
    public string PackingLabelSegment()
    {
        return $"{_name} #{_productID}";
    }
}