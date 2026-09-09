partial class Program
{
    static void Exercise46()
    {
        List<int> numeros = new List<int> { 5, 12, 8, 21, 30, 17, 4 };
        var mayores = numeros.Where(n => n > 10);
        foreach (var m in mayores)
        {
            WriteLine($"{m}");
        }
    }
}