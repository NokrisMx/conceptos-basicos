partial class Program
{
    static void Exercise40()
    {
        List<IPagable40> pagos = new List<IPagable40>();
        List<INotificable40> notificaciones = new List<INotificable40>();

        Empleado40 empleado1 = new Empleado40("Ana", 20000);
        Proveedor40 proveedor1 = new Proveedor40("Microsoft", 35000);
        Empleado40 empleado2 = new Empleado40("Carlos", 18000);

        pagos.Add(empleado1);
        pagos.Add(proveedor1);
        pagos.Add(empleado2);

        foreach (var pago in pagos)
        {
            WriteLine($"Pago: {pago.CalcularPago():C2}");
        }

        notificaciones.Add(empleado1);
        notificaciones.Add(proveedor1);
        notificaciones.Add(empleado2);

        foreach (var noti in notificaciones)
        {
            noti.Notificar();
        }



    }

    interface INotificable40
    {
        void Notificar();
    }

    interface IPagable40
    {
        decimal CalcularPago();
    }

    class Empleado40 : INotificable40, IPagable40
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public Empleado40(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public void Notificar()
        {
            WriteLine($"Notificando a empleado: {Nombre}");
        }

        public decimal CalcularPago()
        {
            return Salario;
        }
    }

    class Proveedor40 : IPagable40, INotificable40
    {
        public string Nombre { get; set; }
        public decimal MontoFactura { get; set; }

        public Proveedor40(string nombre, decimal montoFactura)
        {
            Nombre = nombre;
            MontoFactura = montoFactura;
        }

        public decimal CalcularPago()
        {
            return MontoFactura;
        }

        public void Notificar()
        {
            WriteLine($"Notificando a proveedor: {Nombre}");
        }
    }
}