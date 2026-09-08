partial class Program
{
    static void Exercise41()
    {
        Cliente41 cliente = new Cliente41("Aldo");

        Pedido41 pedido = new Pedido41(1001, cliente);

        WriteLine($"Pedido: {pedido.Numero}");
        WriteLine($"Cliente: {pedido.Cliente.Nombre}");
    }

    class Cliente41
    {
        public string Nombre { get; set; }

        public Cliente41(string nombre)
        {
            Nombre = nombre;
        }
    }

    class Pedido41
    {
        public int Numero { get; set; }
        public Cliente41 Cliente { get; set; }

        public Pedido41(int numero, Cliente41 cliente)
        {
            Numero = numero;
            Cliente = cliente;
        }
    }
}