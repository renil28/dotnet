Create database MyDB;
use MyDB;

--DDL
Create Table Employee(ID int, EmployeeName varchar(200));

--DQL
select * from Employee;

--DML
insert into Employee(ID, EmployeeName) VALUES (1,'Remil Justin');
insert into Employee(ID, EmployeeName) VALUES (2,'Rejil Justin');

update Employee set	EmployeeName='Renil Justin' where ID = 1;

