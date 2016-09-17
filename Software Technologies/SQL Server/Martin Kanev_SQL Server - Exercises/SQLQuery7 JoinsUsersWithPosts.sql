SELECT 
[Blog].[dbo].[Users].Username, [Blog].[dbo].[Posts].Title
FROM
[Blog].[dbo].[Users]
JOIN
[Blog].[dbo].[Posts] ON [Blog].[dbo].[Users].id=[Blog].[dbo].[Posts].AuthorId