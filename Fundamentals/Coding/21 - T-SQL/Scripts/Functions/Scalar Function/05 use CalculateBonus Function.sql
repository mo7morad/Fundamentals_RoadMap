use c21_DB1;

select 
	Name,
	Salary,
	PerformanceRating, 
	dbo.CalculateBonus(PerformanceRating,Salary) as BonusAmount 
from employees2 