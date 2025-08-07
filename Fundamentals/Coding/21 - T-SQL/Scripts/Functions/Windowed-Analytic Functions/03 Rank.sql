use C21_DB1;

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
FROM 
    Students order by grade desc;


--Assigns a rank to each row based on the values in the specified column.

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (ORDER BY Grade DESC) AS GradeRank
FROM 
    Students
	Students order by grade desc;
