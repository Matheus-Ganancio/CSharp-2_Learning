class BankAccount
{
    public BankAccount(string accountNumber, decimal balance, decimal deposit)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        Deposit = deposit;
    }

    public string AccountNumber { get; }
    public decimal Balance { get; }
    public decimal Deposit {  get; set; }

    public void AccountInfo()
    {
        Console.WriteLine($"The account: {AccountNumber}\n" +
            $"has a balance of: {Balance}, last deposit {Deposit}");
    }
    

}