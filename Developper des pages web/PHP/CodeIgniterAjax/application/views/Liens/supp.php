<form id="form-supp" method="post">
<div class="row">
<div class="col-sm-2 col-md-2"></div>
<div class="col-sm-6 col-md-6">
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?= $lien->titre ?></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?= $lien->description ?> <br /></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?= $lien->url ?></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?= $lien->webmaster ?></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?= $lien->theme ?></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?= $lien->date?></td></tr>
</table>  
<div id="btn-supp"><button class="btn btn-success" type="submit">Supprimer</button> </div>
<div id="btn-ann"><button type="button" class="btn btn-danger " data-dismiss="modal" id="btn-ann">Annuler</button></div> 
<input type="hidden" name="id" value="<?=$lien->id?>">
</form>
 </div>
 </div>
<script>
 	$(document).ready(function() {	

	$("#btn-supp").click(function() {
		$.ajax({
		method : "POST",
		url:"index.php/liens/Supprimer",
		data :$("#form-supp").serialize(),
		success: function(data) {			
			$("#myModal").modal("hide");
			$("#panel1").load("index.php/liens/liste");
		}
		});	
	});
});
 </script>