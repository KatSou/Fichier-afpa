<?php 
defined('BASEPATH') OR exit('No direct script access allowed');
	class Liens extends CI_Controller
	{
		public function Index()
		{
			
			$this->load->database();   	
			$requete ["liste"] = $this->LiensDAO->liste();	
    		$this->load->view('Liens/liste', $requete);
		}	

		public function Ajouter()
		{
			if ($this->input->post())
			{				
				$this->LiensDAO->insert();
				redirect(site_url("liens/index"));
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
    			redirect(site_url("liens/index"));
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
    			redirect(site_url("liens/index"));
    		}
    		else
    		{
    			$model["lien"] = $this->LiensDAO->find($id);
    			$this->load->view('liens/supp', $model);
    		}
    		 		
    	}
	
	}
 ?>


