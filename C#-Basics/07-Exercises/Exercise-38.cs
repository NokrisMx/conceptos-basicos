partial class Program
{
    static void Exercise38()
    {
        List<INotificable38> notificaciones = new List<INotificable38>();

        Empleado38 empleado1 = new Empleado38("Ana");
        notificaciones.Add(empleado1);
        Cliente38 cliente1 = new Cliente38("Carlos");
        notificaciones.Add(cliente1);
        Empleado38 empleado2 = new Empleado38("Luis");
        notificaciones.Add(empleado2);

        foreach (var n in notificaciones)
        {
            n.Notificar();
        }
    }

    interface INotificable38
    {
        void Notificar();
    }

    class Empleado38 : INotificable38
    {
        public string Nombre { get; set; }

        public Empleado38(string nombre)
        {
            Nombre = nombre;
        }

        public void Notificar()
        {
            WriteLine($"Notificando a empleado: {Nombre}");
        }
    }

    class Cliente38 : INotificable38
    {
        public string Nombre { get; set; }

        public Cliente38(string nombre)
        {
            Nombre = nombre;
        }

        public void Notificar()
        {
            WriteLine($"Notificando a cliente: {Nombre}");
        }
    }
}