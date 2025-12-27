/* User Defined Functions:
	--> Any function that is created by the user according to the requirements.

		Syntax: 
			
			For single value returning function:
	
				```
				CREATE FUNCTION <FUNCTION_NAME> RETURNS <RETURN_TYPE(NUMERIC, VARCHAR, INT, DECIMAL, TABLE, ...)>
				AS BEGIN
					// LOGIC OR STATMENTS...
					RETURN(<RETURN_VALUE	
				END;
				```

			For an entire row returning function

				```
				CREATE FUNCTION <FUNCTION_NAME> RETURNS TABLE
				AS
					RETURN(SELECT * FROM <TABLE_NAME>);
				```
		Execution: 
			i. If the function returns a single value/column:
		
				```
				SELECT DBO.<FUNCTION_NAME>(<INPUT>) AS <COLUMN_ALIAS_NAME>;
				```
			
			ii. If the function returns an entire record/table:
				
				```
				SELECT * FROM dbo.<FUNCTION_NAME>(<INPUT>);
				```
*/

CREATE DATABASE CLASSWORK_29_12_2025;
USE CLASSWORK_29_12_2025;

CREATE TABLE Student(
	sid INT PRIMARY KEY,
	sname VARCHAR(20),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE
);

CREATE PROCEDURE sp_insert_student(@id INT, @name VARCHAR(20), @gender CHAR, @dob DATE)
AS BEGIN
	INSERT INTO Student VALUES(@id, @name, @gender, @dob);
END;

EXEC sp_insert_student 1001,'Mahesh', 'M', '12-05-1997';
EXEC sp_insert_student 1002,'Radha', 'F', '12-05-1996';
EXEC sp_insert_student 1003,'Saritha', 'F', '12-05-1995';
EXEC sp_insert_student 1004,'Harish', 'M', '12-05-1998';
EXEC sp_insert_student 1005,'Vivek', 'M', '12-05-1997';
EXEC sp_insert_student 1006,'Nandini', 'F', '12-05-1996';
EXEC sp_insert_student 1007,'Ganesh', 'M', '12-05-1995';
EXEC sp_insert_student 1008,'Lavanya', 'F', '12-05-1998';
EXEC sp_insert_student 1009,'Enkamma', 'F', '12-05-1999';
EXEC sp_insert_student 1010,'Enkaiah', 'M', '12-05-2000';

CREATE FUNCTION func_getAge(@id INT) RETURNS INT
AS BEGIN
	DECLARE @age INT;
	SELECT @age = (SELECT YEAR(GETDATE()) - YEAR(dob)) FROM Student WHERE sid = @id;
	RETURN(@age);
END;

SELECT dbo.func_getAge(1001) AS 'Age';

CREATE PROCEDURE sp_getAges_student(@sid INT)
AS BEGIN
	SELECT dbo.func_getAge(@sid) AS 'Age';
END;

EXEC sp_getAges_student 1002;

CREATE FUNCTION func_getRecords_student(@id INT) RETURNS TABLE
AS
	RETURN(SELECT sid,sname, gender, dob FROM Student WHERE sid = @id);


SELECT * FROM dbo.func_getRecords_student(1002);
