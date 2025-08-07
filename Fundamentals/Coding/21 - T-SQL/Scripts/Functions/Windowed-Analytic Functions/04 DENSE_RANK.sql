
use C21_DB1;

--Assigns a rank to each row based on the values in the specified column.
SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (ORDER BY Grade DESC) AS GradeRank
FROM 
    Students;


SELECT 
    StudentID, 
    Name, 
    Grade,
    DENSE_RANK() OVER (ORDER BY Grade DESC) AS GradeRank
FROM 
    Students;
