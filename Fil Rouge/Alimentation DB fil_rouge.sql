Use fil_rouge
go


-- Client

Insert into Client
	Values ('1','Suiveng','Justine','0613858728','suiv@gmail.com','Direct',0.5,'','')
Insert into Client
	Values ('2','Lente','Arnaud','0622769458','arnaud.lente@hotmail.fr','2 mois',0.25,'14598745698954','SARL')
Insert into Client
	Values ('1','Bled','Arthur','0255889966','susui@goo.fr','Direct',0.5,'','')
Insert into Client
	Values ('1','Rich','Toto','0322410601','riri@gogoo.fr','Direct',0.5,'','')
Insert into Client
	Values ('2','Arggg','Vivi','0599665548','googogoogo@ggfd.fr','3 mois',0.25,'14598745656554','EARL')
Insert into Client
	Values ('2','Bibix','Sueee','','Blabla@blay.fr','5 mois',0.25,'18965745698954','SA')
Insert into Client
	Values ('1','Viieloe','Vincent','0322556998','','Direct',0.5,'','')
Insert into Client
	Values ('1','Darnou','Cindy','0266505555','darnoux.cindy@boby.fr','Direct',0.5,'','')
Insert into Client
	Values ('1','Lamotte','Charles','','Charle.lamote@laposte.net','Direct',0.5,'','')
Insert into Client
	Values ('2','Zarzany','Edman','0322410102','','3 mois',0.25,'16987845869854','SARL')

-- Fournisseurs
Insert into Fournisseur 
	Values ('Germtroll','55 rue de l''impasse','80250','Bledarville')
Insert into Fournisseur
	Values ('Musiconly','22 rue de vervines','55050','Googland')
Insert into Fournisseur
	Values ('Noriaplop','10 rue du bas','54500','Hebdol')
Insert into Fournisseur
	Values ('Yamaha','12 route du roi soleil','55240','Goplou')
Insert into Fournisseur
	Values ('Roi de la musique','1236 Avenue du général de Gaule','58900','Merriland')
Insert into Fournisseur
	Values ('Royez','25 route d amiens','80000','Amiens')
Insert into Fournisseur
	Values ('Blanchard','123 rue du paradis','96000','Paris')
Insert into Fournisseur
	Values ('Music only','569 route daloonville','87525','Maillard')
Insert into Fournisseur
	Values ('Glod','5 route BIville','75525','Madcops')


-- Produits

Insert into Produits
	Values ('Sonor Essential Force Green','Batterie - Version Stage S','Serie Essential Force Grosse caisse 22"x20" sans attache','Batterie',20,'',152,200,19)
Insert into Produits
	Values ('Yamaha GL1','Guitare classique 1/8','6 cordes Table en épicea Fond et eclisses en meranti','Guitare/Basse',12,'',500,540,20)
Insert into Produits
	Values ('Yamaha U1 TA PE','Paino droit','Banc et lampe incluse table d harmonie Fonction TransAcoustic ','Clavier',4,'',12000,12550,5.5)
Insert into Produits
	Values ('UltraMixer Pro','Logiciel DJ','Version pour PC Support pour MIDI pour clavier externes','DJ',250,'',95,120,19.6)
Insert into Produits
	Values ('Fender SQ classic Vibe TELE','Guitare électrique','corps en pin manche en érable profil du manche : modern C','Guitare/Basse',23,'',290,360,20)
Insert into Produits
	Values ('Neumann KU100','Micro stéréo binaural','2x capsules intégrées au niveau des oreilles Nécessite une alimentation Phantom +48V, une alimentation externe ou via batterie intégrée','Microphone',2,'',6020,7000,7)
Insert into Produits
	Values ('Martin Atomic 3000','Stronoscope de 3000 Watt','Température de couleur: 5600°K Effet Blinder en continu Vitesse du flash réglable de 20ms à 2 secondes','Lumière',6,'',400,500,19.6)
Insert into Produits
	Values ('Cameo Thunder Wash 600W','Effet de lumière LED 3en1','Strobe, Blinder et Light Wash dans un seul boitier 648 LED SMD blanches de 0,2 Watt de puissance chacune','Lumière',10,'',50,75,15)
Insert into Produits
	Values ('Novation Launchpad MK2','Contrôleur pour Ableton Live','Compatible avec iPad et Midi avec le Camera Connection Kit d Apple vendu séparémentTaux de rafraichissement optimisé','Surface de contrôle',1,'',70,126,5.5)



-- Commercial

Insert into Commercial
	Values ('Bleriot','Jean')
Insert into Commercial
	Values ('Montargie','Quentin')
Insert into Commercial
	Values ('Gorlez','Patrick')
Insert into Commercial
	Values ('Marlot','Marius')
Insert into Commercial
	Values ('Berthe','Evian')
Insert into Commercial
	Values ('Jaha','Vincent')
Insert into Commercial
	Values ('Bleriot','Bertrant')
Insert into Commercial
	Values ('Andrex','Salomé')
Insert into Commercial
	Values ('Thulupin','Noemi')

-- Commande

Insert into Commande
	Values ('En preparation','Facture n°1','28/07/2016','25/07/2016',1,10,2)
Insert into Commande
	Values ('Annulée','Facture n°556','13/11/2016','12/11/2015',2,0,3)
Insert into Commande
	Values ('Expédiée','Facture n°10','5/1/2016','1/1/2016',5,15,3)
Insert into Commande
	Values ('En preparation','Facture n°102','12/10/2016','10/10/2016',4,12,1)
Insert into Commande
	Values ('Expédiée','Facture n°1115','20/11/2016','18/11/2016',6,7,7)
Insert into Commande
	Values ('En cour de livraison','Facture n°11','17/12/2016','14/12/2016',9,9,4)
Insert into Commande
	Values ('Annulée','Facture n°22','9/5/2016','7/5/2016',1,5,4)
Insert into Commande
	Values ('Expédiée','Facture n°45','15/5/2016','5/5/2016',3,8,2)
Insert into Commande
	Values ('Preparation','Facture n°65','17/5/2016','7/5/2016',7,8,4)
Insert into Commande
	Values ('Saisie','Facture n°7','14/12/2016','12/12/2016',5,15,5)
Insert into Commande
	Values ('Expédiée','Facture n°1002','12/11/2016','10/11/2016',10,15,8)
Insert into Commande
	Values ('Soldée','Facture n°100','13/1/2016','11/1/2016',8,15,8)
Insert into Commande
	Values ('Expédiée','Facture n°52','17/8/2016','15/8/2016',2,10,1)
Insert into Commande
	Values ('En cour de livraison','Facture n°55','10/1/2016','7/1/2016',10,0,6)
Insert into Commande
	Values ('Expédiée','Facture n°34','11/1/2016','8/1/2016',5,5,8)


-- Adresse

Insert into adresse
	Values ('225 rue du poney','55205','Baabyloon','225 rue du poney','55205','Baabyloon','225 rue du poney','55205','Baabyloon',1)
Insert into adresse
	Values ('11 avenue du cheval','25633','Lolypoop','11 avenue du cheval','25633','Lolypoop','589 avenue du cheval','25633','Lolypoop',2)
Insert into adresse
	Values ('13 rue du péligolo','12001','Partikol','13 rue du péligolo','12001','Partikol','13 rue du péligolo','12001','Partikol',3)
Insert into adresse
	Values ('12 rue du péligolo','12001','Partikol','12 rue du péligolo','12001','Partikol','12 rue du péligolo','12001','Partikol',4)
Insert into adresse
	Values ('23 rue du péligolo','12001','Partikol','23 rue du péligolo','12001','Partikol','23 rue du péligolo','12001','Partikol',5)
Insert into adresse
	Values ('1231 rue du péligolo','12001','Partikol','1231 rue du péligolo','12001','Partikol','123 rue du péligolo','12001','Partikol',6)
Insert into adresse
	Values ('1223 rue du péligolo','12001','Partikol','1223 rue du péligolo','12001','Partikol','123 rue du péligolo','12001','Partikol',7)
Insert into adresse
	Values ('1213 rue du péligolo','12001','Partikol','1223 rue du péligolo','12001','Partikol','1213 rue du péligolo','12001','Partikol',8)
Insert into adresse
	Values ('1232 rue du péligolo','12001','Partikol','1232 rue du péligolo','12001','Partikol','1232 rue du péligolo','12001','Partikol',9)
Insert into adresse
	Values ('123 rue du péligolo','12001','Partikol','11123 rue du péligolo','12001','Partikol','11123 rue du péligolo','12001','Partikol',10)










-- Rubrique

Insert into Rubrique
	Values ('Guitare/Basse')
Insert into Rubrique
	Values ('DJ')
Insert into Rubrique
	Values ('Batterie')
Insert into Rubrique
	Values ('Clavier')
Insert into Rubrique
	Values ('Surface de contrôle')

-- Fournit

Insert into fournit
	Values (22,1,1)
Insert into fournit
	Values (10,2,2)
Insert into fournit
	Values (12,3,3)
Insert into fournit
	Values (120,4,4)
Insert into fournit
	Values (14,5,5)
Insert into fournit
	Values (50,6,6)
Insert into fournit
	Values (75,7,7)
Insert into fournit
	Values (180,8,8)
Insert into fournit
	Values (18,9,9)


-- sont_present

Insert into sont_present
	Values (2,2,1)
Insert into sont_present
	Values (5,1,2)
Insert into sont_present
	Values (3,2,3)
Insert into sont_present
	Values (5,4,4)
Insert into sont_present
	Values (4,5,5)
Insert into sont_present
	Values (10,4,6)
Insert into sont_present
	Values (8,2,7)
Insert into sont_present
	Values (7,9,8)
Insert into sont_present
	Values (6,6,9)
Insert into sont_present
	Values (3,4,10)
Insert into sont_present
	Values (7,7,11)
Insert into sont_present
	Values (12,8,12)
Insert into sont_present
	Values (11,2,13)
Insert into sont_present
	Values (5,1,14)
Insert into sont_present
	Values (7,3,15)




-- s'occupe

Insert into s_occupe
	Values (1,2)
Insert into s_occupe
	Values (2,2)
Insert into s_occupe
	Values (5,3)


-- Livrer

Insert into livrer
	Values ('Bon de livraison n°22',1,2,3,1)
Insert into livrer
	Values ('Bon de livraison n°2',3,2,1,4)


-- Reference

Insert into reference
	Values (1,3)
Insert into reference
	Values (3,4)
Insert into reference
	Values (2,1)


-- Contient

Insert into contient
	Values (1,3)




