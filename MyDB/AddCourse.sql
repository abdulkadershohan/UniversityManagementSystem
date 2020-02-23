CREATE PROC AddCourse
@ID varchar(50),
@Course_Code varchar(50),
@Department varchar(50),
@Intake_Sec Varchar(50)
AS
	INSERT INTO Teach(ID,Course_Code,Intake_Sec,Department) VALUES (@ID,@Course_Code,@Intake_Sec,@Department)
