
--Using Sub Query
select * from 
(

 SELECT Department, SUM(Sales) AS TotalSales
    FROM Employees6
    GROUP BY Department

) DepartmentSales;


-- Using CTE
WITH DepartmentSales AS
(
    SELECT Department, SUM(Sales) AS TotalSales
    FROM Employees6
    GROUP BY Department
)
SELECT Department, TotalSales FROM DepartmentSales;
