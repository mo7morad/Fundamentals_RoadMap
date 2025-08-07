
select * from Accounts;

BEGIN TRANSACTION;

	BEGIN TRY
		-- Subtract $100 from Account 1
		UPDATE Accounts SET Balance = Balance - 100 WHERE AccountID = 1;

		-- Add $100 to Account 2
		UPDATE Accounts SET Balance = Balance + 100 WHERE AccountID = 2;

		-- Log the transaction
		INSERT INTO Transactions (FromAccount, ToAccount, Amount, Date) VALUES (1, 2, 100, GETDATE());

		-- Commit the transaction
		COMMIT;

	END TRY
	BEGIN CATCH
		-- Rollback in case of error
		ROLLBACK;
		-- Error handling code here (e.g., logging the error)
	END CATCH;


	select * from Accounts;
