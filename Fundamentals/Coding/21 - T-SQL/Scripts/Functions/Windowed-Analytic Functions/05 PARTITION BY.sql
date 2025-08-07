use C21_DB1;

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER ( ORDER BY Grade DESC) AS GradeRank
FROM 
    Students;


SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS GradeRank
FROM 
    Students;

