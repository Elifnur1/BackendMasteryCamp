CREATE TABLE Kitaplar(
    KitapId INT PRIMARY KEY,
    KitapAdi VARCHAR(100),
    YazarAdi VARCHAR(100),
    YayinYili INT,
    SayfaSayısı INT,
    ISBN INT
);
CREATE TABLE Dergiler(
    DergiId INT PRIMARY KEY,
    DergiAdi VARCHAR(100),
    Yayinci VARCHAR(100),
    YayınTarihi DATE,
    Sayı INT,
);
CREATE TABLE DVDler(
    DVDID INT PRIMARY KEY,
    DVDAdi VARCHAR(100),
    Yönetmen VARCHAR(100),
    YayınYılı INT,
    Süre INT
);
CREATE TABLE Ogrenciler(
    OgrenciID INT PRIMARY KEY,
    Ad VARCHAR(100),
    Soyad VARCHAR(100),
    DogumTarihi DATE,
    BolumID INT PRIMARY KEY
);
CREATE TABLE OduncAlmalar(
 OgrenciID INT,
 KitapID INT,
 DergiID INT,
 DVDID INT,
 OduncTarihi DATE,

 FOREIGN KEY (OgrenciID) REFERENCES Ogrenciler (OgrenciID),
 FOREIGN KEY (KitapID) REFERENCES Kitaplar (KitapID),
 FOREIGN KEY (DergiID) REFERENCES Dergiler (DergiID),
 FOREIGN KEY (DVDID) REFERENCES DVDler (DVDID),
 
);
INSERT INTO Kitaplar (KitapID,KitapAdi,YazarAdi,YayınYılı,SayfaSayısı,ISBN) VALUES(1, 'İstanbul Hatırası', 'Orhan Pamuk', 2010, 400, '978-975-0843-01-4'
),
(2, 'Kürk Mantolu Madonna', 'Sabahattin Ali', 1943, 220, '978-605-3478-42-3'),
(3, 'Bir Gün', 'Orhan Pamuk', 2001, 300, '978-605-4512-28-0'),
(4, 'Sineklerin Tanrısı', 'William Golding', 1954, 220, '978-605-3498-31-2'),
(5, 'Saatleri Ayarlama Enstitüsü', 'Ahmet Hamdi Tanpınar', 1961, 280, '978-975-0844-01-5'),
(6, 'Aylak Adam', 'Yusuf Atılgan', 1959, 150, '978-605-08-2751-9'),
(7, 'Beyaz Gemi', 'Refik Halit Karay', 1921, 120, '978-605-300-245-5'),
(8, 'Çocuk Kalbi', 'Edmondo De Amicis', 1886, 160, '978-605-7780-01-2'),
(9, 'Kayıp Zamanın İzinde', 'Marcel Proust', 1913, 500, '978-975-363-027-9'),
(10, 'Tutunamayanlar', 'Oğuz Atay', 1970, 400, '978-975-0815-32-1'),
(11, 'Yalnızız', 'Kemal Tahir', 1959, 300, '978-975-0837-09-2'),
(12, 'Tehlikeli Oyunlar', 'Oğuz Atay', 1973, 350, '978-975-0815-31-4'),
(13, 'İnce Mehmed', 'Yaşar Kemal', 1955, 480, '978-605-0850-36-1'),
(14, 'Hayvan Çiftliği', 'George Orwell', 1945, 112, '978-605-3320-70-5'),
(15, 'Simru', 'Hüseyin Rahmi Gürpınar', 1923, 150, '978-605-4320-40-9'),
(16, 'Gurur', 'Pride and Prejudice', 1813, 400, '978-605-3481-57-2'),
(17, 'Fahrenheit 451', 'Ray Bradbury', 1953, 256, '978-605-2033-25-4'),
(18, 'Bülbülü Öldürseler', 'A. H. Tanpınar', 1944, 300, '978-975-0635-62-3'),
(19, 'Benim Adım Kırmızı', 'Orhan Pamuk', 1998, 400, '978-975-0841-72-3'),
(20, 'Bir Delinin Hatıra Defteri', 'Nikolay Gogol', 1835, 120, '978-605-1001-12-3');

INSERT INTO Dergiler
    (DergiID, DergiAdi, Yayıncı, YayınTarihi, Sayı)
VALUES
    (1, 'Birey', 'Birey Yayıncılık', '2023-01-01', 1),
    (2, 'Sanat Dünyası', 'Sanat Yayınları', '2023-03-01', 45),
    (3, 'Edebiyat', 'Edebiyat Yayınları', '2023-05-01', 12),
    (4, 'Düşünce', 'Düşünce Yayınları', '2023-07-01', 8),
    (5, 'Kültür ve Sanat', 'Kültür Yayınları', '2023-09-01', 20);

INSERT INTO DVDler (DVDID,DVDAdi,Yönetmen,YayinYili,Süre)
VALUES
(1,'Vizontele','Yılmaz Erdoğan',2001,120),
(2,'Eşkıya','Yavuz Turgul',1996,90),
(3,'Kış Uykusu','Nuri Bilge Ceylan',2014,196),
(4,'Güle Güle','Zeki Demirkubuz',2000,100),
(5,'Yol','Şerif Gören',1982,120);
INSERT INTO OduncAlmalar
    (OgrenciID, KitapID, DergiID, DVDID, OduncTarihi)
VALUES
    (1, 1, NULL, NULL, '2023-01-10'),
    (2, NULL, 2, NULL, '2023-02-15'),
    (3, 3, NULL, 1, '2023-03-20'),
    (4, 4, 1, NULL, '2023-04-25'),
    (5, NULL, NULL, 2, '2023-05-30'),
    (6, 5, NULL, NULL, '2023-06-05'),
    (7, NULL, 3, NULL, '2023-07-10'),
    (8, NULL, NULL, 3, '2023-08-15'),
    (9, 6, NULL, NULL, '2023-09-20'),
    (10, 7, NULL, NULL, '2023-09-25');

    --SORGULAR;
    SELECT KitapAdi,YazarAdi,YayinYili FROM Kitaplar;
    SELECT KitapAdi,YazarAdi FROM Kitaplar WHERE YayınYılı>2000;
    SELECT OgrenciID,KitapAdi FROM OduncAlmalar JOIN Kitaplar ON OduncAlmalar.KitapID=Kitaplar.KitapID;
    SELECT KitapAdi,SayfaSayısı FROM Kitaplar ORDER BY SayfaSayısı DESC ;
    SELECT KitapAdi FROM Kitaplar WHERE YazarAdi='Orhan Pamuk';
    SELECT OgrenciID,DergiAdi,Yayıncı FROM OduncAlmalar JOIN Dergiler ON OduncAlmalar.DergiID=Dergiler.DergiID;
    SELECT OgrenciID FROM Ogrenciler LEFT JOIN OduncAlmalar ON Ogrenciler.OgrenciID=OduncAlmalar.OgrenciID WHERE OduncAlmalar.OgrenciID IS NULL;
        SELECT
        'Kitap' AS Tip, KitapID AS ID, COUNT(*) AS OduncSayisi
    FROM OduncAlmalar
    WHERE KitapID IS NOT NULL
    GROUP BY KitapID

   UNION ALL

    SELECT
        'Dergi' AS Tip, DergiID AS ID, COUNT(*) AS OduncSayisi
    FROM OduncAlmalar
    WHERE DergiID IS NOT NULL
    GROUP BY DergiID

   UNION ALL

    SELECT
        'DVD' AS Tip, DVDID AS ID, COUNT(*) AS OduncSayisi
    FROM OduncAlmalar
    WHERE DVDID IS NOT NULL
    GROUP BY DVDID;

SELECT KitabAdi,YayınTarihi FROM Kitaplar ORDER BY YayınTarihi;
SELECT OgrenciID,KitapID,DergiID,DVDAdi FROM OduncAlmalar LEFT JOIN Kitaplar ON OduncAlmalar.KitapID=Kitaplar.KitapID;


