<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php  
 $fp = fopen("ListeLiens.txt","r"); /* Ouverture en lecture seule */
 while (!feof($fp))
{
 $enr = fgets ($fp,4096); /* Lecture de la ligne */
 //echo "$enr<br />";  //lecture du fichier sans liens hypertext
 echo "<a href='$enr'>$enr</a> <br />";  // Lecture du fichier avec les liens hypertext
}
?>
</body>
</html>