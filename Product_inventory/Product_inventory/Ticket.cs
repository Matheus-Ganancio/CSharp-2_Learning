class Ticket
{
    public Ticket(string passenger, string destination)
    {
        Passenger = passenger;
        Destination = destination;
    }

    public string Passenger {  get; set; }
    public string Destination { get; set; }

    public void FlightInfo()
    {
        Console.WriteLine($"Passenger: {Passenger}.\n" +
            $"Please proceed to the flight to {Destination}");
    }
}