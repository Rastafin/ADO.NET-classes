-- 1. Products
CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    StockQuantity INT NOT NULL
);

-- 2. Customers
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) NOT NULL
);

-- 3. Orders
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId) NOT NULL,
    OrderDate DATETIME NOT NULL,
    Status Int NOT NULL
);

-- 4. OrderDetails
CREATE TABLE OrderDetails (
    OrderDetailsId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    OrderId INT FOREIGN KEY REFERENCES Orders(OrderId) NOT NULL,
    ProductId INT FOREIGN KEY REFERENCES Products(ProductId) NOT NULL,
    Quantity INT NOT NULL
);

-- 5. Payments
CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    OrderId INT FOREIGN KEY REFERENCES Orders(OrderId) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    Status Int NOT NULL
);


