CREATE PROC TeacherReg
@ID varchar(50),
@Name varchar(50),
@Email varchar(50),
@Phone varchar(50),
@Password varchar(50)
AS
	INSERT INTO Teacher (ID,Name,Email,Phone,Password) VALUES (@ID,@Name,@Email,@Phone,@Password)
	