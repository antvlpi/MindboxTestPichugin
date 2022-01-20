CREATE DATABASE ProductsDatabase;

USE ProductsDatabase;

CREATE TABLE Categories
(
	id INT IDENTITY(1,1) PRIMARY KEY,  
	category varchar(255) NOT NULL
)

CREATE TABLE Products
(
	id INT IDENTITY(1,1) PRIMARY KEY,  
	product varchar(255) NOT NULL,  
	idCategory INT FOREIGN KEY REFERENCES Categories(Id)
)