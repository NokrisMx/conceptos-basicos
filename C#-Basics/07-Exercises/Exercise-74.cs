partial class Program
{
    static void Exercise74()
    {
        var clientes = new List<Cliente74>
        {
            new Cliente74(1, "Juan"),
            new Cliente74(2, "María"),
            new Cliente74(3, "Pedro")
        };

        var ventas = new List<Venta74>
        {
            new Venta74(1, "Laptop", 15000),
            new Venta74(2, "Mouse", 500),
            new Venta74(1, "Monitor", 8000),
            new Venta74(3, "Teclado", 1200)
        };

        var resultado = ventas.Join(clientes, v => v.ClienteId, c => c.Id, (v, c) => new { Cliente = c.Nombre, Producto = v.Producto, Total = v.Total });

        foreach (var r in resultado)
        {
            WriteLine($"{r.Cliente} - {r.Producto} - {r.Total:C2}");
        }
    }

    class Cliente74
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Cliente74(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    class Venta74
    {
        public int ClienteId { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }

        public Venta74(int clienteId, string producto, decimal total)
        {
            ClienteId = clienteId;
            Producto = producto;
            Total = total;
        }
    }
}