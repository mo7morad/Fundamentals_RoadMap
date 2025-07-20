
DECLARE @counter INT = 1;

--Break Example
--This loop will print numbers from 1 to 5. When the counter reaches 5, the BREAK statement exits the loop.
 PRINT 'Break Example: ' ;
WHILE @counter <= 10
BEGIN
    PRINT 'Counter: ' + CAST(@counter AS VARCHAR);
    IF @counter = 5
    BEGIN
        BREAK; -- Exits the loop when counter reaches 5
    END
    SET @counter = @counter + 1;
END


--This loop will print only odd numbers between 1 and 10. When the counter is even, the CONTINUE statement skips to the next iteration.
PRINT '' ;
PRINT 'Continue Example: ' ;
set @counter=1;


WHILE @counter <= 10
BEGIN
    SET @counter = @counter + 1;
    IF @counter % 2 = 0
    BEGIN
        CONTINUE; -- Skips the current iteration for even numbers
    END
    PRINT 'Counter: ' + CAST(@counter AS VARCHAR);
END
