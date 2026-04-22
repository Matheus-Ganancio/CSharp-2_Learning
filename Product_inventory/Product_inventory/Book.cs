class Book
{
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; set; }
    public string Author { get; set; }

    public void BookDescription()
    {
        Console.WriteLine($"The book \"{Title}\" was written by author \"{Author}\"");
    }
}