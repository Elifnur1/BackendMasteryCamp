SELECT 
    YEAR(o.OrderDate) AS OrderYear,
    MONTH(o.OrderDate) AS OrderMonth,
    SUM(od.UnitPrice * od.Quantity) AS TotalSales
FROM Orders o
JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY 
    YEAR(o.OrderDate), 
    MONTH(o.OrderDate)
ORDER BY 
    OrderYear, 
    OrderMonth;
