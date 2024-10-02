SELECT e.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) AS 'isim soyisim', COUNT(o.OrderID) AS 'Toplam sipariş'
FROM Employees e
LEFT JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
ORDER BY [Toplam sipariş] DESC;
