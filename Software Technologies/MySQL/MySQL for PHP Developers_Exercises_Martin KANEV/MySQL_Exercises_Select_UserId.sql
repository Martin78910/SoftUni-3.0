SELECT 
username, fullname
FROM 
users
WHERE id IN(SELECT author_id FROM posts WHERE id=4)