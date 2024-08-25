CREATE DATABASE WarehouseDB;

USE WarehouseDB;

CREATE TABLE Articles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Description NVARCHAR(255)
);

CREATE TABLE Prices (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ArticleId INT FOREIGN KEY REFERENCES Articles(Id),
    Price DECIMAL(18, 2),
    Date DATE
);

-- Dodanie 10 przyk³adowych artyku³ów
INSERT INTO Articles (Name, Description) VALUES ('Laptop', 'High-performance laptop for gaming and work.');
INSERT INTO Articles (Name, Description) VALUES ('Smartphone', 'Latest model with advanced camera features.');
INSERT INTO Articles (Name, Description) VALUES ('Headphones', 'Noise-cancelling over-ear headphones.');
INSERT INTO Articles (Name, Description) VALUES ('Smartwatch', 'Smartwatch with fitness tracking features.');
INSERT INTO Articles (Name, Description) VALUES ('Tablet', '10-inch tablet with high-resolution display.');
INSERT INTO Articles (Name, Description) VALUES ('Monitor', '4K Ultra HD monitor with wide color gamut.');
INSERT INTO Articles (Name, Description) VALUES ('Keyboard', 'Mechanical keyboard with RGB lighting.');
INSERT INTO Articles (Name, Description) VALUES ('Mouse', 'Ergonomic wireless mouse with customizable buttons.');
INSERT INTO Articles (Name, Description) VALUES ('External Hard Drive', '1TB external hard drive with USB 3.0.');
INSERT INTO Articles (Name, Description) VALUES ('Printer', 'All-in-one printer with wireless connectivity.');

-- Dodanie cen dla ka¿dego artyku³u
INSERT INTO Prices (ArticleId, Price, Date) VALUES (1, 1200.99, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (2, 799.49, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (3, 199.99, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (4, 249.00, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (5, 350.00, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (6, 550.75, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (7, 99.99, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (8, 75.49, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (9, 89.99, GETDATE());
INSERT INTO Prices (ArticleId, Price, Date) VALUES (10, 150.00, GETDATE());
