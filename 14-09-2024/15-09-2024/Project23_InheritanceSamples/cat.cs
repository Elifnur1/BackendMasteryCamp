using System;

namespace Project23_InheritanceSamples;

public class Cat : Animal
{
    public Cat(string name, int age,string color): base(name,age)
    {
        Color=color;
    }
    public string Color{ get; set;}
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} ses çıkardı");
    // base.MakeSound();  // base kavramı,animaldaki makesoundu çalıştır demek.
    }
}
