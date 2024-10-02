SELECT 
REPLACE(p.ProductName,'?','') AS 'Ürün adı',
c.CategoryName AS 'Kategori adı'
FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
ORDER BY p.ProductName
