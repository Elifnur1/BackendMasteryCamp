--Personel Ve Maaş Yönetimi

CREATE TABLE Personeller(
    PersonelID INT PRIMARY KEY,
    Ad nVARCHAR(50),
    Soyad NVARCHAR(50),
    Pozisyon NVARCHAR(10),
    BaslangıcTarihi DATE
)
CREATE TABLE Maaslar(
    MaasID INT PRIMARY KEY,
    PersonelID INT,
    MaasMiktarı DECIMAL (10,2),
    GüncellemeTarihi DATE,
    FOREIGN KEY (PersonelID) REFERENCES Personeller (PersonelID),
)
INSERT INTO Personeller
    (Ad, Soyad, Pozisyon, BaslangıcTarihi)
VALUES
    ('Ahmet', 'Yılmaz', 'Müdür', '2015-09-01'),
    ('Ayşe', 'Kara', 'Öğretmen', '2016-09-01'),
    ('Mehmet', 'Demir', 'Öğretmen', '2017-09-01'),
    ('Fatma', 'Çelik', 'Sekreter', '2018-09-01'),
    ('Ali', 'Kaya', 'Öğretmen', '2019-09-01'),
    ('Zeynep', 'Yavuz', 'Müdür Yardımcısı', '2020-09-01'),
    ('Ebru', 'Polat', 'Öğretmen', '2021-09-01'),
    ('Osman', 'Arslan', 'Sekreter', '2022-09-01'),
    ('Seda', 'Güneş', 'Öğretmen', '2023-09-01'),
    ('Can', 'Koç', 'Öğretmen', '2023-09-01');
    INSERT INTO Maaslar
    (PersonelID, MaasMiktarı, GüncellemeTarihi)
VALUES
    (1, 10000, '2015-09-01'),
    (2, 8000, '2016-09-01'),
    (3, 7500, '2017-09-01'),
    (4, 5000, '2018-09-01'),
    (5, 7500, '2019-09-01'),
    (6, 12000, '2020-09-01'),
    (7, 8000, '2021-09-01'),
    (8, 5000, '2022-09-01'),
    (9, 7500, '2023-09-01'),
    (10, 7500, '2023-09-01');
--SORGULAR
SELECT p.PersonelID,p.Ad, p.Soyad, p.Pozisyon, m.MaasMiktarı FROM Personeller
