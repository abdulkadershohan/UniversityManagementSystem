CREATE TABLE [dbo].[Teach] (
    [ID]          VARCHAR (50) NOT NULL,
    [Course_Code] VARCHAR (20) NOT NULL,
    [Intake_Sec] VARCHAR(50) NOT NULL, 
    [Department] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC, [Course_Code] ASC)
);
