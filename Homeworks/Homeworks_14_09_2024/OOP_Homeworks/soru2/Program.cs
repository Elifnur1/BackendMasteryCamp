using System.Runtime.ConstrainedExecution;

namespace soru2;

public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }   
    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"{Make} marka, {Model} model, {Year} yıl");
    }

}
public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Kapı sayısı:{NumberOfDoors}");
    }
}


public class Bicycle : Vehicle
{
    public Bicycle(string make, string model, int year, int numberOfWheels) : base(make, model, year)
    {
        NumberOfWheels = numberOfWheels;
    }
    public int NumberOfWheels { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Tekerlek sayısı: {NumberOfWheels}");
    }

}
public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public bool HasSidecar { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Sepet Var MI? {HasSidecar}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car1=new Car("BMW","Sport",2024,4);
        car1.BilgileriEkranaYaz();
        Bicycle bicycle=new Bicycle("Bianca","A100",2024,2);
        bicycle.BilgileriEkranaYaz();
        Motorcycle motorcycle1=new Motorcycle("Kawasaki","E10",2024,true);
        motorcycle1.BilgileriEkranaYaz();
    }
}
