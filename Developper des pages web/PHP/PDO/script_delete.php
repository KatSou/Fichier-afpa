
<?php 
require "connexionBase.php";
try
{
	$delete = "DELETE FROM liens WHERE id=:id";
	$result = $db->prepare($delete);
	$result->bindParam(':id',$_POST["id"]);
	$result->execute();
	}
catch (Exception $e)
{
   echo ($e->getMessage());
}
header("Location: liste.php");

 ?>