<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database ="lornbunchuy";
$con = mysqli_connect($hostname,$username,$password,$database);
if(isset($_GET["id"])){
    $id = $_GET["id"];
    $qry_delete = mysqli_query($con,'delete from table_student where student_id = '.$id);
    if($qry_delete){
        header("location:select.php");
    }

}?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>All Student Form</title>
   
</head>

<body>
    <h1>Form All Students</h1>
    
    <?php
    if($con){
        $qry = mysqli_query($con,"select * from table_student order by date_of_birth desc");
        if($qry){
            echo '<table border=1>';
            echo '<tr><td>student_id</td><td>student_name</td><td>date_of_birth</td><td>Action</td></tr>';
            while($row=mysqli_fetch_array($qry,MYSQLI_ASSOC)){
                echo '<tr>';
                    echo '<td>'.$row["student_id"].'</td>';
                    echo '<td>'.$row["student_name"].'</td>';
                    echo '<td>'.$row["date_of_birth"].'</td>';
                    echo '<td> <a href="select.php?id='.$row["student_id"].'" 
                    onclick="return confirm(\'Are you sure you want to delete this item?\');">Delete</a> | <a href="edit.php?id='.$row["student_id"].'">Edit</a></td>';
                echo '</tr>';
            }
            echo '</table>';
        }
    }
    else{
        echo "Connect failed.";
    }
    ?>
</body>
</html>