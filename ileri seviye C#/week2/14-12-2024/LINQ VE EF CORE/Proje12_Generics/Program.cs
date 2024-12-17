/*
Generic yapılar,özellikle tip güvenliği sağlama konusunda işimizi görürler.Fakat aynı zamanda kodun YENİDEN KULLANABİLİRLİĞİNİ arttırır.
DRY-Don't Repeat Yourself
*/

//Dictionary<TKey,TValue>
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Elif", 24);
ages.Add("Ayşe", 44);
ages.Add("Can", 19);

foreach (var item in ages)
{
    System.Console.WriteLine($"{item.Key}: {item.Value}");
}

if (ages.ContainsKey("Elif"))
{
    System.Console.WriteLine(ages["Elif"]);
}
ages.Remove("Can");
foreach (var item in ages)
{
    System.Console.WriteLine($"{item.Key}: {item.Value}");

}

Box<int> numberBox = new Box<int>();
numberBox.Add(5);
System.Console.WriteLine(numberBox.Get());

Box<string> stringBox = new Box<string>();
stringBox.Add("Elif");
System.Console.WriteLine(stringBox.Get());

class Box<T>
{
    private T content;
    public void Add(T item)
    {
        content = item;
    }
    public T Get()
    {
        return content;
    }
}
//  Dictionary<string, int> ages2 = new Dictionary<string, int>();
// ages2.Add("Aybars", 24);
// ages2.Add("Beyza", 44);
// ages2.Add("Aybüke", 19);
// foreach (var item in ages)
// {
//     System.Console.WriteLine($"{item.Key}: {item.Value}");
// }

// if (ages2.ContainsKey("Aybars"))
// {
//     System.Console.WriteLine("Aybars'ın yaşı:" + ages["Aybars"]);
// }
// ages2.Remove("Aybüke");
// System.Console.WriteLine("Aybüke silindikten sonra:");
// foreach (var item in ages2)
// {
//     System.Console.WriteLine(item);
// }

// Holder<DateTime> dateHolder = new Holder<DateTime>();
// dateHolder.SetValue(DateTime.Now);
// System.Console.WriteLine(
// "Tarih: " + dateHolder.GetValue()
// );
// Holder<string> stringHolder = new Holder<string>();
// stringHolder.SetValue("Merhaba Misafir");
// System.Console.WriteLine("Mesaj:" + stringHolder.GetValue());



class Holder<T>
{
    private T Value;
    public void SetValue(T Value)
    {
        this.Value = Value;
    }
    public T GetValue()
    {
        return Value;
    }




}