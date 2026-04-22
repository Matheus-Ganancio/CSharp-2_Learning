class Product
{
    public string name;
    public string description;
    public decimal price;
    public int stock;

    public bool IsAvailable()
    {
        return stock > 0;
    }
    public void PriceWithDiscount(decimal discount)
    {
        price = price * (1 - discount);
    }
}