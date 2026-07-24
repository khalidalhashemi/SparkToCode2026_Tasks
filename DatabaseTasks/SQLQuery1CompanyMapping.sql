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

ALTER TABLE Employee
	ADD Dno int foreign key references Department(Dnumber)

ALTER TABLE Employee
ALTER COLUMN Mname nvarchar(10)

EXEC sp_rename 'Employee.Mname', 'Midname', 'COLUMN';

ALTER TABLE Employee
ALTER COLUMN Midname;

ALTER TABLE Employee
ADD CONSTRAINT UQ_Employee_Mname UNIQUE (Fname);

ALTER TABLE Employee
DROP CONSTRAINT CK_Employee_Salary;

ALTER TABLE Employee
ADD CONSTRAINT CK_Employee_Salary check(Salary between 350 and 3500)

EXEC sp_rename 'Employee', 'Employees';

truncate table EmployeeDependent

drop table EmployeeDependent

drop database TrainingCompany

----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------

-- 2. DML

use TrainingCompany

insert into Employees(Fname, Lname, Bdate, Gender, Salary)
values('Mohammed', 'Ali', '11-12-2000',1,2300)

insert into Employees(Fname, Lname, Bdate, Gender, Salary)
values('Ahmed', 'Ali', '11-12-2007',1,500)

-- row constructor
insert into Employees(Fname, Lname, Bdate, Gender, Salary)
values('Said', 'Ahmed', '12-12-2001',1,600),
      ('Karim', 'Salah', '11-10-2001',1,2300),
	  ('Ghada', 'Ahmed', '12-12-2001',0,750)


-- update
update Employees
set Salary += 25

update Employees
set Salary += 50
where Ssn = 6

update Employees
set EmployeeAddress = 'Muscat', Salary = 2000
where Ssn = 6

delet from Employees
where Ssn = 6

truncate table Employees