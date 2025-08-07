
use C21_DB1;
go

select * from Students;

-- Declare variables for paging
DECLARE @PageNumber AS INT, @RowsPerPage AS INT;

-- Set the page number to 2 (to retrieve the second page of results)
SET @PageNumber = 2;

-- Set the number of rows per page to 3
SET @RowsPerPage = 3;

-- Query to retrieve data with paging
SELECT StudentID, Name, Subject, Grade
FROM Students
-- Order the results by StudentID (or another column as desired)
ORDER BY StudentID
-- Calculate the number of rows to skip (offset) based on the current page
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS
-- Specify the number of rows to fetch after the offset
FETCH NEXT @RowsPerPage ROWS ONLY;

-- Explanation:
-- 1. @PageNumber is set to 2, indicating the second page is to be retrieved.
-- 2. @RowsPerPage is set to 3, meaning each page will display 3 records.
-- 3. The OFFSET clause skips (2-1)*3 = 3 rows (as this is page 2).
-- 4. The FETCH NEXT clause then fetches the next 3 rows after the offset.
-- 5. The result is records 4, 5, and 6 from the Students table, assuming
--    sequential ordering by StudentID.
