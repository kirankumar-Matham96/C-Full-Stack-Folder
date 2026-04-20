CREATE DATABASE EF_DB_2;

USE EF_DB_2;

CREATE TABLE Employee(
	eno INT PRIMARY KEY,
	ename VARCHAR(50),
	job VARCHAR(20),
	salary MONEY,
	deptno INT
);

INSERT INTO Employee VALUES
(1001, 'Vijay', 'Manager', 90000, 10),
(1002, 'Sunil kumar', 'Clerk', 90000, 10),
(1003, 'Ram', 'Clerk', 90000, 10),
(1004, 'Srikanth', 'Analyst', 120000, 10),
(1005, 'Vonod', 'Manager', 150000, 20),
(1006, 'Krishna', 'Developer', 200000, 20)


SELECT * FROM Employee;