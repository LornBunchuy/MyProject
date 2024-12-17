<?php
// Has return and parameter

//function body
// function add($a, $b){
//     $total=$a + $b;
//     return $total;
// }

// $value1 = 10;
// $value2 =5;

// //function call

// $resullt=add($value1, $value2);
// echo $resullt."\n";

// $second =add($resullt,100);
// echo $second."\n";



//Function Body
//Has Return and Has Parameters
function add($a, $b){
    $total = $a + $b;
    return $total;
}
//Has Return but Has no Parameter
function one_week(){
    return 7;
}
//Has no Return and Has no Parameters
function lines(){
    $l="";
    for($i=0;$i<50;$i++){
        $l = $l . "+";
    }
    echo "\n".$l."\n";
}
//Has no return but Has Parameters
function dlines($s){
    $l = " ";
    for($i=0;$i<50;$i++){
        $l = $l . $s;
    }
    echo "\n".$l."\n";
}
$value1 = 10;
$value2 = 5;
//Function Call
lines();
dlines("=");
$result = add($value1,$value2);
echo $result."\n";
dlines("$");
$second = add($result,one_week());
echo $second."\n";
dlines("*");
lines();




function dlr($value){
    return number_format($value,2,".",",")." $";
}
function riels($value){
    return number_format($value,2,".",",")." ៛";
}
$salary_usd = dlr(123456000);
echo $salary_usd."\n";
$salary_riels = riels(123456000);
echo $salary_riels."\n";


?>