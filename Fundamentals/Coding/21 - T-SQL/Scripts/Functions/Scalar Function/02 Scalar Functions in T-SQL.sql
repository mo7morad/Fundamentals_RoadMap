CREATE FUNCTION dbo.GetAverageGrade(@subject NVARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @averageGrade INT;


    SELECT @averageGrade = AVG(Grade)
    FROM Students
    WHERE Subject = @subject;


    RETURN @averageGrade;
END;
