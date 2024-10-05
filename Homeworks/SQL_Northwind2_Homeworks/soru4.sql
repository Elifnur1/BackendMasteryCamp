--Her bir tedarikçinin sağladığı ürünlerin ortalama fiyatını hesaplayın, 
--ancak sadece 10'dan fazla ürün sağlayan tedarikçileri listeleyin.
 SELECT 
 s.SupplierID,
 s.CompanyName AS [Tedarikçi adı],
 p.ProductName AS [Ürün adı],
 AVG(p.UnitPrice) AS [Ortalama fiyat],
 COUNT(p.ProductID) AS ID
 FROM Suppliers s
 JOIN Products p ON s.SupplierID=p.SupplierID
 GROUP BY s.SupplierID , s.CompanyName , p.ProductName
 HAVING COUNT(p.ProductID) >10
 ORDER BY AVG(p.UnitPrice) asc

