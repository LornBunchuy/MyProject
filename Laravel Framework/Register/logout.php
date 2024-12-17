<?php
session_start();

// Check if the user is not logged in
if(!isset($_SESSION["username"])){
    header("location:login.php");
    exit(); // Always add exit() after header redirects
}

// Unset all session variables
session_unset();

// Destroy the session
session_destroy();

// Redirect to login page
header("location:login.php");
exit();
?>