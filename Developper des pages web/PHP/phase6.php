<html>
 <head>
 <title>Quelques variables serveur utiles</title>
 </head>
 <body>


<form action="ton site" method="post">
 Votre e-mail : <input type="text" name="email" />
 <input type="hidden" name="secret" value="texte à passer discrètement" />
 <input type="submit" value="OK" />
 <form action ="check.php" method="post">
 Tu utilises internet plutôt le :<br />
 <input type="checkbox" name="Fjour[]" value="Lundi" />Lundi<br />
 <input type="checkbox" name="Fjour[]" value="Mardi" />Mardi<br />
 <input type="checkbox" name="Fjour[]" value="Mercredi" />Mercredi<br />
 <input type="checkbox" name="Fjour[]" value="Jeudi" />Jeudi<br />
 <input type="checkbox" name="Fjour[]" value="Vendredi" />Vendredi<br />
 <input type="submit" name="Envoyer" value="ENVOYER" />
 </form> 
</form> 
<input type="submit" name="delete" value="Supprimer" />
<input type="submit" name="create" value="Créer" />
<input type="submit" name="update" value="Modifier" />


<?php

if ( isset( $_POST['update'])) { // mise à jour
echo "mise a jour";
} elseif ( isset($_POST['delete'])) {
echo "suppression";
} elseif ( isset($_POST['create']))
 {
echo "Création";
}

 echo "Tu surfes sur le web en semaine plutôt le : ";
 foreach (($_REQUEST["Fjour"]) as $jour) /* Lecture du tableau */
 {
 echo " $Jour - ";
 }  
?> 
 </body>
</html>