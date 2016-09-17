SELECT 
users.username, posts.title
FROM 
users
JOIN
posts ON users.id = posts.author_id