<!DOCTYPE html>
<html>
<head>
	<title>Formulaire supprimer</title>
<link rel="stylesheet" type="text/css" href="bootstrap.css">
<script src="bootstrap.js"></script>
<script src="jquery.js"></script>
 <?php
 require "connexionBase.php"; // Inclusion de notre bibliothèque de fonctions 
 $id=$_GET["id"];  // récupere l'id pour afficher les informations
 $str_requete = "SELECT * FROM liens WHERE id=".$id;
 $result = $db->query($str_requete);

 // Renvoi de l'enregistrement sous forme d'un objet
 $lien = $result->fetch(PDO::FETCH_OBJ);
 ?>
</head>
 <body>  
 <form action="script_delete.php" method="post">
<div class="row"></div>
<div class="col-sm-3 col-md-3"></div>
<div class="col-sm-8 col-md-8">
<h3 align="center">Detail</h3> 
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?php echo $lien->titre ?></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?php echo $lien->description ?> <br /></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?php echo $lien->url ?></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?php echo $lien->webmaster ?></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?php echo $lien->theme ?></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?php echo $lien->date?></td></tr>
<input type="hidden" name="Visible" value="non">
<tr><td align="center"><b>Visible</b></td> <td><input type="checkbox" name="Visible" value="oui" <?php if ($lien->affichage=="oui") { echo "checked"; } ?>></td></tr>
<tr><td align="center"> <button type="submit"> Supprimer</button><td></td></tr>
</table>  
<input type="hidden" name="id" value="<?=$id?>">
</form>
 </div>
 <div class="col-sm-1 col-md-1"></div>
</body>
</html>