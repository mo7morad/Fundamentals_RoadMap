
use C21_DB1;

--This loop iterates over each employee in the Employees table.

DECLARE @EmployeeID INT;
DECLARE @Name varchar(50);
DECLARE @MaxID INT;

-- Initialize the starting point
SELECT @EmployeeID = MIN(EmployeeID) FROM Employees;

-- Find the maximum EmployeeID
SELECT @MaxID = MAX(EmployeeID) FROM Employees;

-- Loop through employees
WHILE @EmployeeID IS NOT NULL AND @EmployeeID <= @MaxID
BEGIN
    -- Perform an operation, e.g., print employee's name
    SELECT @Name=Name FROM Employees WHERE EmployeeID = @EmployeeID;
	PRINT @Name;

    -- Get the next EmployeeID
    SELECT @EmployeeID = MIN(EmployeeID) FROM Employees WHERE EmployeeID > @EmployeeID;

END
