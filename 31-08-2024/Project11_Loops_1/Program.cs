namespace Project11_Loops_1;

class Program
{
    static void Main(string[] args)
    {
        #region for

        //i++ =>  i=i+1; ikiside aynı şeyi ifade ediyor.
        // i=i+3;  =>  i+3; aynı şeyleri ifade ediyor.
        // for (int i=1; i<=5; i = i +1)
        // {
        //Döngü gövdesi: Döngü içerisinde tekrar tekrar çalıştırılmasını istediğimiz kodlar.
        //     Console.WriteLine($"{i}. Merhaba Dünya");
        //}

        //Ekrana 1-10 arasındaki sayıları yazdıran programı hazırlayın.

        /*
        string message;
        int counter=1;
        for (int  i = 1;  i <= 10;  i++)
        {
            message=$" Sayı {counter++}: {i}";
            Console.WriteLine(message);
        }
        */

        //1-10 arasındaki çift sayıları ekrana yazdırın.
        /*
        for (int i = 1; i <=10; i++)
        {
            if (i % 2==0) //2ye bölümünden kalan 0 ise yani çift sayı ise
            {
                Console.WriteLine(i);
            }

            veya

            for (int i = 0; i<=10; i+ = 2)
            {
               Console.WriteLine(i); 
            }
            
          }
          */
        //Kullanıcıdan iki sayı alın.Bu iki sayı arasındaki çift ayıları ekrana yazdırın.
        /*Console.Write("Alt sınır girin:");
        int min=int.Parse(Console.ReadLine());
        Console.Write("Üst sınır girin: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i<=max; i+=2)
        {
          Console.WriteLine(i);
        }
       
        Console.Write("Alt sınır girin:");
        int min = int.Parse(Console.ReadLine());
        min = min % 2 == 0 ? min : ++min;
        Console.Write("Üst sınır girin: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i += 2)
        {
            Console.WriteLine(i);
        }
        
        //kullanıcıdan alınan sayının faktöriyelini hesaplayan programı yazın.
        Console.Write("Faktöriyeli hesaplanacak sayıyı girin: ");
        int value=int.Parse(Console.ReadLine());
        int factorial =1;
        for (int i =2; i<=value; i++)
        {
            //factorial=factorial*i;
            factorial*=i;
        }
        Console.WriteLine($"{value}!= {factorial}");
        */

        #endregion

        #region while
        /*
            int i=1;
            while (i<= 5)
            {
                Console.WriteLine($"{i}. Hello World.");
                i++;
            }
        
        int total=0;
        string input=" ";
        while (input!="exit")
        {
            Console.Write("sayı(çıkış için exit): ");
            input=Console.ReadLine();
            if (int.TryParse(input, out int inputNumber))
            {
                total += inputNumber;
            }
            else if (input != "exit")
            {
              Console.WriteLine("Geçerli bir değer girin");
            }

        }
        Console.WriteLine($"toplam: {total}");
        */

        //kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayınız. ancak kullanıcının girdiği sayıların toplamı,100'den büyük ya da eşitse program sona erip toplamı ekrana yazsın.



        #endregion
       
    }
}
