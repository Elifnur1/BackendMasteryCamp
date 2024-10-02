SELECT 
e.EmployeeID,
SUM(od.UnitPrice * od.Quantity) AS [Toplam satış]
FROM Employees e 
JOIN Orders o ON e.EmployeeID=o.EmployeeID
JOIN OrderDetails od ON o.OrderID=od.OrderID
GROUP BY e.EmployeeID
ORDER BY [Toplam satış] DESC