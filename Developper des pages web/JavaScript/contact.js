// regex
var regcara = "^+[A-Za-z]$";
var regcp = "^[0-9]{5}$";
var regmail = "/^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/";

//controle de saisie

var regex = function(controle)
{
	if (controle.target.id == "société")
		{
			if (controle.target.value =="")
			{
				alert("Champ obligatoire !!, veuillez le remplir.");
			}
			else if (regcara.test(controle.target.value)==false)
			{
				alert("Société non valide !");
			}
		}
	else if ( controle.target.id == "pac")
		{
			if (controle.target.value =="")
			{
				alert("Champ obligatoire !!, veuillez le remplir.");
			}
			else if (regcara.test(controle.target.value)==false)
			{
				alert("Personne non valide !");		
			}
		}
	else if (controle.target.id == "adresse")
		{
			if (controle.target.value =="")
			{
				alert("Champ obligatoire !!, veuillez le remplir.");
			}
			else if (regmail.test(controle.target.value)==false)
			{
				alert("Adresse non valide !");
			}
		}
	else if (controle.target.id == "CP")
		{
			if (controle.target.value =="")
			{
				alert("Champ obligatoire !!, veuillez le remplir.");
			}
			else if (regcp.test(controle.target.value)==false)
			{	
				alert("Code Postal non valide !");
			}
		}
}

// bouton

var element = document.getElementById("Valider");
element.addEventListener("blur",regex);






