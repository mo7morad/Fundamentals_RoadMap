use C21_DB1;

select * from Students order by grade desc;


SELECT 
    StudentID, 
    Name, 
	LAG(Grade, 1) OVER (ORDER BY Grade DESC) AS PreviousGrade,
    Grade,
    Lead(Grade, 1) OVER (ORDER BY Grade DESC) AS NextGrade
FROM 
    Students order by grade desc;

