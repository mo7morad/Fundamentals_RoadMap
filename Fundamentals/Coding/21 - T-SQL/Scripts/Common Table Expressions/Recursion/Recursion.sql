

WITH Numbers AS (


    SELECT 1 AS Number
    
	UNION ALL
   
    SELECT Number + 1 FROM Numbers WHERE Number < 10
)
SELECT * FROM Numbers;

