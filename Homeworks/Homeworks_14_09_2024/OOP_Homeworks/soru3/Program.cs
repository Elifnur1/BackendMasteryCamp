namespace soru3;
public class Employee
{
    public Employee(string name, int ıd, decimal maas)
    {
        Name = name;
        Id = ıd;
        Maas = maas;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Maas { get; set; }
    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"Ad:{Name}\nKimlik Numarası:{Id}\nMaaş:{Maas}");
    }
}

class Manager : Employee
{
    public Manager(string name, int ıd, decimal maas, int numberOfTeams) : base(name, ıd, maas)
    {
        NumberOfTeams = numberOfTeams;
    }
    public int NumberOfTeams { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Takım sayısı: {NumberOfTeams}");
    }

}
class Developer : Employee
{
    public Developer(string name, int ıd, decimal maas, string programingLanguage) : base(name, ıd, maas)
    {
        ProgramingLanguage = programingLanguage;
    }
    public string ProgramingLanguage { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Proglama dili: {ProgramingLanguage}");

    }

}
class Intern : Employee
{
    public Intern(string name, int ıd, decimal maas) : base(name, ıd, maas)
    {
    }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee1=new Employee("Tuba",123123123,34000);
        employee1.BilgileriEkranaYaz();
        Manager manager1=new Manager("Tuba", 123123123, 340004,4);
        manager1.BilgileriEkranaYaz();
        Developer developer1=new Developer("Tuba", 123123123, 34000,"C#");
        developer1.BilgileriEkranaYaz();
        Intern ıntern1=new Intern("Tuba", 123123123, 34000);
        ıntern1.BilgileriEkranaYaz();
    }
}
