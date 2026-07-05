partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1999, 11, 22);
        DateTime currentDate = DateTime.Now;

        TimeSpan age = currentDate - birthDate;
        int daysLived = (int)age.TotalDays;

        Console.WriteLine($"You have lived for approximately {daysLived} days.");
    }

    static void DaysUntilNextBirthday()
    {
        Console.Write("Birthdate (yyyy-MM-dd): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
        DateTime currentDate = DateTime.Now;

        DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan timeUntilNextBirthday = nextBirthday - currentDate;
        int daysUntilNextBirthday = (int)timeUntilNextBirthday.TotalDays;

        Console.WriteLine($"There are {daysUntilNextBirthday} days until your next birthday.");
    }
}