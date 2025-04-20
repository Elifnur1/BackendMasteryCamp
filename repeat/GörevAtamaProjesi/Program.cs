using System;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci student1 = new Ogrenci(); //Öğrnc, sınıfından bir nesne oluşturduk.
        student1.Name = "ELİF";
        student1.Age = 24;
        student1.Gpa = 85;

        System.Console.WriteLine($"Ad:{student1.Name}, Yaş:{student1.Age},Not:{student1.Gpa}");  /
    }



}
