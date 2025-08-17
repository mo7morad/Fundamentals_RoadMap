use C21_DB1;

-- Declare a forward-only cursor named 'forward_only_cursor'.
-- Forward-only cursors can only move forward through the result set and do not support scrolling.
-- This cursor selects StudentID, Name, and IsActive from the 'Students' table.
DECLARE forward_only_cursor CURSOR STATIC FORWARD_ONLY FOR
SELECT StudentID, Name, IsActive FROM dbo.Students;

-- Open the cursor. This initializes the cursor and makes it ready to use.
OPEN forward_only_cursor;

-- Declare variables to store the data for each row fetched by the cursor.
-- @StudentID will hold the StudentID, @Name for the student's name, and @IsActive for the active status.
DECLARE @StudentID int, @Name nvarchar(50), @IsActive bit;

-- Fetch the first row of data from the cursor and store it in the declared variables.
FETCH NEXT FROM forward_only_cursor INTO @StudentID, @Name, @IsActive;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Print the current row's student name and their active status.
    PRINT 'Student Name: ' + @Name + ', IsActive: ' + CAST(@IsActive AS NVARCHAR(10));

    -- Fetch the next row of data from the cursor.
    -- Since this is a forward-only cursor, it can only move to the next row.
    FETCH NEXT FROM forward_only_cursor INTO @StudentID, @Name, @IsActive;
END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE forward_only_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE forward_only_cursor;
