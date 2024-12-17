
<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database = "lornbunchuy";
if(isset($_POST["button_add"])){
    $category_name = $_POST["text_category_name"];
    $created_at = $_POST["text_created_at"];
    $con = mysqli_connect($hostname,$username,$password,$database);
    if ($con == true){
        $qry = mysqli_query($con,"insert into table_category values(NULL,'$category_name','$created_at')");
        if($qry == true){
            echo "insert succeeded";
        }
        else{
            echo "insert failed";
        }
    }
    else{
        echo "Connect failed";
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Add Category</title>
</head>
<body>
    <form action='add.php' method="post">
        <label>Category Name</label><input type="text" name="text_category_name"/><br />
        <label>Date</label><input type ="text" name="text_created_at" /><br />
        <input type="submit" name="button_add" value="Add" />
    </form>    
    
</body>
</html>