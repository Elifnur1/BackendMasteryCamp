using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
   öğretmen bir kişidir.
   öğretmenin ek olarak branş ve maaş bilgisi olacak
   maaş bilgisinin negatif değer olarak girilmesine izin verilmeyecek (sadece hata mesajı verilirse yeterli.)
   öğretmenin bilgileri ekrana yazdırılırken branş ve maaş bilgiside yazdırılacak.
*/
public class Ogretmen : Kisi
{

    public Ogretmen(string name, string soyad, DateTime dogumTarihi, int maas, string brans) : base(name, soyad, dogumTarihi)
    {
        Maas = maas;
        Brans = brans;
    }
    decimal maas;
    public decimal Maas{ get
    {
       return maas;
    }
    
     set{ if(value<0)
    {
        throw new ArgumentException("Negatif maaş bilgisi girilemez.");
    }
       maas=value;

    }}
    public string Brans { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Maaşınız: {Maas:C0}\nBranş: {Brans}");
        

    }

}
