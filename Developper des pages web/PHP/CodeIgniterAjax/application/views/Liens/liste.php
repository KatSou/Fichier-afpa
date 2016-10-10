<div class="row"></div>
<div class="col-sm-1 col-md-1"></div>
<div class="col-sm-10 col-md-10">
<table width='100%' class=' table table-striped'>
<?php foreach ($liste as $row): ?>
            
        <tr>       
        <td><?= $row->titre ?></td>
        <td> <i><a href='<?= $row->url ?>'> <?= $row->url ?></a></i></td>
        <td width='14%'>
        <button type="button" class="btn btn-primary btn-xs btn-details" data-toggle="modal" data-id="<?= $row->id ?>" > Afficher le détail </button>
        </td>
        </tr>                 
        <?php endforeach; ?>
</table>
 </div>
 <div class="col-sm-1 col-md-1"></div>

<script>
$(document).ready(function() {

	$(".btn-details").click(function() {
		var id = $(this).data("id");
		$.ajax({
		url: "<?= site_url("liens/details/"); ?>" + id,
		success: function(data) {
			$("#panel2").html(data);
			$("#panel1").hide();					
		}
		});
	});
});
</script>