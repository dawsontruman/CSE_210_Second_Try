using System;

class Program
{
    static void Main(string[] args)
    {
        // products
        Product cornstarch = new Product("Cornstarch", "001", 215, 1);
        Product explosives = new Product("Explosives", "101", 4599, 12);
        Product chickenTh = new Product("Chicken Thighs", "002", 500, 5);
        Product goatF = new Product("Live Female Goat", "327", 90000, 1);

        // customers and addresses
        Address address1 = new Address("45 Stone St.","Boulderfell","Rockland","Federation of Fantasy Kingdoms");
        Customer customer1 = new Customer("Penny Mason", address1);

        Address address2 = new Address("235 W 4th S", "Rexburg", "Idaho", "United States");
        Customer customer2 = new Customer("Guys Living In My Old Apartment", address2);

        // print orders
        Order order1 = new Order(customer1);
        order1.AddProduct(explosives);
        order1.AddProduct(explosives);
        order1.AddProduct(goatF);
        Console.Write(order1.PackingLabel());
        Console.WriteLine($"Total Cost: {order1.TotalCost()}");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Order order2 = new Order(customer2);
        order2.AddProduct(cornstarch);
        order2.AddProduct(chickenTh);
        order2.AddProduct(chickenTh);
        Console.Write(order2.PackingLabel());
        Console.WriteLine($"Total Cost: {order2.TotalCost()}");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
    }
}