partial class Program
{
    static void NumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.14159d;
        decimal decimalNumber = 19.99m;
        float floatNumber = 2.71828f;
        long longNumber = 1234567890123456789L;

        Console.WriteLine("Numeric Types");
        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Long: {longNumber}");
    }
}