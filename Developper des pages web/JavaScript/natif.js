var tab = new Array();
var i = 1;
var moy = 0;
var som = 0;



while (i != "0")
{
	i = window.prompt("Saisissez votre chiffre : (0) pour arreter la saisie")
	tab.push(i);
}
tab.pop();
i =0;
while (i != tab.length)
{
	som += parseInt(tab[i]);
	i++;
}
moy = som / tab.length;
console.log (som);
console.log (moy);
document.write("La somme est de : "+som+" et la moyenne est de :" +moy);