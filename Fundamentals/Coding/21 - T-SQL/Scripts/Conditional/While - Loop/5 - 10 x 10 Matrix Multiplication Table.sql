-- 10 x 10 Matrix Multiplication Table

DECLARE @row INT = 1;
DECLARE @col INT;
DECLARE @result INT;
DECLARE @rowString VARCHAR(255);
DECLARE @headerString VARCHAR(255);

-- Create the header row for the columns
SET @headerString = CHAR(9); -- Starting with a tab for the row header space
SET @col = 1;
WHILE @col <= 10
BEGIN
    SET @headerString = @headerString + CAST(@col AS VARCHAR) + CHAR(9); -- Append column headers
    SET @col = @col + 1;
END
PRINT @headerString;

-- Generate the multiplication table
WHILE @row <= 10
BEGIN
    SET @col = 1;
    SET @rowString = CAST(@row AS VARCHAR) + CHAR(9); -- Start each row with the row number

    WHILE @col <= 10
    BEGIN
        SET @result = @row * @col;
        SET @rowString = @rowString + CAST(@result AS VARCHAR) + CHAR(9); -- Append multiplication results
        SET @col = @col + 1;
    END

    PRINT @rowString; -- Print the row
    SET @row = @row + 1;
END

