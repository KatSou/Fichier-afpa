<!DOCTYPE html>
<html>
<head>
	<title>Formulaire modifier</title>
<link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
<script src= <?= base_url("js/jquery.js")?>></script>
<script src= <?= base_url("js/bootstrap.js")?>></script>
</head>
<body>  
<form action="<?= site_url("liens/Modifier")?>" method="POST">
<div class="row"></div>
<div class="col-sm-3 col-md-3"></div>
<div class="col-sm-8 col-md-8">
<table width='100%' class="table" >  
	<tr>
		<td align="center"><b>Titre</b></td>
		<td><input type="text" name="Titre" value="<?= ("$lien->titre") ?>"></td>
	</tr>
	<tr>
		<td align="center"><b>Description</b></td>	
		<td><input type="text" name="Description" value="<?= ("$lien->description") ?>"></td>
	</tr>
	<tr>
		<td align="center"><b>URL</b></td>
		<td><input type="text" name="URL" value="<?= ("$lien->url") ?>"></td>
	</tr>
	<tr>
		<td align="center"><b>Webmaster</b></td>
		<td><input type="text" name="Webmaster" value="<?= ("$lien->webmaster") ?>"></td>
	</tr>
	<tr>
		<td align="center"><b>Thème</b></td>
		<td><select name="Theme">
		<option <?php $this->LiensDAO->selectTheme("actualité",$lien->theme) ?> value="actualité">Actualité</option>
		<option <?php $this->LiensDAO->selectTheme("musique",$lien->theme) ?> value="musique">Musique</option>
		<option <?php $this->LiensDAO->selectTheme("sports",$lien->theme) ?> value="sports">Sports</option>
		<option <?php $this->LiensDAO->selectTheme("sciences",$lien->theme) ?> value="sciences">Sciences</option>
		<option <?php $this->LiensDAO->selectTheme("cinéma",$lien->theme) ?> value="cinéma">Cinéma</option>
		<option <?php $this->LiensDAO->selectTheme("divers",$lien->theme) ?> value="divers">Divers</option>
	</select></td>
	</tr>

	<tr>
		<td align="center"><b>Date</b></td>
		<td><input type="text" name="Date" value="<?= $lien->date ?>"></td>
	</tr>
<input type="hidden" name="Visible" value="non">
	<tr>
		<td align="center"><b>Visible</b></td>
		<td><input type="checkbox" name="Visible" value="oui"></td>
	</tr>
	<tr>
		<td align="center"> <button type="submit">Modifier </button>
		<td></td>
	</tr>
</table>  
<input type="hidden" name="id" value="<?=$lien->id?>">
</form>
 </div>
 <div class="col-sm-1 col-md-1"></div>
</body>
</html>