
CREATE TRIGGER trg_AfterInsertStudent ON Students
AFTER INSERT

AS
BEGIN
  
  
    INSERT INTO StudentInsertLog(StudentID, Name, Subject, Grade)
    SELECT StudentID, Name, Subject, Grade FROM inserted;


END;
