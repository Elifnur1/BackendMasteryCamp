using LINQ_Samples;
using Proje10_LINQ_Samples;

Repository repository=new Repository();

#region Tüm Kategorileri Listeleme 
    // var result=repository.Categories.ToList();
    // var result=from Category in repository.Categories
        //  select Category;   
    // Console.ReadLine(); 
#endregion
#region Tüm Kategorielrin Adını Listeleme

    // var categoryNames=repository
    // .Categories
    // .Select(x=>x.Name)
//     // .ToList();
// var categoryNames=from Category in repository.Categories
// select Category.Name;
#endregion
#region Sadece Silinmemiş Kategorileri Listeleme 
    // var deletedCategories=repository
    // .Categories
    // .Where(x=>!x.IsDeleted)
    // .ToList();
#endregion
#region Ürünlerin fiyatlarını Listeleme
   var Prices=repository
   .Products
   .Select(x=>x.Price)
     .ToList();
   
    
#endregion