<form class="form-horizontal">
<div class="row">
<div class="col-sm-2 col-md-2"></div>
<div class="col-sm-7 col-md-7">
<h1 align="center">Details</h1> 
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?= $fi->titre ?></td><td></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?= $fi->description ?> <br /></td><td></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?= $fi->url ?></td><td></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?= $fi->webmaster ?></td><td></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?= $fi->theme ?></td><td></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?= $fi->date?></td><td></td></tr>
<tr>
<td align="center"><button type="button" id="btn-ret" class="btn btn-primary btn-xs" data-dismiss="modal">Retour à la liste</button></div> </td>
<td align="center"><button type="button" id="btn-mod" class="btn btn-success btn-xs btn-data" data-toggle="modal" data-id="<?= $fi->id ?>"> Modifier </button></td> 
<td align="center"><button type="button" id="btn-supp" class="btn btn-danger btn-xs btn-data" data-toggle="modal" data-id="<?= $fi->id ?>"> Supprimer </button></td>
</table>  
</div> 
 <div class="col-sm-3 col-md-3"></div>
 </form>
 </div>

 <script> 	
 $(document).ready(function() {	

	$("#btn-mod").click(function() {
		var id = $(this).data("id");
		$.ajax({
		url: "<?= site_url("liens/Modifier/"); ?>" + id,
		success: function(data) 
			{
				$("#mod").html(data);
				$("#myModal").modal("show");
			}
		});	
	});
	$("#btn-supp").click(function() {
		var id = $(this).data("id");
		$.ajax({
		url: "<?= site_url("liens/Supprimer/"); ?>" + id,
		success: function(data) 
			{
				$("#mod").html(data);
				$("#myModal").modal("show");
			}
		});	
	});
	$("#btn-ret").click(function()
	{	
		$("#panel1").show();
		$("#panel2").load("index.php/liens/liste");						
	});	
});
 </script>
