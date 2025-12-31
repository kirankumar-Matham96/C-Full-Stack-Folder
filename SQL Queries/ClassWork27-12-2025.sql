CREATE DATABASE CLASSWORK_SQL_27_12_2025;

USE CLASSWORK_SQL_27_12_2025;

/* CURSORS:
	-> Cursor is a temporary memory
	-> SQL Server will allocate cursors when performing DML operations
	-> User can allocate them when ever need them
	-> Normally SQL works on sets(all together)
	-> Cusrsors work row-by-row

	-> There are 2 types of cursors:

		1. Implecit Cursors:
			--> Allocated by SQL Server.	
			--> They are also known as Default Cursors
		2. Explicit Cursors:
			--> Allocated by the user when needed
			--> Also known as Named Cursors
			--> We only work with these cursors only

		SYNTAXES:
			
			Creating Syntax:
				```
				DECLARE <CURSOR_NAME> CURSOR FOR SELECT * FROM <TABLE_NAME>
				```
				Note: Using this syntax we can create a cursor. But this cursor can only fetch the data in forward direction only.
			
				So, we have another form:

				```
				DECLARE <CURSOR_NAME> CURSOR STATIC FOR SELECT * FROM <TABLE_NAME>
				```
				Note: With this statis cursor, we can fetch any record.

			Opening Cursor syntax:
				```
				OPEN <CURSOR_NAME>
				```
			Fetching Syntax:
				
				To fetch records using cursors, we have 6 ways:
					
					1. FIRST
						Syntax:

							```
							FETCH FIRST FROM <CURSOR_NAME>
							```

					2. LAST
						Syntax:

							```
							FETCH LAST FROM <CURSOR_NAME>
							```

					3. NEXT
						Syntax:

							```
							FETCH NEXT FROM <CURSOR_NAME>
							```

					4. PRIOR
						Syntax:

							```
							FETCH PRIOR FROM <CURSOR_NAME>
							```

					5. ABSOLUTEn
						Syntax:

							```
							FETCH ABSOLUTE <ROW_NUM> FROM <CURSOR_NAME>
							```

					6. RELATIVEn
						Syntax:

							```
							FETCH RELATIVE <RELATIVE_ROW_NUM> FROM <CURSOR_NAME>
							```
							Note: Here, <RELATIVE_ROW_NUM> can be +ve for forward rows and -ve for prior rows


				Closing Syntax:
					```
					CLOSE <CURSOR_NAME>
					```
				
				Deleting Syntax:
					```
					DEALLOCATE <CURSOR_NAME>
					```
*/

/* 1Q:
	--> Create Student table with columns sid, sname, gender, dob, s1, s2, s3.
	--> Insert data into the table using stored procedure.
	--> Create a cursor on this table.
	--> Using this cursor fetch data of various students records
*/

--Create Student table with columns sid, sname, gender, dob, s1, s2, s3.
CREATE TABLE Student(
	sid INT PRIMARY KEY,
	sname VARCHAR(20),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	s1 INT CHECK(s1 BETWEEN 0 AND 100),
	s2 INT CHECK(s2 BETWEEN 0 AND 100),
	s3 INT CHECK(s3 BETWEEN 0 AND 100)
);

--Insert data into the table using stored procedure.
CREATE PROCEDURE sp_inset_student(@id INT,@name VARCHAR(20),@gender CHAR, @dob DATE, @s1 INT,@s2 INT,@s3 INT)
AS BEGIN
	INSERT INTO Student VALUES (@id,@name,@gender,@dob,@s1,@s2,@s3);
END;

EXEC sp_inset_student 101,'Vidya','F', '12-SEP-2020', 89, 75, 90;
EXEC sp_inset_student 102,'Lavanya','F', '12-SEP-1999', 89, 75, 90;
EXEC sp_inset_student 103,'Vijay','M', '12-SEP-1999', 89, 75, 90;
EXEC sp_inset_student 104,'Madhavi','F', '12-SEP-2021', 89, 75, 90;
EXEC sp_inset_student 105,'Venkat','M', '12-SEP-2020', 89, 75, 90;
EXEC sp_inset_student 106,'Kiran','M', '12-SEP-2021', 89, 75, 90;
EXEC sp_inset_student 107,'Ram','M', '12-SEP-2020', 89, 75, 90;
EXEC sp_inset_student 108,'Ramya','F', '12-SEP-2020', 89, 75, 90;
EXEC sp_inset_student 109,'Manjula','F', '12-SEP-1998', 89, 75, 90;
EXEC sp_inset_student 110,'Saritha','F', '12-SEP-2020', 89, 75, 90;

--Create a cursor on this table.
DECLARE cr_student CURSOR STATIC FOR SELECT sid,sname,gender,dob FROM Student;
OPEN cr_student;

--Using this cursor fetch data of various students records
FETCH FIRST FROM cr_student;
FETCH NEXT FROM cr_student;
FETCH LAST FROM cr_student;
FETCH PRIOR FROM cr_student;
FETCH ABSOLUTE 5 FROM cr_student;
FETCH RELATIVE 5 FROM cr_student;


/* PRE-DEFINED FUNCTIONS:
	-> Functions that are already existing in SQL Server
	-> We have many pre-defined functions
		
		1. Character/String Based Functions:
			
			i. LOWER()
				Syntax: 
					```
					SELECT LOWER(<CHAR_OR_VARCHAR_COLUMN_NAME>) FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT LOWER(<CHAR_OR_STRING>);
					```

			ii. UPPER()
				Syntax:
					```
					SELECT UPPER(<CHAR_OR_VARCHAR_COLUMN_NAME>) FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT UPPER(<CHAR_OR_STRING>);
					```
			
			iii. CONCAT(<STRING1>,<STRING2>)
				Syntax:
					```
					SELECT CONCAT(<VARCHAR_COL1>, <VARCHAR_COL2>) AS '<ALIAS>' FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT CONCAT(<STRING1>, <STRING2>);
					```
			
			iv.	SUBSTRING(<STRING>,<START_INDEX>,<EXCLUSIVE_END_INDEX>)
				Syntax:
					```
					SELECT SUBSTR(<VARCHAR_COL1>,<START_INDEX>,<EXCLUSIVE_END_INDEX>) AS '<ALIAS>' FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT CONCAT(<STRING>, <START_INDEX>, <EXCLUSIVE_END_INDEX>);
					```
			
			v. LEFT(<VARCHAR_COL>,<NUM_OF_CHARACTERS>)
				Syntax:
					```
					SELECT LEFT(<VARCHAR_COL>,<NUM_OF_CHARACTERS>) AS '<ALIAS>' FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT LEFT(<STRING>, <NUM_OF_CHARACTERS>);
					```
			
			vi.	RIGHT()
				Syntax:
					```
					SELECT RIGHT(<VARCHAR_COL>,<NUM_OF_CHARACTERS>) AS '<ALIAS>' FROM <TABLE_NAME>;
					```
					OR

					```
					SELECT RIGHT(<STRING>, <NUM_OF_CHARACTERS>);
					```

			vii. LTRIM()
				Syntax:
					```
					SELECT LTRIM(<VARCHAR_COL>) FROM <TABLE_NAME>
					```
					OR

					```
					SELECT LTRIM(<STRING>);
					```

			viii. RTRIM()
				Syntax:
					```
					SELECT RTRIM(<VARCHAR_COL>) FROM <TABLE_NAME>
					```
					OR

					```
					SELECT RTRIM(<STRING>);
					```
			ix.	TRIM()
				Syntax:
					```
					SELECT TRIM(<VARCHAR_COL>) FROM <TABLE_NAME>
					```
					OR

					```
					SELECT TRIM(<STRING>);
					```
*/

--Display all students names in lower case
SELECT LOWER(sname) AS 'Student''s names in lower case' FROM Student;

--Display all students names in upper case
SELECT UPPER(sname) AS 'Student''s names in upper case' FROM Student;

--Display First characters of student's names
SELECT LEFT(sname, 1) AS 'First character of Student''s name' FROM Student;

--Display last characters of student's names
SELECT RIGHT(sname,1) AS 'Studnet''s name last character' FROM Student;

--Display second to 3rd characters of student's names
SELECT SUBSTRING(sname,2,4) AS 'Student''s name from 2nd char to 3rd char' FROM Student;

--Display student's names with 'std-<studentId>' as suffix
SELECT CONCAT(sname,'-',sid) FROM Student;



