<!DOCTYPE html>
<html>
<head>
	<title>PDO</title>


<?php

try {
 	$db = new PDO('mysql:host=127.0.0.1;charset=utf8;dbname=site', 'root', '');

 } 
 catch (Exception $e) {
 	echo 'Erreur : ' . $e->getMessage() . '<br />' ;
 	echo 'N° : ' . $e->getCode() ;
 	die('Fin du script') ;
 }

 $str_requete = "SELECT * FROM liens";
 $result = $db->query ($str_requete);
 while ($lien = $result->fetch(PDO::FETCH_OBJ)) {
 print($lien->titre . "<br/>");
}
 $result->closeCursor();
 ?>

</head>

<body>


 
  
 

 



</body>
</html>