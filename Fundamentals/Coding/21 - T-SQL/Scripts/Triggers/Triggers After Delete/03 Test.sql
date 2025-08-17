
-- Assuming there is a student with StudentID = 110 in the Students table

--select * from students;

-- Deleting a student
DELETE FROM Students WHERE StudentID = 110;


-- Checking the delete log table
SELECT * FROM StudentDeleteLog;