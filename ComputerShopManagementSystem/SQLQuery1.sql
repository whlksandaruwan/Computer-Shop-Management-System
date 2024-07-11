CREATE DATABASE CSMS;

CREATE TABLE Users
(
    Users_Id INT IDENTITY(1, 1),
	Users_Name VARCHAR(150) UNIQUE,
	Users_Email VARCHAR(150),
	Users_Password VARCHAR(150),
	CONSTRAINT PK_Users PRIMARY KEY (Users_Id)
);

INSERT INTO Users VALUES
    ('Kavindu Sandaruwan', 'sandaruwankavindu059@gmail.com', '200385');

SELECT * FROM Users;