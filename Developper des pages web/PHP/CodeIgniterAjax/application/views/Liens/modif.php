<form id="form-mod" method="POST">
<div class="row">
<div class="col-sm-2 col-md-2"></div>
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
		<td><input type="checkbox" name="Visible" value="oui" checked="true"></td>
	</tr>
	</table>
		<div id="btn-mod1"><button class="btn btn-success" type="submit">Modifier </button> </div>
		<div id="btn-ann"><button type="button" class="btn btn-danger " data-dismiss="modal" id="btn-ann">Annuler</button></div>  
<input type="hidden" name="id" value="<?=$lien->id?>">
</form>
 </div>
 </div>
 <script>
 	$(document).ready(function() {	

	$("#btn-mod1").click(function() {
		$.ajax({
		method : "POST",
		url:"index.php/liens/Modifier",
		data :$("#form-mod").serialize(),
		success: function(data) {			
			$("#myModal").modal("hide");
			$("#panel1").load("index.php/liens/liste");
		}
		});	
	});
});
 </script>


