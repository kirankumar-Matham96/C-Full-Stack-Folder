CREATE DATABASE CLASS09_12_2025;

USE CLASS09_12_2025;

/*
	DROP TABLE Course;
	DROP TABLE Student;
*/

CREATE TABLE Course(
	cid VARCHAR(10) PRIMARY KEY,
	cname VARCHAR(10) NOT NULL UNIQUE,
	fee MONEY NOT NULL,
	tname VARCHAR(10) NOT NULL
);

CREATE TABLE Student(
	sid INT PRIMARY KEY,
	sname VARCHAR(10) NOT NULL,
	gender CHAR CHECK(gender IN ('M','F','O')),
	s1 INT NOT NULL CHECK(s1 <= 100 AND s1 >= 0),
	s2 INT NOT NULL CHECK(s2 <= 100 AND s2 >= 0),
	s3 INT NOT NULL CHECK(s3 <= 100 AND s3 >= 0),
	total INT DEFAULT 0,
	cid VARCHAR(10) REFERENCES Course(cid),
	srank CHAR DEFAULT NULL,
	extraSub VARCHAR(10) DEFAULT 'PowerBI'
);

SELECT * FROM Course;
SELECT * FROM Student;

INSERT INTO Course VALUES
('c1', 'Java', 50000.0, 'Kannababu'),
('c2', '.Net', 50000.0, 'Venkat'),
('c3', 'Python', 20000.0, 'Venkat');

INSERT INTO Student VALUES
(101, 'Tharun', 'M', 65, 85, 45, NULL, 'c1', NULL, 'SQL'),
(102, 'Varun', 'M', 70, 82, 30, NULL, 'c2', NULL, ''),
(103, 'Girija', 'F', 23, 30, 32, NULL, 'c3', NULL, 'SQL'),
(104, 'Ananth', 'M', 56, 90, 95, NULL, 'c1', NULL, ''),
(105, 'Thamanna', 'F', 65, 45, 59, NULL, 'c3', NULL, 'SQL'),
(106, 'Annapurna', 'F', 90, 49, 61, NULL, 'c1', NULL, 'SQL');

UPDATE Student SET total = s1+s2+s3;

SELECT MAX(s1) AS 'Maximum Marks in S1' FROM Student;
SELECT MIN(s1) AS 'Minimum Marks in S1' FROM Student;

SELECT fee FROM Course WHERE cname = '.Net';

UPDATE Student SET s2 = 84 WHERE sid = 103;

SELECT sid,sname FROM Student WHERE s3 < 35;

SELECT * FROM Student WHERE s1 < 35 OR s2 < 35 OR s3 < 35;

SELECT cid, COUNT(sid) AS 'No of Students' FROM Student GROUP BY cid;

SELECT COUNT(sid) AS 'No of Student enrolled in c1' FROM Student WHERE gender = 'M' AND cid = 'c1';

UPDATE Student SET s1 = 91 WHERE sname = 'Annapurna';

SELECT * FROM Student WHERE (s1 > 90 OR s2 > 90 OR s3 > 90);

SELECT COUNT(*) AS 'Failed Students' FROM Student WHERE s1 < 35;



/* Task 2 */

CREATE TABLE Dept(
	did INT PRIMARY KEY,
	dname VARCHAR(10) NOT NULL UNIQUE
);

CREATE TABLE Emp(
	eid INT PRIMARY KEY,
	ename VARCHAR(10) NOT NULL,
	sal MONEY NOT NULL,
	did INT FOREIGN KEY REFERENCES Dept(did),
);

CREATE TABLE State(
	stateId INT PRIMARY KEY,
	stateName VARCHAR(10) NOT NULL
);

CREATE TABLE City(
	cityId INT PRIMARY KEY,
	cityName VARCHAR(10),
	stateId INT FOREIGN KEY REFERENCES State(stateId)
);

CREATE TABLE Items(
	ItemId INT PRIMARY KEY,
	ItemName VARCHAR(10) NOT NULL UNIQUE,
	Cost MONEY NOT NULL
);

CREATE TABLE Customer(
	CustId INT PRIMARY KEY,
	CustName VARCHAR(10) NOT NULL,
	Gender CHAR CHECK(Gender IN ('M','F','O'))
);

CREATE TABLE Orders(
	OrderId INT PRIMARY KEY,
	ItemsId INT FOREIGN KEY REFERENCES Items(ItemId),
	CustId INT FOREIGN KEY REFERENCES Customer(CustId),
	DateOfOrder DATE NOT NULL,
	Status VARCHAR(10) CHECK(Status IN ('Processing', 'Completed'))
);

