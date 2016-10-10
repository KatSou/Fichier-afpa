<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
<script src= <?= base_url("js/jquery.js")?>></script>
<script src= <?= base_url("js/bootstrap.js")?>></script>
	<title></title>
</head>
<body>
<div class="row"></div>
<div class="col-sm-3 col-md-3"></div>
<div class="col-sm-6 col-md-6">
<h1 align="center">Formulaire</h1>
<form action="<?= site_url("liens/Ajouter")?>" method="POST">	
<table>

	<tr><p><b>Titre</b></p>
	<input type="text"  name="Titre" size="100" value="" placeholder=" Saisie ton titre" >
	<p><b>Description</b></p>
	<textarea name="Description"  cols="101" rows="2" placeholder="Description du site "></textarea>
	<p><b>URL</b></p></tr>
	<input type="text" name="URL" size="100" value="" placeholder="URL du site" >
	<p><b>Theme</b></p>
	<select name="Theme">
		<option value="actualité">Actualité</option>
		<option value="musique">Musique</option>
		<option value="sports">Sports</option>
		<option value="sciences">Sciences</option>
		<option value="cinéma">Cinéma</option>
		<option value="divers">Divers</option>
	</select>
	<p><b>Webmaster</b></p>
	<input type="text" name="Webmaster" size="100" value="" placeholder="Entrez une adresse mail"> </br></br></tr>

	<input type="checkbox" name="Visible" value="oui" checked="true"> Visible </br> </br>
	<input type="submit" name="valider" >	
</div>
<div class="col-sm-3 col-md-3"></div>	
</table>
</form>
</body>
</html>