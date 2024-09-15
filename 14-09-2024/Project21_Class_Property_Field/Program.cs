using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace Project21_Class_Property_Field;


//class Product
//{
//     int id;
//     string name;
//     decimal price;
//     bool isActive;

// //Claa içindeki bilgilerin dışarıya kontrollü bir şek,lde açılmasını sağlayan yapılara Property denir.Ysptığımız bu işleme ise KAPSÜLLEME(ENCAPSULATİON).
// public string Name 
// {
//     get
//     {
//         string result=name.Substring(0,3).ToUpper
//         ();
//         return result;
//     }
//     set
//     {
//         name=value;
//     }
// }
// public decimal Price
// {
//     get
//     {
//       return price;
//     }
//     set
//     {
//         //price=value<0 ? 0 : value; ==> Ternary ıf ile de yazabiliriz.
//         if(value<0)
//         price=0;
//         else
//         price=value;
//     }
//}

//}

class Product
{
    // profull snippet
    // private int id;
    // public int Id
    // {
    //    get{return id;}
    //    set {id=value;}
    // }

    // public int Id {get; set;}
    // public string? Name {get; set;}  //tipin yanına soru işareti koyunca null değer olabilceğini biliyorum diyip editörün uyarısını kaldırmış oluyoruz.Veya yanına eşittir diyip tırnak koyarsak varsayılan değer vermiş oluruz,yine bir boşluk olucak fakat null olmuş olmuyor!
    // public string Description { get; set; } ="";
    // public required string Notes { get; set; } //required terimini kullanarakta editörün verdiği uyarıyı kaldırmış oluruz buda farklı 3. yoldur.Fakat bir değer vermek zorundayız ki null olmak yerine atatıdığın değeri döndürebilsin.
    // public decimal Price { get; set; }
    // public bool IsActive { get; set; }

}

class Student
{
    public Student()
    {
        System.Console.WriteLine($"{DateTime.Now} zamanında yrni bir student oluşturuldu.");
    }
    public Student(int studentNumber)
    {
        StudentNumber = studentNumber;
        System.Console.WriteLine($"{DateTime.Now} zamanında yrni bir student oluşturuldu.");

    }
    public int StudentNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }

}

class Category

{
    //     public Category(int ıd, string name, string description)
    //     {
    //         Id = ıd;
    //         Name = name;
    //         Description = description;
    //     }


    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Description { get; set; }
 }

    class Program
    {
        static void Main(string[] args)
        {

            //    Category category1=new Category(56,"Bilgisayar", "Telefonlar burada");



            //     Student s1=new Student();
            //     Student s2 = new Student(48);
            //    System.Console.WriteLine( s2.StudentNumber);



            //     Product product1 =new Product(){Notes="Bişeyler"};
            //     product1.Id=5;
            //     product1.Price=800;
            //     System.Console.WriteLine(product1.Id);



            //    Product product1=new Product();
            //    product1.Name="Iphone 14";
            //    System.Console.WriteLine(product1.Name);

            //    product1.Price=60000;
            //    System.Console.WriteLine(product1.Price);
        }
    }
