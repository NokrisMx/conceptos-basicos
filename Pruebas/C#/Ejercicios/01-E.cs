partial class Program
{
    static void Ejercicio1()
    {
        Empleado empleado = new Empleado("E001", "Juan Pérez", 5000.0);
        double bono = empleado.CalcularBono();
        Console.WriteLine($"El bono del empleado {empleado.Nombre} es: {bono:C2}");
    }
}

class Empleado
{
    public string? Id { get; set; }
    public string? Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string id, string nombre, double salario)
    {
        Id = id;
        Nombre = nombre;
        Salario = salario;
    }

    public double CalcularBono()
    {
        return Salario * 0.10;
    }
}