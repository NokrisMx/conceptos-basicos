partial class Program
{
    static void Exercise37()
    {
        List<Empleado37> empleados = new List<Empleado37>();

        EmpleadoFijo37 empleado1 = new EmpleadoFijo37("Ana", 20000);
        empleados.Add(empleado1);

        EmpleadoPorHora37 empleado2 = new EmpleadoPorHora37("Carlos", 160, 100);
        empleados.Add(empleado2);

        EmpleadoPorHora37 empleado3 = new EmpleadoPorHora37("Maria", 120, 150);
        empleados.Add(empleado3);

        foreach (var e in empleados)
        {
            WriteLine($"Nombre: {e.Nombre}");
            WriteLine($"Salario base: {e.CalcularSalario():C2}");
        }
    }

    abstract class Empleado37
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado37(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public abstract decimal CalcularSalario();

    }

    class EmpleadoFijo37 : Empleado37
    {
        public EmpleadoFijo37(string nombre, decimal salarioBase) : base(nombre, salarioBase)
        {

        }

        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }

    class EmpleadoPorHora37 : Empleado37
    {
        public double HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }

        public EmpleadoPorHora37(string nombre, double horasTrabajadas, decimal pagoPorHora) : base(nombre, 0)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }

        public override decimal CalcularSalario()
        {
            return (decimal)HorasTrabajadas * PagoPorHora;
        }
    }
}