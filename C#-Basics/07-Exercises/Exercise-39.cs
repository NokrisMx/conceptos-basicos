partial class Program
{
    static void Exercise39()
    {
        Cliente39 cliente = new Cliente39("Carlos");
        cliente.Notificar();
        cliente.Registrar();
    }

    interface INotificable39
    {
        void Notificar();
    }

    interface IRegistrable39
    {
        void Registrar();
    }

    class Cliente39 : INotificable39, IRegistrable39
    {
        public string Nombre { get; set; }

        public Cliente39(string nombre)
        {
            Nombre = nombre;
        }

        public void Notificar()
        {
            WriteLine($"Notificando a cliente: {Nombre}");
        }

        public void Registrar()
        {
            WriteLine($"Registrando cliente: {Nombre}");
        }
    }
}