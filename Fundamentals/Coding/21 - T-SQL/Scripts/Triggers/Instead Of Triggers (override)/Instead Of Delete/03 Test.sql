-- Assuming there is a student with StudentID = 4

select * from students;

-- Attempting to delete a student
DELETE FROM Students WHERE StudentID = 4;

Update Students SET IsActive = 1 Where StudentID !=4

-- Checking the status of the student record
SELECT StudentID, Name, IsActive FROM Students WHERE StudentID = 4;
