CREATE DATABASE CLASSWORK_SQL_12_12_2025;

USE CLASSWORK_SQL_12_12_2025;

/* Task-1 */

CREATE TABLE Dept(
	Dno INT PRIMARY KEY,
	Dname VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Emp(
	eno INT PRIMARY KEY,
	ename VARCHAR(20) NOT NULL,
	salary MONEY NOT NULL,
	dno INT FOREIGN KEY REFERENCES Dept(Dno) NOT NULL,
	age INT,
	address VARCHAR(50)
);

/*
	DROP TABLE Emp;
	DROP TABLE Dept;
*/

INSERT INTO DepT VALUES
(10, 'IT'),
(20, 'Maths'),
(30, 'Bench'),
(40, 'Physics');

INSERT INTO Emp VALUES 
(101, 'Anil', 20000.00, 10, 20, 'Hyd'),
(102, 'Sunil', 23000.00, 10, 22, 'Hyd'),
(103, 'Ajay', 25000.00, 10, 17, 'Chennai'),
(104, 'Kiran', 30000.00, 20, 27, 'Hyd'),
(105, 'Vijay', 40000.00, 30, 26, 'Hyd'),
(106, 'Gopal', 26000.00, 20, 20, 'Hyd');

SELECT * FROM Emp;
SELECT * FROM Dept;

/* Class Tasks */
/* w.a.q. to display highest salary */
SELECT MAX(salary) AS 'Highest Salary' FROM Emp;

/* w.a.q. to display highest salary employee details */
SELECT * FROM Emp WHERE Salary = (SELECT MAX(salary) FROM Emp); /* Using Sub query */
	/* OR */
SELECT TOP 1 * FROM Emp ORDER BY Salary DESC; /* Using TOP */

/* w.a.q. to display least salary employee details */
SELECT * FROM Emp WHERE salary = (SELECT MIN(salary) FROM Emp);

	/* OR */
SELECT TOP 1 * FROM Emp ORDER BY salary;

/* w.a.q. to display second highest salary */
SELECT MAX(salary) AS 'Second Highest Salary' FROM Emp WHERE salary < (SELECT MAX(salary) FROM Emp);

/* w.a.q. to display second highest salaried employee details */
SELECT * FROM Emp WHERE salary = (SELECT MAX(salary) AS 'Second Highest Salary' FROM Emp WHERE salary < (SELECT MAX(salary) FROM Emp));



/* After Class Tasks: */
/* 1. w.a.q. to display all employee info, dname who belongs to Maths dept and address is Hyd */
SELECT e.*, d.dname FROM Emp e INNER JOIN Dept d ON e.dno = d.dno WHERE d.dname = 'Maths' AND e.address = 'Hyd';

/* 2. w.a.q. to increase employee salary by 10% whose name ends with 'y' */
UPDATE Emp SET salary = salary + (salary * 10/100) WHERE ename LIKE '%y';

/* 3. w.a.q. to display eid, age, address, dname whose age is between 20 to 25 but they should belong to IT dept */
SELECT e.eno, e.age, e.address, d.Dname FROM Emp e INNER JOIN Dept d ON e.dno = d.Dno WHERE (e.age BETWEEN 20 AND 25) AND d.Dname = 'IT';

/* 4. w.a.q. to display sum of salary, dname, based on dept name */
SELECT SUM(e.salary) AS 'Total Salary', d.dname FROM Emp e INNER JOIN Dept d ON e.dno = d.Dno GROUP BY d.dname;

/* 5. w.a.q. to display eno, did, salary who belongs to Hyd and age should be less than 22 years as well as salary should be more than 25000 */
SELECT e.eno, d.Dno, e.salary FROM Emp e INNER JOIN Dept d ON e.dno = d.Dno WHERE e.address = 'Hyd' AND age < 22 AND e.salary > 25000;

/* 6. w.a.q. to display eno, age, salary of IT dept in descending order based on salary */
SELECT e.eno, e.age, e.salary FROM Emp e INNER JOIN Dept d ON e.dno = d.Dno WHERE d.Dname = 'IT' ORDER BY e.salary DESC;

/* 7. w.a.q. to display eno, age, salary of Maths dept in orders wise based on age */
SELECT e.eno, e.age, e.salary FROM Emp e INNER JOIN Dept d ON e.dno = d.Dno WHERE d.dname = 'Maths' ORDER BY age;


/* Task-2 */
/* Creating employee table 2 */
CREATE TABLE Employee(
	eid INT PRIMARY KEY,
	ename VARCHAR(20) NOT NULL,
	managerId INT
);

INSERT INTO Employee VALUES
(1, 'Sarma', NULL),
(2, 'Vishnu', 1),
(3, 'Venkat', 1),
(4, 'Pavana', 2),
(5, 'AVRao', 2),
(6, 'Murali', 4),
(7, 'Leena', 5);

SELECT * FROM Employee;

/* 1. w.a.q. to display all employees with manager name including Sarma information */
SELECT e.ename AS 'Employee', m.ename AS 'Manager' FROM Employee e LEFT JOIN Employee m ON m.eid = e.managerId;

/* Task-3 */
/* Creating state table */
CREATE TABLE State(
	sid VARCHAR(5) PRIMARY KEY,
	sname VARCHAR(20) NOT NULL
);

/* Creating City table */
CREATE TABLE City(
	cid INT PRIMARY KEY,
	cname VARCHAR(20) NOT NULL,
	sid VARCHAR(5) FOREIGN KEY REFERENCES State(sid)
);

/* Inserting data into State table */
INSERT INTO State VALUES
('s1', 'Telangana'),
('s2', 'AP'),
('s3', 'TN'),
('s4', 'Kerala'),
('s5', 'Karnataka');

/* Inserting data into City table */
INSERT INTO City VALUES
(1, 'Hyd', 's1'),
(2, 'Vijayavada', 's2'),
(3, 'Visag', 's2'),
(4, 'Warangal', 's1');

SELECT * FROM State;
SELECT * FROM City;

/* w.a.q. to display Visag related state */
SELECT * FROM State s INNER JOIN City c ON s.sid = c.sid WHERE c.cname = 'Visag';

/* w.a.q. to display Telangana and Ap related city names */
SELECT c.cname FROM State s INNER JOIN City c ON s.sid = c.sid WHERE s.sname IN ('Telangana', 'AP');

/* w.a.q. to display all city names in Telangana state */
SELECT c.cname FROM State s INNER JOIN City c ON s.sid = c.sid WHERE s.sname = 'Telangana';