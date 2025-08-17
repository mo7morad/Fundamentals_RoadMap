CREATE TRIGGER trg_UpdateStudentView ON StudentView
INSTEAD OF UPDATE
AS
BEGIN
    -- Update PersonalInfo
    UPDATE PersonalInfo
    SET Name = I.Name, Address = I.Address
    FROM PersonalInfo
    INNER JOIN inserted I ON PersonalInfo.StudentID = I.StudentID;

    -- Update AcademicInfo
    UPDATE AcademicInfo
    SET Course = I.Course, Grade = I.Grade
    FROM AcademicInfo
    INNER JOIN inserted I ON AcademicInfo.StudentID = I.StudentID;
END;

