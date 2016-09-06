var x = window.prompt("Saisissez votre premier chiffre :");
var y = window.prompt("Saisissez votre deuxieme chiffre :");
var produit = 0;

function produits (x,y)
{
	var produit = x*y;
	return produit;
}
document.write("Le produit de "+x+" x "+y+" est égal à "+produits(x,y)+".");

function afficheimg ()
{
	var a = "<img src=\"img.jpg\"/>";
	return a;
}

document.write(afficheimg());