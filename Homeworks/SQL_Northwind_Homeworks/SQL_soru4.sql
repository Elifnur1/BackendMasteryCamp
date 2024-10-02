SELECT 
p.UnitsInStock
FROM Products p 
WHERE p.UnitsInStock < 10
ORDER BY p.UnitsInStock ASC