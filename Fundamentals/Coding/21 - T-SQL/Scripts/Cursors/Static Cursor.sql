use C21_DB1;

-- Declare a static cursor named 'static_cursor'. 
-- A static cursor creates a snapshot of the result set at the time of cursor creation.
-- This cursor selects StudentID, Name, and Grade from the 'Students' table.
DECLARE static_cursor CURSOR STATIC FOR
SELECT StudentID, Name, Grade FROM dbo.Students;

-- Open the cursor. This initializes the cursor and makes it ready to use.
OPEN static_cursor;

-- Declare variables to store the data for each row fetched by the cursor.
-- @StudentID will hold the StudentID, @Name for the student's name, and @Grade for the grade.
DECLARE @StudentID int, @Name nvarchar(50), @Grade int;

-- Fetch the first row of data from the cursor and store it in the declared variables.
FETCH NEXT FROM static_cursor INTO @StudentID, @Name, @Grade;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Print the current row's student name and grade.
    PRINT 'Student Name: ' + @Name + ', Grade: ' + CAST(@Grade AS NVARCHAR(10));

    -- Fetch the next row of data from the cursor.
    -- The loop will continue until there are no more rows to fetch.
    FETCH NEXT FROM static_cursor INTO @StudentID, @Name, @Grade;
END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE static_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE static_cursor;



