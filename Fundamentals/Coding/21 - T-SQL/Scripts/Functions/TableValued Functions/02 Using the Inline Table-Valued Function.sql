use C21_DB1;

-- Example 1: Select all students studying Math
SELECT *
FROM dbo.GetStudentsBySubject('Math')

-- Example 2: Get the average grade of students studying Science
SELECT AVG(Grade) as Average
FROM dbo.GetStudentsBySubject('Science')


