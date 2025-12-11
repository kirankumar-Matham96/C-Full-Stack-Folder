/* Creating DB */
CREATE DATABASE SQL_PAPER_9;

/* Using DB */
USE SQL_PAPER_9;

/* Creating Courses table */
CREATE TABLE Courses(
	cid INT PRIMARY KEY,
	cname VARCHAR(10) NOT NULL,
	fee MONEY NOT NULL,
	duration INT NOT NULL,
	startingDate DATE NOT NULL,
	tname VARCHAR(10) DEFAULT 'KANNA BABU'
);

/* Inserting data into Courses table */
INSERT INTO Courses VALUES
(101, 'Java', 50000.0, 5, '2025-12-01', 'Chandu'),
(102, '.Net', 50000.0, 5, '2025-12-01', 'Venkat'),
(103, 'OOPs', 10000.0, 1, '2025-12-01', 'Kannababu'),
(104, 'Python', 5000.0, 5, '2025-12-01', 'Venkat'),
(105, 'C', 5000.0, 2, '2026-01-05', 'Chandu');

/* Displaying all courses data */
select * from Courses;

/* Creating Students table */
CREATE TABLE Students(
	sid INT PRIMARY KEY,
	sname VARCHAR(10) NOT NULL,
	gender CHAR CHECK(gender IN ('M', 'F', 'O')),
	qualification VARCHAR(10) NOT NULL,
	cid INT FOREIGN KEY REFERENCES Courses(cid),
	PStatus VARCHAR(10) NOT NULL
);

/* Inserting data into Students table */
INSERT INTO Students VALUES
(1101, 'Akshara', 'F', 'B.Tech', 101, 'Success'),
(1102, 'Baalu', 'M', 'B.Sc', 103, 'Pending'),
(1103, 'Ambika', 'F', 'B.Tech', 104, 'Pending'),
(1104, 'Karan', 'M', 'M.Tech', 102, 'Success'),
(1105, 'Nalini', 'F', 'MCA', 101, 'Success'),
(1106, 'Indira', 'F', 'B.Tech', 102, 'Success'),
(1107, 'Aakash', 'M', 'B.Tech', 103, 'Pending'),
(1108, 'Sharada', 'F', 'B.Sc', 104, 'Success');

/* Displaying all students info */
SELECT * FROM Students;

/* Queryto display course vise students count */
SELECT cname, COUNT(*) AS 'Students Enrolled' FROM Students s JOIN Courses c ON s.cid = c.cid GROUP BY c.cname;
