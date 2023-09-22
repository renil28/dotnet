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

select * from Employee where EmployeeName like '%Justin%';

Create table department(id int identity(1,1), DepartmentName varchar(2000));

insert into department values('IT');
insert into department values('Admin');
insert into department values('Support');
insert into department values('HR');

select * from department;
select * from Employee;

alter table Employee add deptID int;
update Employee set deptID = 1  where ID = 1;
update Employee set deptID = 2  where ID = 2;

--Demonstration of inner join, left join and right join
select emp.ID, emp.EmployeeName, dep.DepartmentName from Employee emp inner join department dep on emp.deptID = dep.id;
select emp.ID, emp.EmployeeName, dep.DepartmentName from Employee emp left join department dep on emp.deptID = dep.id;
select emp.ID, emp.EmployeeName, dep.DepartmentName from Employee emp right join department dep on emp.deptID = dep.id;

