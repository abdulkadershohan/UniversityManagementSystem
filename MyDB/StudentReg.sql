CREATE PROC StudentReg
@ID varchar(50),
@Name varchar(50),
@Department varchar(50),
@Email Varchar(50),
@Phone varchar(50),
@Intake_Sec varchar(50),
@Password varchar(50)
AS
	INSERT INTO Student(ID,Name,Department,Email,Phone,Intake_Sec,Password) VALUES (@ID,@Name,@Department,@Email,@Phone,@Intake_Sec,@Password)
