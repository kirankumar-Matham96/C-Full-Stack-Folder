/* Triggers:
	
	1. Triggers are some kind of special stored procidures or programs that will be executed automatically when some event(insert, update, delete) occurrs.
	2. We use triggers when we want some event to happen automatically in certain conditions.
	
		Syntax:

			```
			CREATE TRIGGER <TRIGGER_NAME> ON <TABLE_NAME>
			AFTER INSERT/UPDATE/DELETE
			AS BEGIN
				// SQL STATEMENTS
			END;
			```
*/

CREATE DATABASE CLASSWORK_SQL_25_12_2025;

USE CLASSWORK_SQL_25_12_2025;

/* Create a Student table with cols: sid, sname, s1, s2, s3, total, avg */
CREATE TABLE Student(
	sid INT PRIMARY KEY,
	sname VARCHAR(20),
	s1 INT CHECK(s1 >= 0 AND s1 <= 100),
	s2 INT CHECK(s2 >= 0 AND s2 <= 100),
	s3 INT CHECK(s3 >= 0 AND s3 <= 100),
	total INT,
	average MONEY
);

/* Create a Trigger for calculating total, avg.*/
CREATE TRIGGER tr_calculate_total_and_avg ON Student
AFTER INSERT
AS BEGIN
	UPDATE Student
	SET 
	total = inserted.s1+inserted.s2+inserted.s3,
	average = (inserted.s1+inserted.s2+inserted.s3)/3.0
	FROM inserted
	WHERE Student.sid = inserted.sid;
END;

/* Insert some records into Student table using STORED PROCEDURE */
CREATE PROCEDURE sp_insert_student(@id INT, @name VARCHAR(20), @s1 INT, @s2 INT, @s3 INT)
AS BEGIN
	INSERT INTO Student(sid, sname, s1,s2,s3) VALUES (@id, @name, @s1, @s2, @s3);
END;

EXEC sp_insert_student 101, 'Shravan', 95, 75, 89;
EXEC sp_insert_student 102, 'Maheshwari', 90, 85, 86;
EXEC sp_insert_student 103, 'Vidya', 60, 58, 70;
EXEC sp_insert_student 104, 'Mukhesh', 40, 30, 42;
EXEC sp_insert_student 105, 'Kaveri', 95, 95, 95;
EXEC sp_insert_student 106, 'Karunakar', 99, 98, 95;
EXEC sp_insert_student 107, 'Akhila', 85, 80, 79;
EXEC sp_insert_student 108, 'Hari', 50, 85, 79;
EXEC sp_insert_student 109, 'Deepak', 60, 70, 55;
EXEC sp_insert_student 110, 'Ravi', 49, 60, 75;


/* Displaying Student table data */
SELECT * FROM Student;


/* Class Work */

/* 1Q: 
	-> Create 'Emp' Table with Eid, Ename, gender, Dob, Dno, Sal, AnnualSalary
	-> Create Trigger as 'tr_calAnnualSal'. Whenever Emp record inserted, then 'AnnualSalary' has to be calculated and updated
*/
CREATE TABLE Emp(
	eid INT PRIMARY KEY,
	ename VARCHAR(20),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	dno INT DEFAULT 10,
	sal MONEY CHECK(sal >= 25000),
	annualSal MONEY
);

CREATE TRIGGER tr_calAnnualSal ON Emp
AFTER INSERT
AS BEGIN
	UPDATE Emp SET
	Emp.annualSal = inserted.sal*12
	FROM inserted
	WHERE Emp.eid = inserted.eid
END;

CREATE PROCEDURE sp_insert_emp(@id INT, @name VARCHAR(20), @g CHAR, @dob DATE, @dno INT, @sal MONEY)
AS BEGIN
	INSERT INTO Emp(eid, ename, gender, dob, dno, sal) VALUES (@id, @name, @g, @dob, @dno, @sal);
END;

EXEC sp_insert_emp 1001, 'Tarun', 'M', '1999-JAN-12',20, 35000; 
EXEC sp_insert_emp 1002, 'Akhila', 'F', '1998-AUG-01',20, 45000; 
EXEC sp_insert_emp 1003, 'Vivek', 'M', '1998-AUG-01',30, 55000; 
EXEC sp_insert_emp 1004, 'Narasimha', 'M', '1998-AUG-01',10, 30000; 
EXEC sp_insert_emp 1005, 'Jayanth', 'M', '1998-AUG-01',30, 42000; 
EXEC sp_insert_emp 1006, 'Vinay', 'M', '1998-AUG-01',20, 60000; 
EXEC sp_insert_emp 1007, 'Bhanu', 'F', '1998-AUG-01',10, 25000; 
EXEC sp_insert_emp 1008, 'Rashmika', 'F', '1998-AUG-01',30, 70000; 
EXEC sp_insert_emp 1009, 'Suhas', 'M', '1998-AUG-01',20, 40000; 
EXEC sp_insert_emp 1010, 'Lekha', 'F', '1998-AUG-01',10, 45000; 

SELECT * FROM Emp;

/* 2Q:
	-> Create 'Leaves' table with Eid, leaves, monthlySal
	-> Create a trigger as 'tr_calMonthlySal'. Whenever eid, leaves enter in 'Leaves' table, then the trigger has to calculate the 'monthlySal' after the leaves.
	-> assume 30 days for a month
*/
CREATE TABLE Leaves(
	eid INT PRIMARY KEY,
	leaves INT CHECK(leaves BETWEEN 0 AND 12),
	monthlySal MONEY
);

CREATE PROCEDURE sp_insert_leaves(@id INT, @lvs INT, @mSal MONEY)
AS BEGIN
	INSERT INTO Leaves VALUES (@id, @lvs, @mSal);
END;

CREATE TRIGGER tr_calMonthlySal ON Leaves
AFTER INSERT
AS BEGIN
	UPDATE Leaves SET
	Leaves.monthlySal = inserted.monthlySal - (inserted.monthlySal/30)*Leaves.leaves
	FROM inserted
	WHERE Leaves.eid = inserted.eid
END;

EXEC sp_insert_leaves 101,5, 40000;
EXEC sp_insert_leaves 102,2, 45000;
EXEC sp_insert_leaves 103,3, 35000;
EXEC sp_insert_leaves 104,1, 25000;
EXEC sp_insert_leaves 105,2, 50000;
EXEC sp_insert_leaves 106,6, 70000;

SELECT * FROM Leaves;

/* 3Q:
	-> Create a 'Stocks' table with mid, mname, cost, Availability
	-> Create 'Orders' table with orderId, mid, qty, billAmt
	-> Insert values for orderId, mid, qty
	-> Create trigger to find billAmt
	-> Whenever a record inserted in 'Orders' table, then update the stocks table using the trigger.
*/
CREATE PROCEDURE sp_orders_drop
AS BEGIN
	DROP TABLE Orders;
END;

CREATE TABLE Stocks(
	mid INT PRIMARY KEY,
	mname VARCHAR(20),
	cost MONEY,
	Availability INT
);

--EXEC sp_orders_drop;

CREATE TABLE Orders(
	orderId INT PRIMARY KEY,
	mid INT REFERENCES Stocks(mid),
	qty INT,
	billAmt MONEY
);

CREATE PROCEDURE sp_insert_stocks(@id INT, @name VARCHAR(20), @cost MONEY, @avail INT)
AS BEGIN
	INSERT INTO Stocks VALUES (@id, @name, @cost, @avail);
END;

CREATE PROCEDURE sp_insert_orders(@oid INT, @mid INT, @qty INT)
AS BEGIN
	INSERT INTO Orders(orderId, mid, qty) VALUES (@oid, @mid, @qty); 
END;

EXEC sp_insert_stocks 10,'HCL',25000,10;
EXEC sp_insert_stocks 11,'TCS',20000,20;
EXEC sp_insert_stocks 12,'NMDC',15000,50;
EXEC sp_insert_stocks 13,'HDFC',35000,5;
EXEC sp_insert_stocks 14,'SIP',2000,106;

/* Example-start */
-- for understanding what will be available in inserted virtual table
CREATE TRIGGER tr_orders_afterInsert
ON Orders
FOR INSERT
AS BEGIN
	SELECT * FROM inserted;
END;
/* Example-end */

/* Not executed from here */
EXEC sp_insert_orders 1,12,20;
EXEC sp_insert_orders 2,10,3;
EXEC sp_insert_orders 3,13,2;
EXEC sp_insert_orders 4,10,2;
EXEC sp_insert_orders 5,12,5;
EXEC sp_insert_orders 6,14,20;
EXEC sp_insert_orders 7,14,20;
EXEC sp_insert_orders 8,13,3;
EXEC sp_insert_orders 9,12,10;
EXEC sp_insert_orders 10,10,2

/* trigger to calculate billAmt in Orders and update availability in Stocks */
CREATE TRIGGER tr_orders_calBillAmtAndUpdateQty
ON Orders
AFTER INSERT
AS BEGIN
	SET NOCOUNT ON; -- To prevent update messages (improves performance) {But it is not working!}

	-- Calculating billAmt when inserting new order record
	UPDATE o SET o.billAmt = s.cost * i.qty
	FROM Orders o JOIN inserted i ON o.orderId = i.orderId
	JOIN Stocks s ON s.mid = i.mid;

	-- Updating Stocks availability
	UPDATE s SET s.availability = s.availability - i.qty
	FROM Stocks s JOIN inserted i ON s.mid = i.mid
END;

SELECT * FROM Orders;
SELECT * FROM Stocks;

