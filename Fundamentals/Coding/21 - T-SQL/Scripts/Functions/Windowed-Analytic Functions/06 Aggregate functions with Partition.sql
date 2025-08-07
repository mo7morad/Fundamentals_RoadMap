use C21_DB1;

--You can apply aggregate functions over a window of rows specified by the PARTITION BY clause.
SELECT StudentID, Name, Subject, Grade,
       AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
       SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade
FROM Students

order by subject;
