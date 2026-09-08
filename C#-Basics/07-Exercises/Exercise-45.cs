partial class Program
{
    static void Exercise45()
    {
        List<IPagable45> pagable = new List<IPagable45>();

        EmpleadoFijo45 empleado1 = new EmpleadoFijo45("Ana", 20000);
        pagable.Add(empleado1);
        EmpleadoPorHora45 empleado2 = new EmpleadoPorHora45("Carlos", 160, 100);
        pagable.Add(empleado2);
        EmpleadoPorHora45 empleado3 = new EmpleadoPorHora45("María", 120, 150);
        pagable.Add(empleado3);

        foreach (var p in pagable)
        {
            p.CalcularPago();
        }

    }

    interface IPagable45
    {
        decimal CalcularPago();
    }

    abstract class Empleado45
    {
        public string Nombre { get; set; }

        public Empleado45(string nombre)
        {
            Nombre = nombre;
        }

        public abstract decimal CalcularPago();
    }

    class EmpleadoFijo45 : Empleado45, IPagable45
    {
        public decimal SalarioMensual { get; set; }

        public EmpleadoFijo45(string nombre, decimal salarioMensual) : base(nombre)
        {
            SalarioMensual = salarioMensual;
        }

        public override decimal CalcularPago()
        {
            return SalarioMensual;
        }
    }

    class EmpleadoPorHora45 : Empleado45, IPagable45
    {
        public double HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }

        public EmpleadoPorHora45(string nombre, double horasTrabajadas, decimal pagoPorHora) : base(nombre)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }

        public override decimal CalcularPago()
        {
            return (decimal)HorasTrabajadas * PagoPorHora;
        }
    }
}