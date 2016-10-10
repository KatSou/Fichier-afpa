<html>
<head>
 <title> Details </title>
 <meta charset="utf-8">
 <link rel="stylesheet" type="text/css" href= <?= base_url("css/bootstrap.css")?>>
 <script src= <?= base_url("js/jquery.js")?>></script>
 <script src= <?= base_url("js/bootstrap.js")?>></script>
</head>
<body>  
<form action="<?= site_url("liens/Details")?>" method="post">
<div class="row"></div>
<div class="col-sm-1 col-md-1"></div>
<div class="col-sm-5 col-md-5">
<h3 align="center">Details</h3> 
<table width='100%' class="table" >  
<tr><td align="center"><b>Titre</b></td><td><?= $fi->titre ?></td><td></td></tr>
<tr><td align="center"><b>Description</b></td> <td><?= $fi->description ?> <br /></td><td></td></tr>
<tr><td align="center"><b>URL</b></td> <td><?= $fi->url ?></td><td></td></tr>
<tr><td align="center"><b>Webmaster</b></td> <td><?= $fi->webmaster ?></td><td></td></tr>
<tr><td align="center"><b>Thème</b></td> <td><?= $fi->theme ?></td><td></td></tr>
<tr><td align="center"><b>Date</b></td> <td><?= $fi->date?></td><td></td></tr>
<tr><td align="center"><a href="<?= site_url("liens/index")?>">Retour à la liste</a></td>
<td align="center"> <a href='<?= site_url("liens/Modifier/$fi->id") ?>'> Modifier </a></td> 
<td align="center"><a href='<?= site_url("liens/Supprimer/$fi->id") ?>'> Supprimer </a></td>
</table>  
 </div>
 </form>
 <div class="col-sm-6 col-md-6"></div>
 </body>
 </html>