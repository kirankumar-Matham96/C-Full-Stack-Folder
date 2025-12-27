CREATE DATABASE PRACTICE_DB;

USE PRACTICE_DB;

/* 1Q:
	--> Create Students table with sid, sname, gender, english, maths, science, social, total, average, rank
	--> Create Top3Students table with tsid, sid, totalMarks, averageMarks, rank
	--> Create a trigger that calculate the total marks and average marks on record entry.
	--> Create a trigger to insert top 3 students into Top3Students table when a student record is inserted into Students table
	--> NOTE: use stored procedures to insert data into tables
*/

CREATE TABLE Students(
	sid INT PRIMARY KEY,
	sname VARCHAR(20),
	gender CHAR CHECK(gender IN ('M','F','O')),
	english INT CHECK(english BETWEEN 0 AND 100),
	maths INT CHECK(maths BETWEEN 0 AND 100),
	science INT CHECK(science BETWEEN 0 AND 100),
	social INT CHECK(science BETWEEN 0 AND 100),
	total INT,
	average DECIMAL(10,2),
	rank CHAR CHECK(rank IN ('A','B','C','D','F'))
);

CREATE TABLE Top3Students(
	tsid INT PRIMARY KEY,
	sid INT FOREIGN KEY REFERENCES Students(sid) NOT NULL,
	totalMarks INT DEFAULT 0,
	averageMarks DECIMAL(10,2) DEFAULT 0.0,
	rank CHAR CHECK(rank IN ('A','B'))
);

CREATE PROCEDURE sp_insert_student(@id INT, @sname VARCHAR(20),@gender CHAR,@english INT,@maths INT,@science INT,@social INT)
AS BEGIN
	INSERT INTO Students(sid, sname, gender,english, maths, science, social) VALUES (@id, @sname,@gender,@english,@maths,@science,@social)
END;

--CREATE TRIGGER 
