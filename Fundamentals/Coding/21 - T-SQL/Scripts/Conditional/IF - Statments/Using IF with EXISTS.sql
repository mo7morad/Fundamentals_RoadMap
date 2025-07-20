
use C21_DB1;


IF  EXISTS (SELECT * FROM Employees WHERE Name = 'John Smith')
	BEGIN
		PRINT 'Yes, John Smith is there.'
	END
ELSE
	BEGIN
		PRINT 'No, John Smith is there.'
	END