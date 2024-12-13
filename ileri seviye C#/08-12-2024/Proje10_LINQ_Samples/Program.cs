using LINQ_Samples;
using Proje10_LINQ_Samples;

Repository repository = new Repository();

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
//    var Prices=repository
//    .Products
//    .Select(x=>x.Price)
//    .ToList();

#endregion
#region Kategoriye Göre Gruplanmış Ürünleri Listeleme
// var groupByCategory=repository
// .Products
// .GroupBy(x=>x.CategoryId)
// .ToList();
// var groupByCategory=from product in repository.Products
// group product by product.CategoryId;

#endregion
#region Tedarikçi Başına Ürün Sayısını Listeleme
// var productCountBySupllier=repository
// .Products
// .GroupBy(p=>p.SupplierId)
// .Select(g=> new {SupplierId=g.Key,ProductCount=g.Count()})
// .ToList();
// var productCountBySupllier=
// from product in repository.Products
// group product by product.SupplierId into groupedData
// select new {SupplierId=groupedData.Key,ProductCount=groupedData
// .Count()};
#endregion
#region Her Kategorideki ilk ürünü getirme
// var firstProductInCategory=
// repository
// .Products
// .GroupBy(p=>p.CategoryId)
// .Select(g=>g.FirstOrDefault())
// .ToList();
// var firstProductInCategory=
// from product in repository.Products
// group product by product.CategoryId into productGroup
// select productGroup.FirstOrDefault();
#endregion
#region Ürün fiyatlarından en küçüğünü getirme
// var minPrice = repository
// .Products
// .Min(p => p.Price);
//tek bir ürün getirceği için tolist methodunu kullanmamıza gerek yok
// var minPrice=(from product in repository.Products
// select product.Price).Min();
#endregion
#region ÖRNEK LINQ SORGULARIM
//1-
var FullCategory = repository
.Categories
.ToList();
var FullCategory2 = from Category in repository.Categories select Category;
//2-Fiyatları belli aralıkta olan ürünleri getirme.
var result = repository
.Products
.Where(x => x.Price >= 100 && x.Price <= 500 && !x.IsDeleted)
.ToList();
//3-Ürünleri fiyatına göre sıralama Artan.
//Query Syntax
var result2 = from Product in repository.Products orderby Product.Price select Product.Price;


#endregion