CREATE DATABASE CLASSWORK_SQL_10_12_2025;

USE CLASSWORK_SQL_10_12_2025;

CREATE TABLE Dept(
	dno INT PRIMARY KEY,
	dname VARCHAR(20) NOT NULL
);

CREATE TABLE Emp(
	eid INT PRIMARY KEY,
	ename VARCHAR(20) NOT NULL,
	sal MONEY NOT NULL,
	did INT REFERENCES Dept(dno)
);

INSERT INTO Dept VALUES
(10, 'HR'),
(20, 'Developer'),
(30, 'Testing'),
(40, 'DA');

INSERT INTO Emp VALUES
(101, 'Vishnu', 40000.0, 10),
(102, 'Vamsi', 30000.0, 10),
(103, 'Varun', 25000.0, 30),
(104, 'Varma', 65000.0, 30),
(105, 'Avinash', 38000.0, 20),
(106, 'Sarayu', 42000.0, 20);



/* Emp info */
select * from Emp;

/* Dept info */
select * from Dept;

/* display eid, ename, dno, dname */
SELECT e.eid, e.ename, d.dno, d.dname FROM Emp e INNER JOIN Dept d ON e.did = d.dno;

/* display all emp data who belongs to Developer department */
SELECT e.* FROM Emp e INNER JOIN Dept d ON e.did = d.dno WHERE d.dname = 'Developer';

/* display emp info who belongs to HR dept and name starts with v */
SELECT e.* FROM Emp e INNER JOIN Dept d ON e.did = d.dno WHERE d.dname = 'HR' AND e.ename LIKE 'V%';

/* display hr/tester dept data whos employees have more than 30000 sal */
SELECT d.* FROM Emp e INNER JOIN Dept d ON e.did = d.dno WHERE (d.dname = 'HR' OR d.dname = 'Testing') AND e.sal > 30000;

/* display all emp info, dname whose name starts with 's' and ends with 'u' and should belongs to testing dept */
SELECT e.*, d.dname FROM Emp e INNER JOIN Dept d ON e.did = d.dno WHERE e.ename LIKE 's%u' AND d.dname = 'Testing';
