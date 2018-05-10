<?php

$serverName = "argame.database.windows.net";
$username = "argame";
$password = "<type your password here>";
$dbname = "AR_Game";

if (!empty($_REQUEST)){
    
    $score = $_REQUEST["scorePost"];

    echo($score);
    
        $conn = new mysqli($serverName, $server_username, $server_password, $dbName);
        //Check Connection
        if (!$conn) {
            die("Connection Failed." . mysqli_connect_error());
        
        
        //echo $score;

        $sql = "INSERT INTO scores(SCORE) VALUES ('".$score."')";
        $result = mysqli_query($conn, $sql);

        if (!$result) echo "there was an error";
        else echo "Okay, score inserted :)\n";
    }
}

?>
