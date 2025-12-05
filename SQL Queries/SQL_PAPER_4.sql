/* File Name: SQLQuery1.sql */


/* creating database */
CREATE DATABASE HotelDB;

/* using database */
USE HotelDB;

/* creating Product table */
CREATE TABLE Product(
    productId INT PRIMARY KEY NOT NULL,
    PName VARCHAR(255) NOT NULL
);

/* inserting data into Product table */
INSERT INTO Product VALUES (101, 'Biryani'),(102, 'Kebabs'),(103, 'Starters');
INSERT INTO Product VALUES (105, 'Roti');

/* Updating product id from 103 to 104 */
UPDATE Product SET ProductId = 104 WHERE ProductId = 103;

/* Displaying the data from Product table */
SELECT * FROM Product;

/* Creating Items table */
CREATE TABLE Items(
   ItemId INT PRIMARY KEY NOT NULL,
   ItemName VARCHAR(255) NOT NULL,
   Cost MONEY NOT NULL,
   Pid INT NOT NULL
);

/* inserting data into Items table */
INSERT INTO Items VALUES (1121, 'Veg Biryani', 199.0, 101),(1122, 'Hara Bhara', 249.0, 102),(1123, 'Egg Biryani', 199.0, 101),(1124, 'Panneer 65', 189.0, 103);

/* Updating product id from 103 to 104 */
UPDATE Items SET Cost = 300.0 WHERE ItemId = 1122;

/* Updating Panneer 65 cost to +15% */
UPDATE Items SET Cost = (Cost*15/100)+Cost WHERE ItemName = 'Panneer 65';

/* Displaying the data from Items table */
SELECT * FROM Items;

/* Creating Admin table */
CREATE TABLE Admin(
    Username VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL
);

/* inserting data into Admin table */
INSERT INTO Admin VALUES ('admin','admin');

/* Displaying the data from Admin table */
SELECT * FROM Admin;

/* Creating Customers table */
CREATE TABLE Customers(
    custId varchar(20) PRIMARY KEY NOT NULL,
    CustName VARCHAR(255) NOT NULL,
    gender CHAR NOT NULL,
    phno BIGINT NOT NULL,
    DOB DATE NOT NULL,
    Email VARCHAR(300) NOT NULL,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

/* inserting data into Customers table */
INSERT INTO Customers VALUES 
('c1', 'Vishnu', 'M', 9999985467, '30-OCT-1995', 'vishnu@gmail.com', 'vishnu12', 'a1234a'),
('c2', 'Venkat', 'M', 8457956123, '02-NOV-1992', 'venkat@gmail.com', 'venkat22', 'b1234b'),
('c3', 'Pavana', 'F', 5896458712, '12-JUL-1994', 'pavana@gmail.com', 'pavana', 'c1234c'),
('c4', 'Ayesha', 'F', 4585854963, '19-DEC-1996', 'ayesha@gmail.com', 'ayesha1', 'd1234d'),
('c5', 'Mahesh', 'M', 7485965478, '15-Jan-1994', 'mahesh@gmail.com', 'mahesh23', 'e1234e');

/* Deleting record from the Customers table */
DELETE FROM Customers WHERE custId = 'c2';

/* Displaying the data from Custmers table */
SELECT * FROM Customers;

/* Displaying cid, cname, and phno of Customers table */
SELECT custId, CustName, phno FROM Customers;

/* Displaying the female customers data from Custmers table */
SELECT * FROM Customers WHERE gender = 'F';

/* Displaing all the customers whose DOB is after 1994 */
SELECT * FROM Customers WHERE DOB > '1994-12-31';
            /* OR */
SELECT * FROM Customers WHERE YEAR(DOB) > 1994;

/* Query to remove all the customers records */
DELETE FROM Customers;

        /* OR */

TRUNCATE TABLE Customers;

/* Creating Orders table */
CREATE TABLE Orders(
    OrderId varchar(20) PRIMARY KEY NOT NULL,
    ItemId INT NOT NULL,
    CustId VARCHAR(20) NOT NULL,
    Date Date NOT NULL,
    Quantity INT NOT NULL,
    Status VARCHAR(100) NOT NULL,
    BillAmt MONEY
);

/* inserting data into Orders table */
INSERT INTO Orders VALUES
('T1', 1121, 'c1', '06-OCT-2021', 2, 'Processing', 398.0),
('T2', 1123, 'c2', '06-OCT-2021', 1, 'Processing', 199.0),
('T3', 1124, 'c2', '06-OCT-2021', 1, 'Processing', 189.0),
('T4', 1122, 'c3', '06-OCT-2021', 1, 'Processing', 249.0),
('T5', 1125, 'c1', '05-NOV-2022', 3, 'Processing', 299.99);

/* Displaying the data from Orders table */
SELECT * FROM Orders;

/* Displaying the orders in '06-oct-2021' */
SELECT * FROM Orders WHERE Date = '06-OCT-2021';

/* Updating status as 'Completed' for Orders table */
UPDATE Orders SET Status = 'Completed';

/* Creating Student table */
CREATE TABLE Students(
    sid INT PRIMARY KEY NOT NULL,
    Sname VARCHAR(255) NOT NULL,
    Gender CHAR NOT NULL,
    Course VARCHAR(255) NOT NULL,
    Fee MONEY NOT NULL
);

/* Inserting data into Student table */
INSERT INTO Students VALUES 
(101, 'Riya', 'F', 'Python', 20000.0),
(102, 'Sagar', 'M', 'Java', 30000.0),
(103, 'Naira', 'F', '.Net', 25000.0),
(104, 'Kartik', 'M', 'Python', 20000.0),
(105, 'Sakshi', 'F', '.Net', 25000.0);

/* Displaying Students table data */
SELECT * FROM Students;

/* Query to display all female students */
SELECT * FROM Students WHERE Gender = 'F';

/* Students who took Python course */
SELECT * FROM Students WHERE Course = 'Python';

/* Query to display sid, sname, course, and fee */
SELECT sid, Sname, Course, Fee FROM Students;

/* Query to display students who took .net course */
SELECT * FROM Students WHERE Course = '.net';

/* Query to modify course value for student with sid as 104 */
UPDATE Students SET Course = 'Java' WHERE sid = 104;

/* Query to terminate all students details */
DELETE FROM Students;
    /* OR */
TRUNCATE TABLE Students;
    /* OR */
DROP TABLE Students;