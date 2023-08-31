Select 5-4 "Difference"
 GO
 --Creating Table
Create Table Gamers
(
	Id int  Identity(1,1),
	FirstName varchar(20),
	LastName varchar(20),
	Player_Role varchar(20),
	CitizenshipNO int
)
GO

--Selecting All from table
Select * From Gamers
GO

--Inserting into table 5 values
Insert Into Gamers values('Prasiddha','Shrestha','IGL',22)
GO 5

--Selecting All from table
Select * From Gamers
GO

--Renaming the column name in table syntax:EXEC sp_rename 'table_name.old_column_name', 'new_column_name', 'COLUMN';
Exec sp_rename 'Gamers.CitizenshipNO','Age','COLUMN';

--Updating table data 
Update Gamers 
Set FirstName = 'Rohan', LastName = 'Shahi', Player_Role = 'Initiator', Age = 23
Where Id=2
GO
Update Gamers 
Set FirstName = 'Samrat', LastName = 'Shah', Player_Role = 'Support', Age = 23
Where Id=3
GO
Update Gamers 
Set FirstName = 'Ashim', LastName = 'Pokharel', Player_Role = 'Lurker', Age = 22
Where Id=4
GO
Update Gamers 
Set FirstName = 'Prishank', LastName = 'K.C', Player_Role = 'Controller', Age = 21
Where Id=5
GO
Insert Into Gamers values('Prasiddha','Shrestha','IGL',22)
GO
Update Gamers 
Set FirstName = 'Necro', LastName = 'Butcher', Player_Role = 'Duelist', Age = 22
Where Id=6
GO

--Selecting where firstname start with P
Select * From Gamers
Where FirstName Like 'P%' 
GO

--Selecting where firstname or Lastname Contains P
Select * From Gamers
Where FirstName Like '%P%' Or LastName Like '%P%'
GO

--Selecting From table whose age is 23
Select * From Gamers
Where Age = 23
GO

-- Update the age to 25 if the firstname or lastname contains the letter o
Update Gamers 
Set Age = 25
Where FirstName Like '%o%' or LastName Like '%o%'
GO
--Updating Gamer Id 6 Age
Update Gamers 
Set FirstName = 'Necro', LastName = 'Butcher', Player_Role = 'Duelist', Age = 22
Where Id=6
GO
/* Write a query to produce the following output
Age     AgeCount
----------------
20         1
30         5
*/

Select Age, Count(Age) as AgeCount
From Gamers
Group by Age
Go

-- show only agecount greater than 1

Select Age, Count(Age) as AgeCount
From Gamers
Group by Age
having count(Age)>1
Go

--Selecting All from table
Select * From Gamers
GO

--Adding another colum for email
Alter Table Gamers
Add Email Varchar(20) Default 'abc@gmail.com'
GO
--Inserting Another data to see default email
Insert into Gamers (FirstName,LastName,Player_Role,Age) Values('Haribol','Yadav','Sentinel',20)
GO

--Seleting datas whose email value is null
SELECT * FROM Gamers
WHERE LastName is NULL
GO

--Seleting datas whose email value isnot null
SELECT * FROM Gamers
WHERE Email IS NOT NULL
GO

--Updating value of email
Update Gamers 
Set Email =   CONCAT(FirstName,'@gmail.com')
Where Email is NULL
Go

Update Gamers
Set Email=Lower(Email)
WHERE Id < 7
Go

--Deleting
Delete From Gamers
Where Id>7
GO

Insert into Gamers Values('Prasiddha','Shrestha','IGL',22,'praj@gmail.com')

Select *
From Gamers
Where Age not in (25,30)

update Gamers
Set Email = Null
Where Age =25
 
 update Gamers
 Set Email = 'deepesh@gmail.com'
Where id like '%1' and Email is null

Select  CONCAT(FirstName,' ',LastName) as 'Full Name', IsNull(Email,'-') as 'Email address' From Gamers 
GO
--Distinct
Select  Distinct CONCAT(FirstName,' ',LastName) as 'Full Name' From Gamers
Go
--OrderBY
Select *
From Gamers
Order by FirstName Asc
GO
Select *
From Gamers
Order by FirstName Desc
GO

-- Find the current maximum ID value
Select Max(Id) From Gamers
-- Reset the identity seed to the desired number (e.g., 7)
DBCC CHECKIDENT('Gamers', RESEED, 7);

Insert into Gamers Values('Prasiddha','Shrestha','IGL',22,'praj@gmail.com')
Go 3

--Select Top used to specify the number of records to return.
SELECT TOP 3 * FROM Gamers
SELECT  * FROM Gamers
Select TOP 50 Percent * from Gamers

SELECT TOP 3 * FROM Gamers
Where Email = 'praj@gmail.com'

-- The MIN() function returns the smallest value of the selected column.
-- The MAX() function returns the largest value of the selected column.

Select Min(Age) as 'Minimum Age',Max(Age) as 'Maximum Age' From Gamers 

SELECT *
FROM Gamers
WHERE Age = (SELECT MIN(Age)  FROM Gamers)

--created new table Game
Create Table Game
(
	Id int Identity(1,1),
	Gamename varchar(20),
	gameprice int
	
)
GO
insert into Game Values('Valorant',10)
Go 5
Update Game
Set Gamename ='Csgo', gameprice =20
Where id =2
Update Game
Set Gamename ='Fifa', gameprice =20
Where id =3
Update Game
Set Gamename ='Apex', gameprice =20
Where id =4
Update Game
Set Gamename ='Naruto', gameprice =20
Where id =5
Select *From Game

--Join
Select Gamers.FirstName, Game.Gamename
From Gamers
Inner Join Game On Gamers.Id = Game.Id

Select Gamers.FirstName, Game.Gamename
From Gamers
Left Join Game On Gamers.Id = Game.Id

--Created another table Employee
Create Table Employee
(
	Id int Identity(1,1),
	FirstName varchar(20),
	LastName varchar(20),
	age int
)

Insert Into Employee values('Prasiddha','Shrestha',22)
Go 5
--update table Employee
Select *From Employee
Update Employee
Set FirstName = 'Rohan', LastName = 'Shahi', Age = 23
Where Id=2
GO
Update Employee 
Set FirstName = 'Samrat', LastName = 'Shah',  Age = 23
Where Id=3
GO
Update Employee
Set FirstName = 'Ashim', LastName = 'Pokharel', Age = 22
Where Id=4
GO
Update Employee 
Set FirstName = 'Karan', LastName = 'K.C',  Age = 21
Where Id=5
GO

--Union
SELECT FirstName FROM Gamers
UNION
SELECT FirstName FROM Employee
ORDER BY FirstName;
Go

Create Table Student
(
	Id int Not Null Unique Identity(1,1),
	FirstName varchar(20),
	LastName varchar(20),
	age int
)Go

Insert Into Student values('Prasiddha','Shrestha',22)
Go 5

Select *From Student
Update Student
Set FirstName = 'Rohan', LastName = 'Shahi', Age = 23
Where Id=2
GO
Update Student
Set FirstName = 'Hema', LastName = 'Shah',  Age = 23
Where Id=3
GO
Update Student
Set FirstName = 'Raj', LastName = 'Pokharel', Age = 22
Where Id=4
GO
Update Student 
Set FirstName = 'Karan', LastName = 'K.C',  Age = 21
Where Id=5
GO

--Drop table
Drop Table Student
Go

--Primary Key and Check constraint
Create Table Student
(
	Id int Not Null Primary Key Identity(1,1),
	FirstName varchar(20),
	LastName varchar(20),
	age int,
	Check (age>=20)
)

Insert Into Student values('Prasiddha','Shrestha',23)
Go 5

Select *From Student
Update Student
Set FirstName = 'Rohan', LastName = 'Shahi', age = 2
Where Id=2
GO
Update Student
Set FirstName = 'Hema', LastName = 'Shah',  age = 20
Where Id=3
GO
Update Student
Set FirstName = 'Raj', LastName = 'Pokharel', age = 23
Where Id=4
GO
Update Student 
Set FirstName = 'Karan', LastName = 'K.C',  age = 21
Where Id=5
GO

Create Table Student
(
	Id int Not Null Primary Key Identity(1,1),
	FirstName varchar(20),
	LastName varchar(20),
	age int,
	Check (age>=20)
)
Dbcc CheckIdent('Gamers',RESEED,7)
