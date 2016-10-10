
<html>
 <head>
 <title> Details </title>
 <link rel="stylesheet" type="text/css" href="bootstrap.css">
 <script src="bootstrap.js"></script>
 <script src="jquery.js"></script>
 <?php
 require "connexionBase.php"; // Inclusion de notre bibliothèque de fonctions
 $db = connexionBase ();// Appel de la fonction de connexion
 $id=$_GET["id"];  // récupere l'id pour afficher les informations
 $str_requete = "SELECT * FROM liens WHERE id=".$id;
 $result = $db->query($str_requete);

 // Renvoi de l'enregistrement sous forme d'un objet
 $lien = $result->fetch(PDO::FETCH_OBJ);
 ?>

 </head>
 <body>  
<form action="http://127.0.0.1/PHP/PDO/formulaire_modif.php" method="post">
<div class="row"></div>
<div class="col-sm-1 col-md-1"></div>
<div class="col-sm-5 col-md-5">
<h3 align="center">Detail</h3> 
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?php echo $lien->titre ?></td><td></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?php echo $lien->description ?> <br /></td><td></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?php echo $lien->url ?></td><td></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?php echo $lien->webmaster ?></td><td></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?php echo $lien->theme ?></td><td></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?php echo $lien->date?></td><td></td></tr>
<tr><td align="center"><a href="http://127.0.0.1/PHP/PDO/liste.php">Retour à la liste</a></td>  <td align="center"> <?php echo("<a href=' formulaire_modif.php?id=$lien->id'> Modifier </a>");?> </td> <td align="center"> <?php echo("<a href=' formulaire_delete.php?id=$lien->id'> Supprimer </a>");?> </td>
</table>  
 </div>
 </form>
 <div class="col-sm-6 col-md-6"></div>

 </body>
 </html>
 