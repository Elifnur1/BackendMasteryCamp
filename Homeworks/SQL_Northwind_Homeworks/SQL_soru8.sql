SELECT Country AS [Ülke], 
COUNT(CustomerID) AS [Müşteri sayısı]
FROM Customers
GROUP BY Country
ORDER BY [Müşteri sayısı] DESC;
