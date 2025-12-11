CREATE DATABASE ECom;

USE ECom;


/* creating orders table */
CREATE TABLE Orders(
	OrderId INT PRIMARY KEY NOT NULL,
	ItemName VARCHAR(255) NOT NULL,
	Cost MONEY NOT NULL,
	Quantity INT NOT NULL,
	Amount MONEY,
	PaymentMode VARCHAR(200) NOT NULL
);

/* inserting data */
INSERT INTO Orders VALUES 
(1122,'Pizza',399.0,3,NULL,'PhonePay'),
(1123,'Burger',299.0,5,NULL,'Cash'),
(1124,'Biryani',499.0,2,NULL,'PhonePay'),
(1125,'Pizza',699.0,3,NULL,'Cash'),
(1126,'Biryani',249.0,3,NULL,'Cash'),
(1127,'Pizza',799.0,3,NULL,'PhonePay');

/* Updating amount */
UPDATE Orders SET Amount=Cost*Quantity;

/* reading table data */
SELECT * FROM Orders;

/* Total amount */
SELECT SUM(Amount) AS TotalAmount FROM Orders;

/* Total no of orders */
SELECT COUNT(*) AS TotalOrders FROM Orders;

/* mum Sales Orders */
SELECT MAX(ItemName) AS MaxSoldOrder FROM Orders;

/* Minimum Sales Orders */
SELECT MIN(ItemName) AS MaxSoldOrder FROM Orders;

/* Avg amount */
SELECT AVG(Amount) AS 'Average Amount' FROM Orders;

/* Orders by PhonePay */
SELECT SUM(Amount) AS 'Total Amount By PhonePay' FROM Orders WHERE PaymentMode = 'PhonePay';

/* Orders by Cash */
SELECT SUM(Amount) AS 'Total Amount By Cash' FROM Orders WHERE PaymentMode = 'Cash';

/* Biryani Amount */
SELECT SUM(Amount) AS 'Biryani Total Amount' FROM Orders WHERE ItemName = 'Biryani';

/* Burger Orders */
SELECT COUNT(ItemName) AS 'Burger Orders' FROM Orders WHERE ItemName = 'Burger';

/* Pizza Orders */
SELECT COUNT(ItemName) AS 'Pizza Orders' FROM Orders WHERE ItemName = 'Pizza';


/* User Table */

/* Creating User Table */
CREATE TABLE Users(
	Uid INT PRIMARY KEY NOT NULL,
	UName VARCHAR(255),
	pwd VARCHAR(255)
);

/* Inserting data */
INSERT INTO Users VALUES 
(1, 'Venkat', '123'),
(2, 'Venkat', NULL),
(3, NULL, '123'),
(4, 'Vishnu', 'abc'),
(5, 'Prasad', ''),
(6, '', 'abc');

SELECT * FROM Users;

/* Checking user is invalid (DB side) */
SELECT * FROM Users WHERE Uname IS NULL OR pwd IS NULL;
SELECT * FROM Users WHERE UName NOT LIKE '_%_' OR pwd NOT LIKE '_%_';
SELECT * FROM Users WHERE (Uname IS NULL OR pwd IS NULL) OR (UName NOT LIKE '_%_' OR pwd NOT LIKE '_%_')

/* Checking user is invalid (Server side) */
SELECT * FROM Users WHERE Uname = '<user_given_username>' AND pwd = '<user_given_password>'; /* cannot run it here */