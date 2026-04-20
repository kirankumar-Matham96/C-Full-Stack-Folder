CREATE DATABASE EF_DB_1;

USE EF_DB_1;

CREATE TABLE Users(
	id INT PRIMARY KEY,
	name VARCHAR(50),
	city VARCHAR(20),
	address VARCHAR(100)
);

INSERT INTO Users VALUES
(1, 'Kiran', 'Hyderabad', 'TG'),
(2, 'Tharun', 'Pune', 'MH'),
(3, 'Varun', 'Chennai', 'TN'),
(4, 'Charan', 'Hyderabad', 'TG'),
(5, 'Maaran', 'Chennai', 'TN');

SELECT * FROM Users;
