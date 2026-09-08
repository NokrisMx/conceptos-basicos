partial class Program
{
    static void Exercise35()
    {
        Empleado35 empleado = new Empleado35("Juan", 30000);
        WriteLine(empleado.Nombre);
        WriteLine(empleado.SalarioBase);

        EmpleadoFijo35 empleadoFijo = new EmpleadoFijo35("Juan", 30000);
        WriteLine($"Nombre: {empleadoFijo.Nombre}");
        WriteLine($"Salario: {empleadoFijo.CalcularSalario35():C2}");

        EmpleadoPorHora35 empleadoPorHora = new EmpleadoPorHora35("Carlos", 160, 100);
        WriteLine(empleadoPorHora.Nombre);
    }

    class Empleado35
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado35(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public virtual decimal CalcularSalario35()
        {
            return SalarioBase;
        }
    }

    class EmpleadoFijo35 : Empleado35
    {

        public EmpleadoFijo35(string nombre, decimal salarioBase) : base(nombre, salarioBase)
        {

        }


    }

    class EmpleadoPorHora35 : Empleado35
    {
        public double HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }
        public EmpleadoPorHora35(string nombre, double horasTrabajadas, decimal pagoPorHora) : base(nombre, 0)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }

        public override decimal CalcularSalario35()
        {
            return (decimal)HorasTrabajadas * PagoPorHora;
        }
    }


}