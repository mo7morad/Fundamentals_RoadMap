use C21_DB1;

-- Declare a dynamic cursor named 'dynamic_cursor'.
-- A dynamic cursor reflects changes in the database while the cursor is open.
-- This cursor selects StudentID, Name, and Subject from the 'Students' table.
DECLARE dynamic_cursor CURSOR DYNAMIC FOR
SELECT StudentID, Name, Subject FROM dbo.Students;

-- Open the cursor. This initializes the cursor and makes it ready to use.
OPEN dynamic_cursor;

-- Declare variables to store the data for each row fetched by the cursor.
-- @StudentID will hold the StudentID, @Name for the student's name, and @Subject for the subject.
DECLARE @StudentID int, @Name nvarchar(50), @Subject nvarchar(50);

-- Fetch the first row of data from the cursor and store it in the declared variables.
FETCH NEXT FROM dynamic_cursor INTO @StudentID, @Name, @Subject;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Print the current row's student name and subject.
    PRINT 'Student Name: ' + @Name + ', Subject: ' + @Subject;

    -- Fetch the next row of data from the cursor.
    -- The loop will continue until there are no more rows to fetch.
    FETCH NEXT FROM dynamic_cursor INTO @StudentID, @Name, @Subject;
END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE dynamic_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE dynamic_cursor;
