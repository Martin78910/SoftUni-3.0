SELECT p.title AS post,
  u.username AS author
FROM posts p JOIN users u
  ON p.author_id = u.id
