partial class Program
{
    static void ShowDateTime()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date and Time:");
        Console.WriteLine($"Now: {now.ToString("dd-MM-yyyy")}");
        Console.WriteLine($"Today: {now.ToShortDateString()}");
        Console.WriteLine($"Hour: {now.Hour}");
        Console.WriteLine($"Day: {now.Day}");
        Console.WriteLine($"Day of Week: {now.DayOfWeek}");
        Console.WriteLine($"Year: {now.Year}");
        Console.WriteLine($"Month: {now.Month}");
        Console.WriteLine($"Date: {now.Date}");
        Console.WriteLine($"Time: {now.TimeOfDay}");
    }
}