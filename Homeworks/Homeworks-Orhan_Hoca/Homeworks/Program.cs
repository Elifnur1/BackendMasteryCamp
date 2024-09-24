using System.ComponentModel;

namespace Homeworks;

class Program
{
    static void Main(string[] args)
    {
        #region  Hesap Makinesi -v1
        // System.Console.WriteLine("Kaç adet rakam girilsin istiyorsunuz:");
        // int Number = int.Parse(Console.ReadLine());
        // double[] numbers = new double[Number];
        // double toplam = 0;
        // for (int i = 0; i < Number; i++)
        // {
        //     Console.Write($"Sayı{i + 1}: ");
        //     numbers[i] = double.Parse(Console.ReadLine());
        //     toplam += numbers[i];
        // }
        // double ort = toplam / Number;
        // System.Console.WriteLine($"Toplam :{toplam}");
        // System.Console.WriteLine($"Ortalama: {ort}");

        #endregion

        #region v2
        // System.Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?: ");
        // System.Console.WriteLine("1-Çarpma");
        // System.Console.WriteLine("2-Bölme");
        // System.Console.WriteLine("3-Çıkarma");
        // System.Console.WriteLine("4-Toplama");
        // System.Console.WriteLine("1 ile 4 arasında yapmak istediğiniz işlemi seçin :");

        // System.Console.WriteLine("Kaç adet rakamla işlem yapmak istiyorsunuz? :");
        // int numbers=int.Parse(Console.ReadLine());
        // double[] dizi=new double[numbers];
        // for(int i=0; i<numbers; i++)
        // {
        //     System.Console.WriteLine($"Sayı{i+1}: ");
        //     dizi[i] =double.Parse(Console.ReadLine());
        // }
        // double total=dizi[0];
        // for(int i=0; i<numbers; i++)
        // {
        //     switch(numbers)
        //     {
        //         case 1:
        //         total *= dizi[i];
        //         break;
        //         case 2:
        //         total /=dizi[i];
        //         break;
        //         case 3:
        //         total -=dizi[i];
        //         break;
        //         case 4:
        //         total +=dizi[i];
        //         break;
        //     }
        // }
        // System.Console.WriteLine($"Sonuç : {total}");



        #endregion

        #region v3
        // double total = 0;
        // string devam;
        // do
        // {
        //     System.Console.WriteLine("Bir rakam girin: ");
        //     double number = double.Parse(Console.ReadLine());
        //     System.Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        //     System.Console.WriteLine("1-Toplama");
        //     System.Console.WriteLine("2-Çıkarma");
        //     System.Console.WriteLine("3-Çarpma");
        //     System.Console.WriteLine("4-Bölme");
        //     System.Console.WriteLine("1 ile 4 arasında işlem seçimi yapın: ");
        //     int islem=int.Parse(Console.ReadLine());


        //         switch(islem)
        //         {
        //             case 1:
        //                 total += number;
        //                 break;
        //             case 2:
        //                 total -= number;
        //                 break;
        //             case 3:
        //                 total *= number;
        //                 break;
        //             case 4:
        //                 if (number != 0)
        //                     total /= number;
        //                 break;
        //         }

        //     System.Console.WriteLine($"Sonuç : {total}");
        //     System.Console.WriteLine("Devam etmek için e ye basın: ");
        //     devam = Console.ReadLine();
        // } while (devam.ToLower()=="e");

        #endregion

        #region Alişveriş Hesaplama- v1
        // string[] ürünler=["elma","armut","makarna","çikolata"];
        // double[] fiyat=[5.0,3.5,2.5,4.0];
        // double total=0;
        // string secim;
        // System.Console.WriteLine("Market ürünleri ve ürünlerin fiyatları: ");
        // for(int i=0; i<ürünler.Length; i++)
        // {
        //     System.Console.WriteLine($"ürünler{i+1}: {ürünler[i]} - {fiyat[i]}");
        // }
        // do
        // {
        //     Console.Write("Almak istediğiniz ürünü girin(toplamı t ile gösterilecek):");
        //     secim=Console.ReadLine();
        //     if(secim.ToLower()=="t")
        //     {
        //        System.Console.WriteLine($"Toplam fiyat: {total}");
        //        break;
        //     }
        //     if (int.TryParse(secim, out int ürünno) && ürünno<=ürünler.Length)
        //     {
        //         total+=fiyat[ürünno -1];
        //         System.Console.WriteLine($"{ürünler[ürünno-1]} eklendi. toplam tutar:{total} TL");
        //     }
        // } while (true);


        #endregion

        #region v2
        // string[] ürünler = ["muz", "çilek", "mango", "ananas", "avakado", "nar", "kivi", "coconut", "domates", "salatalık"];
        // double[] fiyat = [5.0, 4.5, 10.0, 10.0, 12.3, 23.3, 5.1, 6.2, 15.3, 7.9];
        // double total = 0;
        // string secim;
        // System.Console.WriteLine("Market ürünleri ve fiyatları:");

        // for (int i = 0; i < ürünler.Length; i++)
        // {
        //     System.Console.WriteLine($"ürünler{i + 1}: {ürünler[i]} - {fiyat[i]}");
        // }
        // Console.Write("Kaç adet ürün almak istediğinizi girin:");
        // int sonuc = int.Parse(Console.ReadLine());
        // List<string> ürün=new List<string>();
        // int sayac=0;
        // do
        // {
        //     System.Console.WriteLine("Almak istediğiniz ürünün numarasını girin:");
        //     secim=Console.ReadLine();
        //     if(secim.ToLower()=="t")
        //     {
        //         System.Console.WriteLine($"Alınan ürünler:{string.Join(",",ürün)}");
        //         System.Console.WriteLine($"Toplam fiyat:{total}");
        //         break;
        //     }
        //     if(int.TryParse(secim, out int ürünno) && ürünno > 0 && ürünno <= ürünler.Length)
        //     {
        //         ürün.Add(ürünler[ürünno -1]);
        //         total += fiyat[ürünno -1];
        //         sayac++;
        //         System.Console.WriteLine($"{ürünler[ürünno-1]} eklendi. toplam fiyat:{total}");
        //     }
        //     if(sayac >= total)
        //     {
        //        System.Console.WriteLine($"Alınan ürünler: {string.Join(",",ürün)}");
        //        System.Console.WriteLine($"Toplam fiyat: {total} TL");
        //        break;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Geçersiz seçim");
        //     }
        // } while (true);



        #endregion

        #region v3

        // string[] ürünler = ["muz", "çilek", "mango", "ananas", "avakado", "nar", "kivi", "coconut", "domates", "salatalık"];
        // double[] fiyat = [5.0, 4.5, 10.0, 10.0, 12.3, 23.3, 5.1, 6.2, 15.3, 7.9];
        // double total = 0;
        // string secim;
        // System.Console.WriteLine("Market ürünleri ve fiyatları:");

        // for (int i = 0; i < ürünler.Length; i++)
        // {
        //     System.Console.WriteLine($"ürünler{i + 1}: {ürünler[i]} - {fiyat[i]}");
        // }
        // Console.Write("Kaç adet ürün almak istediğinizi girin:");
        // int sonuc = int.Parse(Console.ReadLine());
        // List<string> ürün = new List<string>();
        // int sayac = 0;
        // do
        // {
        //     System.Console.WriteLine("Almak istediğiniz ürünün numarasını girin:");
        //     secim = Console.ReadLine();
        //     if (secim.ToLower() == "t")
        //     {
        //         System.Console.WriteLine($"Alınan ürünler:{string.Join(",", ürün)}");
        //         System.Console.WriteLine($"Toplam fiyat:{total}");
        //         break;
        //     }
        //     if (int.TryParse(secim, out int ürünno) && ürünno > 0 && ürünno <= ürünler.Length)
        //     {
        //         ürün.Add(ürünler[ürünno - 1]);
        //         total += fiyat[ürünno - 1];
        //         sayac++;
        //         System.Console.WriteLine($"{ürünler[ürünno - 1]} eklendi. toplam fiyat:{total}");
        //     }
        //     if (sayac >= total)
        //     {
        //         System.Console.WriteLine($"Alınan ürünler: {string.Join(",", ürün)}");
        //         System.Console.WriteLine($"Toplam fiyat: {total} TL");
        //         break;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Geçersiz seçim");
        //     }
        // } while (true);
        // Console.WriteLine("Toplam Tutar: " + total + " TL");

        // Console.Write("Ödediğiniz tutarı girin: ");
        // double odeme = double.Parse(Console.ReadLine());


        // double paraUstu = odeme - total;


        // Console.WriteLine("\nAldığınız Ürünler:");
        // foreach (var urun in ürün)
        // {
        //     Console.WriteLine(urun);
        // }

        // Console.WriteLine("Toplam Tutar: " + total + " TL");
        // Console.WriteLine("Ödediğiniz Tutar: " + odeme + " TL");
        // Console.WriteLine("Para Üstü: " + paraUstu + " TL");

        // if (paraUstu < 0)
        // {
        //     Console.WriteLine("Ödediğiniz tutar yeterli değil.");
        // }

        #endregion
        #region Taş kağıt makas oyunu -v1

        // string[] options = { "taş", "kağıt", "makas" };
        // Random random = new Random();

        // while (true)
        // {
        //     Console.WriteLine("Taş, Kağıt, Makas oyunu! (Çıkmak için 'çık' yazın)");
        //     Console.Write("Seçiminizi yapın: ");
        //     string secim = Console.ReadLine().ToLower();

        //     if (secim == "çık")
        //     {
        //         Console.WriteLine("Oyundan çıkılıyor...");
        //         break;
        //     }

        //     if (Array.IndexOf(options, secim) == -1)
        //     {
        //         Console.WriteLine("Geçersiz seçim! Lütfen 'taş', 'kağıt' veya 'makas' seçin.");
        //         continue;
        //     }

        //     int computerChoiceIndex = random.Next(0, options.Length);
        //     string computerChoice = options[computerChoiceIndex];
        //     Console.WriteLine($"Bilgisayarın seçimi: {computerChoice}");

        //     if (secim == computerChoice)
        //     {
        //         Console.WriteLine("Beraberlik!");
        //     }
        //     else if ((secim == "taş" && computerChoice == "makas") ||
        //              (secim == "kağıt" && computerChoice == "taş") ||
        //              (secim == "makas" && computerChoice == "kağıt"))
        //     {
        //         Console.WriteLine("Kazandın!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Kaybettin!");
        //     }
        // }
        #endregion

        #region v2

        // string[] options = { "taş", "kağıt", "makas" };
        // Random random = new Random();
        // int userScore = 0, computerScore = 0;

        // while (true)
        // {
        //     Console.WriteLine("Taş, Kağıt, Makas oyunu! (Çıkmak için 'çıkış' yazın)");
        //     Console.Write("Seçiminizi yapın: ");
        //     string userChoice = Console.ReadLine().ToLower();

        //     if (userChoice == "çıkış")
        //     {
        //         Console.WriteLine("Oyundan çıkılıyor...");
        //         break;
        //     }

        //     if (Array.IndexOf(options, userChoice) == -1)
        //     {
        //         Console.WriteLine("Geçersiz seçim! Lütfen 'taş', 'kağıt' veya 'makas' seçin.");
        //         continue;
        //     }

        //     int computerChoiceIndex = random.Next(0, options.Length);
        //     string computerChoice = options[computerChoiceIndex];
        //     Console.WriteLine($"Bilgisayarın seçimi: {computerChoice}");

        //     if (userChoice == computerChoice)
        //     {
        //         Console.WriteLine("Beraberlik!");
        //     }
        //     else if ((userChoice == "taş" && computerChoice == "makas") ||
        //              (userChoice == "kağıt" && computerChoice == "taş") ||
        //              (userChoice == "makas" && computerChoice == "kağıt"))
        //     {
        //         Console.WriteLine("Kazandın!");
        //         userScore++;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Kaybettin!");
        //         computerScore++;
        //     }

        //     Console.WriteLine($"Skor - Siz: {userScore} | Bilgisayar: {computerScore}\n");
        // }

        #endregion

        #region Quiz
        // string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?" };
        // string[] cevaplar = { "mavi", "ankara" }; // Cevapları küçük harfle tutalım
        // string[] secenekler = { "kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir" };

        // int dogruSayisi = 0;
        // int yanlisSayisi = 0;

        // for (int i = 0; i < sorular.Length; i++)
        // {
        //     Console.WriteLine(sorular[i]);
        //     string[] mevcutSecenekler = secenekler[i].Split('|');

        //     for (int j = 0; j < mevcutSecenekler.Length; j++)
        //     {
        //         Console.WriteLine($"{j + 1}. {mevcutSecenekler[j]}");
        //     }

        //     Console.Write("Cevabınızı girin: ");
        //     string kullaniciCevabi = Console.ReadLine().ToLower();

        //     if (kullaniciCevabi == cevaplar[i])
        //     {
        //         Console.WriteLine("Doğru cevap!");
        //         dogruSayisi++;
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Doğru cevap: {cevaplar[i]}");
        //         yanlisSayisi++;
        //     }

        //     Console.WriteLine(); 
        // }

        // Console.WriteLine($"Toplam Doğru: {dogruSayisi}, Toplam Yanlış: {yanlisSayisi}");
    
       #endregion



}
}
