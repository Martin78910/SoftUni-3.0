DELETE FROM posts
WHERE author_id = 
  (SELECT id FROM users
   WHERE username = 'pepi');
