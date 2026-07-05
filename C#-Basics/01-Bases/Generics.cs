partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 4 };

        WriteLine($"Tamaño del arreglo númerico {GetArrayLength(numbers)}");
        WriteLine($"Tamaño del arreglo nombres {GetArrayLength(names)}");
        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy texto" };
        numberBox.Show();
        stringBox.Show();
    }

    //Metodos sin uso de genericos
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Método generico

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }

    //Clase generica
    class Box<T>
    {
        public T? Content { get; set; }
        public void Show()
        {
            WriteLine($"Contenido: {Content}");
        }
    }
}