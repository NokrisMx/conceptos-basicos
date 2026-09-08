partial class Program
{
    static void Exercise42()
    {
        Pedido42 pedido = new Pedido42(1001, EstadoPedido42.Pagado);
        WriteLine($"Pedido: {pedido.Numero}");
        WriteLine($"Estado: {pedido.Estado}");
    }

    enum EstadoPedido42
    {
        Pendiente,
        Pagado,
        Enviado,
        Cancelado
    }


    class Pedido42
    {
        public int Numero { get; set; }
        public EstadoPedido42 Estado { get; set; }

        public Pedido42(int numero, EstadoPedido42 estado)
        {
            Numero = numero;
            Estado = estado;
        }
    }
}