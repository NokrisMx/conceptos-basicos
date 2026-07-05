partial class Program
{
    static void StringType()
    {
        string greeting = "Hello, World!";
        string name = "Alice";
        string combined = greeting + " My name is " + name + ".";
        string interpolated = $"{greeting} My name is {name}.";

        Console.WriteLine("String Type");
        Console.WriteLine($"Greeting: {greeting}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Combined: {combined}");
        Console.WriteLine($"Interpolated: {interpolated}");
        Console.WriteLine($"Length of Greeting: {greeting.Length}");
        Console.WriteLine($"Uppercase Greeting: {greeting.ToUpper()}");

        int number = 42;
        string numberAsString = number.ToString();
        Console.WriteLine($"Number as String: {numberAsString}");
    }
}