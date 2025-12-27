/* SQL Final Practice: Major Project for DOTNET */

/* HOSPITAL MANAGEMENT SYSTEM
	I. Create tables as below:
		
			1. Departments: id, name, location(room number), headDoctorId
			2. HealthIssues: id, name
			3. Doctors: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
			4. DoctorSpecialisations: doctorId, healthIssueId
			5. Patients: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
			6. Nurses: id, name,  gender, dob, deptId, phoneNumber, email, address
			7. Staff: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift 
			8. Tests: id, name, cost
			9. Surgeries: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
			10. Appointments: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
			11. Admissions: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
			12. Rooms: id, type, chargePerDay, availability
			13. TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
			14. SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
			15. Medicines: id, name, price, expiryDate, stock
			16. Prescriptions: id, patientId, doctorId, date
			17. PrescriptionDetails: id, medicinId, quantity, dosage
			18. Bills: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
			19. BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
			20. Users: userId, userName, passwordHash, role
			21. DoctorSchedules: doctorId, dayOfWeek, startTime, endTime
			22. Insurance: id, patientId, provider, policyNumber, coverageAmt
			23. AuditLogs: logId, userId, action, timestamp
		
	II. Create index for necessary fields in each table
	III. Create stored procedures for inserting updating and deleting records for each table. The DML operations should effect cascadingly.
	IV. Create triggers where ever needed
	V. Create views for security
	VI. Create Functions for certain operations:()
	VII. Normalise the tables and make it clean and scalable
	VIII. Import data files to insert data into the tables
	IX. Use this database for the major project in MVC.Net Core.
	
*/

--Creating a database
CREATE DATABASE HOSPITAL_DB;

--Using database
USE HOSPITAL_DB;

/* Creating tables - starts */

--Department: id, name, location(room number), headDoctorId
CREATE TABLE Department(
	id INT PRIMARY KEY,
	name VARCHAR(150) UNIQUE, 
	roomNo INT,
	headDoctor VARCHAR(255)
);

--HealthIssue: id, name
CREATE TABLE HealthIssue(
	id INT PRIMARY KEY,
	name VARCHAR(255)
);

--Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
CREATE TABLE Doctor(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	qualification VARCHAR(50) CHECK(designation IN ('MBBS','FRCS','RMP','PG','PHD','MASTERS')),
	designation VARCHAR(50) CHECK(designation IN ('HEAD','SENIOR','JUNIOR','INTERN','CONTRACT')),
	phoneNumber BIGINT,
	email VARCHAR(50) UNIQUE,
	address VARCHAR(255),
	joiningDate DATE,
	status VARCHAR(20) CHECK(status IN ('Active', 'Inactive', 'On Leave'))
);

--DoctorSpecialisation: doctorId, healthIssueId
CREATE TABLE DoctorSpecialisation(
	doctorId INT REFERENCES Doctor(id),
	healthIssueId INT references HealthIssue(id)
);

--Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
CREATE TABLE Patient(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	bloodGroup VARCHAR(20) CHECK(bloodGroup IN ('A +Ve','A -Ve','B +Ve','B -Ve','AB +Ve','AB -Ve','O +Ve','O -Ve', 'Bombay')),
	healthIssueId INT REFERENCES HealthIssue(id),
	deptId INT REFERENCES Department(id),
	doctorId INT REFERENCES Doctor(id),
	phoneNumber BIGINT,
	email VARCHAR(50),
	address VARCHAR(255),
	emergencyContact BIGINT
);

--Nurse: id, name,  gender, dob, deptId, phoneNumber, email, address, joiningDate, status
CREATE TABLE Nurse(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	deptId INT REFERENCES Department(id),
	phoneNumber BIGINT,
	email VARCHAR(50) UNIQUE,
	address VARCHAR(255),
	joiningDate DATE,
	status VARCHAR(20) CHECK(status IN ('Active', 'Inactive', 'On Leave'))
);

--Staf: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift, status
CREATE TABLE Staff(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	role VARCHAR(100) CHECK(role IN ('Manager','Head Manager','Doctor','Head Doctor','Head of Department','Super Intendent','Nurse','Pune','Head Nurse', 'Sweeper')),
	gender CHAR CHECK(gender IN ('M','F','O')),
	dob DATE,
	phoneNumber BIGINT,
	email VARCHAR(50) UNIQUE,
	address VARCHAR(255),
	joiningDate DATE,
	shift VARCHAR(20) CHECK(shift IN ('Day-Morning','Day-Afternoon','Day-Evening','Night')),
	status VARCHAR(20) CHECK(status IN ('Active', 'Inactive', 'On Leave'))
);

--Test: id, name, cost
CREATE TABLE Test(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	cost MONEY DEFAULT 500
);

--Surgerie: id, name, theatorCost, equipmentCost, surgeonFee, anesthecianFee
CREATE TABLE Surgery(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	theatorCost MONEY DEFAULT 5000,
	equipmentCost MONEY DEFAULT 10000,
	surgeonFee MONEY DEFAULT 20000,
	anesthecianFee MONEY DEFAULT 15000
);

--Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
CREATE TABLE Appointment(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	doctorId INT REFERENCES Doctor(id),
	deptId INT REFERENCES Department(id),
	appointmentDate DATE,
	appointmentType VARCHAR(10) CHECK(appointmentType IN ('opd','ipd','emergency')), 
	status VARCHAR(10) CHECK(status IN ('Confirmed','Pending','Rejected')),
	visitingFee MONEY DEFAULT 500
);

--Room: id, type, chargePerDay, availability
CREATE TABLE Room(
	id INT PRIMARY KEY,
	type VARCHAR(20) CHECK(type IN ('general', 'shared', 'individual', 'delux', 'AC')),
	chargePerDay MONEY DEFAULT 1000,
	availability INT NOT NULL
);

--Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
CREATE TABLE Admission(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	deptId INT REFERENCES Department(id),
	roomId INT REFERENCES Room(id),
	admissionDate DATE NOT NULL,
	dischargeDate DATE,
	status VARCHAR(20) CHECK(status IN ('IN','OUT', 'WAITING'))
);

--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
CREATE TABLE TestsConducted(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	testId INT REFERENCES Test(id),
	doctorId INT REFERENCES Doctor(id),
	testDate DATE,
	result VARCHAR(200),
	cost MONEY NOT NULL
);

--SurgeriesPerformed: surgeryId, patientId, surgeonId, anesthecianId, surgeryDate, totalCost, status
CREATE TABLE SurgeriesPerformed(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	surgeonId INT REFERENCES Doctor(id),
	anesthecianId INT REFERENCES Doctor(id),
	surgeryDate DATE,
	totalCost MONEY NOT NULL,
	status VARCHAR(10) CHECK(status IN ('Success','Failed', 'OnGoing', 'Cancelled'))
);

--Medicine: id, name, price, expiryDate, stock
CREATE TABLE Medicine(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	price MONEY NOT NULL,
	expiryDate DATE,
	stock INT
);

--Prescription: id, patientId, doctorId, date
CREATE TABLE Prescription(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	doctorId INT REFERENCES Doctor(id),
	date DATE
);

--PrescriptionDetail: id, medicinId, quantity, dosage
CREATE TABLE PrescriptionDetail(
	id INT PRIMARY KEY,
	medicineId INT REFERENCES Medicine(id),
	quantity INT,
	dosage VARCHAR(5) CHECK(dosage IN ('TWAD','TAD','M','A','N', 'OAD'))
);

--Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
CREATE TABLE Bill(
	id INT PRIMARY KEY,
	patientId INT,
	visitId INT,
	totalBill MONEY,
	discountPercent INT,
	gstPercent DECIMAL(10,2),
	netAmount MONEY,
	amountPaid MONEY,
	balanceAmount MONEY
);

--BillingDetail: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
CREATE TABLE BillingDetail(
	id INT PRIMARY KEY,
	billId INT,
	chargeType VARCHAR(10) CHECK(chargeType IN ('test','surgery','room','medicine')),
	referenceId INT UNIQUE,
	amount MONEY
);

--Users: userId, userName, passwordHash, role
CREATE TABLE Users(
	id INT PRIMARY KEY,
	userName VARCHAR(255),
	passwordHash VARCHAR(255),
	role VARCHAR(20)
);

--DoctorSchedule: doctorId, dayOfWeek, startTime, endTime

--Insuranc: id, patientId, provider, policyNumber, coverageAmt

--AuditLog: logId, userId, action, timestamp

/* Creating tables - ends */