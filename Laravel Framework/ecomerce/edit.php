<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database="lornbunchuy";
$category_id = "";
$category_name = "";
$category_at ="";
$con = mysqli_connect($hostname,$username,$password,$database);
if(isset($_GET["id"])){
    $qry=mysqli_query($con,"select * from table_category where category_id='".$_GET["id"]."'");
    while($row = mysqli_fetch_array($qry,MYSQLI_ASSOC)){
        $category_id = $row["category_id"];
        $category_name = $row["category_name"];
    }
}
if(isset($_POST["button_update"])){
    $qry_update = mysqli_query($con,"update table_category set category_name='".$_POST["text_category_name"]."',
    category_at='".date("Y-m-d H:i:s")."' where category_id='".$_POST["text_category_id"]."'");
    if($qry_update){
        header("location:select.php");
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit</title>
</head>
<body>
    <form action="edit.php" method="post">
        <label style="display:none">Category ID</label><input type="hidden" name="text_category_id" value='<?php echo $category_id;?>' /><br />
        <label>Category Name</label><input type="text" name="text_category_name" value='<?php echo $category_name;?>' /><br />
        <input type="submit" name="button_update" value="Update" /> 
    </form>
</body>
</html>