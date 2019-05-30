USE [HP]
GO

/****** Object: Table [dbo].[Actors] Script Date: 29/05/2019 17:38:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Actors];


GO
CREATE TABLE [dbo].[Actors] (
    [ActorID]     INT NOT NULL IDENTITY PRIMARY KEY,
    [ActorName]   NVARCHAR (50) NOT NULL,
    [CharacterID] INT           NULL
);
 