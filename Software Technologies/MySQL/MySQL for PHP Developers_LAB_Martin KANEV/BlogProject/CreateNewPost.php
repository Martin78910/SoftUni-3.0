<form>
    <div>Title</div>
    <input type="text" name="title">
    <div>Content</div>
    <textarea name="content"></textarea>
    <div><input type="submit" value="Post"></div>
</form>
<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
$mysqli->set_charset("utf8");
if ($mysqli->connect_errno) die('Cannot connect to MySQL');

if (isset($_GET['title'])) {
    $mysqli = new mysqli('localhost', 'root', '', 'blog');
    $mysqli->set_charset("utf8");
    $stmt = $mysqli->prepare(
        "INSERT INTO posts(title, content) VALUES (?, ?)");
    $stmt->bind_param("ss",
        $_GET['title'], $_GET['content']);
    $stmt->execute();
    if ($stmt->affected_rows == 1)
        echo "Post created.";
    else die("Insert post failed.");
}

?>