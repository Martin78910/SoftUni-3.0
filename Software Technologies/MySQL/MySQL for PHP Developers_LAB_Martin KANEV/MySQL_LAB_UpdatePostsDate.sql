UPDATE posts
SET date = STR_TO_DATE('2016-12-31', '%Y-%m-%d')
WHERE YEAR(date) = 2016;
