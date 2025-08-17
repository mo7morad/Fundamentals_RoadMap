

CREATE TRIGGER trg_InsertStudentView ON StudentView
INSTEAD OF INSERT
AS
BEGIN
    -- Insert into PersonalInfo
    INSERT INTO PersonalInfo (StudentID, Name, Address)
    SELECT StudentID, Name, Address FROM inserted;

    -- Insert into AcademicInfo
    INSERT INTO AcademicInfo (StudentID, Course, Grade)
    SELECT StudentID, Course, Grade FROM inserted;
END;
