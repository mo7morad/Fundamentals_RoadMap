DECLARE @Balance DECIMAL(10, 2) = 950.00; -- Example balance
DECLARE @Withdrawal DECIMAL(10, 2) = 100.00; -- Withdrawal amount

--Loop with Conditional Exit
WHILE @Balance > 0
BEGIN
    -- Perform a withdrawal
    SET @Balance = @Balance - @Withdrawal;

    IF @Balance < 0
		BEGIN
			PRINT 'Insufficient funds for withdrawal.';
			BREAK;
		END

    PRINT 'New Balance: ' + CAST(@Balance AS VARCHAR);
END