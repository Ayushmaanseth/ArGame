
<?php

$serverName = "argame.database.windows.net";
$username = "argame";
$password = "<type your password here>";
$dbname = "AR_Game";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 


$sql= "CREATE TABLE scores ( SCORE INT(6) UNSIGNED PRIMARY KEY )";

//$getResults= sqlsrv_query($conn, $tsql);
//echo ("Reading data from table" . PHP_EOL);
if ($conn->query($sql) === TRUE) {
    echo "Table Scores created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}


$conn->close();
?>
