<?php
session_start();
$username = "";
$password = "";
$con = mysqli_connect("localhost","root","","coca" );
if(isset($_POST["button_login"])){
    $username = $_POST["username"];
    $password = md5($_POST["password"]);
    $qry = mysqli_query($con,"select * from table_user where username='$username' and password ='$password'");
  echo  $match = mysqli_num_rows($qry);
    if ($match == 1){
        $_SESSION["username"] = $username;
        header("location:dashboard.php");
    }
    else{
        echo "username or password is incorrent.";
    }
}
?>
<html>
    <head>
        <title>Log in</title>
    </head>
    <body>
        <h1>Log in</h1>
        <form action="login.php" method="post">
            <label>Username</label><input type="text" name="username" /><br />
            <label>Password</label><input type="password" name="password" /><br />
            <input type="submit" name="button_login" value="login" />
        </form>
    </body>
</html>