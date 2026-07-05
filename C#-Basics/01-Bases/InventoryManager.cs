partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Shampoo", "Soap", "Toothpaste", "Lotion", "Conditioner"];
        int[] stock = [50, 100, 75, 30, 60];
        double[] prices = [5.99, 1.99, 3.49, 7.99, 6.49];

        Console.WriteLine("MENU");
        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");
        int opcion = int.Parse(Console.ReadLine()!);

        if (opcion == 1)
        {
            Console.WriteLine("Inventory Report:");
            Console.WriteLine("------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} - Stock: {stock[i]}, Price: ${prices[i]:C2}");
            }

            Console.WriteLine("\nIngrese el producto que desea comprar:");
            string? searchedProduct = Console.ReadLine()!;
            Console.WriteLine("Ingrese la cantidad que desea comprar:");
            int? quantity = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < products.Length; i++)
            {
                if (string.Equals(products[i], searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double totalCost = quantity.Value * prices[i];
                        Console.WriteLine($"Compra exitosa. {quantity} {products[i]}: ${totalCost:C2}");
                        stock[i] -= quantity.Value;
                        Console.WriteLine($"Compra exitosa. Stock restante de {products[i]}: {stock[i]} unidades.");
                    }
                    else
                    {
                        Console.WriteLine($"Lo siento, solo tenemos {stock[i]} unidades de {products[i]} en stock.");
                    }
                }
            }
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Gracias por usar el Inventory Manager. ¡Hasta luego!");
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
        }
    }
}