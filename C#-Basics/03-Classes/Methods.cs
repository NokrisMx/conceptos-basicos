partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();
        // car.ShowMessage("Cambiando de modelo");
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        //Un constructor
        Car sportsCar = new("Ferrari", 2020);
        WriteLine(car.ShowInfo());

        //Sintaxís simplificada
        Car collectionCar = new Car { Model = "Cadilac", Year = 1980 };
        WriteLine(collectionCar.ShowInfo());

        //Listas de objetos
        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="StepWay", Year=2019},
            new Car(){Model="Captur", Year=2000}
        };
        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }
    }
}

class Car
{
    public string? Model { get; set; }
    public int Year { get; set; }

    //Constructor con parametros
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    //Constructor por defecto
    public Car() { }

    //Destructor (~)
    ~Car()
    {
        WriteLine($"Destructor llamado. Recurso liberado.");
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    public string ShowInfo()
    {
        return $"Autómovil: {Model}, Año: {Year}";
    }

    //Metodos sobrecargados
    public void ShowMessage() => WriteLine("Este es un autómovil.");
    public void ShowMessage(string message) => WriteLine(message);

    //Metodos static
    public static void GeneralInfo()
    {
        WriteLine($"El autómovil es uno de los transportes mas usados.");
    }
}