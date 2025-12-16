/* Sored Procedures */

/* Creating a database */
CREATE DATABASE CLASSWORK_SQL_16_12_2025;

/* Using database */
USE CLASSWORK_SQL_16_12_2025;

/* Stored procedure for dropping all tables */
CREATE PROCEDURE sp_delete_all_tables
AS BEGIN
	/*DROP TABLE Department;
	DROP TABLE Employee;
	*/
	DROP TABLE Branch1;
	DROP TABLE Branch2;
END;

EXEC sp_delete_all_tables;

/* Creating department table */
CREATE TABLE Department(
	did INT PRIMARY KEY,
	dname VARCHAR(20) NOT NULL
);


/* Creating a stored procedure for Inserting data into the tables */
CREATE PROCEDURE sp_dinsert(@id INT, @name VARCHAR(20))
AS BEGIN
	INSERT INTO Department VALUES(@id, @name);
END;

/* Executing the stored procedure to insert data */
EXEC sp_dinsert 10,'HR';
EXEC sp_dinsert 20,'IT';
EXEC sp_dinsert 30,'DA';
EXEC sp_dinsert 40,'DS';

/* Creating employees table */
CREATE TABLE Employee(
	eid INT PRIMARY KEY,
	ename VARCHAR(20) NOT NULL,
	salary MONEY,
	gender CHAR CHECK(gender IN ('M','F','O')),
	deptID INT REFERENCES Department(did)
);

/* Creating a stored procedure for Inserting data into the tables */
CREATE PROCEDURE sp_einsert(@id INT, @name VARCHAR(20), @sal MONEY, @gender CHAR, @did INT)
AS BEGIN
	INSERT INTO Employee VALUES(@id, @name, @sal, @gender, @did);
END;

EXEC sp_einsert 101, 'Venkat', 20000.00, 'M', 20;
EXEC sp_einsert 102, 'Raghu', 35000.00, 'M', 30;
EXEC sp_einsert 103, 'Madhavi', 25000.00, 'F', 10;
EXEC sp_einsert 104,'Manjula', 45000.00, 'F', 40;
EXEC sp_einsert 105, 'Kishor', 50000.00, 'O', 10;
EXEC sp_einsert 106, 'Akhila', 70000.00, 'F', 20;
EXEC sp_einsert 107, 'Vinod', 26000.00, 'M', 40;
EXEC sp_einsert 108, 'Jyothi', 22000.00, 'F', 30;

/* Stored procedure for displaying all info of Department and Employee tables */
CREATE PROCEDURE sp_display_dept_emp
AS BEGIN
	SELECT * FROM Department;
	SELECT * FROM Employee;
END;

EXEC sp_display_dept_emp;

/* Calss Tasks */

/* 1Q: Create Branch1 and Branch2 tables */

/* Creating Branch 1 table */
CREATE TABLE Branch1(
	Eid INT PRIMARY KEY,
	Ename VARCHAR(20) NOT NULL,
	Sal MONEY
);

/* Creating Branch 2 table */
CREATE TABLE Branch2(
	Eid INT PRIMARY KEY,
	Ename VARCHAR(20) NOT NULL,
	Sal MONEY
);

/* 2Q: Insert records */

/* Stored procedure for inserting data into Branch1 table */
CREATE PROCEDURE sp_b1insert1(@id INT, @name VARCHAR(20), @Sal MONEY)
AS BEGIN
	INSERT INTO Branch1 VALUES (@id, @name, @sal);
END;

/* Stored procedure for inserting data into Branch2 table */
CREATE PROCEDURE sp_b1insert2(@id INT, @name VARCHAR(20), @Sal MONEY)
AS BEGIN
	INSERT INTO Branch2 VALUES (@id, @name, @sal);
END;

/* Inserting data into Branch1 table */
EXEC sp_b1insert1 101,'Venkat',20000.0;
EXEC sp_b1insert1 102,'Vishnu',25000.0;
EXEC sp_b1insert1 103,'Varun',18000.0;
EXEC sp_b1insert1 104,'Sarma',27000.0;
EXEC sp_b1insert1 105,'Pavana',32000.0;

/* Inserting data into Branch1 table */
EXEC sp_b1insert2 201,'Ravi',22000.0;
EXEC sp_b1insert2 202,'AVRao',18000.0;
EXEC sp_b1insert2 101,'Venkat',20000.0;
EXEC sp_b1insert2 104,'Sarma',27000.0;
EXEC sp_b1insert2 203,'Lakshmi',17000.0;

/* 3Q: Display all info from both tables */

/* Stored procedure to display Branch1 data */
CREATE PROCEDURE sp_displayb1
AS BEGIN
	SELECT * FROM Branch1;
END;

/* Stored procedure to display Branch2 data */
CREATE PROCEDURE sp_displayb2
AS BEGIN
	SELECT * FROM Branch2;
END;

/* Displaying data from Branch 1 & 2 tables */
EXEC sp_displayb1;
EXEC sp_displayb2;

/* Stored procedure to show all info from b1 and b2 tables using realational set operators */
CREATE PROCEDURE sp_show_with_union_all
AS BEGIN
	SELECT * FROM Branch1 UNION ALL SELECT * FROM Branch2;
END;

EXEC sp_show_with_union_all;

/* 4Q: Display total employees without duplicates */

/* Stored procedure to show all info from b1 and b2 tables using realational set operators without duplicates */
CREATE PROCEDURE sp_show_with_union
AS BEGIN
	SELECT * FROM Branch1 UNION SELECT * FROM Branch2;
END;

EXEC sp_show_with_union;

/* 5Q: Display the employees who are working only in branch 1 */
SELECT * FROM Branch1 EXCEPT SELECT * FROM Branch2

/* 6Q: Display the employees who are working only in branch 2 */
SELECT * FROM Branch2 EXCEPT SELECT * FROM Branch1

/* 7q: Display all employees who are working in both Branches */
SELECT * FROM Branch1 INTERSECT SELECT * FROM Branch2

/* 8Q: Display total Salaries paid by branch wise */
/* Simple and basic with union all */
SELECT 'Branch1' AS Branch, SUM(Sal) AS 'Total Salary'
FROM Branch1
UNION ALL
SELECT 'Branch2', SUM(Sal)
FROM Branch2;

/* Cleaner and Scalable with union all + group by */
SELECT Branch, SUM(Sal) AS 'Total Salary' FROM (
	SELECT 'Branch1' AS Branch, Sal FROM Branch1
	UNION ALL
	Select 'Branch2', Sal FROM Branch2
) T
GROUP BY Branch;