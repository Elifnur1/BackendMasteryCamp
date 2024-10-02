SELECT 
c.Country AS ülke,
sum(od.UnitPrice * od.Quantity) AS [Toplam satış tutarı]
FROM orders o 
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Customers c ON o.CustomerID=c.CustomerID
GROUP BY c.Country