

CREATE FUNCTION dbo.GetTopPerformingStudents( )

RETURNS @Result TABLE (
    StudentID INT,
    Name NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT
)
AS
BEGIN
    
	INSERT INTO @Result (StudentID, Name, Subject, Grade)
    SELECT TOP 3 StudentID, Name, Subject, Grade
    FROM Students
    ORDER BY Grade DESC;

    RETURN;
END;