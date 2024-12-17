<?php
session_start();
if(!isset($_SESSION["username"])){
    header("location:login.php");
}

$hostname = "localhost";
$username = "root";
$password = "";
$database = "coca";
$con = mysqli_connect($hostname, $username, $password, $database);
if(isset($_POST["button_register"])){
    $email = $_POST["email"];
    $username = $_POST["username"];
    $password = md5($_POST["password"]);
    $qry = mysqli_query($con,"insert into table_user values(NULL,'$email','$username','$password')");
    if($qry){
        echo "Insert Succeeded";
    }
    else{
        echo "Insert failed";
    }
}
?>
<html>
    <head>
        <title>Register</title>
        
    </head>
    <body>
        <h1>Register</h1>
        <form action="register.php" method="post">
            <label>Email</label><input type="email" name="email" /><br />
            <label>Username</label><input type="text" name="username" /><br />
            <label>Password</label><input type="password" name="password" /><br />
            <input type="submit" name="button_register" value="Register" />
        </form>
    </body>
</html>