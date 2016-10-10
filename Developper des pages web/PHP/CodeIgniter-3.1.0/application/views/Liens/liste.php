<!DOCTYPE html>
<html lang="fr">
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
<script src= <?= base_url("js/jquery.js")?>></script>
<script src= <?= base_url("js/bootstrap.js")?>></script>
</head>
<body>
<body background-color="#FFFFCC">
<div class="row">
<div class="col-sm-1 col-md-1"></div>
<div class="col-sm-10 col-md-10">
<h2><p align='center'>SOMMAIRE</h2>
<p align='center'> <a href="<?= site_url("liens/Ajouter")?>"> Ajouter un enregistrement</a> </p align></p align><br />
<table width='100%' class=' table table-striped'>
<?php foreach ($liste as $row): ?>
            
        <tr>       
        <td><?= $row->titre ?></td>
        <td> <i><a href='<?= $row->url ?>'> <?= $row->url ?></a></i></td>
        <td width='14%'><a href='<?= site_url("liens/details/$row->id") ?>'> Afficher le détail </a></td>
        </tr>                 
        <?php endforeach; ?>
</table>
 </div>

 <div class="col-sm-1 col-md-1"></div>
 </div>
</body>
</html>

