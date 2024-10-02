SELECT 
c.CategoryID,
c.CategoryName AS [Kategori adı],
AVG(p.UnitPrice) AS [Ortalama fiyatı]
FROM Categories c
JOIN Products p ON c.CategoryID=p.CategoryID
GROUP BY c.CategoryName ,c.CategoryID
ORDER BY [Ortalama fiyatı] 