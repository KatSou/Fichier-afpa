<!DOCTYPE html>
<html>
<head>
	<title>liste</title>
<link rel="stylesheet" type="text/css" href="bootstrap.css">
<script src="jquery.js"></script>
<script src="bootstrap.js"></script>

</head>
<body background-color="#FFFFCC">
<div class="row"></div>
<div class="col-sm-1 col-md-1"></div>
<div class="col-sm-10 col-md-10">
<?php 
require "connexionBase.php"; // Inclusion de notre bibliothèque de fonction
//$db = connexionBase(); // Appel de la fonction de connexion
$str_requete = "SELECT id,titre,url FROM liens WHERE affichage='oui' ORDER BY date DESC";
$result = $db->query($str_requete);

if (!$result) {
	echo "PDO::errorInfo():";
	$msg = $db->errorInfo();
	echo "$msg[2]"."<br />";
	die ("Erreur dans la requete ! (str_requete)<br> <a href=\"javascript:history.go(-1)\">BACK</a>");
}

?>
<h2><p align='center'>SOMMAIRE</h2>
<p align='center'> <a href="formulaire_ajout.html"> Ajouter un enregistrement</a> </p align></p align><br />
<?php 
if ($result->rowCount() == 0) {
	die("La table est vide");
}
echo "<table width='100%' class=' table table-striped'> 
<th> Titre </th>
<th> URL </th>
<th> </th>";

while ($lien = $result->fetch(PDO::FETCH_OBJ)){
	echo("<tr>		
		<td width='49%'>$lien->titre</td>
		<td> <i><a href='$lien->url'>$lien->url</a></i></td>
		<td width='14%'><a href=' detail.php?id=$lien->id'> Afficher le détail </a></td>
		</tr>
		");
}
echo ("</table>");
 ?>
 </div>
 <div class="col-sm-1 col-md-1"></div>

</body>
</html>