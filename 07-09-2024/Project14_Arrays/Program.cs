namespace Project14_Arrays;

class Program
{
    static void Main(string[] args)
    {

        //Diziler reference type türündedir.
        //  int [] numbers;
        //  numbers=new int[5];

        //  numbers[0]=45;
        //  numbers[1]=145;
        //  numbers[2]=425;
        //  numbers[3]=435;
        //  numbers[4]=4555;

        //  for (int i=0; i<5; i++)
        //  {
        //     Console.WriteLine($" Dizinin {i+1}. Elemanı:{numbers[i]}");
        //  }


        // int[] numbers={49,34,90,67,44};//Boyutu :5 (new int [5] demiş gibi olunuyor.)
        // for (int i=0; i<5; i++)
        // {
        //     Console.WriteLine($"Dizinin {i+1}.Elemanı :{numbers[i]}");
        // }



        //     string[] studentNames = {
        //     "Ali",
        //    "Ayşe",
        //    "Elif",
        //    "Sezen",
        //    "Murat"
        //   };

        //   foreach (string student in studentNames)
        //   {
        //     Console.WriteLine(student);

        //   }

        //   for (int i=0; i<studentNames.Length; i++)
        //   {

        //         studentNames[i] += "Canoğlu";
        //        // studentNames[i] = studentNames[i] + "Canoğlu";

        //  } 
        //  Console.WriteLine();
        //  Console.WriteLine("Değişmiş hali:");
        //  for (int i =0; i<studentNames.Length; i++)
        //  {
        //     Console.WriteLine(studentNames);
        //  }


        //int[] prices = { 40, 50, 60, 70, 80 };
        // prices dizisinin içindeki fiyatlara %10 zam gelmiştir. zamlı fiyatları içerecek şekilde prices dizisini güncelleyecek kodu yazın.


        // Console.WriteLine("zamsız ürün fiyatı:");
        // Console.WriteLine("--------");
        // foreach (int p in prices)
        // {
        //          Console.WriteLine(p);
        // }
        // //ürünlere zam yapıyoruz
        // for (int i=0; i<prices.Length; i++)
        // {
        //     prices[i] *= (int) ( prices[i] *1.1);
        // }
        // Console.WriteLine("zamlı ürün fiyatı:");
        // Console.WriteLine("--------");
        // Console.WriteLine(p);



        //a=40 b=50 c=45 şeklinde elimizde bulunan 3 sayıdan en büyüğünü bulduran kodu yazın.

        // int a=40;
        // int b=50;
        // int c=45;

        // int max = int.MinValue;
        // if (a>max)
        // {
        //     max = a;
        // }
        // if(b>max)
        // {
        //     max =b;
        // }
        // if(c>max)
        // {
        //     max=c;
        // }
        // Console.Write(max);


        //20 elemanlı bir int dizisine 1-100 arasında rastgele değerler atayalım. Ardından bu dizinin içindeki en küçük ve en büyük değeri tespit edip ekrana yazdıralım.

        //Dizimizi oluşturup rastgele değerler atıyoruz.
        //     Random rnd= new Random();
        //     int[] numbers=new int[10];
        //     for (int i=1; i<=numbers.Length; i++)
        //   {
        //     numbers [i]=rnd.Next(1,101);
        //     Console.WriteLine(numbers[i]);
        //   }

        //   //En büyüğüğ ve en küçüğü bulduruyoruz.
        //   int max= int. MinValue;
        //   int min=int.MaxValue;
        //   foreach (int number in numbers)
        //   {
        //     if (number>max) max=number;
        //     if (number<min) min=number;

        //   }

        //En büyük ve en küçük değerleri yazdırıyoruz
        //   Console.WriteLine($"En küçük: {min}\n En büyük: {max}");



        // Random rnd = new Random();
        // int[] numbers = new int[10];
        // for (int i = 1; i <numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     Console.WriteLine(numbers[i]);
        // }
        // Array.Reverse(numbers);
        // Console.WriteLine("Dizinin sıralı hali ");
        // for (int i = 1; i <numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     Console.WriteLine(numbers[i]);
        //}


        // Random rnd = new Random();
        // int[] numbers = new int[10];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     Console.WriteLine($"Index: {i} - number:{numbers[i]}");
        // }
        // numbers[5] = 99;
        //  for (int i=0; i<numbers.Length; i++)
        // {
        //     Console.WriteLine($"Index: {i} - number:{numbers[i]}");
        // }
        // Console.WriteLine(Array.IndexOf(numbers,99));



        // string text="çok hava çok güzel çok ama çok fazla çok";
        // string[] result = text.Split("çok");
        // Console.WriteLine(result[0]);

        //dizileri kopyalamak

        // string[] names = {"Ayşen" , "Umay" , "Ceyda","Begüm"};
        // string[] newNames = names;

        // names [0]="Heda";
        // Console.WriteLine(newNames[0]);

        // string[] names = {"Ayşen" , "Umay" , "Ceyda","Begüm"};
        // string[] newNames= new string[names.Length];
        // Array.Copy(names,newNames , 4);
        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }
        
        // newNames[0]="Heda";
        // foreach (var name in newNames)
        // {
        //    Console.WriteLine(name);    
        // }

        // //dizide var yok kontrolü yapmak
        // int[] numbers = {3,6,7,12};
        // bool exist=Array.Exists(numbers,n => n==2); //dizide 2 rakamı var mı diye soruyorum n>4 deseydim 4 ten büyük sayı var mı diye sordum cevap 6 , 7 ,12 olduğu için ever dicek.
        // Console.Write(exist ? "Var" : "Yok");  


        //dizide belirtilen koşula uygun ilk elemanı getirmek
        // int[] numbers={3 ,6 ,7,12,6};
        // int result=Array.Find(numbers, n=> n == 3);
        // Console.WriteLine(result);


        //dizide belirtilen koşula uygun tüm elemanları getirmek
        // int[] numbers={3 ,6,7,12 ,6};
        // int[] result=Array.FindAll(numbers, x=> x==6);
        // foreach (var n in result)
        // {
        //     Console.WriteLine(n);
        // }



        //dizinin boyutunu(eleman sayısını) değiştirmek
        // int[] numbers={3,6,8};
        // Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers, 4);
        // numbers[3]=55;
        // Console.Write(numbers.Length);


        // //dizinin belirli bölümünü temizlemek
        // int[] numbers={4,5,6,7,8,9,12,2,4,5,12};
        // Console.WriteLine("Dizinin orjinal hali");
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(numbers);
        // }
        // Array.Clear(numbers);

        // Console.WriteLine();
        // Console.WriteLine("Dizinin temizlenmiş hali");
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }




    }
}
