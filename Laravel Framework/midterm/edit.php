<?php
$hostname = "localhost";
$username = "root";
$password = "";
$database = "lornbunchuy";
$student_id = "";
$student_name = "";
$date_of_birth = "";
$con = mysqli_connect($hostname, $username, $password, $database);

if (!$con) {
    die("Connection failed: " . mysqli_connect_error());
}

if (isset($_GET["id"])) {
    $qry = mysqli_query($con, "SELECT * FROM table_student WHERE student_id='" . $_GET["id"] . "'");
    while ($row = mysqli_fetch_array($qry, MYSQLI_ASSOC)) {
        $student_id = $row["student_id"];
        $student_name = $row["student_name"];
        $dateofbirth = $row["date_of_birth"]; 
    }
}

if (isset($_POST["button_update"])) {
    $qry_update = mysqli_query($con, "UPDATE table_student SET student_name='" . $_POST["text_student_name"] . "', date_of_birth='" . $_POST["text_date_of_birth"] . "' WHERE student_id='" . $_POST["text_student_id"] . "'");
    if ($qry_update) {
        header("location:select.php");
    } else {
        echo "Error updating record: " . mysqli_error($con);
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Student</title>
    
   
</head>
<body>
    <h1>Form Update Student</h1>
    <form action="edit.php" method="post">
        <input type="hidden" name="text_student_id" value='<?php echo $student_id; ?>' />
        <label>student_name</label><input type="text" name="text_student_name" value='<?php echo $student_name; ?>' /><br />
        <label>date_of_dirth</label><input type="text" name="text_date_of_birth" value='<?php echo $date_of_birth; ?>' /><br />
        <input type="submit" name="button_update" value="Update" />
    </form>
</body>
</html>