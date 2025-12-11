/* Creating database */
CREATE DATABASE CLASSWORK_SQL_11_12_2025;

/* Using DB */
USE CLASSWORK_SQL_11_12_2025;

/* Dropping tables
	DROP TABLE Students;
	DROP TABLE Payments;
*/

/* Creating Studets table */
CREATE TABLE Students(
	StudentID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Course VARCHAR(30),
	Fee INT CHECK(Fee > 0)
);

/* Creating Payments table */
CREATE TABLE Payments(
	PaymentID INT PRIMARY KEY,
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	AmountPaid INT NOT NULL,
	PaymentDate DATE
);
/* 1. */
/* Inserting the data into Students table */
INSERT INTO Students VALUES
(101, 'Ravi', 'Java', 35000),
(102, 'Jyothi', '.Net', 35000),
(103, 'Shankar', 'Java', 35000),
(104, 'Mohammad', 'Python', 25000),
(105, 'Shabeena', '.Net', 35000),
(106, 'Vamshi', 'Angular', 30000),
(107, 'Aparna', '.Net', 35000),
(108, 'Maheshwari', 'Java', 35000),
(109, 'Preetham', 'React', 30000);

/* Inserting the data into Payments table */
INSERT INTO Payments VALUES
(1001, 104, 10000, '01-NOV-2025'),
(1002, 105, 5000, '01-OCT-2025'),
(1003, 101, 2000, '01-NOV-2025'),
(1004, 102, 15000, '01-DEC-2025'),
(1005, 104, 20000, '25-NOV-2025'),
(1006, 103, 35000, '01-OCT-2025'),
(1007, 101, 22000, '01-DEC-2025'),
(1008, 102, 5000, '15-DEC-2025'),
(1009, 105, 20000, '01-DEC-2025');

/* Displaying all the data from Students and Payments tables individually */
SELECT * FROM Students;
SELECT * FROM Payments;

/* 2. Updating the student course to '.Net' whose id is 101 */
UPDATE Students SET Course = '.Net' WHERE StudentID = 101;

/* 3. Delete students who has no payments */

/* 4. Get all students whose fee is more than 30000 */
SELECT * FROM Students WHERE Fee > 30000;

/* 5. Get payments made in the current month */
SELECT * FROM Payments WHERE MONTH(PaymentDate) = MONTH(CAST(GETDATE() as DATE));

/* 6. Display total amount paid by each student */
SELECT s.Name, SUM(p.AmountPaid) FROM Students s LEFT JOIN Payments p ON s.StudentID = p.StudentID GROUP BY p.StudentID, s.Name;

/* 7. Display min, max, and avg payments */
SELECT MIN(AmountPaid) AS 'Minimum Payment' , MAX(AmountPaid) AS 'Maximum Payment', AVG(AmountPaid) AS 'Average Payment' FROM Payments;

/* 8. Show total amount paid by each student, but only include students who paid more than Rs. 10,000/- */
SELECT s.Name, SUM(p.AmountPaid) AS 'Total Amount Paid' FROM Students s LEFT JOIN Payments p ON s.StudentID = p.StudentID GROUP BY p.StudentID, s.Name HAVING SUM(p.AmountPaid) < 10000;

/* 9. Count how many payments each student made */


/* 10. Show courses that have more than 2 students */

/* 11. Show student's name, course, amount paid, and payment date */

/* 12. List students who have not made any payments */

/* 13. Show students along with total fee and total paid amount */

/* 14. Show balance amount for each student. (Note: Balance = Fee - TotalAmountPaid) */

/* 15. Show the highest paying student */

/* 16. Show the latest payment done (name + date + amount) */

/* 17. Show students who completed 80% of their fee */

/* 18. Show the course wise total collected fee */


/* ======== MOCK INTERVIEW QUESTIONS ======== */

/* 13. W.A.Q to find students who paid more than 5000 */

/* 14. W.A.Q to display each student's total payment done */

/* 15. W.A.Q to display all students with their payment details (even if no payment exists) */

/* 16. Write a query to find students who belongs to a particular course (eg: 'Java') */

/* 17. Astudent appears twice in the table. How do you find the duplicate records */

/* 18. Find students who did not pay any amount */

/* 19. A payment record is entered with wrong amount. W.A.Q to correct the amount */

/* 20. W.A.Q to delete students with no payment records in the Payments table */

/* 21. A student want to update their course. W.A.Q */
