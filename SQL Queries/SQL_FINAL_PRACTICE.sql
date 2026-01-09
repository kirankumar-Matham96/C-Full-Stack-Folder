/* SQL Final Practice: Major Project for DOTNET */

/* HOSPITAL MANAGEMENT SYSTEM
	I. Create tables as below:
		
			1. Department: id, name, location(roomNo), headDoctorId
			2. HealthIssue: id, name
			3. Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
			4. DoctorSpecialisation: doctorId, healthIssueId
			5. Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
			6. Nurse: id, name,  gender, dob, deptId, phoneNumber, email, address
			7. Staff: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift 
			8. Test: id, name, cost
			9. Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
			10. Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
			11. Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
			12. Room: id, type, chargePerDay, availability
			13. TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
			14. SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
			15. Medicine: id, name, price, expiryDate, stock
			16. Prescription: id, patientId, doctorId, date
			17. PrescriptionDetail: id, medicinId, quantity, dosage
			18. Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
			19. BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
			20. Users: userId, userName, passwordHash, role
			21. DoctorSchedule: doctorId, dayOfWeek, startTime, endTime
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
	qualification VARCHAR(50) CHECK(qualification IN ('MBBS','FRCS','RMP','PG','PHD','MASTERS')),
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
	healthIssueId INT REFERENCES HealthIssue(id)
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
	email VARCHAR(50) UNIQUE,
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

--Staf: id, name, role, deptId, gender, dob, phoneNumber, email, address, joiningDate, shift, status
CREATE TABLE Staff(
	id INT PRIMARY KEY,
	name VARCHAR(255),
	role VARCHAR(100) CHECK(role IN ('Manager','Head Manager','Doctor','Head Doctor','Head of Department','Super Intendent','Nurse','Pune','Head Nurse', 'Sweeper')),
	deptId INT REFERENCES Department(id),
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

--Surgery: id, name, theatorCost, equipmentCost, surgeonFee, anesthecianFee
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
	appointmentDate DATE DEFAULT GETDATE(),
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
	admissionDate DATE DEFAULT GETDATE(),
	dischargeDate DATE DEFAULT DATEADD(DAY, 10, GETDATE()),
	status VARCHAR(20) CHECK(status IN ('IN','OUT', 'WAITING'))
);

--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
CREATE TABLE TestsConducted(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	testId INT REFERENCES Test(id),
	doctorId INT REFERENCES Doctor(id),
	testDate DATE DEFAULT GETDATE(),
	result VARCHAR(200),
	cost MONEY NOT NULL
);

--SurgeriesPerformed: surgeryId, patientId, surgeonId, anesthecianId, surgeryDate, totalCost, status
CREATE TABLE SurgeriesPerformed(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	surgeonId INT REFERENCES Doctor(id),
	anesthecianId INT REFERENCES Doctor(id),
	surgeryDate DATE DEFAULT GETDATE(),
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
	date DATE DEFAULT GETDATE()
);

--PrescriptionDetail: id, medicinId, quantity, dosage
CREATE TABLE PrescriptionDetails(
	id INT PRIMARY KEY,
	medicineId INT REFERENCES Medicine(id),
	quantity INT,
	dosage VARCHAR(5) CHECK(dosage IN ('TWAD','TAD','M','A','N', 'OAD')),
	timestamp DATE DEFAULT GETDATE()
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
	balanceAmount MONEY,
	timestamp DATE DEFAULT GETDATE()
);

--BillingDetail: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
CREATE TABLE BillingDetails(
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
CREATE TABLE DoctorSchedules(
	doctorId INT REFERENCES Doctor(id),
	dayOfWeek VARCHAR(10),
	startTime TIME,
	endTime TIME
);

--Insuranc: id, patientId, provider, policyNumber, coverageAmt
CREATE TABLE Insurance(
	id INT PRIMARY KEY,
	patientId INT REFERENCES Patient(id),
	provider VARCHAR(50) NOT NULL,
	policyNumber BIGINT NOT NULL,
	coverageAmt MONEY NOT NULL
);

--AuditLog: logId, userId, action, timestamp
CREATE TABLE AuditLogs(
	logId INT PRIMARY KEY,
	userId INT REFERENCES Users(id),
	action VARCHAR(10) CHECK(action IN ('IN_PROGRESS','COMPLETED','PENDING')),
	timestamp DATETIME DEFAULT GETDATE()
);

/* Creating tables - ends */

/* Creating Indeces - starts */

--  1. Department: id, name, location(room number), headDoctorId
--Index for Department table
CREATE INDEX idx_headDoctor_department ON Department(headDoctor)

--	2. HealthIssue: id, name
--Index for HealthIssue table
CREATE INDEX idx_name_healthIssue ON HealthIssue(name);

--	3. Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
--Index for Doctor table
CREATE INDEX idx_all_doctor ON Doctor(name, qualification, designation, phoneNumber, address, status); --Is this possible? If yes, how will it work?

--	4. DoctorSpecialisations: doctorId, healthIssueId
--Index for DoctorSpecialisations table
	--No Need

--	5. Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
--Index for Patient table
CREATE INDEX idx_all_patient ON Patient(name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, address, emergencyContact);

--	6. Nurses: id, name,  gender, dob, deptId, phoneNumber, email, address
--Index for Nurses table
CREATE INDEX idx_all_nurse ON Nurse(name,  gender, dob, deptId, phoneNumber, address);

--	7. Staff: id, name, role, deptId, gender, dob, phoneNumber, email, address, joiningDate, shift 
--Index for Staff table
CREATE INDEX idx_all_staff ON Staff(name, role, deptId, gender, dob, phoneNumber, email, address, joiningDate, shift);

--	8. Tes: id, name, cost
--Index for Test table
CREATE INDEX idx_all_test ON Test(name,cost);

--	9. Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
--Index for Surgery table
CREATE INDEX idx_name_surgery ON Surgery(name)

--	10. Appointments: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
--Index for Appointment table
CREATE INDEX idx_type_appointment ON Appointment(appointmentType);
CREATE INDEX idx_status_appointment ON Appointment(status);

--	11. Admissions: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
--Index for Admissions table
CREATE INDEX idx_admissionDate_admission ON Admission(admissionDate);
CREATE INDEX idx_dischargeDate_admission ON Admission(dischargeDate);
CREATE INDEX idx_status_admission ON Admission(status);

--	12. Rooms: id, type, chargePerDay, availability
--Index for Rooms table
CREATE INDEX idx_all_room ON Room(type, chargePerDay, availability);

--	13. TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
--Index for TestsConducted table
CREATE INDEX  idx_all_testsConducted ON TestsConducted(testDate, result, cost);

--	14. SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
--Index for SurgeriesPerformed table
CREATE INDEX idx_all_surgeriesPerformed ON SurgeriesPerformed(surgeryDate, totalCost, status);

--	15. Medicines: id, name, price, expiryDate, stock
--Index for Medicines table
CREATE INDEX idx_all_medicine ON Medicine(name, price, expiryDate, stock);

--	16. Prescriptions: id, patientId, doctorId, date
--Index for Prescriptions table
CREATE INDEX idx_all_prescription ON Prescription(date);

--	17. PrescriptionDetails: id, medicinId, quantity, dosage
--Index for PrescriptionDetails table
CREATE INDEX idx_all_PrescriptionDetails ON PrescriptionDetails(quantity, dosage);

--	18. Bills: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
--Index for Bills table
CREATE INDEX idx_all_bill ON Bill(totalBill, discountPercent, GSTPercent, netAmount, amountPaid, balanceAmount);

--	19. BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
--Index for BillingDetails table
CREATE INDEX idx_all_billingDetails ON BillingDetails(chargeType, referenceId, amount);

--	20. Users: userId, userName, passwordHash, role
--Index for Users table
CREATE INDEX idx_all_users ON Users(userName, role);

--	21. DoctorSchedules: doctorId, dayOfWeek, startTime, endTime
--Index for DoctorSchedules table
CREATE INDEX idx_all_doctorSchedules ON DoctorSchedules(dayOfWeek, startTime, endTime);

--	22. Insurance: id, patientId, provider, policyNumber, coverageAmt
--Index for Insurance table
CREATE INDEX idx_allInsurance ON Insurance(provider, policyNumber, coverageAmt);

--	23. AuditLogs: logId, userId, action, timestamp
--Index for AuditLogs table
CREATE INDEX idx_all_auditLogs ON AuditLogs(action, timestamp);

/* Creating Indeces - ends */

/* Creating Stored Procedures - starts */

--Department: id, name, location(room number), headDoctorId
--Inserting Data
CREATE PROCEDURE sp_insert_department(@id INT, @name VARCHAR(150), @roomNumber INT, @headDoctor VARCHAR(255))
AS BEGIN
	INSERT INTO Department VALUES (@id, @name, @roomNumber, @headDoctor);
END;

--Reading all Data
CREATE PROCEDURE sp_readAll_department
AS BEGIN
	SELECT * FROM Department;
END;

--Updating Data (NOTE: COALESCE function returns first non-null value. If the user did not provide any value or null, it will keep the origina data as is)
CREATE PROCEDURE sp_update_department(@id INT, @name VARCHAR(150), @roomNumber INT, @headDoctor VARCHAR(255))
AS BEGIN
	UPDATE Department SET
	name = COALESCE(@name,name),
	roomNo = COALESCE(@roomNumber,roomNo),
	headDoctor = COALESCE(@headDoctor, headDoctor)
	WHERE id = @id;
END;

--Deleting Data
CREATE PROCEDURE sp_delete_department(@id INT)
AS BEGIN
	DELETE FROM Department WHERE id = @id;
END;

--Truncate Table
TRUNCATE TABLE Department

--Dropping Table
CREATE PROCEDURE sp_drop_department
AS BEGIN
	DROP TABLE Department;
END;

--HealthIssue: id, name
--Inserting data
CREATE PROCEDURE sp_insert_healthissue(@id INT, @name VARCHAR(255))
AS BEGIN
	INSERT INTO HealthIssue VALUES(@id, @name);
END;

--updating data
CREATE PROCEDURE sp_update_healthissue(@id INT, @name VARCHAR(255))
AS BEGIN
	UPDATE HealthIssue SET name = @name WHERE id = @id;
END;

--reading data
CREATE PROCEDURE sp_read_healthissue
AS BEGIN
	SELECT * FROM HealthIssue;
END;

--deleting data
CREATE PROCEDURE sp_delete_healthissue(@id INT)
AS BEGIN
	DELETE FROM HealthIssue WHERE id = @id;
END;

--dropping table
CREATE PROCEDURE sp_drop_healthissue
AS BEGIN
	DROP TABLE HealthIssue;
END;

--truncate table
CREATE PROCEDURE sp_truncate_healthissue
AS BEGIN
	TRUNCATE TABLE HealthIssue;
END;

--Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--DoctorSpecialisation: doctorId, healthIssueId
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Nurse: id, name,  gender, dob, deptId, phoneNumber, email, address
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Staff: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift 
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Test: id, name, cost
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--Room: id, type, chargePerDay, availability
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
--Inserting data
--updating data
--reading data
--deleting data
--dropping table

--SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--Medicine: id, name, price, expiryDate, stock
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--Prescription: id, patientId, doctorId, date
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--PrescriptionDetail: id, medicinId, quantity, dosage
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--Users: userId, userName, passwordHash, role
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--DoctorSchedule: doctorId, dayOfWeek, startTime, endTime
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--Insurance: id, patientId, provider, policyNumber, coverageAmt
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

--AuditLogs: logId, userId, action, timestamp
	--Inserting data
	--updating data
	--reading data
	--deleting data
	--dropping table

/* Creating Stored Procedures - ends */

/* Creating Triggers - starts */

--Department: id, name, location(roomNo), headDoctorId
	--No need

--HealthIssue: id, name
	--No need

--Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
	--No need

--DoctorSpecialisation: doctorId, healthIssueId
	--No need

--Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
	--No need

--Nurse: id, name,  gender, dob, deptId, phoneNumber, email, address
	--No need

--Staff: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift 
	--No need

--Test: id, name, cost
	--No need

--Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
	--No need

--Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
	--No need

--Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
	--When a new admission is created, room availability should be updated
	CREATE TRIGGER tr_updateRoomAvailability_admission_room ON Admission
	AFTER INSERT
	AS BEGIN
		UPDATE Room SET
		Room.availability = Room.availability - 1
		FROM inserted
		WHERE Room.id = inserted.roomId AND Room.availability-1 >= 0;
	END;

--Room: id, type, chargePerDay, availability
	--No need

--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
	--No need

--SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
	--No need

--Medicine: id, name, price, expiryDate, stock
	--No need

--Prescription: id, patientId, doctorId, date
	--No need

--PrescriptionDetail: id, medicinId, quantity, dosage
	--No need

--Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
	--No need

--BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
	--No need

--Users: userId, userName, passwordHash, role
	--No need

--DoctorSchedule: doctorId, dayOfWeek, startTime, endTime
	--No need

--Insurance: id, patientId, provider, policyNumber, coverageAmt
	--No need

--AuditLogs: logId, userId, action, timestamp
	--No need

/* Creating Triggers - ends */

/* Creating views - starts */

--Department: id, name, location(roomNo), headDoctorId
CREATE VIEW view_department AS SELECT name,headDoctor,roomNo FROM Department;
SELECT * FROM view_department;
	
--HealthIssue: id, name
CREATE VIEW view_healthIssue AS SELECT name FROM HealthIssue;

--Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
CREATE VIEW view_doctor AS SELECT name, gender, qualification, designation, status FROM Doctor;

--DoctorSpecialisation: doctorId, healthIssueId
CREATE VIEW view_doctorSpecialization AS SELECT * FROM DoctorSpecialisation;

--Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
CREATE VIEW view_patient AS SELECT id, name, gender, dob, bloodGroup FROM Patient;

--Nurse: id, name, gender, dob, deptId, phoneNumber, email, address
CREATE VIEW view_nurse AS SELECT id, name, gender, dob, deptId, phoneNumber FROM Nurse;

--Staff: id, name, role, deptId, gender, dob, phoneNumber, email, address, joiningDate, shift 
CREATE VIEW view_staff AS SELECT id, name, role, deptId, gender, shift FROM Staff;

--Test: id, name, cost
CREATE VIEW view_test AS SELECT * FROM Test;

--Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
CREATE VIEW view_surgery AS SELECT * FROM Surgery;

--Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee

--Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status

--Room: id, type, chargePerDay, availability

--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost

--SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status

--Medicine: id, name, price, expiryDate, stock

--Prescription: id, patientId, doctorId, date

--PrescriptionDetail: id, medicinId, quantity, dosage

--Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt

--BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount

--Users: userId, userName, passwordHash, role

--DoctorSchedule: doctorId, dayOfWeek, startTime, endTime

--Insurance: id, patientId, provider, policyNumber, coverageAmt

--AuditLogs: logId, userId, action, timestamp


	-- Continue creating views based on the tables list above later

/* Creating views -ends */


/* Creating cursors - starts */
	
--Department: id, name, location(roomNo), headDoctorId
DECLARE cursor_department CURSOR STATIC FOR SELECT * FROM view_department;

--HealthIssue: id, name
DECLARE cursor_healthIssue CURSOR STATIC FOR SELECT * FROM view_healthIssue;

--Doctor: id, name, gender, dob, qualification, designation, phoneNumber, email, address, joiningDate, status
DECLARE cr_doctor CURSOR STATIC FOR SELECT * FROM view_doctor;

--DoctorSpecialisation: doctorId, healthIssueId
--Patient: id, name, gender, dob, bloodGroup, healthIssueId, deptId, doctorId, phoneNumber, email, address, emergencyContact
--Nurse: id, name,  gender, dob, deptId, phoneNumber, email, address
--Staff: id, name, role, deptId, designation, gender, dob, phoneNumber, email, address, joiningDate, shift 
--Test: id, name, cost
--Surgery: id, name, theatorCost, equipmentCost, surgianFee, anesthecianFee
--Appointment: id, patientId, doctorId, deptId, appointmentDate, appointmentType(opd/ipd/emergency),status, visitingFee
--Admission: id, patientId, deptId, roomId, admissionDate, dischargeDate, status
--Room: id, type, chargePerDay, availability
--TestsConducted: patientTestId, patientId, testId, doctorId, testDate, result, cost
--SurgeriesPerformed: surgeryId, patientId, surgeonId, surgeryDate, totalCost, status
--Medicine: id, name, price, expiryDate, stock
--Prescription: id, patientId, doctorId, date
--PrescriptionDetail: id, medicinId, quantity, dosage
--Bill: id, pid, visitId, totalBill, discount, GST, netAmt, amtPaid, balanceAmt
--BillingDetails: id, billId, chargeType(test/surgery/room/medicine), referenceId, amount
--Users: userId, userName, passwordHash, role
--DoctorSchedule: doctorId, dayOfWeek, startTime, endTime
--Insurance: id, patientId, provider, policyNumber, coverageAmt
--AuditLogs: logId, userId, action, timestamp


/* Creating cursors -ends */


/* Creating Functions - starts */

/* Creating Functions - ends */

