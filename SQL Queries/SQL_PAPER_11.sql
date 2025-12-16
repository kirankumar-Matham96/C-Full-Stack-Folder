CREATE DATABASE SQL_PAPER_11;

USE SQL_PAPER_11;

CREATE PROCEDURE sp_drop_course
AS BEGIN
	DROP TABLE Course;
END;

CREATE PROCEDURE sp_drop_student
AS BEGIN
	DROP TABLE Student;
END;

/* 4Q: Create tables Course and Student */
/*
	EXEC sp_drop_course;
	EXEC sp_drop_student;
*/
CREATE TABLE Course(
	cid VARCHAR(10) PRIMARY KEY,
	cname VARCHAR(20) NOT NULL,
	fee MONEY NOT NULL
);

CREATE TABLE Student(
	sid INT PRIMARY KEY,
	sname VARCHAR(20) NOT NULL,
	gender CHAR CHECK(gender IN ('M', 'F', 'O')),
	cid VARCHAR(10) REFERENCES Course(cid)
);


/* 5Q: Insert data into tables */
CREATE PROCEDURE sp_cinsert(@id VARCHAR(10), @name VARCHAR(20), @fee MONEY)
AS BEGIN
	INSERT INTO Course(cid, cname, fee) VALUES (@id, @name, @fee);
END;

CREATE PROCEDURE sp_sinsert(@id INT, @name VARCHAR(20), @gender CHAR, @cid VARCHAR(10))
AS BEGIN
	INSERT INTO Student(sid, sname, gender, cid) VALUES (@id, @name, @gender, @cid);
END;

EXEC sp_cinsert 'c1', 'Python', 25000.0;
EXEC sp_cinsert 'c2', 'jAVA', 30000.0;
EXEC sp_cinsert 'c3', '.Net', 35000.0;
EXEC sp_sinsert 101, 'Sana', 'F', 'c1';
EXEC sp_sinsert 102, 'Naira', 'F', 'c3';
EXEC sp_sinsert 103, 'Riyaan', 'M', 'c1';

CREATE PROCEDURE sp_display_all
AS BEGIN
	SELECT * FROM Course;
	SELECT * FROM Student;
END;

EXEC sp_display_all;

/* 6Q: w.a.q to display sid, sname, and gender */
SELECT sid, sname, gender FROM Student;

/* 7Q: w.a.q. to display sid, sname, and cid */
SELECT sid,sname,cid FROM Student;

/* 8Q: w.a.q. to display 103 student course details */
SELECT c.* FROM Student s, Course c
WHERE s.cid = c.cid AND s.sid = 103;

/* 9Q: w.a.q. to display sid, sname, cid, cname */
SELECT s.sid, s.sname, c.cid, c.cname FROM Student s, Course c
WHERE s.cid = c.cid;

/* 10Q: w.a.q. to display python student details */
SELECT s.* FROM Student s, Course c
WHERE s.cid = c.cid AND c.cname = 'Python';

/* 11Q: w.a.q. to display all students in Python */
SELECT s.sid, s.sname FROM Student s, Course c
WHERE s.cid = c.cid AND c.cname = 'Python';

/* 12Q: w.a.q. to display python course and students information */
SELECT c.cname, s.* FROM Student s, Course c
WHERE s.cid = c.cid AND c.cname = 'Python';

/* 13 + 14 Q: w.a.q. to create State and City tables */
CREATE TABLE State(
	sid INT PRIMARY KEY,
	sname VARCHAR(20) UNIQUE
);

CREATE TABLE City(
	cid INT PRIMARY KEY,
	cname VARCHAR(50) NOT NULL,
	sid INT REFERENCES State(sid)
);

/* 15Q: w.a.q. to insert 5 records in State and City Tables */
INSERT INTO State(sid, sname) VALUES
(101, 'Telangana'),
(102, 'Andhra Pradesh'),
(103, 'Maharastra'),
(104, 'Kerala'),
(105, 'Madhya Pradesh');

INSERT INTO City VALUES
(1001, 'Hyderabad', 101),
(1002, 'Pune', 103),
(1003, 'Visag', 102),
(1004, 'Thiruvananthapuram', 104),
(1005, 'Jabalpur', 105),
(1006, 'Sicinderabad', 101);

SELECT * FROM State;
SELECT * FROM City;

/* 16Q: Display city id, city name, state id */
SELECT cid, cname, sid FROM City;

/* 17Q: w.a.q. to create department table with did, dname, employee table with eid, ename, gender, salary, dob and did */
CREATE TABLE Dept(
	did INT PRIMARY KEY,
	dname VARCHAR(20)
);
CREATE TABLE Emp(
	eid INT PRIMARY KEY, 
	ename VARCHAR(20),
	gender CHAR CHECK(gender IN ('M', 'F', 'O')),
	salary MONEY,
	did INT REFERENCES Dept(did)
);

/* 18Q: w.a.q. to insert 5 records */
INSERT INTO Dept VALUES
(10, 'IT'),
(20, 'HR'),
(30, 'DS'),
(40, 'DA'),
(50, 'QA');

INSERT INTO Emp VALUES
(1111, 'Vamshi', 'M', 68000.0, 30),
(1112, 'Veena', 'F', 50000.0, 20),
(1113, 'Shrujana', 'F', 45000.0, 30),
(1114, 'Sundaram', 'M', 36000.0, 10),
(1115, 'Sunil', 'M', 60000.0, 50);


/* 19Q: w.a.q. to display all dept info */
SELECT * FROM Dept;

/* 20Q: w.a.q. to display all emp info */
SELECT * FROM Emp;

