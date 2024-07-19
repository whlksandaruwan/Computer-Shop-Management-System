CREATE DATABASE CSMS;

CREATE TABLE Users
(
   Users_Id INT IDENTITY(1, 1),
   Users_Name VARCHAR(150) UNIQUE,
   Users_Email VARCHAR(150),
   Users_Password VARCHAR(150),
   CONSTRAINT PK_users PRIMARY KEY(Users_Id)
);

INSERT INTO Users VALUES
    ('Kavindu', 'sandaruwan@gmail.com', '200385');

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

SELECT * FROM Users;
SELECT * FROM Brand;
SELECT * FROM Category;