use C21_DB1;

select * from students where studentid=1;

-- Updating the grade of the student
UPDATE Students
SET Grade = 88
WHERE StudentID = 1;

-- Checking the log table
SELECT * FROM StudentUpdateLog;

