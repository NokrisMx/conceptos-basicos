partial class Program
{
    static void Ejercicio2()
    {
        List<Empleado2> empleados = new()
{
    new Empleado2{Id=1,Nombre="Juan",Salario=12000},
    new Empleado2{Id=2,Nombre="Pedro",Salario=8000},
    new Empleado2{Id=3,Nombre="Luis",Salario=18000},
    new Empleado2{Id=4,Nombre="Ana",Salario=9500},
    new Empleado2{Id=5,Nombre="María",Salario=21000}
};
        // Instrucciones para realizar las siguientes operaciones con LINQ:
        //          Todos los empleados con salario mayor a 10000.
        //          Ordenarlos de mayor a menor salario.
        //          Obtener únicamente sus nombres.
        //          Calcular el promedio de salario.

        var empleadosConSalarioMayor = empleados.Where(e => e.Salario > 10000);
        var empleadosOrdenados = empleadosConSalarioMayor.OrderByDescending(e => e.Salario);
        var nombres = empleadosOrdenados.Select(e => e.Nombre);
        var promedio = empleados.Average(e => e.Salario);
        WriteLine("Empleados con salario mayor a 10000:");
        foreach (var nombre in nombres)
        {
            WriteLine(nombre);
        }
        WriteLine($"Promedio de salario: {promedio}");
        WriteLine("Empleados ordenados de mayor a menor salario:");
        foreach (var empleado in empleadosOrdenados)
        {
            WriteLine($"Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
        }
        WriteLine("Nombre de empleados");
        foreach (var nombre in nombres)
        {
            WriteLine(nombre);
        }
        WriteLine($"Promedio de salario: {promedio}");
    }
}

class Empleado2
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public double Salario { get; set; }

    // Parameterless constructor to allow object initializers
    public Empleado2() { }
}