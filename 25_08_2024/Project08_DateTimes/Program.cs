using System.Runtime.InteropServices;

namespace Project08_DateTimes;

class Program
{
    static void Main(string[] args)
    {
        //C# ta tarih ve saat tipindeki verilerle çalışmak için DateTime adında bir sınıf vardır.

        DateTime now=DateTime.Now;
        //Console.WriteLine(now);

        /*string time1="şu anki tarih saat:"; 
        DateTime now2=DateTime.Now;
        string time2= time1+ " "+now2;
        Console.WriteLine(time2);
        Console.WriteLine($"3 hafta sonraki tarih:  {now.AddDays(21)}");*/
        
       // Console.WriteLine(now.ToString("dd/MM/yyyy")); gün ay yıl
       // Console.WriteLine(now.ToString("hh:mm:ss"));  SafeArrayTypeMismatchException dakika saniye

       //Console.WriteLine(now.ToString("d")); sadece gün ay yıl gösterir küçük d
       //Console.WriteLine(now.ToString("D")); uzun şekilde gösterir 

       //Console.WriteLine(now.ToString("MMMM yyyy"));

       //Console.WriteLine(now.ToShortDateString()); 25.08.2024
       //Console.WriteLine(now.ToShortTimeString());  12:01

       //int day=5;
       //int month=6;
       //int year=1988;
       //DateTime date=new DateTime(year,month,day, 04,5,0);
       //Console.WriteLine(date);
       //Console.WriteLine(date.AddDays(-3)); addDays veya AddMonth kavramları normalde eklemek anlamında fakat parantez içinde -3,4,5... yazarsak o tarihten öncesini ekrana yazdırır.

       //DateTime birthDate=new DateTime(1975,7,16);
       //int month=birthDate.Month;
       //Console.WriteLine(month);

       //Console.WriteLine(now.DayOfWeek);

    




    }
}
