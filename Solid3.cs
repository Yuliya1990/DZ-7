using System;

interface IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea();
}

class Rectangle : IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IFigure
{
    private int width = 0;
    private int height = 0;
    public int Width { get { return width; } set { width = value; height = value; } }
    public int Height { get { return height; } set { width = value; height = value; } }
    public int GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFigure sqr = new Square();
        sqr.Width = 5;
        Console.WriteLine(sqr.GetArea());
        Console.ReadKey();
    }
}
