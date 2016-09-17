SELECT 
*
FROM
[Blog].[dbo].[Users]
WHERE
id IN (SELECT AuthorId
              FROM 
			  [Blog].[dbo].[Posts])