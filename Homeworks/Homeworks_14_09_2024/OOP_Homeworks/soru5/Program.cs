namespace soru5;

public class Event
{
    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public virtual void BilgileriYaz()
    {
        System.Console.WriteLine($"Etkinlik Adı:{Name}\nEtkinlik Tarihi:{Date}\nLokasyon:{Location}");
    }
}
class Meeting : Event
{
    public Meeting(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"Toplantı başladı.");
    }
}
class BirthDay : Event
{
    public BirthDay(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"{Name} başladı");
    }
}
class Task : Event
{
    public Task(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"tamamlandı");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BirthDay birthDay1=new BirthDay("Elif'in doğum günü",DateTime.Now,"Sarıyer");
        birthDay1.BilgileriYaz();
        Meeting meeting1=new Meeting("İş Toplantısı",DateTime.Now,"Sarıyer");
        meeting1.BilgileriYaz();
        Task task1=new Task("Etkinlik",DateTime.Now,"Sarıyer");
        task1.BilgileriYaz();
       
        


    }
}
