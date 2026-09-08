partial class Program
{
    static void Exercise34()
    {
        Empleado34 empleado = new Empleado34("Juan", 30000);
        WriteLine(empleado.Nombre);
        WriteLine(empleado.SalarioBase);
        EmpleadoFijo34 empleadoFijo = new EmpleadoFijo34("Ana", 20000);
        WriteLine(empleadoFijo.Nombre);
        WriteLine(empleadoFijo.SalarioBase);
        EmpleadoPorHora34 empleadoPorHora = new EmpleadoPorHora34("Carlos", 160, 100);
        WriteLine(empleadoPorHora.Nombre);
        WriteLine(empleadoPorHora.CalcularSalarioPorHora34());
    }

    class Empleado34
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado34(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public decimal CalcularSalario34()
        {
            return SalarioBase;
        }
    }

    class EmpleadoFijo34 : Empleado34
    {
        public EmpleadoFijo34(string nombre, decimal salarioBase) : base(nombre, salarioBase)
        {

        }
    }

    class EmpleadoPorHora34 : Empleado34
    {
        public double HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }
        public EmpleadoPorHora34(string nombre, double horasTrabajadas, decimal pagoPorHora) : base(nombre, 0)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }

        public decimal CalcularSalarioPorHora34()
        {
            return (decimal)HorasTrabajadas * PagoPorHora;
        }
    }


}