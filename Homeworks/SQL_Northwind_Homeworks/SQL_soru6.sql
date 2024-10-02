SELECT 
c.CategoryName AS 'Kategori adı',
p.UnitsInStock AS 'Stok durumu'
FROM Categories c JOIN Products p ON c.CategoryID=p.ProductID
ORDER BY p.UnitsInStock