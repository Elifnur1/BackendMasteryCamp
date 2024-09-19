namespace soru10;
public class Karakter
{
    public Karakter(string name, string sağlık)
    {
        Name = name;
        Sağlık = sağlık;
    }

    public string Name { get; set; }
    public string Sağlık { get; set; }
    public virtual void Bilgiler()
    {
        System.Console.WriteLine($"{Name} karakteri ,{Sağlık} durumu.");
    }
}
class Savaşçı : Karakter
{
    public Savaşçı(string name, string sağlık) : base(name, sağlık)
    {
    }
    public void Bilgiler()
    {
        base.Bilgiler();
        System.Console.WriteLine("Kılıç saldırısı");
    }
}
class Büyücü : Karakter
{
    public Büyücü(string name, string sağlık) : base(name, sağlık)
    {
    }
    public void Bilgiler()
    {
        base.Bilgiler();
        System.Console.WriteLine("Büyü Atma");
    }
}
class Okçular : Karakter
{
    public Okçular(string name, string sağlık) : base(name, sağlık)
    {
    }
    public void Bilgiler()
    {
        base.Bilgiler();
        System.Console.WriteLine("Oku Fırlatma");
    }
}

class Program
{
    static void Main(string[] args)
    {
       Savaşçı savaşçı1=new Savaşçı("Thor","sağlıklı");
       savaşçı1.Bilgiler();
       Büyücü büyücü1=new Büyücü("Cadı", "sağlıksız");
       büyücü1.Bilgiler();
       Okçular okçular1=new Okçular("Askerler","sağlıklı");
       okçular1.Bilgiler();
    }
}
