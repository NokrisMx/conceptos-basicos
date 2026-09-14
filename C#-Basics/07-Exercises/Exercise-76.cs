partial class Program
{
    static void Exercise76()
    {
        var clientes = new List<Cliente76>
{
    new Cliente76(1, "Juan"),
    new Cliente76(2, "María"),
    new Cliente76(3, "Pedro")
};

        var ventas = new List<Venta76>
{
    new Venta76(1, "Laptop", 15000),
    new Venta76(2, "Mouse", 500),
    new Venta76(1, "Monitor", 8000),
    new Venta76(3, "Teclado", 1200)
};

        var resultado = ventas.Join(clientes, v => v.ClienteId, c => c.Id, (v, c) => new { Cliente = c.Nombre, Producto = v.Producto, Total = v.Total }).Where(v => v.Total > 5000);

        foreach (var r in resultado)
        {
            WriteLine($"{r.Cliente} - {r.Producto} - {r.Total:C2}");
        }

    }



    class Cliente76
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Cliente76(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    class Venta76
    {
        public int ClienteId { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }

        public Venta76(int clienteId, string producto, decimal total)
        {
            ClienteId = clienteId;
            Producto = producto;
            Total = total;
        }
    }
}