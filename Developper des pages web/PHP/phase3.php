<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<table border>
<?php

/*$max = 150;
 
echo 'Les chiffres impair compris entre '.$min.' et '.$max.' sont:';
 
for($i = $min; $i < $max ; $i=$i+2){
    echo $i.' ';
}*/


/*for ($i=1; $i < 500; $i++) { 

	echo "Je dois faire mes sauvegardes régulieres de mes fiches".' ';
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