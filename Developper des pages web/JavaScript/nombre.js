$(document).ready(function()
{
	$aleatoire = Math.floor((Math.random()*20)+1);
	console.log($aleatoire);
	$("#lab1").show();	
	$('#button1').click(function()
		{

			$saisie= $("#textBox1").val();
			$saisie = parseInt($saisie);

			if ($saisie < $aleatoire)
			{
				$('#lab2').html('Votre nombre est trop petit !!');
				$("#textBox1").val("");
				$("#textBox1").focus();
			}	
			else if ($saisie>$aleatoire)
			{
				$('#lab2').html('Votre nombre est trop grand !!');
				$("#textBox1").val("");
				$("#textBox1").focus();
			}
			else 
			{
				$('#lab2').html('Vous avez gagner !!');
			}
		});

		$('#reset').click(function()
		{
			$("#textBox1").val("");
			$('#lab2').html('');
			$aleatoire = Math.floor((Math.random()*20)+1);
			$("#textBox1").focus();
			console.log($aleatoire);
		});
});

	
	