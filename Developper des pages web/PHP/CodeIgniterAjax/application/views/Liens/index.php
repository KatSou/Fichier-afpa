<!DOCTYPE html>
<html>
<head>
	<title></title>
	 <link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
	 <link rel="stylesheet" type="text/css" href= <?= base_url("css/test.css")?>>
 	<script src= <?= base_url("js/jquery.js")?>></script>
 	<script src= <?= base_url("js/bootstrap.js")?>></script>
</head>
<body>
<div align="center" id="panel1"><h2>SOMMAIRE</h2>
<button type="button" class="btn btn-primary btn-sm"  id="btn1">Ajouter un enregistrement</button>
</div>
<br>
</br>
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>        
      </div>  
      <div class="modal-body" id="mod"></div>    
      <div class="modal-footer">        
      </div>
    </div>
  </div>
</div>
<div id="panel2">
	
</div>
</body>
</html>
<script>
$(document).ready(function() {
	$.ajax({
		url: "<?= site_url("liens/liste"); ?>",
		success: function(data) {
			$("#panel2").html(data);
		}
	});

	$("#btn1").click(function() {
		$.ajax({
		url: "<?= site_url("liens/ajouter"); ?>",
		success: function(data) {
			$("#mod").html(data);
			$("#myModal").modal("show");
		}
		});	
	});

});

</script>