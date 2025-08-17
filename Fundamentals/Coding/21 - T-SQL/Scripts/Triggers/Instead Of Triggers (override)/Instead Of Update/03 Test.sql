
--Test
--select * from StudentView

UPDATE StudentView
SET Name = 'Mohammed', Course = 'Math', Grade = 66
WHERE StudentID = 1;

SELECT * FROM PersonalInfo WHERE StudentID = 1;
SELECT * FROM AcademicInfo WHERE StudentID = 1;
