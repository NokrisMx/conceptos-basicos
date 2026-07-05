partial class Program
{
    static void DataStructures()
    {
        User pedro = new User { Name = "Aldo", Age = 26 };
        pedro.Greet();

        Point point = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Point: ({point.X}, {point.Y})");

        CellPhone phone = new CellPhone("iPhone", "2022");
        Console.WriteLine($"Phone: {phone.Model} ({phone.Year})");
    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

record CellPhone(string Model, string Year);