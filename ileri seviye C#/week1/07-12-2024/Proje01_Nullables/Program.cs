/*
Nullable Types
Bu tipler , bir değerin "YOK" (null) olabilmesine iizn veren veri türleridir.
Genellikler referans tipler için mümkün olan bir durumda.
Varsayılan olarak null değer içeremeyen Value Type'ler istenilirse null değer içerebilece hale getirilebilirler. Bunun için tip adının yanına "?" yazılır.
*/

int? nullableInt = null;

if (nullableInt.HasValue)
{
    System.Console.WriteLine("Değeri var");
}
else
{
    System.Console.WriteLine("Değeri yok");
}

int? nullableValue = null;
// int? result= nullableValue ==null ? 100 : nullableValue;
int result = nullableValue ?? 100;  //çift soru işareti öperatörü bir değişkenin null olup olmadığını kontrol eden bir öperatördür.
System.Console.WriteLine(result);

//Bir veritabanından kullanıcının yaşını alıyoruz,ancak bazı durumlarda bu veri null gelebiliyor.

int userAge = GetUserAge();
System.Console.WriteLine(userAge);

int GetUserAge()
{
    int? age = null;  //Bu fake bir veri tabanından yaş çekme kodu.
    return age ?? -1;
}