Console.WriteLine("Product 1");

Product item1 = new Product();
item1.name = "Keyboard";
item1.description = "Standard US keyboard";
item1.price = 90.00m;
item1.stock = 15;

Console.WriteLine(@$"Product Info: 
Name: {item1.name};
Description: {item1.description};
Price: {item1.price};
Stock: {item1.stock}.
");

// --------------------------------------------
Console.WriteLine("\n----------------------------\n");
// aplicando caracteristicas

if (item1.IsAvailable())
{
    Console.WriteLine("Product Available");
}

item1.PriceWithDiscount(0.2m);

Console.WriteLine(@$"Product Info: 
Name: {item1.name};
Description: {item1.description};
Price: {item1.price};
Stock: {item1.stock}.
");

// -----------------------------------------------
Console.WriteLine("\n----------------------------\n");

Console.WriteLine("Product 2");

Book item2 = new Book("Salome", "Oscar Wilde");
//item2.Title = "Salome";
//item2.Author = "Oscar Wilde";

item2.BookDescription();


// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");

Console.WriteLine("Bank Account Details:\n");

BankAccount AccountDetails1 = new BankAccount("12345-6", 999.99m, 1000.00m);

AccountDetails1.AccountInfo();

// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");

Employee Employee = new Employee("Ronaldo peixoto", "Administrative Assistant");

Console.WriteLine("Employee: " + Employee.Name);
Console.WriteLine("Position: " + Employee.Position);

// Tentativa inválida
Employee.Promotion("Administrative Assistant");
// Promoção válida
Employee.Promotion("Project Analyst");

Console.WriteLine("--- New Position ---");
Console.WriteLine("Employee: " + Employee.Name);
Console.WriteLine("Position: " + Employee.Position);
