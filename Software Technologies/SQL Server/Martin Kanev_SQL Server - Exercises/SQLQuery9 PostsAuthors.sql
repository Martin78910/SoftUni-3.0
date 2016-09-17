SELECT 
UserName, FullName
FROM 
[Blog].[dbo].[Users]
WHERE
id IN (SELECT 
AuthorID 
FROM 
[Blog].[dbo].[Posts]

)