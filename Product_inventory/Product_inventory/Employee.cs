class Employee
{
    public Employee( string name, string position)
    {
        Name = name;
        Position = position;
    }
    public string Name { get; set; }
    public string Position { get; set; }

    public void Promotion(string NewPosition)
    {
        if (NewPosition != Position)
        {
            Position = NewPosition;
            Console.WriteLine($"Promoted {NewPosition}");
        }
        else
        {
            Console.WriteLine("Error: The new position title must be different from the current position title.");
        }
    }
    
}