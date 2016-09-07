<?php
 $euro=6.55957;
 printf("%.2f FF<br />",$euro);
 $money1 = 68.75;
 $money2 = 54.35;
 $money = $money1 + $money2;
 // echo $money affichera "123.1";
 echo "affichage sans printf : " . $money . "<br />";
 $monformat = sprintf("%01.2f", $money);

 // echo $monformat affichera "123.10"
 echo "affichage avec printf : " . $monformat . "<br />";

 $year="2002";
 $month="4";
 $day="5";
 $varDate = sprintf("%04d-%02d-%02d", $year, $month, $day) ;

 // echo $varDate affichera "2002-04-05"
 echo "affichage avec sprintf : " . $varDate;

/* affichage du titre
bla bla bla ... bla bla */
//echo $titre;

// affichage du titre
//echo $titre;
\n

 $age=25;
 
 (($age >= 18) ? $reponse="majeur" : $reponse="mineur");
 echo "Vous êtes ".$reponse. "."; 
?>