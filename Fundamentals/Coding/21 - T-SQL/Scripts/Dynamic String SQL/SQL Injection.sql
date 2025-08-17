use c21_DB1;

    DECLARE @SQL NVARCHAR(MAX);
 --   SET @SQL = N'SELECT * FROM Employees where EmployeeID=1 or 1=1';
    SET @SQL = N'SELECT * FROM Employees where EmployeeID=1' ;
	
	print @SQL; 

	EXECUTE(@SQL);
