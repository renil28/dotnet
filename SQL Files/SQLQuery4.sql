use MyDB;

select * from Employee;

--Create a table student with primary key and default values
create table student(id int identity(1,1), FirstName varchar(200) NOT NULL, 
LastName varchar(200), ClassName int, CreatedOn datetime DEFAULT GETDATE(), PRIMARY KEY(id) )

--Call inbuilt function GETDATE()
select GETDATE();

select * from student;

--Insert Values
insert into student(FirstName, LastName, ClassName) VALUES('Renil', 'Justin', 1)
insert into student(FirstName, LastName, ClassName) VALUES('Rejil', 'Justin', 2)

--Concat names to create a fullname
select CONCAT(FirstName,' ',LastName) FullName from student

--Creating a funtion for full name
create function GetFullName(@ID INT)
returns varchar(2000)
as
BEGIN
return (select CONCAT(FirstName,' ',LastName) FullName from student where id =@ID)
END

--If you want full name for all the ids
SELECT dbo.GetFullName(id) as FullName from student;

--If you want full name for specific ids such id = 1
SELECT dbo.GetFullName(1) as FullName from student;