use c21_DB1;

--Sub Query
select * from 
(
  SELECT EmployeeId, Name, Sales
    FROM Employees6
    WHERE Department = 'Sales'
) SalesStaff ;



--CTE
WITH SalesStaff AS
(
    SELECT EmployeeId, Name, Sales
    FROM Employees6
    WHERE Department = 'Sales'
)
SELECT * FROM SalesStaff;