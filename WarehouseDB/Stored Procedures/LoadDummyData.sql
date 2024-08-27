CREATE PROCEDURE LoadDummyData
AS
BEGIN
    -- Insert sample articles
    INSERT INTO Articles (Name, Description) 
    VALUES 
        ('Laptop', 'High-performance laptop for gaming and work.'),
        ('Smartphone', 'Latest model with advanced camera features.'),
        ('Headphones', 'Noise-cancelling over-ear headphones.'),
        ('Smartwatch', 'Smartwatch with fitness tracking features.'),
        ('Tablet', '10-inch tablet with high-resolution display.'),
        ('Monitor', '4K Ultra HD monitor with wide color gamut.'),
        ('Keyboard', 'Mechanical keyboard with RGB lighting.'),
        ('Mouse', 'Ergonomic wireless mouse with customizable buttons.'),
        ('External Hard Drive', '1TB external hard drive with USB 3.0.'),
        ('Printer', 'All-in-one printer with wireless connectivity.');

    -- Insert sample prices
    INSERT INTO Prices (ArticleId, Price, Date) 
    VALUES 
        (1, 1200.99, GETDATE()),
        (2, 799.49, GETDATE()),
        (3, 199.99, GETDATE()),
        (4, 249.00, GETDATE()),
        (5, 350.00, GETDATE()),
        (6, 550.75, GETDATE()),
        (7, 99.99, GETDATE()),
        (8, 75.49, GETDATE()),
        (9, 89.99, GETDATE()),
        (10, 150.00, GETDATE());
END
GO
