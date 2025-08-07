use C21_DB1;

select * from students order by grade desc;

--Assigns a unique integer to each row within the result set.

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
FROM 
    Students order by grade desc;
