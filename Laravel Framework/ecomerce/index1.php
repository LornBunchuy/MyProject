<?php
$java = 90;
$php = 80;
$cshap = 9;
$total = $java + $php + $cshap;
$average = $total / 3;
echo "Total is :" . $total."<br />";
print "average is :".$average."<br />";
if($average >= 50){
    echo "Pass <br />";
}
else if($average< 50){
    echo " Fail <br />";
}
?>