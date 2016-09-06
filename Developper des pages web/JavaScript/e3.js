var compt = 1;

while (reponse != "")
{
	var reponse = window.prompt("Saisissez le prénom N°"+compt+"\nou Click sur Annuler pour arrêter la saisie");
	compt++;
	document.write(reponse);
	document.write(" ");

}
var total = compt - 2;
document.write(" Le nombre de prénom : "+total);