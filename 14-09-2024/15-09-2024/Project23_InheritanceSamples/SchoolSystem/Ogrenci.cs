using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
 Öğrenci bir kişidir
 Öğrencinin ek olarak öğrenci numarası özelliği vadır.
 öğrencinin bilgileri ekrana yazdırılırken öğrenci numarasıda yazdırılmalıdır.

*/
public class Ogrenci : Kisi
{
    public Ogrenci(string name, string soyad, DateTime dogumTarihi, int ogrenciNumarası) : base(name, soyad, dogumTarihi)
    {
        OgrenciNumarası = ogrenciNumarası;
    }
    public int OgrenciNumarası { get; set; }
    public override void BilgileriEkranaYaz()
    {
    System.Console.WriteLine($"Ad: {Name}\nSoyad: {Soyad}\nYaş: {Yas}\n Öğrenci Numarası:{OgrenciNumarası}");
    }

}
