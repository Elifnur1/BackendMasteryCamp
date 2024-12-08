/*
  C#8.0 ve sonrasında , reference türlerini nujllable yapısı içinde ele alabilme özelliği eklenmiştir.Bu özellik sayesinde , kod yazarken null değerlerle çalışmayı daha güvenli hale getirebiliriz.

  VARSAYILAN DAVRANIŞ
  Nullable Reference Types: Kapalı (tüm reference türleri varsayılan olarak nullable'dir.) -> klasik(eski) yaklaşım 
  Nullable reference types açık: Tüm referans türleri varsayılan olarak non-nullable'dir.--> yeni yaklaşım
*/
// string? firstName;

// #nullable disable
// Category category = null;

// class Category
// {
//     public string? Name { get; set; }
//     #nullable disable
//     public string tittle { get; set; }
// }

using System.Runtime.CompilerServices;

string? nullableString = null;
string nonnullableString = "Merhaba";

//null olmayan değerlerin uzunluğu bulmak için 1.yol;
// if (nullableString != null)
// System.Console.WriteLine(nullableString.Length);

//2.yol;
// System.Console.WriteLine(nullableString?.Length);

// System.Console.WriteLine(nonnullableString.Length);

String? greeting = "Hello!";
// if(greeting == null)
// {
//     greeting="Hello!";
// }

//Null Coalasing Operator
greeting ??= "Hello";
System.Console.WriteLine(greeting);

/*
Modern kodlamada bu null kontrol mekanizmalarından yararlanmak oldukça faydalıdır. Kodumuzun daha güvenli ve okunabilir hale gelmesini sağlar.
Aynı zamanda Run Time hatalarını azaltma konusunda da faydalıdır.Bu kodunuzun kaliteli kod olmasını sağlayan unsurlardan biridir.
*/

string? firstName = null;
System.Console.WriteLine(firstName.Length);
