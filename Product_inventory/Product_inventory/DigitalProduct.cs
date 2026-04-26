
class DigitalProduct
{
    public DigitalProduct(string name, double price, TechnicalInformation info)
    {
        Name = name;
        Price = price;
        Info = info;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public TechnicalInformation Info { get; set; }

    public void ShowDetail()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Price: €{Price}");
        Console.WriteLine($"Size: {Info.SizeMB} MB");
        Console.WriteLine($"Compatible: {Info.OperatingSystem}");
    }
}
