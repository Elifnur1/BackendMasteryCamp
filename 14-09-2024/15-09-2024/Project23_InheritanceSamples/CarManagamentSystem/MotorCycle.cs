using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year, string coolingSystem) : base(brand, model, year)
    {
        CoolingSystem = coolingSystem;
    }
    public string CoolingSystem { get; set; }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"motorun soğutma sistemi: {CoolingSystem}");
    }
}
