-- SELECT * FROM Categories 
-- SELECT CategoryName from Categories
--Products tablosundaki tüm kayıtların productıd,UnitsInStock , UnitPrice kolonlarını geri döndürün.

-- SELECT p.ProductId, 
-- p.UnitPrice, 
-- p.UnitsInStock 
-- from Products p

--En yüksek fiyatı bulalım.

--SELECT 
-- MAX(p.UnitPrice) AS [Maksimum fiyatı], 
-- MIN(p.UnitPrice) AS [Minimum fiyatı],
-- AVG(p.UnitPrice) AS [Ortlama],
-- COUNT(*) AS [Ürün sayısı],
-- SUM(p.UnitPrice) AS [Toplam Değer]
-- FROM Products p 

--Temel fonksiyon
-- SELECT p.ProductName AS [Default],
-- UPPER(p.ProductName) AS [Büyük Harf],
-- LOWER(p.ProductName) AS [Küçük Harf],
-- lower(REPLACE(p.ProductName,' ','_'))AS [Url]
-- FROM Products p

-- SELECT * 
-- FROM Products p 
-- WHERE p.UnitPrice>40

SELECT *
FROM Products p
-- WHERE p.UnitPrice >=40 AND p.UnitPrice>=100
WHERE p.UnitPrice BETWEEN 40 AND 100
ORDER BY p.ProductName
