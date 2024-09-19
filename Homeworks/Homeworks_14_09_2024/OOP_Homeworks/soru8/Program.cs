namespace soru8;
public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void BilgileriYaz()
    {
        System.Console.WriteLine($"ad:{Name}\nyaş:{Age}");
    }
}
class Teacher : Person
{
    public Teacher(string name, int age, string subjectTaught) : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }
    public string SubjectTaught { get; set; }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"Öğrettiği konu:{SubjectTaught} ,{Name} derse katılıyor. ");

    }

}
class Student : Person
{
    public Student(string name, int age, string gradeLevel) : base(name, age)
    {
        GradeLevel = gradeLevel;
    }
    public string GradeLevel { get; set; }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
        System.Console.WriteLine($"sınıf seviyesi :{GradeLevel} , {Name} derse katıldı.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       Teacher teacher1=new Teacher("Ayşe" , 48,"Matematik");
       teacher1.BilgileriYaz();
       Student student1=new Student("Berat",17,"4.sınıf");
       student1.BilgileriYaz();

    }
}
