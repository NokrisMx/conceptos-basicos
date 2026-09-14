partial class Program
{
    static void Exercise77()
    {
        var clientes = new List<Cliente77>
{
    new Cliente77(1, "Juan"),
    new Cliente77(2, "María"),
    new Cliente77(3, "Pedro")
};

        var ventas = new List<Venta77>
{
    new Venta77(1, "Laptop", 15000),
    new Venta77(2, "Mouse", 500),
    new Venta77(1, "Monitor", 8000),
    new Venta77(3, "Teclado", 1200)
};

        var resultado = ventas.Join(
        clientes,
        v => v.ClienteId,
        c => c.Id,
        (v, c) => new
        {
            Cliente = c.Nombre,
            Total = v.Total
        })
        .GroupBy(v => v.Cliente);

        foreach (var grupo in resultado)
        {
            WriteLine($"{grupo.Key} - {grupo.Sum(v => v.Total):C2}");
        }

    }



    class Cliente77
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Cliente77(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    class Venta77
    {
        public int ClienteId { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }

        public Venta77(int clienteId, string producto, decimal total)
        {
            ClienteId = clienteId;
            Producto = producto;
            Total = total;
        }
    }
}