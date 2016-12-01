CREATE TABLE [dbo].[Table]
(
	[applicantID] INT NOT NULL PRIMARY KEY, 
    [lastName] NCHAR(10) NOT NULL, 
    [firstName] NCHAR(10) NOT NULL, 
    [emailAddress] NCHAR(10) NOT NULL, 
    [positionApplied] NCHAR(10) NOT NULL
)
