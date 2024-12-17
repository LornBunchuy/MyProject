<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database="lornbunchuy";
$con = mysqli_connect($hostname,$username,$password,$database);
if(isset($_GET["id"])){
    $id = $_GET["id"];
    $qry_delete = mysqli_query($con,'delete from table_category where category_id = '.$id);
    if($qry_delete){
        header("location:select.php");
    }

}?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>All Categories</h1>
    <p><a href="add.php"> Add New </a></p>
    <?php
    if($con){
        $qry = mysqli_query($con,"select * from table_category order by category_at desc");
        if($qry){
            echo '<table border=1>';
            echo '<tr><td>Category ID</td><td>Category Name</td><td>Date</td><td>Action</td></tr>';
            while($row=mysqli_fetch_array($qry,MYSQLI_ASSOC)){
                echo '<tr>';
                    echo '<td>'.$row["category_id"].'</td>';
                    echo '<td>'.$row["category_name"].'</td>';
                    echo '<td>'.$row["category_at"].'</td>';
                    echo '<td> <a href="select.php?id='.$row["category_id"].'" 
                    onclick="return confirm(\'Are you sure you want to delete this item?\');">Delete</a> | Edit </td>';
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