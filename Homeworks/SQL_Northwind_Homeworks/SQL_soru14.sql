SELECT 
c.CompanyName AS [Müşteri adı],
count(o.OrderID) AS  [satış miktarı]
FROM Customers c 
JOIN Orders o ON c.CustomerID=o.CustomerID
GROUP BY o.OrderID , c.CompanyName
ORDER BY [satış miktarı] DESC

