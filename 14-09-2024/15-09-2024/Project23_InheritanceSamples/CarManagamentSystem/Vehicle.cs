using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;

public class Vehicle
{
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

 public string Brand { get; set; }
 public string Model { get; set; }
 public int Year { get; set; }
 public void start()
 {
     System.Console.WriteLine("Araba çalıştı.");
 }
 public void stop()
 {
    System.Console.WriteLine("Araba durdu");
 }
 public virtual void BilgileriYaz()
 {
    System.Console.WriteLine($"Markası: {Brand}\nModeli: {Model}\nYılı: {Year}");
 }
 }


