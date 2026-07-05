/*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una clase "Bus" con las siguientes propiedades:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implementar un constructor para inicializar los valores.
// 3. Agregar un método "Drive(int kilometers)" que aumente el kilometraje.
// 5. Agregar un método "ShowPrice()" que nos devuelva el precio del bus.
// 6. Crear una clase "Fleet" que administre una lista de buses.
//    - Método para agregar buses a la flota.
//    - Método mostrar el listado de buses.
//
// 7. Instanciar al menos tres objetos de la clase Bus, agregarlos a la Fleet y simular la conducción de 5000.
// 8. Mostrar los detalles de la flota antes y después de la conducción.

partial class Program
{
    // static void ProductSalesDemo()
    // {
    //     Inventory inventory = new();
    //     Product laptop = new Product("Laptop", 1200.99, 5);
    //     Product mouse = new Product("Mouse", 100, 10);
    //     inventory.AddProduct(laptop);
    //     inventory.AddProduct(mouse);
    //     inventory.ShowInventory();
    //     laptop.Sell(1);
    // }

    static void BusFleet()
    {

        Bus toyota = new Bus("Toyota", "Corolla", 2019, 200000, 10000);
        Bus honda = new Bus("Honda", "Civic", 2018, 300000, 8000);
        Bus Ford = new Bus("Ford", "Fiesta", 2017, 400000, 7000);
        Fleet fleet = new();
        fleet.AddBus(toyota);
        fleet.AddBus(honda);
        fleet.AddBus(Ford);
        fleet.ShowBuses();
        WriteLine($"-Despues de manejar 5000 km-");
        toyota.Drive(5000);
        honda.Drive(5000);
        Ford.Drive(5000);
        fleet.ShowBuses();
    }
}

// class Product
// {
//     public string? Name { get; set; }
//     public double Price { get; set; }
//     public int Stock { get; set; }

//     public Product(string name, double price, int stock)
//     {
//         Name = name;
//         Price = price;
//         Stock = stock;
//     }

//     public void ShowInfo()
//     {
//         WriteLine($"Producto: {Name}, Precio: {Price}, Stock:{Stock}");
//     }

//     public bool Sell(int quantity)
//     {
//         if (quantity <= Stock)
//         {
//             Stock -= quantity;
//             WriteLine($"Venta realizada: {quantity} unidades de {Name}");
//             return true;
//         }
//         WriteLine($"Stock insuficiente para {Name}");
//         return false;
//     }
// }

// class Inventory
// {
//     private List<Product> products = new List<Product>();

//     public void AddProduct(Product product)
//     {
//         products.Add(product);
//     }

//     public void ShowInventory()
//     {
//         WriteLine($"Inventario de productos");
//         foreach (var product in products)
//         {
//             product.ShowInfo();
//         }
//     }
// }

class Bus
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public double TotalKilometers { get; set; }

    public Bus(string brand, string model, int year, Decimal price, double totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public Bus() { }

    public void Drive(int kilometers)
    {
        TotalKilometers += kilometers;
    }

    public void ShowPrice()
    {
        WriteLine($"Precio: {Price:C2}");
    }
}

class Fleet
{
    private List<Bus> buses = new List<Bus>();
    public void AddBus(Bus bus)
    {
        buses.Add(bus);
    }

    public void ShowBuses()
    {
        WriteLine($"Listado de Buses");
        foreach (var bus in buses)
        {
            WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Year: {bus.Year}, Kilometraje: {bus.TotalKilometers}");
        }
    }
}