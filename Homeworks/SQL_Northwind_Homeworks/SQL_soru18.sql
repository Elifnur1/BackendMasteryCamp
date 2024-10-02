SELECT 
c.CustomerID,COUNT(o.OrderID) AS [Toplam sipariş]
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID, c.CompanyName, c.ContactName
HAVING COUNT(o.OrderID) >= 5
ORDER BY [Toplam sipariş] ASC
