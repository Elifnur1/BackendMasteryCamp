using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Kisi
{
    public Kisi(string name, string soyad, DateTime dogumTarihi)
    {
        Name = name;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public string Name { get; set; }
  public string Soyad { get; set; }
  public DateTime DogumTarihi { get; set; }
  public byte Yas  //Salt okunur (ReadOnly) property
  {
    get
    {
       return(byte) (DateTime.Now.Year-DogumTarihi.Year);
    }
  }

    public object OgrenciNumarası { get; private set; }

    public virtual void BilgileriEkranaYaz()
  {
    System.Console.WriteLine($"Ad: {Name}\nSoyad: {Soyad}\nYaş: {Yas}");
  }

}
