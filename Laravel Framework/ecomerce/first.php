<?php
$c_sharp = "";
$java="";
$php = "";
$cpp = "";
$phython = "";
$total = 0;
$average = 0;
$result = "";
$grade ="";
if(isset($_POST["button_ok"])){
    $c_sharp = $_POST["text_c_sharp"];
    $java = $_POST["text_java"];
    $php = $_POST["text_php"];
    $cpp = $_POST["text_cpp"];
    $phython = $_POST["text_phython"];
    $total = $c_sharp + $java + $php + $cpp + $phython;
    $average = $total / 5;
    if($average >=50){
        $result = "Pass";
        if($average>=90){
            $grade = "A";
        }
        else if ($average >= 80)
        {
            $grade = "B";
        }
        else if ($average >= 70)
        {
            $grade = "C";
        }
        else if ($average >= 60)
        {
            $grade = "D";
        }
    }
    else if($average < 50){
        $result = "Fail";
        $grade = "F";
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form method="post" action="first.php">
    <label>C#</label><input type="text" name="text_c_sharp" value='<?php echo $c_sharp;?>'/><br />
    <label>Java</label><input type="text" name="text_java" value='<?php echo $java;?>'/><br />
    <label>PHP</label><input type="text" name="text_php" value='<?php echo $php;?>'/><br />
    <label>Phython</label><input type="text" name="text_phython" value='<?php echo $php;?>'/><br />
    <label>C++</label><input type="text" name="text_cpp" value='<?php echo $php;?>'/><br />
    <hr />
    <input type="submit" name="button_ok" value="Calculate" /><br />
    <label>Total</label><input type="text" name="text_total" value='<?php echo $total;?>'/> <br />
    <label>Average</label><input type="text" name="text_average" value='<?php echo $average;?>' /><br />
    <label>Result </label><input type="text" name="text_result" value='<?php echo $result;?> '/><br />
    <label>Grade </label><input type="text" name="text_grade" value='<?php echo $grade;?> '/>
    
</form>
</body>
</html>