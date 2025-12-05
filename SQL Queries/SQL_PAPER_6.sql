CREATE DATABASE BANK;

USE BANK

/* DROP TABLE Transactions; */

CREATE TABLE Transactions(
	TransactionId INT PRIMARY KEY NOT NULL,
	AccountNo BIGINT NOT NULL,
	TransactionType VARCHAR(100) NULL,
	Amount MONEY NOT NULL,
	TrnsactionDate DATE NULL
);

INSERT INTO Transactions VALUES 
(1001, 9856745892, 'Deposite', 5000.00, '2024-02-15'),
(1002, 5894567859, 'Withdraw', 2000.00, '2024-02-18'),
(1003, 5214630256, 'Deposite', 7000.00, '2024-02-20'),
(1004, 2520210236, 'Withdraw', 3000.00, '2024-02-22');

/* Displaying all data */
SELECT * FROM Transactions;

/* Modifying data */
UPDATE Transactions SET Amount = 10000.00 WHERE TransactionId = 1002;

/* Query to remove record with id 1003 */
DELETE FROM Transactions WHERE TransactionId = 1003;

/* Modifying amount for 1001 */
UPDATE Transactions SET Amount = 6000.0 WHERE TransactionId = 1001;

/* Inserting new record with id 1005 */
INSERT INTO Transactions VALUES (1005, 2520210569, 'Deposite', 3000.00, '2024-02-23');

/* Inserting only id, accoun, amount */
INSERT INTO Transactions(TransactionId, AccountNo, Amount) VALUES (1006, 7845986523, 8500.00);

/* Deleting 1004 record */
DELETE FROM Transactions WHERE TransactionId = 1004;

CREATE TABLE Employee(
	Eid INT PRIMARY KEY NOT NULL,
	Ename VARCHAR(255) NOT NULL,
	Gender CHAR NOT NULL,
	Salary MONEY NOT NULL,
	AnnualSal MONEY NULL,
	Dno INT NOT NULL
);

INSERT INTO Employee(Eid, Ename, Gender, Salary, Dno) VALUES
(101, 'Nivitha', 'F', 47000.0, 10),
(102, 'Sanjay', 'M', 56000.0, 20),
(103, 'Hyshika', 'F', 34000.0, 10);

UPDATE Employee SET AnnualSal = Salary * 12;

SELECT * FROM Employee;

SELECT Eid, AnnualSal, AnnualSal*15/100 AS HikeAmount FROM Employee;

SELECT * FROM Employee WHERE Salary < 50000.0;

SELECT * FROM Employee WHERE Dno != 20;

SELECT * FROM Employee WHERE Gender = 'F';

UPDATE Employee SET Salary = 60000.0 WHERE Eid = 102;

SELECT * FROM Employee WHERE Gender = 'M';

SELECT * FROM Employee WHERE Dno = 20;