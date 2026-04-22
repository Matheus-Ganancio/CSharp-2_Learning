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

Console.WriteLine("Product 2");

Book item2 = new Book("Salome", "Oscar Wilde");
//item2.Title = "Salome";
//item2.Author = "Oscar Wilde";

item2.BookDescription();
