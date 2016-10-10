<?php 
defined('BASEPATH') OR exit('No direct script access allowed');
	class Liens extends CI_Controller
	{
		public function Index()
		{
			
    		$this->load->view('Liens/index');
		}	

		public function liste()
		{
			
			$this->load->database();   	
			$requete ["liste"] = $this->LiensDAO->liste();	
    		$this->load->view('Liens/liste', $requete);
		}	

		public function ajouter()
		{
			if ($this->input->post())
			{				
				$this->LiensDAO->insert();
				
			}
			else
			{
				$this->load->view('liens/ajout');
			}
		}	

		public function Details($id)
		{
			$liste["fi"]=$this->LiensDAO->find($id);
			$this->load->view('liens/details',$liste);
		}

    	public function Modifier($id)
		{
    		
    		if ($this->input->post())
    		{
    			$liste = $this->LiensDAO->update($_POST["id"]);    			
    			
    		}
    		else
    		{
    			$model["lien"] = $this->LiensDAO->find($id);
    			$this->load->view('liens/modif', $model);
    		}
    	}

    	public function Supprimer($id)
		{
    		
    		if ($this->input->post())
    		{
    			$liste = $this->LiensDAO->delete($_POST["id"]);    			
    			
    		}
    		else
    		{
    			$model["lien"] = $this->LiensDAO->find($id);
    			$this->load->view('liens/supp', $model);
    		}
    		 		
    	}
	
	}
 ?>


