CREATE DATABASE CLASS5;

USE CLASS5;

CREATE TABLE Orders(
	CustId INT PRIMARY KEY NOT NULL,
	OrderId INT NOT NULL,
	OrderDate DATE NOT NULL,
	Amount MONEY NOT NULL,
	PaymentMode VARCHAR(250) NOT NULL,
	Status VARCHAR(200) NOT NULL
);

INSERT INTO Orders VALUES
(101, 1122, '2024-08-08', 2500, 'PhonePay', 'Processing'),
(102, 1564, '2024-07-30', 3600, 'Cash', 'Delivered'),
(103, 1698, '2024-08-08', 1300, 'PhonePay', 'Delivered'),
(104, 1562, '2024-07-30', 6850, 'Cash', 'Processing');

/* Display all data */
SELECT * FROM Orders;

/* Pay method is Cash */
SELECT * FROM Orders WHERE PaymentMode = 'Cash';

/* Status is Processing */
SELECT * FROM Orders WHERE Status = 'Processing';

/* 8th Aug Orders list */
SELECT * FROM Orders WHERE MONTH(OrderDate) = 8;
		/* OR */
SELECT * FROM Orders WHERE OrderDate LIKE '2024-08-%';

/* Total sales amount */
SELECT SUM(Amount) AS 'Total Sales Amount' FROM Orders;

/* Total Amount from PhonePay */
SELECT SUM(Amount) AS 'Total Amount From PhonePay' FROM Orders WHERE PaymentMode = 'PhonePay';

/* Count of items not yet delivered */
SELECT COUNT(*) AS 'Orders Not Delivered' FROM Orders WHERE Status != 'Delivered';


/* TASK - 2 */

/* Create Emp table */
CREATE TABLE Emp(
	eid INT PRIMARY KEY NOT NULL,
	ename VARCHAR(255) NOT NULL,
	gender CHAR,
	sal MONEY,
	deptid INT NOT NULL,
	doj DATE NOT NULL,
	Uname VARCHAR(255) NOT NULL,
	pwd VARCHAR(255) NOT NULL
);

/* Inserting 10 records */
INSERT INTO Emp VALUES 
(101, 'Vishnu', 'M', 50000.0, 3, '2024-OCT-12', 'vishnu', 'viishnu101'),
(102, 'Vaani', 'F', 56000.0, 2, '2024-AUG-16', 'vani', 'vani'),
(103, 'Priyanka', 'F', NULL, 1, '2024-DEC-20', 'priyank101', 'priyank101'),
(104, 'Vishnuvardhan', 'M', 45000.0, 3, '2024-JAN-23', 'vishnu', 'viishnu101'),
(105, 'Prathap', 'M', NULL, 3, '2024-MAR-14', 'prathap', 'prathap'),
(106, 'Maheshwari', 'F', 62000.0, 2, '2024-JAN-02', 'maheshwar', 'maheshwar'),
(107, 'Sathya Sarama', 'M', 35000.0, 3, '2024-FEB-05', 'sarma', 'sathya'),
(108, 'Lekhya', 'F', 290000.0, 3, '2024-JUL-24', 'lekhya123', 'sathya'),
(109, 'Sarma', 'M', 130000.0, 1, '2024-JUN-16', 'sarma', 'sarma123'),
(110, 'Venkat', 'M', 50000.0, 2, '2024-OCT-12', 'venkat235', 'venkat@123'),
(111, 'Ananthaiah', 'M', 34000.0, 1, '2024-OCT-13', 'ananth', 'ananth123');

/* Display all records */
SELECT * FROM Emp;

/* 102 emp info */
SELECT * FROM Emp WHERE eid = 102;

/* display eid, ename, doj */
SELECT eid, ename, doj FROM Emp;

/* emp with no sal */
SELECT * FROM Emp WHERE Sal IS NULL;

/* name starts with a and ends with h */
SELECT * FROM Emp WHERE ename LIKE 'a%h';

/* name that has a */
SELECT * FROM Emp WHERE ename LIKE '%a%';

/* name has 3rd char as s */
SELECT * FROM Emp WHERE ename LIKE '__s%';

/* Total sal */
SELECT SUM(Sal) AS 'Total Salary Paid To Employees' FROM Emp;

/* Max sal */
SELECT MAX(Sal) AS 'Maximum Salary' FROM Emp;

/* Min sal */
SELECT MIN(Sal) AS 'Minimum Salary' FROM Emp;

/* Employees count dept vise */
SELECT deptid, COUNT(*) AS 'Dept Count' FROM Emp GROUP BY deptid;

/* Count of males */
SELECT COUNT(gender) as 'Total Male Employees' FROM Emp GROUP BY gender HAVING gender = 'M';

/* Update salary as 5000 for employees with no sal */
UPDATE Emp SET Sal = 5000.0 WHERE Sal IS NULL;

/* user name as 'Vishnu' */
SELECT * FROM Emp WHERE Uname = 'Vishnu';

/* user name as 'sarma' password as 'sathya' */
SELECT * FROM Emp WHERE Uname = 'sarma' AND pwd = 'sathya';

