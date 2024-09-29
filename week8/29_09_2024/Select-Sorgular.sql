--Join:SQL de tabloları ilişkili alanlar üzerinden birleştirme işlemine join denir.
--Join türleri:
--(inner) join: Birleştirilecek iki tablodaki eşleşen kayıtları bir araya getirir.
--left join: sol taraftaki tablonun tüm kayırlarını sağ taraftaki tablonun sadece eşleşen kayıtlarını getirir.
--right join:sağ taraftaki tablonun tüm kayırlarını sol taraftaki tablonun sadece eşleşen kayıtlarını getirir.
--outher(full) join: Birleştirilecek iki tablodaki eşleşen ya da eşleşmeyen tüm kayıtları bir araya getirir.

--Products ve Categories tabloların birleştirilmesini sağlayalım.
-- SELECT 
-- p.ProductID AS [Id],
-- p.ProductName AS [ürün],
-- p.UnitPrice AS [Kategori]
-- FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
-- WHERE c.CategoryName='Beverages'

--Yeni bir kategori ekliyoruz.
-- INSERT INTO Categories (CategoryName,Description)
-- VALUES ('Televizyon','Televizyon ürünleri burada')

-- SELECT * FROM Categories c JOIN Products p ON p.CategoryID=c.CategoryID

--Ürünleri (ProductID, ProductName,UnitPrice) Supplier Company Name leri ile birlikte listeleyelim.
-- SELECT p.ProductID, p.ProductName, p.UnitPrice,s.CompanyName FROM Products p 
-- JOIN Suppliers s ON s.SupplierID=p.SupplierID

--Ürünleri (ProductID, ProductName,UnitPrice) Category name ve supplier company name leri ile birlikte listeleyelim.

-- SELECT p.ProductID, p.ProductName, p.UnitPrice,s.CompanyName, c.CategoryName 
-- FROM Products p 
-- JOIN Suppliers s ON s.SupplierID=p.SupplierID 
-- JOIN Categories c ON c.CategoryID=p.ProductID

--Hangi sipariş hangi çalışan tarafından hangi müşteriye gerçekleştirilmiştir?
--OrderId,OrderDate,Employee name ,Customer name

-- SELECT o.OrderID,o.OrderDate,
-- FROM Orders o 
-- JOIN Employees e ON o.EmployeeID=e.EmployeeID
-- JOIN Customers c ON o.CustomerID=c.CustomerID

--kategöriye göre ürün stok adedini gösterelim.
-- SELECT
-- c.CategoryName AS [kategori adı],
-- SUM(p.UnitsInStock) AS [Stok toplama] 
-- FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName
-- ORDER BY [Stok toplama] 

--Hangi ülkede,kaç müşterimiz var?
-- SELECT 
-- c.Country AS [üLKE],
-- COUNT(*) AS [Müşteri sayısı]
-- FROM Customers c 
-- GROUP BY c.Country
-- ORDER BY [Müşteri sayısı] DESC

--En çok hangi ülkede müşterimiz varsa,müşteri sayısıyla birlikte gösterelim.

-- SELECT top (1)
--  c.Country AS [üLKE],
--  COUNT(*) AS [Müşteri sayısı]
--  FROM Customers c 
--  GROUP BY c.Country
--  ORDER BY [Müşteri sayısı] DESC

--Hangi kategoriden kaç tane ürün var bulalım.

-- SELECT 
-- c.CategoryName AS [Kategori],
-- COUNT(p.ProductID) AS [Adet]
-- FROM Categories c
-- left JOIN Products p ON c.CategoryID=p.CategoryID
-- GROUP BY c.CategoryName

--Hangi ülkeye ne kadarlık kargo harcaması yapmışız?
-- SELECT 
-- o.ShipCountry AS [Ülke],
-- SUM(Freight) AS [kargo harcaması]
-- FROM Orders o 
-- GROUP BY ShipCountry

--Hangi ülkeye ne kadarlık satış yapmışız?
-- SELECT 
-- o.ShipCountry AS [Ülke],
-- SUM(od.UnitPrice * od.Quantity) AS [Toplam satış],
-- SUM(Discount * UnitPrice) AS [Komisyon]
-- FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID
-- GROUP BY o.ShipCountry
-- ORDER BY [Toplam satış] DESC

--Germany'den tedarik ettiğimiz ürünlerin toplam satış tutarını bulunuz.
-- SELECT s.Country,
-- sum(o.UnitPrice * o.Quantity) AS [Toplam satış]
-- FROM Products p
-- JOIN OrderDetails o ON p.ProductID=o.ProductID
-- JOIN Suppliers s ON p.SupplierID=s.SupplierID
-- GROUP BY s.Country
-- HAVING s.Country='Germany'

--Bölgelere göre satış tutarı.
-- SELECT r.RegionDescription AS [Bölge],
-- FORMAT(sum(od.UnitPrice * od.Quantity * (1-od.Discount)),'N2','tr-TR') AS [Tutar]
-- FROM OrderDetails od 
-- JOIN Orders o ON od.OrderID=o.OrderID
-- JOIN Employees e ON o.EmployeeID=e.EmployeeID
-- JOIN EmployeeTerritories et ON e.EmployeeID=et.EmployeeID
-- JOIN Territories t ON et.TerritoryID=t.TerritoryID
-- JOIN Region r ON t.RegionID=r.RegionID
-- GROUP BY r.RegionDescription

--Hangi çalışanımız hangi kategoriden ne kadarlık sipariş almıştır.
-- SELECT 
-- e.FirstName AS [çalışan],
-- c.CategoryName AS [Kategori Adı],
-- sum(od.UnitPrice * od.Quantity * (1-od.Discount))
-- FROM Employees e 
-- JOIN Orders o ON e.EmployeeID=o.EmployeeID
-- JOIN OrderDetails od ON o.OrderID=od.OrderID
-- JOIN Products p ON od.ProductID=p.ProductID
-- JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName , e.FirstName
-- ORDER BY e.FirstName,c.CategoryName


 --Müşterilerin hangi kategoriden ne kadarlık satış yaptığını bulalım.
-- SELECT 
-- cu.CompanyName AS [Müşteri],
-- c.CategoryName AS [Kategori Adı],
-- sum(od.UnitPrice * od.Quantity * (1-od.Discount))
-- FROM Customers cu
-- JOIN Orders o ON cu.CustomerID=o.CustomerID
-- JOIN OrderDetails od ON o.OrderID=od.OrderID
-- JOIN Products p ON od.ProductID=p.ProductID
-- JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName , cu.CompanyName
-- ORDER BY cu.CompanyName,c.CategoryName

--1997 yılının mart ayında yapılan satışları listeleyelim.
-- SELECT * 
-- FROM orders o 
-- where o.OrderDate BETWEEN '1997-3-1' AND '1997-3-31'

--chai ürününe ait 1997 yılının mart ayında yapılan satışları listeleyelim.
-- SELECT *
-- FROM Orders o 
-- JOIN OrderDetails od ON o.OrderID=od.OrderID
-- JOIN Products p ON od.ProductID=p.ProductID
-- WHERE o.OrderDate BETWEEN '1997-3-1' and '1997-3-31' AND p.ProductName='chai'



