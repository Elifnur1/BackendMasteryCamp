using System.Runtime.ConstrainedExecution;
using Project23_InheritanceSamples.CarManagamentSystem;
using Project23_InheritanceSamples.SchoolSystem;

namespace Project23_InheritanceSamples;
public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void MakeSound()
    {
        System.Console.WriteLine($"{Name} ses çıkardı");
    }

}
class Program
{
    static void Main(string[] args)
    {

        //    Kisi kisi1=new Kisi("Elif","Binici",new DateTime(2000,4,9));
        //    kisi1.BilgileriEkranaYaz();
        //    System.Console.WriteLine($"Kişinin Yaşı {kisi1.Yas}");
        //    Ogrenci ogrenci1=new Ogrenci("Ayşe","Ünal", new DateTime(1977,1,10),1010);
        //    ogrenci1.BilgileriEkranaYaz();

        //    Ogretmen ogretmen1=new Ogretmen("Ali","Yılmaz",new DateTime(1990,3,4),30000,"matematik");
        //    ogretmen1.BilgileriEkranaYaz();

        //  Car car1=new Car("BMW","5.20",2025,4);
        //  car1.BilgileriYaz();
        //  car1.start();
        //  car1.stop();
        //  MotorCycle motorCycle=new MotorCycle("Kawasaki","MT09",2025,"sıvı soğutma");
        //  motorCycle.BilgileriYaz();
        //  car1.opentrunk();


        // Cat cat1=new Cat("Heda", 5, "Siyah");
        // cat1.MakeSound();
        // Dog dog1 = new Dog("Ares",3);
        // dog1.MakeSound();
    }
}
