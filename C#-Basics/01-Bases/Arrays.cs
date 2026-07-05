partial class Program
{
    static void Arrays()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        Console.WriteLine("Array Elements:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine($"Array Length: {numbers.Length}");
        Console.WriteLine($"First Element: {numbers[0]}");

        //Desde final del array
        Console.WriteLine($"Last Element: {numbers[^1]}");
        Console.WriteLine($"Second to Last Element: {numbers[^2]}");

        //Rangos para obtener suabarrays
        int[] firstThree = numbers[..3]; // Elementos del índice 0 al 2
        Console.WriteLine("First Three Elements: " + string.Join(", ", firstThree));
        int[] middleTwo = numbers[1..^1]; // Elementos del índice 1 al penúltimo
        Console.WriteLine("Middle Two Elements: " + string.Join(", ", middleTwo));


    }
}