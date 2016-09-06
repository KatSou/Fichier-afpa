use Fil_rouge
go

-- Chiffre d'affaire par fournisseur
CREATE VIEW chiffre_affaire_fournisseur
as
SELECT fournisseur_nom,SUM ( quantite_produit_fournit *( prix_vente_ht*taux_tva)) as 'Chiffre d''affaire'
FROM Fournisseur
JOIN Fournit on Fournit.fournisseur_reference = fournisseur.fournisseur_reference
JOIN Produits on Produits.produit_reference = Fournit.produit_reference
GROUP BY fournisseur_nom
go

-- Chiffre d'affaire total
CREATE VIEW chiffre_affaire_total
as
SELECT SUM ( quantite_produit_fournit *( prix_vente_ht*taux_tva)) as 'Chiffre d''affaire'
FROM Fournisseur
JOIN Fournit on Fournit.fournisseur_reference = fournisseur.fournisseur_reference
JOIN Produits on Produits.produit_reference = Fournit.produit_reference
go


-- Liste des produits commandés (ref produit, qte commandé)
CREATE VIEW liste_produits_commandees
as
SELECT quantite_acheter,produit_reference
FROM Sont_present
go


-- Liste des commandes pour un client (date, ref client, montant)

CREATE VIEW liste_commande_par_client
as
SELECT client_reference, CAST (commande_date as date) as 'Date de commande ', SUM (quantite_acheter *(prix_vente_ht*taux_tva)) as 'montant total'
FROM Commande
JOIN Sont_present on Sont_present.commande_numero = Commande.commande_numero
JOIN Produits on Produits.produit_reference = Sont_present.produit_reference
GROUP BY commande.client_reference, commande_date
go



-- Répartition du chiffre d'affaire par type de client

CREATE VIEW chiffre_affaire_type_client
as
SELECT client_categorie, SUM (quantite_acheter *(prix_vente_ht*taux_tva)) as 'Chiffre d''affaire total'
FROM Client
JOIN Commande on commande.client_reference = Client.client_reference
JOIN Sont_present on Sont_present.commande_numero = Commande.commande_numero
JOIN Produits on Produits.produit_reference = Sont_present.produit_reference
GROUP BY client_categorie
go

-- - Lister les commandes en cours de livraison
CREATE VIEW commande_en_livraison
as
SELECT commande_numero
FROM Commande
WHERE commande_etat = 'En cour de livraison'
go


-- REGARDER LES VIEWS

SELECT * FROM chiffre_affaire_fournisseur
SELECT * FROM chiffre_affaire_total
SELECT * FROM liste_produits_commandees
SELECT * FROM liste_commande_par_client
SELECT * FROM chiffre_affaire_type_client
SELECT * FROM commande_en_livraison