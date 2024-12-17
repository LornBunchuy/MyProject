<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database = "lornbunchuy";
if(isset($_POST["button_add"])){
    $student_name = $_POST["text_student_name"];
    $dateofbirth = $_POST["text_date_of_birth"];
    $con = mysqli_connect($hostname,$username,$password,$database);
    if ($con == true){
        $qry = mysqli_query($con,"insert into table_student values(NULL,'$student_name','$dateofbirth')");
        if($qry == true){
            echo "<p class='success-message'>Insert succeeded</p>";
        }
        else{
            echo "<p class='error-message'>Insert Failed</p>";
        }
    }
    else{
        echo "<p class='error-message'>Connect failed</p>";
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Form Add Student</title>
</head>
<body>
    <h1>Form Add Student</h1>
    <form action='insert.php' method="post">
        <label>student_name</label><input type="text" name="text_student_name"/><br />
        <label>date_of_birth</label><input type ="text" name="text_date_of_birth" /><br />
        <input type="submit" name="button_add" value="Save" />
    </form>    
</body>
</html>