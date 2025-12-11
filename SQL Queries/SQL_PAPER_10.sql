/* Creating db */
CREATE DATABASE SQL_PAPER_10;

/* Using DB */
USE SQL_PAPER_10;

/*
	DROP TABLE Products;
	DROP TABLE Customers;
	DROP TABLE Items;
	DROP TABLE Orders;
*/

/* Creating Products Table */
CREATE TABLE Products(
	pid VARCHAR(10) PRIMARY KEY,
	pname VARCHAR(10) NOT NULL UNIQUE
);

/* Inserting data into Products Table */
INSERT INTO Products VALUES
('p1', 'Biryani'),
('p2', 'Kebabs'),
('p3', 'Starters');

/* Creating Customers Table */
CREATE TABLE Customers(
	custId INT PRIMARY KEY,
	custName VARCHAR(10) NOT NULL,
	phno BIGINT NOT NULL UNIQUE,
	dob DATE NOT NULL
);

/* Inserting data into Customers Table */
INSERT INTO Customers VALUES
(101, 'Vishnu', 7845895648, '1992-10-30'),
(102, 'Varma', 5462135895, '1992-06-23'),
(103, 'Avinash', 7458963215, '1991-04-18'),
(104, 'Venkat', 1212458745, '1992-11-02');

/* Creating Items Table */
CREATE TABLE Items(
	itemId VARCHAR(10) PRIMARY KEY,
	itemName VARCHAR(20) NOT NULL,
	Cost MONEY NOT NULL,
	pid VARCHAR(10) FOREIGN KEY REFERENCES Products(pid)
);

/* Inserting data into Items Table */
INSERT INTO Items VALUES
('I1', 'Veg Biryani', 180.0, 'p1'),
('I2', 'Chicket Biryani', 250.0, 'p1'),
('I3', 'Panneer 65', 220.0, 'p3'),
('I4', 'Apollo Fish', 320.0, 'p3'),
('I5', 'Gobhi Manchuria', 220.0, 'p3');

/* Creating Orders Table */
CREATE TABLE Orders(
	orderId VARCHAR(10) PRIMARY KEY,
	custId INT FOREIGN KEY REFERENCES Customers(custId),
	itemId VARCHAR(10) FOREIGN KEY REFERENCES Items(itemId)
);

/* Inserting data into Orders Table */
INSERT INTO Orders VALUES
('o1', 101, 'I2'),
('o2', 101, 'I3'),
('o3', 102, 'I5'),
('o4', 103, 'I2'),
('o5', 104, 'I4'),
('o6', 104, 'I5');

/* Displaying all Products */
SELECT * FROM Products;

/* Displaying all Customers */
SELECT * FROM Customers;

/* Displaying all Items */
SELECT * FROM Items;

/* Displaying all Orders */
SELECT * FROM Orders;

/* Query to display custId, custName, itemId, itemName of second(102) customer */
SELECT c.custId, c.custName, i.itemId, i.itemName FROM Customers c INNER JOIN Orders o ON c.custId = o.custId INNER JOIN Items i ON o.itemId = i.itemId WHERE c.custId = 102;

/* Query to display all items in product table and matching itmes in items table */
SELECT * FROM Products p LEFT JOIN Items i ON p.pid = i.pid;

/* Query to display total items present in each Products in Products table */
/* Query to display Customer info whose phno is 5462135895 */
/* Query to display all Customers who are born in 1992 */
/* Query to display Orders placed by Vishnu */
/* Query to display total bill amount of Vishnu */
/* Query to display orderid, custId, custName, cot of all orders */
/* Query to display all kebabs info */
/* Query to update the cost of item with id 'I2' */
/* Query to delete 103 record form customer table */
/* Query to display all orders of Venkat */

