<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
$mysqli->set_charset("utf8");
$query = "SELECT*FROM posts";
$result = $mysqli->query($query);
If(!$result){
    die('Error! Failed to process query');
}

If($result->num_rows>0){
    while ($row =$result->fetch_assoc()){
        echo "Id: " .htmlspecialchars($row['id'])."<br>"
            ."Title: " .htmlspecialchars($row['title'])."<br>"
            ."Content:" .htmlspecialchars($row['content'])."<br>"
            ."Date:" .htmlspecialchars($row['date'])."<br>";
    }
}
else{
    echo"0 results";
}
?>