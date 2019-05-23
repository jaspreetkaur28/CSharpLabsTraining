use Northwind;
go
drop database IF EXISTS ToDo
go
create database ToDo
go
use ToDo
go
CREATE TABLE Categories(CategoryID INT NOT NULL IDENTITY PRIMARY KEY, CategoryName NVARCHAR(50) NOT NULL); 
CREATE TABLE Users(UserID INT NOT NULL IDENTITY PRIMARY KEY, UserName NVARCHAR(50) NOT NULL); 
CREATE TABLE Tasks(TaskID INT NOT NULL IDENTITY PRIMARY KEY, 
TaskName NVARCHAR(50) NOT NULL, Done Bit Null, DateStarted Date Null, DateCompleted Date Null, 
CategoryID INT NULL FOREIGN KEY REFERENCES Categories(CategoryID), UserID INT NULL FOREIGN KEY REFERENCES Users(UserID)
  );
 
  SET IDENTITY_INSERT Tasks OFF
SET IDENTITY_INSERT Categories ON
INSERT INTO Categories (CategoryID, CategoryName) VALUES (1, 'Home'),(2, 'Work'),(3, 'Family') 
SET IDENTITY_INSERT Categories OFF
 
SET IDENTITY_INSERT Users ON
INSERT INTO Users(UserID, UserName) VALUES (1, 'John'),(2, 'Jane'),(3, 'Sophie')
SET IDENTITY_INSERT Users OFF
 
SET IDENTITY_INSERT Tasks ON
INSERT INTO Tasks(TaskID, TaskName, CategoryID, UserID) 
			VALUES (1,'Pick up milk', 1, 1),
				(2,'Complete project', 2, 2),
				(3,'organise family event', 3, 3)
SET IDENTITY_INSERT Tasks OFF

SET IDENTITY_INSERT Tasks ON
INSERT INTO Tasks(TaskID, TaskName, Done, DateStarted, CategoryID, UserID) 
			VALUES (4,'Make cupcakes',1, '12/05/2019', 1, 1),
				(5,'Fix Printer',1,'12/05/2019', 1, 1),   
				(6,'qwerty',1,'12/05/2019', 2, 2)
SET IDENTITY_INSERT Tasks OFF