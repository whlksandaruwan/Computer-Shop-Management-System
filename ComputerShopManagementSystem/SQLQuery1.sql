﻿CREATE DATABASE CSMS;

CREATE TABLE Users
(
   Users_Id INT IDENTITY(1, 1),
   Users_Name VARCHAR(150) UNIQUE,
   Users_Email VARCHAR(150),
   Users_Password VARCHAR(150),
   CONSTRAINT PK_users PRIMARY KEY(Users_Id)
);

INSERT INTO Users VALUES
    ('Kavindu', 'sandaruwan@gmail.com', '200385'),
	('Tech', 'techhaven@gmail.com', '2024');
	

CREATE TABLE Brand
(
	Brand_Id INT IDENTITY(1, 1),
	Brand_Name VARCHAR(150) UNIQUE,
	Brand_Status VARCHAR(15),
	CONSTRAINT PK_Brand PRIMARY KEY(Brand_Id)
);

CREATE TABLE Category
(
    Category_Id INT IDENTITY(1, 1),
	Category_Name VARCHAR(150) UNIQUE,
	Category_Status VARCHAR(15),
	CONSTRAINT PK_Category PRIMARY KEY (Category_Id)
);

CREATE TABLE Product
(
	Product_Id INT IDENTITY(1, 1),
	Product_Name VARCHAR(150) UNIQUE,
	Product_Image IMAGE,
	Product_Rate INT,
	Product_Quantity INT,
	Product_Brand VARCHAR(150),
	Product_Category VARCHAR(150),
	Product_Status VARCHAR(15),
	CONSTRAINT PK_Product PRIMARY KEY (Product_Id)
);

CREATE TABLE Orders
(
	Orders_Id INT IDENTITY(1,1),
	Orders_Date Date,
	Customer_Name VARCHAR(150),
	Customer_Number VARCHAR(15) UNIQUE,
	Total_Amount INT,
	Paid_Amount INT,
	Due_Amount INT,
	Discount INT,
	Grand_Total INT,
	Payment_Status VARCHAR(15),
	CONSTRAINT PK_Orders PRIMARY KEY (Orders_Id)
);

CREATE PROCEDURE GetOrdersReport(@StartDate Date, @EndDate Date)
AS
SELECT Orders_Id, Orders_Date, Customer_Name, Customer_Number, Grand_Total
FROM Orders
WHERE Orders_Date BETWEEN @startDate AND @EndDate
ORDER BY Orders_Date ASC;

SELECT * FROM Users;
SELECT * FROM Brand;
SELECT * FROM Category;
SELECT * FROM Product;
SELECT * FROM Orders;