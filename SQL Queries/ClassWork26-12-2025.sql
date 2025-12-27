/* Index in SQL:

	--> Indexing is used to make the data in order.
	--> With indexing, it is easier to get the data faster.
	--> There are 2 types of indecees in SQL:
		i. Clustered Index / Primary Index
		ii. Non-Clustered Index / Secondary Index
	
	i.Clustered Index:
		-> Any field that has constrains 'Primary Key', then the field is by default included into clustered index.
	
	ii. Non-Clustered Index:
		-> All the fields except 'PRIMARY' Indexes are called Non-Clustered Indeces.

	Syntax:

		CREATE INDEX <INDEX_NAME> ON <TABLE_NAME>(<COLUMN_NAME>);

		To delete index: DROP INDEX <INDEX_NAME>;
*/

CREATE DATABASE CLASSWORK_26_12_2025;

USE CLASSWORK_26_12_2025;

CREATE TABLE Emp(
	eid INT PRIMARY KEY, -- It is a clustered index
	ename VARCHAR(20),
	gender CHAR CHECK(gender IN ('M','F','O')),
	salary MONEY,
	dno INT
);

CREATE INDEX enameIndex ON Emp(ename);

CREATE PROCEDURE sp_insert_emp(@eid INT, @ename VARCHAR(20), @gender CHAR, @salary MONEY, @dno INT)
AS BEGIN
	INSERT INTO Emp VALUES (@eid, @ename, @gender, @salary, @dno);
END;

EXEC sp_insert_emp 101,'Prasad','M',65000, 10; 
EXEC sp_insert_emp 102,'Vamshi','M',60000, 20; 
EXEC sp_insert_emp 103,'Abhishek','M',55000, 30; 
EXEC sp_insert_emp 104,'Hari','M',70000, 10; 
EXEC sp_insert_emp 105,'Abhilash','M',80000, 30; 
EXEC sp_insert_emp 106,'Kiran','M',90000, 20; 

SELECT ename FROM Emp;


/* Views:
	--> Views are logical tables created based on the base tables.
	--> The purpose of the views is to hide the unnecessary data from the user.
	
		Syntax: CREATE VIEW <VIEW_NAME> AS SELECT COL_1,COL_2,...COL_N FROM <TABLE_NAME>;

		Execution: SELECT * FROM <VIEW_NAME>;

	Data Manipulation Language(DML) operations on view:
		
		i. Delete
		
			Syntax: DELETE FROM <VIEW_NAME> WHERE eid = 102;

			Rules to delete records from views:
				-> View must not contain 'Aggregation functions' or 'Grouping Functions'.
				-> Views Must not contain any 'GROUP BY' clause.
				-> Views must not contain any 'DISTINCT' clause.

		ii. Update
			
			Syntax: UPDATE <VIEW_NAME> SET ENAME = 'Sandeep' WHERE <CONDITION>
		
			Rules to update records from views:
				-> View must not contain 'Aggregation functions' or 'Grouping Functions'.
				-> Views Must not contain any 'GROUP BY' clause.
				-> Views must not contain any 'DISTINCT' clause.
				-> Views must not contain any columns that are derived from an expression.

		iii. Insert

			Syntax: INSERT INTO <VIEW_NAME> VALUES (<VALUES...>);

			Rules to insert records through views:
				-> View must not contain 'Aggregation functions' or 'Grouping Functions'.
				-> Views Must not contain any 'GROUP BY' clause.
				-> Views must not contain any 'DISTINCT' clause.
				-> Views must not contain any columns that are derived from an expression.
				-> Base tables must not contain any NOT NULL constrained columns that are not derived in the view.
	
	NOTE: ANY DML OPERATIONS PERFORMED ON VIEWS ARE REFLECTED TO ORIGINAL/BASE TABLES
*/

CREATE VIEW view_emp AS SELECT eid, ename,gender,salary FROM Emp;

DROP VIEW view_emp;

SELECT * FROM view_emp;

SELECT * FROM Emp;

INSERT INTO view_emp VALUES (107, 'Ramesh', 'M', 35000);

UPDATE view_emp SET ename = 'Srikanth' WHERE eid = 107;

DELETE FROM view_emp WHERE eid = 102;