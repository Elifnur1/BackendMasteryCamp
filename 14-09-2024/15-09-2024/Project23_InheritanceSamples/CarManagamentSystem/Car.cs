using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }
    public int CountOfDoors { get; set; }
    public void opentrunk()
    {
        System.Console.WriteLine("Kaput açıldı.");
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"arabanın kapı sayısı: {CountOfDoors}");
    }
    

 }
