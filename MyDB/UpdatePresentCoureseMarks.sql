CREATE PROC UpdatePresentCoureseMarks
@ID varchar(50),
@Course_Code varchar(50),
@Mid float,
@Final float,
@Out_of_30 float,
@Total float
AS
	INSERT INTO Present_Course_Marks(ID,Course_Code,Mid,Final,Out_of_30,Total) VALUES (@ID,@Course_Code,@Mid,@Final,@Out_of_30,@Total)
