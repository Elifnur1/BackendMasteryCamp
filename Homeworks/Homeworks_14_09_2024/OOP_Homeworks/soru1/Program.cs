using System.Diagnostics;

namespace OOP_Homeworks;

public class Animal
{
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public virtual void Makesound()
    {
        System.Console.WriteLine($"{Name} ses çıkardı.");
    }

}

public class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} kükredi.");
    }
}
public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} boru sesi çıkardı.");
    }
}
public class Giraffe : Animal
{
    public Giraffe(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} hortum sesi çıkardı.");
    }
}

class Program
{
    static void Main(string[] args)
    {


        Lion lion1 = new Lion("Dan", 20, "Aslan");
        lion1.Makesound();
        Elephant elephant1 = new Elephant("Aleyna", 24, "Fil");
        elephant1.Makesound();
        Giraffe giraffe1 = new Giraffe("Berat", 17, "Zürafa");
        giraffe1.Makesound();






    }
}
