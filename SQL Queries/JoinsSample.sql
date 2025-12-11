/* Creating data base */
CREATE DATABASE JOINS;

/* Using database */
USE JOINS;

/* Creating table */
CREATE TABLE Courses(
	cid INT PRIMARY KEY,
	cname VARCHAR(255) NOT NULL,
	fee MONEY NOT NULL,
	durationInMonths INT NOT NULL, 
	startDate DATE NULL
);

/* Inserting data */
INSERT INTO Courses VALUES
(101, 'Java', 5000.00, 3, '12-DEC-2025'),
(102, 'Python', 3000.00, 1, '12-DEC-2025'),
(103, '.Net', 5000.00, 3, '12-DEC-2025'),
(104, 'Devops', 4000.00, 3, '23-DEC-2025'),
(105, 'Cyber Security', 10000.00, 5, '03-JAN-2026'),
(106, 'React', 10000.00, 1, '15-MAY-2026'),
(107, 'Angular', 10000.00, 2, '15-MAY-2026'),
(108, 'ASP.Net', 10000.00, 1, '01-JUN-2026'),
(109, 'Html', 1000.00, 1, '01-MAR-2026'),
(110, 'CSS', 1000.00, 1, '01-APR-2026'),
(111, 'JavaScript', 3000.00, 2, '01-MAY-2026');

/* Displaying data in first table */
SELECT * FROM Courses;


/*
DROP TABLE Students; 
*/

/* Creating table */
CREATE TABLE Students(
	sid INT PRIMARY KEY,
	fname VARCHAR(255) NOT NULL,
	lname VARCHAR(255) NOT NULL,
	sname VARCHAR(255) NULL,
	gender CHAR NOT NULL,
	qualification VARCHAR(200) NOT NULL,
	userName VARCHAR(255) NULL,
	cid INT FOREIGN KEY REFERENCES Courses(cid),
	paymentStatus VARCHAR(100) NOT NULL
);


/* Inserting data */
INSERT INTO Students(sid, fname, lname, gender, qualification, cid, paymentStatus) VALUES
(1001, 'Laxman', 'Mandori', 'M', 'B.Tech',  102, 'Pending'),
(1002, 'Pavan', 'Kakutla', 'M', 'B.Tech',  101, 'Success'),
(1003, 'Vidya', 'Lingutla', 'F', 'B.Sc',  103, 'Success'),
(1004, 'Prasanna', 'Devuri', 'F', 'B.Tech',  104, 'Pending'),
(1005, 'Lalitha', 'Palle', 'F', 'B.Sc',  105, 'Pending'),
(1006, 'Kishor', 'Yelluri', 'M', 'B.Tech',  106, 'Success'),
(1007, 'Madhu', 'Mudigonda', 'M', 'M.Tech',  107, 'Pending'),
(1008, 'Venkatesh', 'Sakinala', 'M', 'MCA',  108, 'Success'),
(1009, 'Vaani', 'Rajarla', 'F', 'M.Sc',  101, 'Pending'),
(1010, 'Naresh', 'Kavuri', 'M', 'MCA',  101, 'Success'),
(1011, 'Deepika', 'Velakatla', 'F', 'B.Tech',  103, 'Success'),
(1012, 'Sunil', 'Bommidaila', 'M', 'B.Tech',  103, 'Pending'),
(1013, 'Mahesh', 'Kotha', 'M', 'B.Tech',  102, 'Pending'),
(1014, 'Divya', 'Pinjurli', 'F', 'B.Sc',  102, 'Success'),
(1015, 'Raghava', 'Komatla', 'M', 'B.Sc',  106, 'Success'),
(1016, 'Yogesh', 'Devulapalli', 'M', 'M.Tech',  105, 'Success');

/* Displaying data */
SELECT * FROM Students;

/* Updating Students Table */
UPDATE Students SET sname = fname+' '+lname, userName = LOWER(fname+'-'+lname+'-'+CAST(cid AS VARCHAR(150)));


/* ===================================== QUERIES ===================================== */

/* Display all the data from Courses and Students tables */
SELECT * FROM Courses JOIN Students ON Courses.cid = Students.cid;

/* Display all data of the female students */
SELECT * FROM Courses JOIN Students ON Courses.cid = Students.cid WHERE gender = 'F';

/* Display full name, user name, qualification, course name of the male students */
SELECT
	sname AS 'Full Name',
	userName AS 'User Name',
	qualification AS Qualification,
	Students.cid as 'Course ID'
FROM 
	Courses JOIN Students ON Courses.cid = Students.cid
WHERE gender = 'M';

/* Display maximum fee */
SELECT MAX(fee) AS 'Max Fee' FROM Courses;

/* Display minimum fee */
SELECT MIN(fee) AS 'Max Fee' FROM Courses;

/* Display students details, who did not complete their payments */
SELECT * FROM Students WHERE paymentStatus != 'Success';

/* Display students details, who completed their payments */
SELECT * FROM Students WHERE paymentStatus = 'Success';

/* Display total number of courses available */
SELECT COUNT(cid) AS 'Total Courses Available' FROM Courses;

/* Display maximum duration course */
SELECT MAX(durationInMonths) AS 'Maximum Duration' FROM Courses;

/* Display all students data in alphabetical order of their first name in descending order */
SELECT * FROM Students ORDER BY fname DESC;

/* Display all students data in alphabetical order of their last name in ascending order */
SELECT * FROM Students ORDER BY lname;

/* Display total number of male and female studets that enrolled in Java in descending order of the students count */
SELECT gender, COUNT(gender) AS 'Total No of Students' FROM Students WHERE cid = 101 GROUP BY gender ORDER BY 'Total No of Students' DESC;

/* Display top 3 popular courses */
SELECT
	TOP 3 c.cid, cname AS 'Course Name',
	COUNT(s.sid) AS 'Students Count'
FROM
	Courses c JOIN Students s ON c.cid = s.cid
GROUP BY cname,c.cid
ORDER BY 'Students Count' DESC;

/* Display number of students enrolled in each course */
SELECT
	c.cid as 'Course ID',
	cname AS 'Course Name',
	COUNT(s.sid) AS 'Studnets Count'
FROM 
	Courses c JOIN Students s ON c.cid = s.cid 
GROUP BY c.cid, cname
ORDER BY 'Studnets Count' DESC;