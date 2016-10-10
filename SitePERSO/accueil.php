<?php 
defined('BASEPATH') OR exit('No direct script access allowed');
	class accueil extends CI_Controller
	{
		public function index()
		{
			$this->load->view('header/header');
			$this->load->view('accueil/b_acc');
			$this->load->view('footer/footer');
		}

	}
?>