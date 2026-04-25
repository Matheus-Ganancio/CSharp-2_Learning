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

Console.WriteLine("Bank Account Details: \n");

BankAccount AccountDetails1 = new BankAccount("12345-6", 999.99m, 1000.00m);

AccountDetails1.AccountInfo();

// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");
Console.WriteLine("Employee Details: \n");

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


// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");
Console.WriteLine("Rectangle Details: \n");

Rectangle RectangleArea1 = new Rectangle(6, 10);

RectangleArea1.RectangleArea();

// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");
Console.WriteLine("Movie Details: \n");

Movie MovieInfo1 = new Movie("Dinossauro Luz", 18);
MovieInfo1.ShowResult(20);

Movie MovieInfo2 = new Movie("Gato Fogguete", 14);
MovieInfo2.ShowResult(11);

// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");
Console.WriteLine("Item Stock Details: \n");

StationeryStore Item1 = new StationeryStore("Fork", 40);
Item1.Take(5);
Item1.ShowInventory();

// ----------------------------------------------
Console.WriteLine("\n----------------------------\n");
Console.WriteLine("Order Details: \n");

Order Customer1 = new Order("01", "Lucia", "Delivered");
Customer1.DisplayOrder();

Order Customer2 = new Order("02", "James", "On the way");
Customer2.DisplayOrder();
Customer2.UpdateStatus("Delivered");
Customer2.DisplayOrder();