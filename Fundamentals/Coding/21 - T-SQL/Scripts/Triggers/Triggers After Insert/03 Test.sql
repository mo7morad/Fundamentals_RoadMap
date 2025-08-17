
use C21_DB1;

-- Inserting a new student
INSERT INTO Students (StudentID, Name, Subject, Grade)
VALUES (110, 'ALi Doe', 'Mathematics', 75);

-- Checking the log table
SELECT * FROM StudentInsertLog;