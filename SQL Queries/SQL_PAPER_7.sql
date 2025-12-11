CREATE DATABASE SQL_PAPER_7;

USE SQL_PAPER_7;

CREATE TABLE Dept(
	did INT PRIMARY KEY,
	dname VARCHAR(20) NOT NULL UNIQUE
);

INSERT INTO Dept VALUES
(10, 'IT'),
(20, 'HR'),
(30, 'Developer');

SELECT * FROM Dept;

CREATE TABLE Emp(
	eid INT PRIMARY KEY,
	ename VARCHAR(255) NOT NULL,
	sal MONEY CHECK(sal >= 25000.00) DEFAULT 25000.00,
	dno INT REFERENCES Dept(did),
	age INT NOT NULL
);

INSERT INTO Emp VALUES
(11201, 'Yuvika', 35000.0, 20, 23),
(11202, 'Rahul', 68000, 10, 28),
(11203, 'Aarna', 50000,20,25),
(11204, 'Suraj', 100000,30,35);

/* Display all employees details */
SELECT * FROM Emp;

/* Display all emp details, dname who belongs to HR dept */
SELECT *,dname FROM Emp e JOIN Dept d ON dno = did WHERE Dname = 'HR';

/* Query to increment emp sal to 10% whos name ends with 'Y' */
UPDATE Emp SET sal = sal+sal*10/100 WHERE ename LIKE 'Y%';

/* Query to display eno, age, dname whos age is b/w 23 and 28 and belongs to 'IT' dept */
SELECT eid, age, dname FROM Emp e JOIN Dept d ON dno = did WHERE age > 23 AND age < 28;
 
/* Query to display sum of sal, dname based on dept name */
SELECT SUM(Sal) AS 'Total Salary', dname FROM Emp e JOIN Dept d ON did = dno GROUP BY Dname;

/* Query to display all dept info */
SELECT * FROM Dept;

/* Query to display eno, ename, dno, dname */
SELECT eid, ename, did, dname FROM Emp e JOIN Dept d ON dno = did;

/* Query to display all emp info who belongs to 'Developer' dept */
SELECT * FROM Emp e JOIN Dept d ON dno = did WHERE dname = 'Developer';


/* Query to display emp details who belongs to 'HR' dept and their name starts with 'Y' */

/* Query to display emp info who belongs to either 'HR' or 'IT' dept and salary is more than Rs. 30,000/- */

/* Query to display all emp info, dname whos name starts with 's' and ends with 'j' and they should belongs to 'Developer' dept */

/* Query to display all info whose name has exactly 6 characters */

/* Query to display emp info whose name starts with 'R' and ends with 'I' */

/* Query to display emp info whose sal is in b/w 25000 and 50000 */

