use Fil_rouge
go

CREATE proc Liv_en_cours
as
SELECT commande_numero
FROM Commande
WHERE commande_etat = 'En cour de livraison'
go

exec Liv_en_cours
go



CREATE VIEW delais_moyen
as
SELECT (SUM (DAY(date_facturation) - DAY(commande_date ))) as delais
FROM Commande
GROUP BY commande_numero
go

SELECT * FROM delais_moyen
go

DROP proc delais_moyen
go

CREATE PROC delais_moyen1
as
SELECT AVG (delais) as moyenne_delais
FROM delais_moyen
go

exec delais_moyen1
go

CREATE VIEW jointure
as
SELECT Produits.produit_reference, Fournisseur.fournisseur_reference
FROM Produits
JOIN Fournit on Fournit.produit_reference = Produits.produit_reference
JOIN Fournisseur on Fournisseur.fournisseur_reference = Fournit.fournisseur_reference
go

select * from jointure