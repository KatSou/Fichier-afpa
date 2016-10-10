<?php defined('BASEPATH') OR exit('No direct script access allowed');


	class Accueil extends CI_Controller
	{
		public function index()
		{
			$this->load->view('header/header');
			$this->load->view('accueil/accueil');
			$this->load->view('footer/footer');
		}
		public function zonegameur()
		{			
			$this->load->view('header/header');
			$this->load->view('gameur/gameur');
			$this->load->view('footer/footer');
		}
	}
?>