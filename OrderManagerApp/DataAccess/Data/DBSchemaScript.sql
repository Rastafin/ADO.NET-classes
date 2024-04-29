-- 1. Products
CREATE TABLE Products (
    Id INT PRIMARY KEY,
    Name NVARCHAR(255),
    Price DECIMAL(10, 2),
    StockQuantity INT
);

-- 2. Customers
CREATE TABLE Customers (
    Id INT PRIMARY KEY,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Email NVARCHAR(255)
);

-- 3. Orders
CREATE TABLE Orders (
    Id INT PRIMARY KEY,
    CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
    OrderDate DATETIME,
    Status Int
);

-- 4. OrderDetails
CREATE TABLE OrderDetails (
    Id INT PRIMARY KEY,
    OrderId INT FOREIGN KEY REFERENCES Orders(Id),
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    Quantity INT
);

-- 5. Payments
CREATE TABLE Payments (
    Id INT PRIMARY KEY,
    OrderId INT FOREIGN KEY REFERENCES Orders(Id),
    Amount DECIMAL(10, 2),
    PaymentDate DATETIME,
    Status Int
);