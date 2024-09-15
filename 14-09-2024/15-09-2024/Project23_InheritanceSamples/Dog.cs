using System;

namespace Project23_InheritanceSamples;

public class Dog : Animal
{
    public Dog (string name,int age) : base(name ,age)
    {
    }
    public int OlfactionLevel { get; set; }
    public string Breed { get; set; }
    public override void MakeSound()
    {
       System.Console.WriteLine($"{Name} havladı");
    }
    public void Swim()
    {
        System.Console.WriteLine(($"{Name} yüzdü"));
    }
}
