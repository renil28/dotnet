Create database MyDB;
use MyDB;

--DDL
Create Table Employee(ID int identity(1,1), EmployeeName varchar(200));
--Create Table Employee(ID int , EmployeeName varchar(200));

--DQL
select * from Employee;

--DML
insert into Employee(ID, EmployeeName) VALUES (1,'Remil Justin');
insert into Employee(ID, EmployeeName) VALUES (2,'Rejil Justin');

insert into Employee(EmployeeName) VALUES ('Renil Justin');
insert into Employee(EmployeeName) VALUES ('Rejil Justin');

update Employee set	EmployeeName='Renil Justin' where ID = 1;

delete from Employee where ID = 1;

truncate table Employee;

drop table Employee;


--in like not in between or and
select * from Employee where id in (1,2,3);

select * from Employee where id not in (1);
