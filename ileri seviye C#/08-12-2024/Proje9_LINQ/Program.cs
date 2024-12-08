/*
 LINQ(Language Integrated Query): C# programlama dilinde veri sorgulama ve dönüştürme işlemlerini BASİTLEŞTİREN çok güçlü bir özelliktir.Amaç:farklı veri kaynaklarından sorgulama yapmayı kolaylaştırarak standart ved daha okunabilir hale getirmektedir.

TEMEL ÖZELLİKLER:
1-Syntax(söz dizimi) Bütünlüğü
2-Tip Güvenliği
3-Görece Performans artışı

***NOT: Bazı durumlar için LINQ tercih edilmemek durumunda kalabilir. ilerledikçe bu durumlara örnek senaryolarla çalışıyor olacağız.

LINQ TÜRLERİ:
1)LINQ to Objects
2)LINQ to Entities
3)LINQ to XML
4)LINQ to Dataset
*/

//Method Syntax
// int[] numbers = [10, 2, 3, 4, 5, 6, 7, 8, 9, 1];

// var result1 = numbers.Where(x => x % 2 == 0);

// var result2 = numbers.OrderBy(x => x);
// var result3 = numbers.OrderByDescending(x => x);

// foreach (var number in result2)
// {
//     System.Console.WriteLine(number);
// }

//LINQ to Objects

using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

List<Student> students = [
new Student{Id=1, Name="Ayşen",Age=18,Grade=85},
new Student{Id=2, Name="Elif",Age=18,Grade=80},
new Student{Id=3, Name="Ali",Age=18,Grade=90},
new Student{Id=4, Name="Emre",Age=18,Grade=95},

];

//Grade değeri 90 ve üzerinde olanları filtreleyelim
//1)Method Syntax
var result = students
.Where(x => x.Grade > 90)
.OrderBy(x => x.Name);
foreach (var s in result)
{
    System.Console.WriteLine($"{s.Name}:{s.Grade}");
}

//2)Query Syntax
var resultQuery = from Student in students
                  where Student.Grade >= 90
                  orderby Student.Name
                  select Student;
foreach (var s in resultQuery)
{
    System.Console.WriteLine($"{s.Name}:{s.Grade}");
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
}