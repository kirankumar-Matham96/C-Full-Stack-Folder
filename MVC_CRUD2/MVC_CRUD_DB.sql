--DROP DATABASE MVC_CRUD;
CREATE DATABASE MVC_CRUD;

USE MVC_CRUD;

--DROP TABLE UserHobbies
--DROP TABLE Hobbies

/* Users table */
CREATE TABLE Users(
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(255) UNIQUE,
	password VARCHAR(255),
	gender VARCHAR(6) CHECK(gender IN ('male', 'female', 'others')),
	city VARCHAR(20)
);

/* Hobbies table */
CREATE TABLE Hobbies(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(20) UNIQUE
);


/* Joining table */
CREATE TABLE UserHobbies(
	userId INT,
	hobbyId INT,
	PRIMARY KEY (userId, hobbyId), -- Composite primary key (i.e., same user cannot have duplicate hobby)
	FOREIGN KEY (userId) REFERENCES Users(id),
	FOREIGN KEY (hobbyId) REFERENCES Hobbies(id)
);

/* Stored Procedures */

--Users: 
--(insert)
CREATE PROCEDURE sp_insert_users
	@username VARCHAR(255),
	@pwd VARCHAR(255),
	@gender VARCHAR(6),
	@city VARCHAR(20),
	@userId INT OUTPUT -- to verify when a new record inserted
AS
BEGIN
	INSERT INTO Users(username, password, gender, city)
	Values(@username,@pwd,@gender,@city);

	SET @userId = SCOPE_IDENTITY(); -- returns inserted id (dynamic id generated)
END;

--(select)
CREATE PROCEDURE sp_get_users
AS
BEGIN
	SELECT * FROM Users;
END;

--(select with id)
CREATE PROCEDURE sp_getById_users @id INT
AS
BEGIN
	SELECT * FROM Users WHERE id = @id;
END;

--(update)
CREATE PROCEDURE sp_update_users
	@id INT,
	@username VARCHAR(255),
	@pwd VARCHAR(255),
	@gender VARCHAR(6),
	@city VARCHAR(20)
AS
BEGIN
	UPDATE Users
	SET username = @username, password = @pwd, gender = @gender, city = @city
	WHERE id = @id;
END;

--(delete)
CREATE PROCEDURE sp_delete_users @id INT
AS
BEGIN
	DELETE FROM Users WHERE id = @id;
END;


--Hobbies:
--(insert)
CREATE PROCEDURE sp_insert_hobbies
	@name VARCHAR(20),
	@hobbyId INT OUTPUT
AS
BEGIN
	INSERT INTO Hobbies(name) VALUES(@name);
	SET @hobbyId = SCOPE_IDENTITY(); --returns id to verify the insertion
END;

--(select)
CREATE PROCEDURE sp_get_hobbies
AS
BEGIN
	SELECT * FROM Hobbies;
END;

--UserHobbies (Joining table)
--(insert)
CREATE PROCEDURE sp_insert_userHobbies
	@userId INT,
	@hobbyId INT
AS
IF NOT EXISTS( --condition to check if data exists already
	SELECT 1 FROM UserHobbies
	WHERE userId = @userId AND hobbyId = @hobbyId
)
BEGIN
	INSERT INTO UserHobbies VALUES(@userId, @hobbyId);
END;

/* Get all the data of a user */
CREATE PROCEDURE sp_getAllUsersWithHobbies
	--@userId
AS BEGIN
	SELECT * FROM Users u
	LEFT JOIN UserHobbies uh ON u.id = uh.userId
	LEFT JOIN Hobbies h ON h.id = uh.HobbyId
END;

/* Get all the data of a user in formatted output */
CREATE PROCEDURE sp_getUsersWithHobbies_Formatted
	--@userId INT
AS
BEGIN
	SELECT 
		u.id,
		u.username,
		u.gender,
		u.city,
		STRING_AGG(h.name, ', ') AS Hobbies
	FROM Users u
	LEFT JOIN UserHobbies uh ON u.id = uh.userId
	LEFT JOIN Hobbies h ON uh.hobbyId = h.id
	--WHERE u.id = @userId
	GROUP BY u.id, u.username, u.gender, u.city;
END
 
/* Executions */

-- start (execute these 3 statements at once)
DECLARE	@newUserId INT;
EXEC sp_insert_users 
	@username = 'Kirankumar',
	@pwd = '487#596ahvfdQAZj@1531ef!',
	@gender = 'male',
	@city = 'hyderabad',
	@userId = @newUserId OUTPUT;
SELECT @newUserId as NewUserId;
-- end


EXEC sp_get_users

EXEC sp_update_users 1, 'Kiran Kumar', '12qaazQAZ', 'male', 'Hyderabad';

EXEC sp_delete_users 1;

DECLARE @newHobbyId INT;
EXEC sp_insert_hobbies 
	@name = 'travel',
	@hobbyId = @newHobbyId OUTPUT;
SELECT @newHobbyId AS NewHobbyId;

EXEC sp_get_hobbies

EXEC sp_insert_userHobbies 2, 5

--queries to get all the info
EXEC sp_getAllUsersWithHobbies -- basic (compatible for MVC)
EXEC sp_getUsersWithHobbies_Formatted --Advanced (Not compatible for MVC)

