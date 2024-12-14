/*
Generic yapılar,özellikle tip güvenliği sağlama konusunda işimizi görürler.Fakat aynı zamanda kodun YENİDEN KULLANABİLİRLİĞİNİ arttırır.
DRY-Don't Repeat Yourself
*/

//Dictionary<TKey,TValue>
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

// Box<int> numberBox=new Box<int>();
// numberBox.Add(5);
// System.Console.WriteLine(numberBox.Get());

// Box<string> stringBox=new Box<string>();
// stringBox.Add("Elif");
// System.Console.WriteLine(stringBox.Get());

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