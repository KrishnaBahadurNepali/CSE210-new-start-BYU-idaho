using System;

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name => name;
    public string ProductId => productId;
    public double Price => price;
    public int Quantity => quantity;

    public double TotalCost()
    {
        return price * quantity;
    }
}