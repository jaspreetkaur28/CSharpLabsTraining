Use Northwind; 
drop database IF EXISTS ToDo
go
create database ToDo
use ToDo
go
CREATE TABLE Categories(CategoryID INT NOT NULL IDENTITY PRIMARY KEY, CategoryName NVARCHAR(50) NOT NULL); 
CREATE TABLE Users(UserID INT NOT NULL IDENTITY PRIMARY KEY, UserName NVARCHAR(50) NOT NULL); 
CREATE TABLE Tasks(TaskID INT NOT NULL IDENTITY PRIMARY KEY, 
TaskName NVARCHAR(50) NOT NULL, Done Bit Null, DateStarted Date Null, DateCompleted Date Null, 
CategoryID INT NULL FOREIGN KEY REFERENCES Categories(CategoryID), UserID INT NULL FOREIGN KEY REFERENCES Users(UserID)
  );


SET IDENTITY_INSERT [ToDo.Categories] ON
INSERT INTO [ToDo.Categories] ([(CategoryID], [CategoryName]) VALUES (1, 'Home'),(2, 'Work'),(3, 'Family') 
SET IDENTITY_INSERT [ToDo.Categories] OFF

SET IDENTITY_INSERT [ToDo.Users] ON
INSERT INTO [ToDo.Users]([(UserID], [UserName]) VALUES (1, 'John'),(2, 'Jane'),(3, 'Sophie')
SET IDENTITY_INSERT [ToDo.Users] OFF

SET IDENTITY_INSERT [ToDo.Tasks] ON
INSERT INTO [ToDo.Users]([(TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) 
			VALUES (1, "Pick up milk", null, 28/05/2019,null, 1, 1),
				(2, "Complete project", null, null, 2, 2),(3, "organise family event", null, null, 2, 3)
SET IDENTITY_INSERT [ToDo.Tasks] OFF
