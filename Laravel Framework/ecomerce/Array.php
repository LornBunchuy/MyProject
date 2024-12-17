<?php
// $seasons = array();
// $seasons[0] = "Summer";
// $seasons[1] = "Winter";
// $seasons[2] = "Spring";
// $seasons[3] = "Autum";
// echo count($seasons)."\n";
// for($i=0;$i<count($seasons);$i++){
//     echo "Seasons: ".$seasons[$i]." ";
// }


// foreach($seasons as $item){
//     echo "Seasons: ".$item." \n";
// }

// $i=0;
// while($i<count($seasons)){
//     echo "Seasons: ".$seasons[$i]." ";
//     $i++;
// }
// $i=0;
// do{
//     echo "Seasons: ".$seasons[$i]." ";
//     $i++;
// }while($i<count($seasons)); 



$seasons = array(
    array('id','full name'),
    array('1','mony ho'),
    array('2','G devit'),
    array('3','Vanda man')
    );

for($i=0;$i<4;$i++){
    for($j=0;$j<2;$j++){
        echo $seasons[$i][$j]."\t\t ";
    }
    echo "\n";
}

foreach($seasons as $item){
    foreach($item as $tem){
        echo "Seasons: ".$tem." \n";
    }
 }
?>