partial class Program
{
    static void HandleNullables()
    {
        string? name = null;
        //operador de coalescencia nula (??)
        Console.WriteLine($"Name: {name ?? "Unknown"}");
        //Operador de acceso nulo seguro (?.)
        int? nameLength = name?.Length;
        Console.WriteLine($"Name Length: {nameLength ?? 0}");
    }
}