CREATE DATABASE DAY5;

USE DAY5;

/* Admin Table */
CREATE TABLE Admin(
	Username VARCHAR(255) PRIMARY KEY NOT NULL,
	Password VARCHAR(255) NOT NULL
);

INSERT INTO Admin VALUES('admin', 'admin');

SELECT * FROM Admin;

/* Orders Table */
CREATE TABLE Orders(
	OrderId INT PRIMARY KEY NOT NULL,
	ProductId INT NOT NULL,
	Quantity INT NOT NULL,
	cid INT NOT NULL,
	BillAmount MONEY NOT NULL,
	Status VARCHAR(100) NOT NULL,
	Date DATE NOT NULL
);

INSERT INTO Orders VALUES 
(1,3,5,3,299.99,'Completed','10-DEC-2025'),
(2,2,2,2,399.99,'Pending','12-JAN-2025'),
(3,3,3,1,499.99,'Processing','23-NOV-2024'),
(4,1,6,2,599.99,'Pending','09-MAY-2025'),
(5,2,1,3,199.99,'Processing','01-MAR-2025'),
(6,4,2,1,299.99,'Completed','06-AUG-2024');

SELECT * FROM Orders;

/* Product Table */
CREATE TABLE Product(
	pid INT	PRIMARY KEY NOT NULL,
	PName VARCHAR(255) NOT NULL
);

/* Items Table */
CREATE TABLE Items(
	ItemId INT PRIMARY KEY NOT NULL,
	ItemName VARCHAR(255) NOT NULL,
	Cost MONEY NOT NULL,
	Pid INT NOT NULL
);

INSERT INTO Items VALUES 
(1,'Mobile', 19999.99, 2),
(2,'Washing Machine', 29999.99, 1),
(3,'TV', 39999.99, 3),
(4,'Tab', 25999.99, 2),
(5,'Laptop', 19999.99, 1),
(6,'Mobile', 10000.00, 2);

SELECT * FROM Items;

/* Customer Table */
CREATE TABLE Customer(
	cid INT PRIMARY KEY NOT NULL,
	cname VARCHAR(255) NOT NULL,
	gender CHAR NOT NULL,
	phno BIGINT NOT NULL,
	passwod VARCHAR(255) NOT NULL,
	Email VARCHAR(255) NOT NULL UNIQUE,
	DOB DATE NOT NULL,
	username VARCHAR(255) NOT NULL
);

DROP TABLE Customer;

/* Payment Table */
CREATE TABLE Payment(
	Pid INT PRIMARY KEY NOT NULL,
	cid INT NOT NULL,
	OrderId INT NOT NULL,
	Status VARCHAR(255) NOT NULL
);

ALTER TABLE Payment ADD Date DATE NOT NULL;

/* PaymentMode Table */
CREATE TABLE PaymentMode(
	Pid INT NOT NULL,
	PaymetType VARCHAR(150) NOT NULL
);