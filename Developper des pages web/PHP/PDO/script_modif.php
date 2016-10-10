<?php 
require "connexionBase.php";
try
{
$datetoday = date("Y-m-d");
// $update = "UPDATE liens SET titre='".$_POST["Titre"]."', webmaster='".$_POST["Webmaster"]."', description='".$_POST["Description"]."',url='".$_POST["URL"]."',theme= '".$_POST["Theme"]."',date='".$datetoday."',affichage='".$_POST["Visible"]."' WHERE id=".$_POST["id"];
$update = "UPDATE liens SET titre=:ti, webmaster=:we , description=:de ,url=:u ,theme=:th , date=:da ,affichage=:af WHERE id=:id";
$result = $db->prepare($update);
$result->bindParam(':ti',$_POST["Titre"]);
$result->bindParam(':we',$_POST["Webmaster"]);
$result->bindParam(':de',$_POST["Description"]);
$result->bindParam(':u',$_POST["URL"]);
$result->bindParam(':th',$_POST["Theme"]);
$result->bindParam(':da', $datetoday);
$result->bindParam(':af',$_POST["Visible"]);
$result->bindParam(':id',$_POST["id"]);
$result->execute();
}


catch (Exception $e)
{
   echo ($e->getMessage());
}
header("Location: liste.php");
?>
