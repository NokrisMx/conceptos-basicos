partial class Program
{
    static void Exercise73()
    {
        var departamentos = new List<Departamento73>
{
    new Departamento73("Ventas", new List<string> { "Ana", "Luis" }),
    new Departamento73("Sistemas", new List<string> { "Pedro", "María", "Carlos" })
};

        var empleados = departamentos.SelectMany(d => d.Empleados);

        foreach (var e in empleados)
        {
            WriteLine($"{e}");
        }
    }

    class Departamento73
    {
        public string Nombre { get; set; }
        public List<string> Empleados { get; set; }

        public Departamento73(string nombre, List<string> empleados)
        {
            Nombre = nombre;
            Empleados = empleados;
        }
    }


}