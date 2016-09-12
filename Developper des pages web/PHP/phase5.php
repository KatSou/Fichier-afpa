<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php  

if (file_exists("ListeLiens.txt")) /* Vérification si fichier existant */
 $fp = fopen("ListeLiens.txt","r"); /* Ouverture en lecture seule */
else {
 echo "Fichier introuvable !";
 exit();
} 


?>
</body>
</html>