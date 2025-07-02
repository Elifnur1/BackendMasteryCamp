USE master

DROP DATABASE IF EXISTS Okul

CREATE DATABASE Okul
--tabloları yaratma işlemi başlıyor.
USE Okul
CREATE TABLE Bolumler
(
    BolumID INT PRIMARY KEY IDENTITY(1,1),
    BolumAdi NVARCHAR(50) NOT NULL
)
CREATE TABLE Dersler
(
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersAdi NVARCHAR(100) NOT NULL,
    Kredi TINYINT NOT NULL,
    BolumID INT NOT NULL,
    FOREIGN KEY (BolumID) REFERENCES Bolumler(BolumID)
)
CREATE TABLE Ogrenciler
(
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NULL,
    BolumID INT NOT NULL,
    FOREIGN KEY(BolumID) REFERENCES Bolumler(BolumID)
)

CREATE TABLE DersKayitlari
(
    OgrenciID INT,
    DersID INT,
    PRIMARY KEY(OgrenciID,DersID),
    FOREIGN KEY(OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY(DersID) REFERENCES Dersler(DersID)
)
--tabloları yaratma işlemi bitti.
--veri ekleme işlemi başlıyor.
INSERT INTO Bolumler
    (BolumAdi)
VALUES
    ('Bilgisayar Mühendisliği'),
    ('Hukuk'),
    ('Mekatronik Mühendisliği')

    INSERT INTO Dersler(BolumID,DersAdi,Kredi)
    VALUES
       (1,'Temel',4),
       (1,'Temel Ders',4),
       (1,'Temel Elektronik',6),
       (1,'Yapay Zekaya Giriş',8),
       (2,'Temel Hukuk',6),
       (2,'Anayasa Hukuku',10),
       (3,'Malzeme Bilimi',3)

       INSERT INTO Ogrenciler(BolumID,Ad,Soyad,DogumTarihi)
       VALUES
         (1,'Alican','Kintutar','2000-05-05'),
         (1,'Seden','Tutan','1998-02-12'),
         (2,'Candan','Er','2000-10-10'),
         (3,'Kemal','Evrim','1996-04-15')

         INSERT INTO DersKayitlari(OgrenciID,DersID)
         VALUES
           (1,1),(1,2),(1,3),
           (2,3),
           (3,4),(3,5),
           (4,6)




    --veri ekleme işi bitti.

