
use ToDo;
GO

/****** Object: Table [dbo].[Tasks] Script Date: 29/05/2019 12:26:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE IF EXISTS [dbo].[Tasks]
DROP TABLE IF EXISTS [dbo].[Users]
DROP TABLE IF EXISTS [dbo].[Categories]

 

 
GO
CREATE TABLE [dbo].[Users] (
    [UserID]   INT NOT NULL IDENTITY PRIMARY KEY,
    [UserName] NVARCHAR (50) NOT NULL
);
 
 

GO
CREATE TABLE [dbo].[Categories] (
    [CategoryID]   INT NOT NULL IDENTITY PRIMARY KEY,
    [CategoryName] NVARCHAR (50) NOT NULL
);

GO
CREATE TABLE [dbo].[Tasks] (
    [TaskID]       INT NOT NULL IDENTITY PRIMARY KEY,
    [TaskName]      NVARCHAR (50) NOT NULL,
    [Done]          BIT           NULL,
    [DateStarted]   DATE          NULL,
    [DateCompleted] DATE          NULL,
    [CategoryID]   INT NULL FOREIGN KEY REFERENCES Categories(CategoryID),
    [UserID]       INT NULL FOREIGN KEY REFERENCES Users(UserID),
	[Deadline]		 DATE          NULL
);




SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Home')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Work')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Family')
SET IDENTITY_INSERT [dbo].[Categories] OFF


SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (1, N'John')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (2, N'Jane')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (3, N'Sophie')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (6, N'Lilly')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (10, N'Rupi')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (11, N'Test')
SET IDENTITY_INSERT [dbo].[Users] OFF



SET IDENTITY_INSERT [dbo].[Tasks] ON
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (1, N'walk to work', 1, NULL, NULL, 3, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (2, N'Complete project', 1, NULL, NULL, 1, 2)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (3, N'organise family event', 1, NULL, NULL, 1, 3)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (4, N'make lunch', 1, N'2019-12-05', N'2019-12-07', 2, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (5, N'eat lunch', 1, N'2019-12-04', N'2019-12-15', 1, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (7, N'wash dishes', 1, N'2019-10-02', NULL, 3, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (8, N'eat', 1, N'2019-11-11', NULL, 3, 2)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (9, N'Learning more', NULL, N'2019-01-31', N'2019-01-31', NULL, 3)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (10, N'learning stuff', 1, N'2019-10-02', NULL, 1, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (11, N'eat moref', 1, N'2019-11-17', NULL, 2, 2)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (12, N'break time', NULL, N'2019-03-21', NULL, NULL, 3)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (13, N'do presentation', 1, N'2019-10-02', NULL, 1, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (15, N'Do Work', 1, N'2019-08-08', NULL, 2, 3)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (18, N'Do Work', 1, N'2019-04-30', NULL, 1, 3)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (23, N'rfgjhk', NULL, NULL, NULL, NULL, NULL)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (26, N'Hi Ollie', 1, NULL, NULL, 2, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (27, N'Make Jassi Cake', NULL, NULL, NULL, 3, 10)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (28, N'Test2', 1, NULL, NULL, 2, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskName], [Done], [DateStarted], [DateCompleted], [CategoryID], [UserID]) VALUES (29, N'asdfg', 0, N'2019-03-02', NULL, 2, 2)
SET IDENTITY_INSERT [dbo].[Tasks] OFF

