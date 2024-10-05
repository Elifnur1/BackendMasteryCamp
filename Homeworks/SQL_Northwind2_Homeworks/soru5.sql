--En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun.
SELECT 
o.CustomerID AS ID,
COUNT(DISTINCT C.CategoryID) AS [kategori sayısı]
FROM Orders o 
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Products p on od.ProductID=p.ProductID
JOIN Categories c ON p.CategoryID=c.CategoryID
GROUP BY o.CustomerID
HAVING COUNT(DISTINCT C.CategoryID) >=3
ORDER BY [kategori sayısı] 