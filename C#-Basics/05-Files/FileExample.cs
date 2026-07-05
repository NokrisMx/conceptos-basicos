partial class Program
{
    static void FileExample()
    {
        var filePath = "./05-Files/Example.txt";

        var content = File.ReadAllText(filePath);
        //WriteLine(content);
        var lines = File.ReadAllLines(filePath);
        foreach (var item in lines)
        {
            WriteLine(item);
        }
        WriteLine(lines[1]);
        //File.Copy(filePath, "./05-Files/Example-Copy.txt", overwrite: true);
        File.Delete("./05-Files/Example-Copy.txt");
    }
}