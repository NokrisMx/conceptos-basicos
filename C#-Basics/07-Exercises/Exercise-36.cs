partial class Program
{
    static void Exercise36()
    {
        List<Empleado36> empleados = new List<Empleado36>();

        EmpleadoFijo36 empleado1 = new EmpleadoFijo36("Ana", 20000);
        empleados.Add(empleado1);

        EmpleadoPorHora36 empleado2 = new EmpleadoPorHora36("Carlos", 160, 100);
        empleados.Add(empleado2);

        EmpleadoPorHora36 empleado3 = new EmpleadoPorHora36("Maria", 120, 150);
        empleados.Add(empleado3);

        foreach (var e in empleados)
        {
            WriteLine($"Nombre: {e.Nombre}");
            WriteLine($"Salario base: {e.CalcularSalario():C2}");
        }
    }

    class Empleado36
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado36(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }

    class EmpleadoFijo36 : Empleado36
    {
        public EmpleadoFijo36(string nombre, decimal salarioBase) : base(nombre, salarioBase)
        {

        }

    }

    class EmpleadoPorHora36 : Empleado36
    {
        public double HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }
        public EmpleadoPorHora36(string nombre, double horasTrabajadas, decimal pagoPorHora) : base(nombre, 0)
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