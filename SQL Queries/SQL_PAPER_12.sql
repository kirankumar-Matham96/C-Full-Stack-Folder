CREATE DATABASE SQL_PAPER_12;

USE SQL_PAPER_12;

/* 3Q: Create tables for Dept and Emp */
CREATE TABLE Dept(
	did INT PRIMARY KEY,
	dname VARCHAR(20) UNIQUE
);

CREATE TABLE Emp(
	eid INT PRIMARY KEY,
	ename VARCHAR(20),
	gender CHAR CHECK(gender IN ('M', 'F', 'O')),
	sal MONEY,
	did INT FOREIGN KEY REFERENCES Dept(did)
);

/* 4Q: Query to insert data into tables */
INSERT INTO Dept VALUES
(10, 'Developer'),
(20, 'HR'),
(30, 'Testing');

INSERT INTO Emp VALUES
(101, 'Kartheek', 'M', 56000, 10),
(102, 'Sam', 'F', 32000, 20),
(103, 'Reena', 'F', 78000, 30);

/* 5Q: Display all Dept info */
SELECT * FROM Dept;

/* 6Q: Display all Emp info */
SELECT * FROM Emp;

/* 7Q: Display highest salaried employee */
SELECT TOP 1 * FROM Emp ORDER BY Sal DESC;

/* 8Q: Display lowest salaried employee */
SELECT TOP 1 * FROM Emp ORDER BY Sal;

/* 9Q: Display second highest salaried employee */
SELECT TOP 1 * FROM (SELECT TOP 2 * FROM Emp ORDER BY Sal DESC) T ORDER BY Sal;

/* 10Q: Display top 3 records of an employee table */
SELECT TOP 3 * FROM Emp;

/* 11Q: Display top 2 earners records of an employee table */
SELECT TOP 2 * FROM Emp ORDER BY Sal DESC;

/* 14Q: Query to create S1 and S2 tables */
CREATE TABLE S1(
	eid INT PRIMARY KEY,
	ename VARCHAR(20),
	salary MONEY
);

CREATE TABLE S2(
	eid INT PRIMARY KEY,
	ename VARCHAR(20),
	salary MONEY
);

/* 15Q: Query to insert data into S1 and S2 tables */
INSERT INTO S1 VALUES
(101, 'Suraj', 25000),
(102, 'Ritika', 42000),
(103, 'Shruthi', 56000),
(104, 'Roshan', 30000),
(105, 'Pavani', 70000);

INSERT INTO S2 VALUES
(301, 'Ritwik', 35000),
(302, 'Pavani', 70000),
(304, 'Advik', 45000),
(305, 'Roshan', 30000),
(306, 'Shruthi', 56000);

/* 16Q: Display all records in S1 */
SELECT * FROM S1;

/* 17Q: Display all records in S2 */
SELECT * FROM S2;

/* 18Q: Display all employee records from both S1 and S2 */
SELECT * FROM S1 UNION ALL SELECT * FROM S2;

/* 19Q: Display total employees records without duplicates */
SELECT ename, salary FROM S1 UNION SELECT ename, salary FROM S2;

/* 20Q: Display employees records from S1 */
SELECT * FROM S1;

/* 21Q: Display employees records from S2 */
SELECT * FROM S2;

/* 22Q: Display employees records from both S1 and S2 */
SELECT * FROM S1 UNION ALL SELECT * FROM S2;

/* 23Q: Display total salary paid from both S1 and S2 */
SELECT SUM(Salary) AS 'Total Salary' FROM
(SELECT salary FROM S1 UNION ALL SELECT salary FROM S2) T;

/* 36Q: Create a stored procedure on Products table with pid, pname, and pcost */
CREATE PROCEDURE sp_create_products
AS BEGIN
	CREATE TABLE Products(
		pid INT PRIMARY KEY,
		pname VARCHAR(20),
		pcost MONEY
	);
END;

EXEC sp_create_products;

/* 37Q: Create a stored procedure to insert records into Products table */
CREATE PROCEDURE sp_insert_products(@pid INT, @pname VARCHAR(20),@pcost MONEY)
AS BEGIN
	INSERT INTO Products VALUES (@pid, @pname, @pcost);
END;

EXEC sp_insert_products 101, 'LG TV', 55000;
EXEC sp_insert_products 102, 'Samsung TV', 60000;
EXEC sp_insert_products 103, 'Onida TV', 49000;
EXEC sp_insert_products 104, 'TCS TV', 35000;
EXEC sp_insert_products 105, 'Redmi TV', 15000;

/* 39Q: Create a stored procedure to delete records from Products table */
CREATE PROCEDURE sp_delete_products(@pid INT)
AS BEGIN
	DELETE FROM Products WHERE pid = @pid;
END;

EXEC sp_delete_products 101;

/* 40Q: Create a stored procedure to update records in Products table */
CREATE PROCEDURE sp_update_products(@pid INT, @pname VARCHAR(20), @pcost MONEY)
AS BEGIN
	UPDATE Products SET pname = @pname, pcost = @pcost WHERE pid = @pid;
END;

EXEC sp_update_products 103, 'Google TV', 60000;

/* 41Q: Create a stored procedure to display all records in Products table */
CREATE PROCEDURE sp_display_products
AS BEGIN
	SELECT * FROM Products
END;

EXEC sp_display_products;

/* 42Q: Create a stored procedure to display records in Products table based on eid */
CREATE PROCEDURE sp_display_products_with_id(@pid INT)
AS BEGIN
	SELECT * FROM Products WHERE pid = @pid
END;

EXEC sp_display_products_with_id 102;
