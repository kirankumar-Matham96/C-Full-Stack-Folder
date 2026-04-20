CREATE DATABASE EMPLOYEE_WITH_JQUERY_DB;

USE EMPLOYEE_WITH_JQUERY_DB;

CREATE TABLE Employee(
	id INT PRIMARY KEY,
	name VARCHAR(MAX),
	salary MONEY
);

CREATE PROCEDURE sp_insert_employee (@id INT, @name VARCHAR(MAX), @salary MONEY)
AS BEGIN
    INSERT INTO Employee VALUES (@id, @name, @salary)
END;

EXEC sp_insert_employee 101,'Vinay',68122.23;
EXEC sp_insert_employee 102,'Raju',55000.00;
EXEC sp_insert_employee 103,'Priya',52000.00;
EXEC sp_insert_employee 104,'Samanth',65000.00;
EXEC sp_insert_employee 105,'Hruday',42000.00;

SELECT * FROM Employee;

