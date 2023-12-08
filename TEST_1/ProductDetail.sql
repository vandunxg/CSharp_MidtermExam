--Table Category
CREATE TABLE Category(
  CategoryID NVARCHAR(10) PRIMARY KEY NOT NULL,
  CategoryName NVARCHAR(20) NOT NULL,
);

-- Table Product
CREATE TABLE Product(
  ProductCode NVARCHAR(10) PRIMARY KEY NOT NULL,
  Desciption NVARCHAR(100) NOT NULL,
  UnitPrice NVARCHAR(10) NOT NULL,
  OnHandQuantity NVARCHAR(5) NOT NULL,
  CategoryID NVARCHAR(10) NOT NULL,
  FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);