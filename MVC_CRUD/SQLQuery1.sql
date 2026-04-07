CREATE DATABASE USERS_DB;

USE USERS_DB;

CREATE TABLE Users(
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(255) UNIQUE,
	password VARCHAR(255),
	phone VARCHAR(15)
)


CREATE PROCEDURE sp_insert_users(@username VARCHAR(255), @pwd VARCHAR(255), @phone VARCHAR(15))
AS BEGIN
	INSERT INTO Users(username, password, phone) VALUES(@username, @pwd, @phone);
END;

EXEC sp_insert_users 'Kirankumar1','QAWsedrf', '+91 7858965478'

CREATE PROCEDURE sp_select_users
AS BEGIN
	SELECT * FROM Users;
END;

EXEC sp_select_users

CREATE PROCEDURE sp_count_users(@username VARCHAR(255), @pwd VARCHAR(255))
AS BEGIN
	SELECT COUNT(username) AS 'Total Matched Users' FROM Users WHERE username = @username and password = @pwd;
END;

EXEC sp_count_users 'kirankumar','QAwsedrf'