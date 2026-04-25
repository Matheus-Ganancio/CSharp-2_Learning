class Order
{
    public Order(string orderNumber, string customerName, string status)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        Status = status;
    }

    public string OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public string Status { get; set; }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order Nº: {OrderNumber} \n" +
            $"Customer: {CustomerName} \n" +
            $"Status: {Status} \n");
    }

}