--Her bir ürün için, o ürünü sipariş eden benzersiz müşteri sayısını bulun.
SELECT DISTINCT 
p.ProductID,
p.ProductName,
COUNT(o.CustomerID) AS 'Benzersiz müşteri sayısı'
FROM Customers c
JOIN Orders o ON c.CustomerID=o.CustomerID
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Products p ON od.ProductID=p.ProductID
GROUP BY p.ProductID , p.ProductName