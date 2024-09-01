namespace Project06_StringMethods;

class Program
{
    static void Main(string[] args)
    {

        string fullName = "halil Umut MELER";

        /*int len=fullName.Length;
        Console.WriteLine(len); 

        Console.WriteLine(fullName.ToLower());  //küçük harfe çevirir.
        Console.Write(fullName.ToUpper());*/


        /* string adress1="Yeni Umut Sitesi e Blok";
         string adress2="No:12 D:5";
         string district="Kadıköy";
         string province="İstanbul";

         string fullAdress1= adress1+ " " + adress2+ " " + district + "/" + province;
         string fullAdress2=$"{adress1} {adress2} {district} / {province}";
         Console.WriteLine(fullAdress2);
         Console.WriteLine(fullAdress1);*/

        /* string text1="Nişantaşı";
         string text2="Üniversitesi";
         string loc1="Bayrampaşa";
         string currentLoc="Sarıyer";
         string date1="09.09.2009";
         string date2="05.05.2018";
         //Nişantaşı üniversitesi , 09.09.2000 tarihinde İstanbuk'un Bayrampaşa ilçesinde faaliyete başladı.Ardından 05.05.2018 tarihinde yine İstanbulun Sarıyer ilçesinde kurulan TechCampus'e taşındı.

         string full= text1 + " " +text2 + ","  + date1 + " tarihinde " + "İstanbul'un" + loc1 + " ilçesinde faaliyete başladı." + "Ardından" + " " +date2 +" " + "tarihinde yine İstanbul'un" + " "+ currentLoc + " "+ "ilçesinde" + " " + "kurulan TechCampus'e taşındı.";
         string fullmessage= String.Concat(text1," ", text2, " , " , date1, " tarihinde yine İstanbul'un" ,"loc1,", "ilçesinde faaliyete başladı. Ardından" ,..... gibi birleştirme yapılabilir.
         Console.WriteLine(full);*/

        //string findName="umut";
        //string findText="Umut";
        //bool response=fullName.Contains(findText);
        //Console.WriteLine(response);

        //string firstname="Begüm";
        // Console.WriteLine(firstname.IndexOf("ü"));

        //string firstName = "Ayşen Umay";
        //Console.WriteLine(firstName.StartsWith("Ayşen"));
        //Console.WriteLine(firstName.EndsWith("ay"));

        /* string newsTitle = "Dolar'ın ateşi çıktı!";
         string newsId="132423";
         string newscategory="Ekonomi";
         string newsUrl = newsTitle.Replace(" ", "-");
         newsUrl = newsUrl.Replace("!", "");
         newsUrl=newsUrl.Replace("ı", "i");
         newsUrl=newsUrl.Replace("ş", "s");
         newsUrl = newsUrl.Replace("ç", "c");
         newsUrl=$"{newsUrl}-{newsId}-{newscategory.ToLower()}";
         */

        Console.WriteLine(newsUrl);





    }


}
