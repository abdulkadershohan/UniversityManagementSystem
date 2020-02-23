CREATE TABLE [dbo].[Present_Course_Marks] (
    [ID]          VARCHAR(50)        NOT NULL,
    [Course_Code] VARCHAR (10) NOT NULL,
    [Mid]         FLOAT (53) NULL,
    [Final]       FLOAT (53) NULL,
    [Out of 30]   FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC, [Course_Code] ASC)
);

