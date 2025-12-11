/* Creating db */
CREATE DATABASE SQL_PAPER_8;

/* Using DB */
USE SQL_PAPER_8;

/* Creating table */
CREATE TABLE Orders(
	CustId INT PRIMARY KEY,
	OrderId INT NOT NULL,
	OrderDate DATE NOT NULL,
	Amt MONEY NOT NULL,
	PayMode VARCHAR(15) NOT NULL, 
	Status VARCHAR(15) NOT NULL
);

/* Inserting data */
INSERT INTO Orders VALUES 
(101, 1122, '2024-12-17', 2500, 'PhonePay', 'Processing'),
(112, 1219, '2025-01-01', 7900, 'Cash', 'Complete'),
(132, 1317, '2024-02-07', 5400, 'GPay', 'Processing'),
(176, 1714, '2025-02-28', 3800, 'Cash', 'Complete');

/* Query to dsiplay all data */
SELECT * FROM Orders;

/* Query to display all orders where payment mode is 'Cash' */
SELECT * FROM Orders WHERE PayMode = 'Cash';

/* Query to display all orders whose status is 'Processing' */
SELECT * FROM Orders WHERE Status = 'Processing';

/* Query to display total sales amount */
SELECT COUNT(Amt) AS 'Total Sales Amount' FROM Orders;

/* Query to display total amount received where payment mode is 'PhonePay' */
SELECT SUM(Amt) AS 'Total Amt by PhonePay' FROM Orders WHERE PayMode = 'PhonePay';

/* Query to display total items which are not yet delivered */
SELECT COUNT(*) AS 'Total Pending Items' FROM Orders WHERE Status != 'Cmpleted';