-- SQL task 3: Company Management Mapping
-- 1. DDL

create database TrainingCompany

use TrainingCompany

create table Employee
(
	FirstName nvarchar(20) not null,
	MiddleName nvarchar(20),
	LastName nvarchar(20) not null,
	Ssn int primary key identity (1, 1),
	Bdate date,
	EmployeeAddress nvarchar(100) not null,
	-- Gender bit default 0,

	Gender nvarchar(6) check(Gender IN('male', 'female')),
	Salary int CONSTRAINT CK_Employee_Salary check(Salary between 350 and 3500),
	Super_Ssn int,
	foreign key (Super_Ssn) references Employee(Ssn)
)

create table Department
(
	Dname nvarchar(20) not null,
	Dnumber int primary key identity(1, 1),
	Mgr_Ssn int,
	Mgr_Start_Date date,

	foreign key (Mgr_Ssn) references Employee(Ssn),
)

create table Dept_Locations
(
	Dnumber int,
	Dlocation nvarchar(50),

	foreign key (Dnumber) references Department(Dnumber),
	primary key (Dnumber, Dlocation),
)

create table Project
(
	Pname nvarchar(50) not null,
	Pnumber int primary key identity(1, 1),
	Plocation nvarchar(50) not null,
	Dnum int,

	foreign key (Dnum) references Department(Dnumber),
)

create table Works_on
(
	Essn int,
	Pno int,
	Hrs int not null,

	foreign key (Essn) references Employee(Ssn),
	foreign key (Pno) references Project(Pnumber),
	primary key (Essn, Pno),
)

create table EmployeeDependent
(
	Essn int,
	Dependent_name nvarchar(50),
	Gender bit default 0,
	Bdate date,
	Relationship nvarchar(10),

	foreign key (Essn) references Employee(Ssn),
	primary key (Essn, Dependent_name),
)