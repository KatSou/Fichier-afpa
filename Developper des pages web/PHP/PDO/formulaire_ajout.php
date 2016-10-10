<?php 
if (isset($_POST["Visible"])) {
	$visible = "oui";
}
else {
	$visible = "non";
}
print_r($visible);

require "connexionBase.php";
try
{

$insert = "INSERT INTO liens (titre,webmaster,description,url,theme,date,affichage) VALUES (:Titre,:Webmaster,:Description,:URL,:Theme,:date,:Visible)";

$result = $db->prepare($insert);

$datetoday = date("Y-m-d");
$result->bindParam(':Titre',$_POST["Titre"]);
$result->bindParam(':Webmaster',$_POST["Webmaster"]);
$result->bindParam(':Description',$_POST["Description"]);
$result->bindParam(':URL',$_POST["URL"]);
$result->bindParam(':Theme',$_POST["Theme"]);
$result->bindParam(':date', $datetoday);
$result->bindParam(':Visible',$visible);
$result->execute();

}


catch (Exception $e)
{
   echo ($e->getMessage());
}
header("Location: liste.php");
?>