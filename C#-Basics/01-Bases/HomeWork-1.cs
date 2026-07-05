partial class Program
{
    static void SalesReport()
    {
        string productName = "Laptop";
        int quantitySold = 3;
        double price = 750.99;
        double totalAmount = quantitySold * price;

        Console.WriteLine("Sales Report");
        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Quantity Sold: {quantitySold}");
        Console.WriteLine($"Price: ${price:F2}");
        Console.WriteLine($"Total Amount: {totalAmount:C}");
    }

    static void SalaryCalculator()
    {
        Console.Write($"Employee:");
        string? employeeName = Console.ReadLine();

        Console.Write($"Hourly Rate: ");
        double? hourlyRate = double.Parse(Console.ReadLine()!);

        Console.Write($"Hours Worked: ");
        double? hoursWorked = double.Parse(Console.ReadLine()!);

        double grossSalary = (double)(hourlyRate * hoursWorked);

        Console.WriteLine("Salary Calculator");
        Console.WriteLine();
        Console.WriteLine($"Employee: {employeeName}");
        Console.WriteLine($"Hourly Rate: ${hourlyRate:F2}");
        Console.WriteLine($"Hours Worked: {hoursWorked:F2}");
        Console.WriteLine($"Gross Salary: ${grossSalary:F2}");
    }
}


