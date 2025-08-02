DECLARE @ID INT = 1;  -- Example PersonID
DECLARE @FName NVARCHAR(100);
DECLARE @LName NVARCHAR(100);
DECLARE @Email NVARCHAR(255);
DECLARE @Found BIT;

EXEC SP_GetPersonByID2
    @PersonID = @ID,
    @FirstName = @FName OUTPUT,
    @LastName = @LName OUTPUT,
    @Email = @Email OUTPUT,
    @IsFound = @Found OUTPUT;


IF @Found = 1
    SELECT @FName as FirstName, @LName as LastName, @Email as Email;
ELSE
    PRINT 'Person not found';
