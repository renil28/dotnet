use MyDB2

--Create Table Employee
create table Employee(ID int identity(1,1) primary key,
EmployeeID varchar(100),
FirstName varchar(100),
LastName varchar(100),
Salary int,
Gender varchar(100),
CreatedOn datetime DEFAULT GETDATE());

select * from Employee;

create function GetEmployeeID()
returns varchar(2000)
as
BEGIN
return (select CONCAT('EMP0', ID) EmployeeID from Employee)
END

ALTER TABLE EMPLOYEE
ALTER COLUMN EmployeeID varchar(100) ;

--Using proc to InsertData
alter proc InsertData(@FirstName varchar(200), @LastName varchar(200), @EmployeeID varchar(200), @salary int, @gender varchar(200))
as 
BEGIN

IF((select count(*) from Employee where EmployeeID = @EmployeeID)>0)
BEGIN
insert into Employee(FirstName,LastName,EmployeeID, Salary, Gender) values(@FirstName, @LastName, @EmployeeID, @salary, @gender);
update Employee set EmployeeID = dbo.GetEmployeeID();
END

ELSE

BEGIN
insert into Employee(FirstName,LastName,EmployeeID, Salary, Gender) values(@FirstName, @LastName, @@IDENTITY, @salary, @gender);
update Employee set EmployeeID = dbo.GetEmployeeID();
END

END;

exec InsertData 'Renil', 'Justin', '123',23132,'Male'
exec InsertData 'Rejil', 'Justin', '113',23132,'Male'

select * from Employee;

delete from Employee where ID = 3;