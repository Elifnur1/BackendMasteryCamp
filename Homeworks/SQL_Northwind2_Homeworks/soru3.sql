--Çalışanların yöneticilerini (FirstName ve LastName) listeleyin. 
--Yöneticisi olmayan çalışanlar da listelenmelidir.
SELECT 
e.FirstName + '' +e.LastName AS 'çalışan isim soyisim',
m.FirstName + '' + m.LastName AS 'Yönetici isim soyisim'
FROM Employees e 
left JOIN Employees m on e.ReportsTo=m.EmployeeID 