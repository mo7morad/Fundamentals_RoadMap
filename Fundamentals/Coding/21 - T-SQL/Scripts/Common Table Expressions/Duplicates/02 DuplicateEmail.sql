
WITH DuplicateEmails AS (
    SELECT 
        Email, 
        COUNT(*) AS DuplicateEmail
    FROM Contacts
    GROUP BY Email
    HAVING COUNT(*) > 1
)
SELECT c.ContactID, c.Name, c.Email
FROM Contacts c
INNER JOIN DuplicateEmails de ON c.Email = de.Email;


-- OR

WITH duplicateEmails AS
(
  SELECT DISTINCT C1.* FROM Contacts C1 INNER JOIN Contacts C2 ON C1.ContactID != C2.ContactID AND C1.Email = C2.Email
)
SELECT * FROM duplicateEmails ORDER BY Email;