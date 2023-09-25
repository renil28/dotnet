use MyDB;

select * from Employee;

--Create a table student with primary key and default values
create table student(id int identity(1,1), FirstName varchar(200) NOT NULL, 
LastName varchar(200), ClassName int, CreatedOn datetime DEFAULT GETDATE(), PRIMARY KEY(id) )

create table class(id int identity(1,1), ClassName varchar(200) NOT NULL);
insert into class(ClassName) values('MCA');
insert into class(ClassName) values('MBA');
insert into class(ClassName) values('MSc');

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

select FirstName, LastName, c.ClassName from 
student s inner join class c on s.id = c.id;

-- Creating View
Create View GetData as

select s.id, dbo.GetFullName(s.id) as FullName,c.ClassName, s.CreatedOn from 
class c inner join student s on c.id = s.id;

--Displaying View
select * from GetData;

--Using proc to InsertData
ALTER proc InsertData(@FirstName varchar(200), @LastName varchar(200), @ClassName varchar(200))
as 
BEGIN

IF((select count(*) from class where ClassName = @ClassName)>0)
BEGIN
insert into student(FirstName,LastName,ClassName) values(@FirstName, @LastName, (select id from class where ClassName = @ClassName));
END
ELSE

BEGIN

insert into class(ClassName) values(@ClassName);
insert into student(FirstName,LastName,ClassName) values(@FirstName, @LastName, @@IDENTITY);

END
END;

--Using InsertData
exec InsertData 'Suresh', 'Kumar', 'X'

select * from student;
select * from class;

select count(*) from class where ClassName= 'X'

