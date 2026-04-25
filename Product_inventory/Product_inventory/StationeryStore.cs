class StationeryStore
{
    public StationeryStore(string name, int stock)
    {
        Name = name;
        Stock = stock;
    }

    public string Name { get; set; }
    private int Stock;

    public void Take(int HowMany)
    {
        Console.WriteLine($"Actual stock: {Stock}");
        if (HowMany <= Stock)
        {
            Stock -= HowMany;
            Console.WriteLine($"Withdrawal of {HowMany} units completed successfully.");
        }
        else
        {
            Console.WriteLine($"Error: Insufficient stock to withdraw {Stock} units.");
        }
    }
    public void ShowInventory()
    {
        Console.WriteLine("Produto: " + Name);
        Console.WriteLine("Estoque: " + Stock);
    }
}