partial class Program
{
    static void Exercise75()
    {
        var clientes = new List<Cliente75>
        {
            new Cliente75(1, "Juan"),
            new Cliente75(2, "María"),
            new Cliente75(3, "Pedro")
        };

        var ventas = new List<Venta75>
        {
            new Venta75(1, "Laptop", 15000),
            new Venta75(2, "Mouse", 500),
            new Venta75(1, "Monitor", 8000),
            new Venta75(3, "Teclado", 1200)
        };

        var resultado = ventas.Join(clientes, v => v.ClienteId, c => c.Id, (v, c) => new { Cliente = c.Nombre, Producto = v.Producto });

        foreach (var r in resultado)
        {
            WriteLine($"{r.Cliente} - {r.Producto}");
        }
    }

    class Cliente75
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Cliente75(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    class Venta75
    {
        public int ClienteId { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }

        public Venta75(int clienteId, string producto, decimal total)
        {
            ClienteId = clienteId;
            Producto = producto;
            Total = total;
        }
    }
}