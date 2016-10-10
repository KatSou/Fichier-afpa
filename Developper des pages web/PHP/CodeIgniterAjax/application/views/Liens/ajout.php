<div class="row">
<div class="col-sm-2 col-md-2"></div>
<div class="col-sm-7 col-md-7">
<h1 align="center">Formulaire</h1>
<form class="form-horizontal" method="POST" id="form-ajout">	
<table>

	<tr><p><b>Titre</b></p>
	<input type="text"  name="Titre" size="50px"  value="" placeholder=" Saisie ton titre" >
	<p><b>Description</b></p>
	<textarea name="Description" cols="52px"  rows="2" placeholder="Description du site "></textarea>
	<p><b>URL</b></p></tr>
	<input type="text" name="URL" size="50px" value="" placeholder="URL du site" >
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
	<input type="text" name="Webmaster" size="50px" value="" placeholder="Entrez une adresse mail"> </br></br></tr>

	<input type="checkbox" name="Visible" value="oui" checked="true"> Visible </br> </br>
	<div id="btn-val"><input type="submit" name="valider" class="btn btn-success"></input></div>            
	<div id="btn-ann"><button type="button" class="btn btn-danger " data-dismiss="modal" id="btn-ann">Annuler</button></div>
	</table>
	</form>	
</div>
<div class="col-sm-3 col-md-3"></div>
</div>

<script>
$(document).ready(function() {	

	$("#btn-val").click(function() {
		$.ajax({
		method : "POST",
		url:"index.php/liens/Ajouter",
		data :$("#form-ajout").serialize(),
		success: function(data) {			
			$("#myModal").modal("hide");
			$("#panel1").load("index.php/liens/liste");
		}
		});	
	});
});
</script>