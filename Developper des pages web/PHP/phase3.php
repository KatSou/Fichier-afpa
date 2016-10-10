<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<table border>
<?php

/* // Nombre impaire
$max = 150;
 
echo 'Les chiffres impair compris entre '.$min.' et '.$max.' sont:';
 
for($i = $min; $i < $max ; $i=$i+2){
    echo $i.' ';
}*/


/* //Punition
for ($i=1;$i<=500;$i++) {
  echo "$i. Je dois faire des sauvegardes régulières...<BR>\n";
}*/

// 1ère ligne
echo "<TR><TD></TD>";
for ($c=0;$c<13;$c++) {
  echo "<TH>$c</TH>";
}
echo "</TR>\n";
// toutes les lignes
for ($l=0;$l<13;$l++) {
  // 1 ligne
  echo "<TR><TH>$l</TH>";
  for ($c=0;$c<13;$c++) {
    $r=$c*$l;
    echo "<TD ALIGN=right>$r</TD>";
  }  
  echo "</TR>\n";
}
?>
</table>
 



</body>
</html>