CREATE DATABASE EXAMPLE_28_DB;

USE EXAMPLE_28_DB;

CREATE TABLE Country(
    Id INT IDENTITY PRIMARY KEY,
    [Name] VARCHAR(MAX)
);

ALTER TABLE [User]
ADD CONSTRAINT UQ_User_Email UNIQUE (Email);

CREATE TABLE [User](
    Id INT IDENTITY(1001,1) PRIMARY KEY,
    Username VARCHAR(MAX),
    Firstname VARCHAR(MAX),
    Lastname VARCHAR(MAX),
    [Password] VARCHAR(MAX),
    Gender VARCHAR(10) CHECK(Gender IN ('male', 'female', 'others')),
    Phone VARCHAR(20),
    Email VARCHAR(50),
    Age INT,
    [State] VARCHAR(100),
    ReceiveNewsLetters BIT,
    Hobbies VARCHAR(50),
    DateOfSubscription DATE,
    CountryId INT FOREIGN KEY REFERENCES Country(Id),
    MaritalStatus VARCHAR(10) CHECK(MaritalStatus IN ('single', 'married', 'widow', 'divorced', 'affaires')),
    Address VARCHAR(MAX),
    RegistrationFee MONEY
);

CREATE PROCEDURE sp_insert_user (
    @username VARCHAR(MAX),
    @firstname VARCHAR(MAX),
    @Lastname VARCHAR(MAX),
    @password VARCHAR(MAX),
    @gender VARCHAR(10),
    @phone VARCHAR(20),
    @email VARCHAR(50),
    @age INT,
    @state VARCHAR(100),
    @receiveNewsLetters BIT,
    @hobbies VARCHAR(50),
    @dateOfSubscription DATE,
    @countryId INT,
    @maritalStatus VARCHAR(10),
    @address VARCHAR(MAX),
    @registrationFee MONEY
)
AS BEGIN
    INSERT INTO [User](
      Username,
      Firstname,
      Lastname,
      [Password],
      Gender,
      Phone,
      Email,
      Age,
      [State],
      ReceiveNewsLetters,
      Hobbies,
      DateOfSubscription,
      CountryId,
      MaritalStatus,
      [Address],
      RegistrationFee)
      VALUES (
      @username, 
      @firstname, 
      @Lastname,
      @password,
      @gender,
      @phone,
      @email,
      @age,
      @state, 
      @receiveNewsLetters,
      @hobbies,
      @dateOfSubscription,
      @countryId,
      @maritalStatus,
      @address,
      @registrationFee 
      );
END;

CREATE PROCEDURE sp_insert_country (@name VARCHAR(MAX))
AS BEGIN
    INSERT INTO Country([Name]) VALUES (@name)
END;

EXEC sp_insert_country 'India';
EXEC sp_insert_country 'USA';
EXEC sp_insert_country 'China';
EXEC sp_insert_country 'Russia';
EXEC sp_insert_country 'Thailand';
EXEC sp_insert_country 'Combodia';
EXEC sp_insert_country 'Philippeans';
EXEC sp_insert_country 'German';
EXEC sp_insert_country 'UK';

EXEC sp_insert_user 'KiranKKK','Kiran', 'Kumar', 'QAwsedrf', 'male', '12478961', 'kiran@gmail.com', 29, 'Telangana', 1, 'Gaming,Movies,Coding', '2026-04-12', 1, 'single', 'Near My home', 42136.00;

SELECT * FROM Country;
SELECT * FROM [User];
