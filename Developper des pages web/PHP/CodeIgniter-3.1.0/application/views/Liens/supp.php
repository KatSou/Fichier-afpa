<!DOCTYPE html>
<html>
<head>
	<title>Formulaire supprimer</title>
<link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
<script src= <?= base_url("js/jquery.js")?>></script>
<script src= <?= base_url("js/bootstrap.js")?>></script> 
</head>
 <body>  
 <form action="<?= site_url("liens/Supprimer")?>" method="post">
<div class="row"></div>
<div class="col-sm-3 col-md-3"></div>
<div class="col-sm-8 col-md-8">
<h3 align="center">Details</h3> 
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?= $lien->titre ?></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?= $lien->description ?> <br /></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?= $lien->url ?></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?= $lien->webmaster ?></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?= $lien->theme ?></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?= $lien->date?></td></tr>
<tr><td align="center"> <button type="submit">Supprimer</button><td></td></tr>
</table>  
<input type="hidden" name="id" value="<?=$lien->id?>">
</form>
 </div>
 <div class="col-sm-1 col-md-1"></div>
</body>
</html>