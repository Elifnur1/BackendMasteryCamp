SELECT top 5
p.ProductID, p.ProductName, SUM(od.Quantity) AS 'Toplam miktar'
FROM OrderDetails od
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY 'Toplam miktar' DESC

