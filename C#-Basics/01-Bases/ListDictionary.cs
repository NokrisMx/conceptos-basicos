partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        names.Add("Diana");
        Console.WriteLine($"Total names: {names.Count}");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        names.Remove("Bob");
        bool isPresent = names.Contains("Bob");
        Console.WriteLine($"Is Bob in the list? {isPresent}");

        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice"},
            { 2, "Bob"},
            { 3, "Charlie"}
        };
        Console.WriteLine($"El estudiante con ID 2 es: {students[2]}");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }


    }
}