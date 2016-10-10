<?php

class LiensDAO extends CI_Model
{

	public function insert ()
	{	
		$datejour = date("Y-m-d");
		if ($_POST["Visible"]=="oui")
		{
			$affichage = "oui";
		}
		else
		{
			$affichage = "non";
		}
		$data = array(

			"titre" => $_POST["Titre"],
			"description" => $_POST["Description"],
			"webmaster" => $_POST["Webmaster"],
			"url" => $_POST["URL"],
			"theme" => $_POST["Theme"],
			"date" => $datejour,
			"affichage" => $affichage,			
			);
		try
		{
			$this->db->insert('liens',$data);
		}
		catch (exception $e)
		{
			alert($e->getmessage());
		}


		}
	public function liste ()
	{
		$requete = $this->db->query("SELECT id,titre,url FROM liens WHERE affichage = 'oui' ORDER BY date DESC");		
		return $requete->result();
	}

	public function update ($id)
	{
		$datejour = date("Y-m-d");
		if ($_POST["Visible"]=="oui")
		{
			$affichage = "oui";
		}
		else
		{
			$affichage = "non";
		}
		$data = array(

			"titre" => $_POST["Titre"],
			"description" => $_POST["Description"],
			"webmaster" => $_POST["Webmaster"],
			"url" => $_POST["URL"],
			"theme" => $_POST["Theme"],
			"date" => $datejour,
			"affichage" => $affichage,			
			); 
			try 
			{				
				$this->db->update('liens', $data, "id=".$id);
			}    	
        	        	  
        	catch (exception $e)
			{
				alert($e->getmessage());
			}      	
	}

	public function find ($id)
	{
		$resultat = $this->db->query("select * from liens where id= ?",$id)->row();
		return $resultat;
	}

	public function delete($id)
	{
		try
		{
		$this->db->delete('liens', array("id"=> $id));
		}
		catch (exception $e)
		{
			alert($e->getmessage());
		} 

	}

	public function selectTheme ($theme, $envoie)
	{
        if ($theme == $envoie)
        {
            echo "selected='selected'";
        }
    }

}?>