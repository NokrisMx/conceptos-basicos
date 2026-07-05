partial class Program
{
    public static void staticInHeritance()
    {
        HogwartsStudent student = new HogwartsStudent()
        {
            Name = "Harry Potter",
            House = "Gryffindor"
        };

        HogwartsProfessor professor = new HogwartsProfessor()
        {
            Name = "Severus Snape",
            Subject = "Pociones"
        };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();
    }
}

class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

class HogwartsStudent : Character
{
    public string? House { get; set; }
    public override void Greet()
    {
        base.Greet();
        WriteLine($"Hola, soy {Name} y soy estudiante.");
    }

    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Hogwarts");
    }
}

class HogwartsProfessor : Character
{
    public string? Subject { get; set; }
    public override void Greet()
    {
        base.Greet();
        WriteLine($"Hola, soy {Name} y soy profesor.");
    }

    public void MySubject()
    {
        WriteLine($"Enseño {Subject} en Hogwarts");
    }
}