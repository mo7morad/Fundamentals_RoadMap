

CREATE TRIGGER trg_AfterDeleteStudent ON Students
AFTER DELETE
AS
BEGIN
  
    INSERT INTO StudentDeleteLog(StudentID, Name, Subject, Grade)
    SELECT StudentID, Name, Subject, Grade FROM deleted;


END;