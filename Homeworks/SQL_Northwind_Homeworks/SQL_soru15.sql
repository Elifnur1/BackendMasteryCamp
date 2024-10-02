SELECT ı.ShipperName, COUNT(ı.OrderID) AS 'Toplam sipariş'
FROM Invoices ı
GROUP BY ı.ShipperName

