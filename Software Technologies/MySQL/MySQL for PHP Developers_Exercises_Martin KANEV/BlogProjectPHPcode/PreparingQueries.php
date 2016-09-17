<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
$mysqli->set_charset("utf8");
$query = $mysqli->prepare("INSERT INTO users(username,password,fullname)VALUES(?,?,?)");
$username="Greta";
$password=md5("IchLiebeWurstschen");
$fullname = "Greta Berghoffen";
$query->bind_param("sss",$username,$password,$fullname);
$query->execute();
if ($query->affected_rows ==1){
    echo "User successfully created!";
    }
    else {
        die("Inserting user failed");
    }

?>