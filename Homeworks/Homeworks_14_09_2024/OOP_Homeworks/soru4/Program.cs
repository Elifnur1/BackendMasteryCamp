namespace soru4;

public class Book
{
    public Book(string title, string author, int pages, int ıSBN)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = ıSBN;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }
    public virtual void Borrow()
    {
        System.Console.WriteLine($"{Title} Ödünç Al.");
    }
    public virtual void Return()
    {
        System.Console.WriteLine($"{Title} İade et.");
    }


}
class Library : Book
{
    public Library(string title, string author, int pages, int ıSBN) : base(title, author, pages, ıSBN)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
       Book book1=new Book("Sol Ayağım","Christy Brown",164,123123123);
       book1.Borrow();
       book1.Return();
       Library library=new Library("Sol Ayağım","Christy Brown",164, 123123123);
    }
}
