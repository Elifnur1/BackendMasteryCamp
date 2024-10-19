namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir notun aşağıdaki tabloya göre harf karşılığını veren bir program yazın.

        Console.WriteLine("Bir not girin(0-100):");
        string input=Console.ReadLine();

        int not;
        bool newinput=int.TryParse(input, out not);
        if (newinput)
        {
            string harfNotu;

            if (not >= 90 && not<=100)
            {
                harfNotu="AA";
            }
            else if (not>=85 && not<=89)
            {
                harfNotu="BA";
            }
            else if (not>=80 && not<=84)
            {
                harfNotu="BB";
            }
            else if (not>=70 && not<=79)
            {
                harfNotu="CB";
            }
            else if (not>=60 && not<=69)
            {
                harfNotu="CC";
            }
            else if (not>=55 && not<=59)
            {
                harfNotu="DC";
            }
            else if(not>=50 && not<=54)
            {
                harfNotu="DD";
            }
            else if (not>=40 && not<=49)
            {
                harfNotu="FD";
            }
            else if(not>=0 && not<=39)
            {
                harfNotu="FF";
            }
            else
            {
                Console.WriteLine("GEÇERLİ NOT GİRİN:");
                return;
            }
            Console.WriteLine($" notunuzun harf not karşılığı :{harfNotu}");
            }
        
        
    }
}
