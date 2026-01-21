/* ============================================================
   DATABASE CREATION & CONTEXT
   ============================================================ */

-- Create the main Hospital database
CREATE DATABASE HospitalDB;
GO

-- Switch context to HospitalDB
USE HospitalDB;
GO

/* ============================================================
   LOOKUP / MASTER TABLES
   These tables store static reference data used across the system
   ============================================================ */

-- Stores gender reference values (M/F/O etc.)
CREATE TABLE GenderMaster (
    GenderId INT IDENTITY PRIMARY KEY,       -- Surrogate primary key
    Code CHAR(1) UNIQUE NOT NULL,             -- Gender code (M/F)
    Description VARCHAR(20)                   -- Gender description
);

-- Stores common status values (Active, Inactive, Completed, etc.)
CREATE TABLE StatusMaster (
    StatusId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(30) UNIQUE NOT NULL
);

-- Stores system roles (Admin, Doctor, Nurse, Receptionist)
CREATE TABLE RoleMaster (
    RoleId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(50) UNIQUE NOT NULL
);

-- Stores appointment types (Online, Walk-in, Emergency)
CREATE TABLE AppointmentTypeMaster (
    AppointmentTypeId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL
);

/* ============================================================
   CORE MASTER TABLES
   ============================================================ */

-- Department information
CREATE TABLE Department (
    DepartmentId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(150) UNIQUE NOT NULL,        -- Department name
    RoomNo INT,                               -- Department room number
    HeadDoctorId INT NULL                     -- Optional head doctor reference
);

-- List of health issues / diseases
CREATE TABLE HealthIssue (
    HealthIssueId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) UNIQUE NOT NULL
);

-- Hospital room details
CREATE TABLE Room (
    RoomId INT IDENTITY PRIMARY KEY,
    RoomType VARCHAR(30),                     -- ICU / General / Private
    ChargePerDay MONEY NOT NULL,
    TotalBeds INT NOT NULL,
    AvailableBeds INT NOT NULL
);

-- Medicine master inventory
CREATE TABLE Medicine (
    MedicineId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) UNIQUE NOT NULL,
    Price MONEY NOT NULL,
    ExpiryDate DATE,
    Stock INT NOT NULL                        -- Available stock
);

-- Diagnostic test master
CREATE TABLE TestMaster (
    TestId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) UNIQUE NOT NULL,
    Cost MONEY NOT NULL
);

-- Surgery master data
CREATE TABLE SurgeryMaster (
    SurgeryId INT IDENTITY PRIMARY KEY,
    Name VARCHAR(200) UNIQUE NOT NULL,
    TheatreCost MONEY,
    EquipmentCost MONEY,
    SurgeonFee MONEY,
    AnesthetistFee MONEY
);

/* ============================================================
   STAFF & USERS
   ============================================================ */

-- System users table for authentication
CREATE TABLE Users (
    UserId INT IDENTITY PRIMARY KEY,
    UserName VARCHAR(100) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    PasswordSalt VARCHAR(255) NOT NULL,
    RoleId INT REFERENCES RoleMaster(RoleId),
    IsActive BIT DEFAULT 1,
    LastLogin DATETIME
);

-- Doctor details
CREATE TABLE Doctor (
    DoctorId INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(200),
    GenderId INT REFERENCES GenderMaster(GenderId),
    DOB DATE,
    Qualification VARCHAR(100),
    DepartmentId INT REFERENCES Department(DepartmentId),
    Phone VARCHAR(15),
    Email VARCHAR(100) UNIQUE,
    StatusId INT REFERENCES StatusMaster(StatusId),
    UserId INT UNIQUE REFERENCES Users(UserId) -- One-to-one with Users
);

-- Nurse details
CREATE TABLE Nurse (
    NurseId INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(200),
    GenderId INT REFERENCES GenderMaster(GenderId),
    DepartmentId INT REFERENCES Department(DepartmentId),
    Phone VARCHAR(15),
    Email VARCHAR(100),
    StatusId INT REFERENCES StatusMaster(StatusId)
);

-- Other hospital staff
CREATE TABLE Staff (
    StaffId INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(200),
    RoleId INT REFERENCES RoleMaster(RoleId),
    DepartmentId INT REFERENCES Department(DepartmentId),
    GenderId INT REFERENCES GenderMaster(GenderId),
    Phone VARCHAR(15),
    StatusId INT REFERENCES StatusMaster(StatusId)
);

/* ============================================================
   DOCTOR SPECIALIZATION & SCHEDULE
   ============================================================ */

-- Mapping doctors to health issues (Many-to-Many)
CREATE TABLE DoctorSpecialization (
    DoctorId INT REFERENCES Doctor(DoctorId),
    HealthIssueId INT REFERENCES HealthIssue(HealthIssueId),
    PRIMARY KEY (DoctorId, HealthIssueId)
);

-- Doctor availability schedule
CREATE TABLE DoctorSchedule (
    ScheduleId INT IDENTITY PRIMARY KEY,
    DoctorId INT REFERENCES Doctor(DoctorId),
    DayOfWeek VARCHAR(10),
    StartTime TIME,
    EndTime TIME
);

/* ============================================================
   PATIENT & TRANSACTIONS
   ============================================================ */

-- Patient master table
CREATE TABLE Patient (
    PatientId INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(200),
    GenderId INT REFERENCES GenderMaster(GenderId),
    DOB DATE,
    BloodGroup VARCHAR(10),
    Phone VARCHAR(15),
    Email VARCHAR(100),
    EmergencyContact VARCHAR(15)
);

-- Patient insurance details
CREATE TABLE Insurance (
    InsuranceId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    Provider VARCHAR(100),
    PolicyNumber VARCHAR(50),
    CoverageAmount MONEY
);

-- Appointment booking table
CREATE TABLE Appointment (
    AppointmentId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    DoctorId INT REFERENCES Doctor(DoctorId),
    DepartmentId INT REFERENCES Department(DepartmentId),
    AppointmentDate DATETIME,
    AppointmentTypeId INT REFERENCES AppointmentTypeMaster(AppointmentTypeId),
    StatusId INT REFERENCES StatusMaster(StatusId),
    VisitingFee MONEY
);

-- Patient admission records
CREATE TABLE Admission (
    AdmissionId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    DepartmentId INT REFERENCES Department(DepartmentId),
    RoomId INT REFERENCES Room(RoomId),
    AdmissionDate DATETIME,
    DischargeDate DATETIME,
    StatusId INT REFERENCES StatusMaster(StatusId)
);

/* ============================================================
   MEDICAL TRANSACTIONS
   ============================================================ */

-- Prescription header
CREATE TABLE Prescription (
    PrescriptionId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    DoctorId INT REFERENCES Doctor(DoctorId),
    PrescriptionDate DATETIME
);

-- Prescription medicines
CREATE TABLE PrescriptionDetail (
    PrescriptionDetailId INT IDENTITY PRIMARY KEY,
    PrescriptionId INT REFERENCES Prescription(PrescriptionId),
    MedicineId INT REFERENCES Medicine(MedicineId),
    Quantity INT,
    Dosage VARCHAR(20)
);

-- Diagnostic tests conducted
CREATE TABLE TestsConducted (
    TestConductedId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    TestId INT REFERENCES TestMaster(TestId),
    DoctorId INT REFERENCES Doctor(DoctorId),
    TestDate DATETIME,
    Result VARCHAR(500),
    Cost MONEY
);

-- Surgeries performed
CREATE TABLE SurgeriesPerformed (
    SurgeryPerformedId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    SurgeryId INT REFERENCES SurgeryMaster(SurgeryId),
    SurgeonId INT REFERENCES Doctor(DoctorId),
    SurgeryDate DATETIME,
    TotalCost MONEY,
    StatusId INT REFERENCES StatusMaster(StatusId)
);

/* ============================================================
   BILLING
   ============================================================ */

-- Bill master
CREATE TABLE Bill (
    BillId INT IDENTITY PRIMARY KEY,
    PatientId INT REFERENCES Patient(PatientId),
    TotalAmount MONEY,
    Discount MONEY,
    GST MONEY,
    NetAmount MONEY,
    AmountPaid MONEY,
    Balance MONEY,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- Individual bill items
CREATE TABLE BillItem (
    BillItemId INT IDENTITY PRIMARY KEY,
    BillId INT REFERENCES Bill(BillId),
    ItemType VARCHAR(50),      -- Medicine / Test / Surgery / Room
    ReferenceId INT,           -- Reference table ID
    Amount MONEY
);

/* ============================================================
   AUDIT
   ============================================================ */

-- Tracks system actions for auditing
CREATE TABLE AuditLog (
    AuditLogId INT IDENTITY PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    Action VARCHAR(100),
    ActionDate DATETIME DEFAULT GETDATE()
);

/* ============================================================
   STORED PROCEDURES
   ============================================================ */

-- Department creation procedure
CREATE PROCEDURE sp_Department_Create
(
    @Name VARCHAR(150),
    @RoomNo INT,
    @HeadDoctorId INT = NULL
)
AS
BEGIN
    INSERT INTO Department(Name, RoomNo, HeadDoctorId)
    VALUES (@Name, @RoomNo, @HeadDoctorId);

    SELECT SCOPE_IDENTITY() AS DepartmentId;
END;
GO

-- Department update procedure
CREATE PROCEDURE sp_Department_Update
(
    @DepartmentId INT,
    @Name VARCHAR(150),
    @RoomNo INT,
    @HeadDoctorId INT
)
AS
BEGIN
    UPDATE Department
    SET Name = @Name,
        RoomNo = @RoomNo,
        HeadDoctorId = @HeadDoctorId
    WHERE DepartmentId = @DepartmentId;
END;
GO

-- User creation (authentication)
CREATE PROCEDURE sp_User_Create
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @PasswordSalt VARCHAR(255),
    @RoleId INT
)
AS
BEGIN
    INSERT INTO Users(UserName, PasswordHash, PasswordSalt, RoleId)
    VALUES (@UserName, @PasswordHash, @PasswordSalt, @RoleId);

    SELECT SCOPE_IDENTITY() AS UserId;
END;
GO

-- Doctor creation with user (transactional)
CREATE PROCEDURE sp_Doctor_Create
(
    @FullName VARCHAR(200),
    @GenderId INT,
    @DOB DATE,
    @Qualification VARCHAR(100),
    @DepartmentId INT,
    @Phone VARCHAR(15),
    @Email VARCHAR(100),
    @StatusId INT,
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @PasswordSalt VARCHAR(255),
    @RoleId INT
)
AS
BEGIN
    BEGIN TRAN;

    DECLARE @UserId INT;

    INSERT INTO Users(UserName, PasswordHash, PasswordSalt, RoleId)
    VALUES (@UserName, @PasswordHash, @PasswordSalt, @RoleId);

    SET @UserId = SCOPE_IDENTITY();

    INSERT INTO Doctor
    (
        FullName, GenderId, DOB, Qualification,
        DepartmentId, Phone, Email, StatusId, UserId
    )
    VALUES
    (
        @FullName, @GenderId, @DOB, @Qualification,
        @DepartmentId, @Phone, @Email, @StatusId, @UserId
    );

    COMMIT;

    SELECT @UserId AS UserId;
END;
GO
