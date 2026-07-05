partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/";
        Directory.CreateDirectory($"{directoryPath}/DirEjemplo");
        if (Directory.Exists($"{directoryPath}/DirEjemplo"))
        {
            WriteLine("El directorio ya existe");
        }
        else
        {
            WriteLine("No existe");
        }
        Directory.Delete($"{directoryPath}/DirEjemplo", recursive: true);
        WriteLine("Directorio eliminado");
    }
}