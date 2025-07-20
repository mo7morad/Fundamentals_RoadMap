DECLARE @row INT = 1;
-- Example 4 - Nested While Loops - 10 x 10 Multiplication Table
DECLARE @col INT;
DECLARE @result INT;

WHILE @row <= 10
BEGIN
    SET @col = 1;
    WHILE @col <= 10
    BEGIN
        SET @result = @row * @col;
        PRINT CAST(@row AS VARCHAR) + ' x ' + CAST(@col AS VARCHAR) + ' = ' + CAST(@result AS VARCHAR);
        SET @col = @col + 1;
    END
    SET @row = @row + 1;
END


