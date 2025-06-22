using System;

namespace Project24_Interface.Interfaces;

public interface IRepo //Bir sınıfın içerdiği metotların imzasını tanımlayan arayüz.
{
    public void Create();  //void=geri dönüş tipi olmayan metot.
    public void GetAll();
    public void GetById();
    public void Update();
    public void Delete();
    public void GetByUrl();
}
