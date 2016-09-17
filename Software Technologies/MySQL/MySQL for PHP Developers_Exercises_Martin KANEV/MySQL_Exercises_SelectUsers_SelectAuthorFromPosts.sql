SELECT*FROM users
WHERE id IN(SELECT author_id FROM posts)