/*
=====================================
Análisis de Ventas con LINQ y Excepciones
=====================================
*/
// 🏆 Ejercicio:
// Desarrollar un sistema para analizar las ventas de una empresa usando colecciones y LINQ.
// Tendrás una clase "Sale" con las siguientes propiedades:
//  - Product (public)
//  - Category (public)
//  - Amount (public)
//
// También una lista con 6 ventas ficticias.
// Lo que tendrás que desarrollar es:
// 1. Filtrar y mostrar las ventas con monto superior a 1000.
// 2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.
// 3. Manejar excepciones en caso de errores al procesar los datos.

using System.ComponentModel;

partial class Program
{
    static void SalesAnalysis()
    {
        try
        {
            List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };

            WriteLine($"Ventas con monto superior a 1000:");
            var ventaSuperior = from s in sales
                                where s.Amount > 1000
                                select s;
            foreach (var venta in ventaSuperior)
            {
                Write($"Producto: {venta.Product}, Categoría: {venta.Category}, {venta.Amount:C2}\n");
            }

            WriteLine($"Total de ventas por categoría:");
            var ventasCategoria = sales.GroupBy(s => s.Category).Select(g => new { Category = g.Key, TotalAmount = g.Sum(s => s.Amount) });
            foreach (var item in ventasCategoria)
            {
                WriteLine($"Categoría: {item.Category}, Total Ventas: {item.TotalAmount:C2}");
            }
        }
        catch (Exception ex)
        {
            WriteLine($"Error al procesar las ventas {ex.Message}");
        }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}