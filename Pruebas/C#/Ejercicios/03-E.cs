partial class Program
{
    static void Ejercicio3()
    {
        WriteLine("Ingrese una cadena de texto:");
        string? input = ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            StringReverse(input);
        }
        else
        {
            WriteLine("No se ingresó ninguna cadena.");
        }
    }

    static void StringReverse(string cadena)
    {
        string reversed = string.Concat(cadena.Reverse());
        WriteLine($"Cadena original: {cadena}");
        WriteLine($"Cadena invertida: {reversed}");
    }
}