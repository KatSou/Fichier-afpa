var aleatoire = Math.floor((Math.random() * 20) + 1);
console.log(aleatoire);
saisie =0;

function verif()
{
	var saisie = document.getElementById("textBox1").value;	
		
		if (saisie < aleatoire)
		{
			document.getElementById("label1").innerHTML = "Votre nombre est trop petit !! Entrez un nouveau nombre :";
		}
		else if (saisie > aleatoire)
		{
			document.getElementById("label1").innerHTML = "Votre nombre est trop grand !! Entrez un nouveau nombre :";
		}
		else 
		{
			document.getElementById("label1").innerHTML = "Vous avez gagner !!";
		}	
}	


