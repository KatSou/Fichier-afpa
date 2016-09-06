// regex
// var regcara = /^+[A-Za-z]$/;
// var regcp = "^[0-9]{5}$";
// var regmail = "/^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/";

//controle de saisie

var regex = function(controle)
{
	var regcara = /^[A-Za-z]+$/;
	var regcp = /^((0[1-9])|([1-8][0-9])|(9[0-8])|(2A)|(2B))[0-9]{3}$/;
	var regmail = /^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/;

	if (controle.target.id == "societe")
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
	else if (controle.target.id == "email")
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

document.getElementById("societe").addEventListener("blur",regex);
document.getElementById("pac").addEventListener("blur",regex);
document.getElementById("CP").addEventListener("blur",regex);
document.getElementById("ville").addEventListener("blur",regex);
document.getElementById("email").addEventListener("blur",regex);





function affiche()
{
	var elt = document.getElementById("language").value;
	document.getElementById("ETP").value += elt + "\n";
}

var liste = document.getElementById("language");
liste.addEventListener("change",affiche);






