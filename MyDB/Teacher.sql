CREATE TABLE [dbo].[Teacher]
(
	[ID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [CourseCode] VARCHAR(50) NULL
)
