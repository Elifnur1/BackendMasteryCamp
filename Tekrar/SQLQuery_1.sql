--veri tabanı oluşturma aşaması
use master
GO

IF exists (select *
from sys.databases
where name='LearnifyStockAppDb') 
BEGIN
    alter DATABASE LearnifyStockAppDb SET single_user with rollback IMMEDIATE
    drop database LearnifyStockAppDb
END
GO

CREATE DATABASE LearnifyStockAppDb
GO

USE LearnifyStockAppDb
GO

--categories tablosu
CREATE TABLE Categories
(
    Id int primary key identity,
    Name NVARCHAR(MAX) not null,
    DESCRIPTION NVARCHAR(max) not null,
    Isdeleted bit not null DEFAULT 0,
    CreatedAt DATETIME2 (3) not null DEFAULT getdate(),
    UpdatedAt DATETIME2(3)

)
 GO
--suppliers tablosu
CREATE TABLE suppliers
(
    Id int primary key identity,
    Name NVARCHAR(MAX) not null,
    Email NVARCHAR(MAX) not null,
    Phonenumber NVARCHAR(MAX) not null,
    City NVARCHAR(MAX) not null,
    Country NVARCHAR(MAX) not null,
    Contact NVARCHAR(MAX) not null,
    Adress NVARCHAR(max),
    Isdeleted bit not null DEFAULT 0,
    CreatedAt DATETIME2 (3) not null DEFAULT getdate(),
    UpdatedAt DATETIME2(3)

)
 GO
--products tablosu
CREATE TABLE products
(
    Id int primary key identity,
    Name NVARCHAR(MAX) not null,
    DESCRIPTION NVARCHAR(max) not null,
    CategoryId int not null,
    SupplierId int not null,
    StockQuantity int not null DEFAULT 0,
    MinimumStockLevel int not null DEFAULT 1,
    Price decimal (10,2) not null,
    Isdeleted bit not null DEFAULT 0,
    CreatedAt DATETIME2 (3) not null DEFAULT getdate(),
    UpdatedAt DATETIME2(3)
    CONSTRAINT FK_Products_Categories  FOREIGN key (CategoryId) REFERENCES categories(Id),
    CONSTRAINT FK_Products_Suppliers FOREIGN key (SupplierId) REFERENCES suppliers(Id),
    CONSTRAINT CHK_Products_StockQuantity check (StockQuantity>=0),
    CONSTRAINT CHK_Products_MinimumStockLevel check (MinimumStockLevel>=1),
    CONSTRAINT CHK_Products_Price check (Price>=0)
)
 GO
 --Transactiontypes tablosu
CREATE TABLE Transactiontypes
(
    Id int primary key identity,
    Name NVARCHAR(MAX) not null,
    DESCRIPTION NVARCHAR(max) not null,
    Isdeleted bit not null DEFAULT 0,
    CreatedAt DATETIME2 (3) not null DEFAULT getdate(),
    UpdatedAt DATETIME2(3)

)
 GO
 --1 'Giriş'
 --2 'Çıkış'

--StockTransactions tablosu
CREATE TABLE StockTransactions
(
    Id int primary key identity,
    ProductId int not null,
    TransactionTypeId int not null,
    TransactionTypeDate DATETIME not null DEFAULT GETDATE(),
    Quantity int  not null,
    Note NVARCHAR(max) not null,
    Isdeleted bit not null DEFAULT 0,
    CONSTRAINT FK_StockTransactions_Products FOREIGN key (ProductId) REFERENCES products(Id),
    CONSTRAINT FK_StockTransactions_TransactionTypes FOREIGN key (TransactionTypeId) REFERENCES Transactiontypes(Id),
    CONSTRAINT CHK_StockTransactions_Quantity check (Quantity>0)
)
 GO

 --Customers tablosu
CREATE TABLE Customers
(
    Id int primary key identity,
    Name NVARCHAR(MAX) not null,
    Contact NVARCHAR(max) not null,
    Email NVARCHAR(max) not null,
    Phonenumber NVARCHAR(max) not null,
    City NVARCHAR(max) not null,
    Country NVARCHAR(max) not null,
    Adress NVARCHAR(max),
    Isdeleted bit not null DEFAULT 0,
    CreatedAt DATETIME2 (3) not null DEFAULT getdate(),
    UpdatedAt DATETIME2(3)

)
 GO
 --Sales tablosu
CREATE TABLE Sales
(
    Id int primary key identity,
    productId int not null,
    CustomerId int not null,
    Quantity int not null,
    UnitPrice DECIMAL (10,2) not null,
    Isdeleted bit not null DEFAULT 0,
    SaleDate DATETIME2 (3) not null DEFAULT getdate(),

)
 GO
 --Index'ler
 --products
 CREATE NONCLUSTERED INDEX IX_Products_CategoryId on products (CategoryId);
 CREATE NONCLUSTERED INDEX IX_Products_Suppliers on products (SupplierId);
-- Sales
create nonclustered index IX_Sales_ProductId on Sales(ProductId);
create nonclustered index IX_Sales_CustomerId on Sales(CustomerId);
create nonclustered index IX_Sales_SaleDate on Sales(SaleDate);

-- StockTransactions
create nonclustered index IX_StockTransactions_ProductId on StockTransactions(ProductId);
create nonclustered index IX_StockTransactions_TransactionDate on StockTransactions(TransactionDate);
create nonclustered index IX_StockTransactions_TransactionTypeId on StockTransactions(TransactionTypeId);


-- Categories tablosuna örnek veri ekle
insert into Categories (Name, Description) values
('Elektronik', 'Elektronik ürünler, bilgisayarlar, telefonlar, vb.'),
('Giyim', 'Erkek ve kadın giyim ürünleri'),
('Gıda', 'Yiyecek ve içecekler');

-- Suppliers tablosuna örnek veri ekle
insert into Suppliers (Name, Contact, Email, PhoneNumber, Adress, City, Country) values
('TechSupply', 'John Doe', 'john@techsupply.com', '555-1234', '123 Tech St.', 'İstanbul', 'Türkiye'),
('FashionWorld', 'Jane Smith', 'jane@fashionworld.com', '555-5678', '456 Fashion Rd.', 'Ankara', 'Türkiye'),
('FoodMart', 'Ali Kılıç', 'ali@foodmart.com', '555-9876', '789 Food Ave.', 'İzmir', 'Türkiye');

-- Products tablosuna örnek veri ekle
insert into Products (Name, Description, CategoryId, SupplierId, StockQuantity, MinimumStockLevel, Price) values
('iPhone 14', 'Apple iPhone 14, 128GB', 1, 1, 50, 5, 12000.00),
('Samsung Galaxy S21', 'Samsung Galaxy S21, 128GB', 1, 1, 30, 3, 9500.00),
('Tişört', 'Pamuklu erkek tişört', 2, 2, 100, 10, 150.00),
('Kot Pantolon', 'Kot pantolon, mavi', 2, 2, 80, 8, 250.00),
('Paket Makarnalar', '500g makarna', 3, 3, 500, 50, 10.00),
('Şişe Su', '1.5L su', 3, 3, 300, 30, 5.00);

-- TransactionTypes tablosuna örnek veri ekle
insert into TransactionTypes (Name) values
('Giriş'),
('Çıkış');

-- StockTransactions tablosuna örnek veri ekle
insert into StockTransactions (ProductId, TransactionTypeId, TransactionDate, Quantity, Note) values
(1, 1, '2024-11-01', 20, 'Yeni ürün stoğu girişi'),
(2, 1, '2024-11-02', 15, 'Yeni ürün stoğu girişi'),
(3, 2, '2024-11-03', 10, 'Satış sonrası çıkış'),
(4, 2, '2024-11-04', 5, 'Satış sonrası çıkış'),
(5, 1, '2024-11-05', 100, 'Yeni ürün stoğu girişi'),
(6, 1, '2024-11-06', 200, 'Yeni ürün stoğu girişi');

-- Customers tablosuna örnek veri ekle
insert into Customers (Name, Contact, Email, PhoneNumber, Address, City, Country) values
('Mehmet Yılmaz', 'mehmet.yilmaz@example.com', 'mehmet@example.com', '555-1111', '1234 Example St.', 'İstanbul', 'Türkiye'),
('Ayşe Kara', 'ayse.kara@example.com', 'ayse@example.com', '555-2222', '5678 Another Rd.', 'Ankara', 'Türkiye'),
('Fatma Çelik', 'fatma.celik@example.com', 'fatma@example.com', '555-3333', '91011 Old St.', 'İzmir', 'Türkiye');

-- Sales tablosuna örnek veri ekle
insert into Sales (ProductId, CustomerId, Quantity, UnitPrice, SaleDate) values
(1, 1, 1, 12000.00, '2024-11-10'),
(2, 2, 2, 9500.00, '2024-11-11'),
(3, 3, 3, 150.00, '2024-11-12'),
(4, 1, 1, 250.00, '2024-11-13'),
(5, 2, 10, 10.00, '2024-11-14'),
(6, 3, 5, 5.00, '2024-11-15');




