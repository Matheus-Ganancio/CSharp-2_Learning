class Rectangle
{
    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    public int Height { get; set; }
    public int Width { get; set; }

    public void RectangleArea()
    {
        Console.WriteLine($"Rectangle area: {Height * Width}");
    }
}