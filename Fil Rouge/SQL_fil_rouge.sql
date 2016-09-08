create database Fil_rouge
go

Use Fil_rouge
go

/*------------------------------------------------------------
-- Table: Client
------------------------------------------------------------*/
CREATE TABLE Client(
	client_reference INT IDENTITY (1,1) NOT NULL ,
	client_categorie VARCHAR (1)  ,
	client_nom       VARCHAR (30)  ,
	client_prenom    VARCHAR (30)  ,
	client_telephone VARCHAR (10)  ,
	client_mail      VARCHAR (30)  ,
	type_reglement   VARCHAR (30)  ,
	prix_coef        FLOAT  NOT NULL ,
	pro_siret		 VARCHAR (50),
	pro_raison		 VARCHAR (50),
	CONSTRAINT prk_constraint_Client PRIMARY KEY NONCLUSTERED (client_reference)
);

create index type_client
On Client (client_categorie)


/*------------------------------------------------------------
-- Table: Fournisseur
------------------------------------------------------------*/
CREATE TABLE Fournisseur(
	fournisseur_reference       INT IDENTITY (1,1) NOT NULL ,
	fournisseur_nom             VARCHAR (30)  ,
	fournisseur_adresse         VARCHAR (100)  ,
	fournisseur_cp              VARCHAR (10)  ,
	fournisseur_ville           VARCHAR (50)  ,
	CONSTRAINT prk_constraint_Fournisseur PRIMARY KEY NONCLUSTERED (fournisseur_reference)
);



/*------------------------------------------------------------
-- Table: Produits
------------------------------------------------------------*/
CREATE TABLE Produits(
	produit_reference    INT IDENTITY (1,1) NOT NULL ,
	produit_nom          VARCHAR (200)  ,
	produit_libelle_court VARCHAR (50)  ,
	produit_libelle_long VARCHAR (250)  ,
	produit_rubrique     VARCHAR (30)  ,
	produit_stock        INT   ,
	produit_photo        VARCHAR (25)  ,
	prix_achat_initial   MONEY  NOT NULL ,
	prix_vente        MONEY   ,
	taux_tva             FLOAT   ,
	CONSTRAINT prk_constraint_Produits PRIMARY KEY NONCLUSTERED (produit_reference)
);


/*------------------------------------------------------------
-- Table: Commercial
------------------------------------------------------------*/
CREATE TABLE Commercial(
	commercial_matricule INT IDENTITY (1,1) NOT NULL ,
	commercial_nom       VARCHAR (25)  ,
	commercial_prenom    VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Commercial PRIMARY KEY NONCLUSTERED (commercial_matricule)
);


/*------------------------------------------------------------
-- Table: Commande
------------------------------------------------------------*/
CREATE TABLE Commande(
	commande_numero      INT IDENTITY (1,1) NOT NULL ,
	commande_etat        VARCHAR (25)  ,
	facture              VARCHAR (30)  ,
	date_facturation     DATE     ,
	commande_date        DATETIME  ,
	client_reference     INT  REFERENCES Client(client_reference) ,
	code_reduction       INT   ,
	commercial_matricule INT  REFERENCES Commercial(commercial_matricule) ,
	CONSTRAINT prk_constraint_Commande PRIMARY KEY NONCLUSTERED (commande_numero)
);

create index facture_index
On Commande (facture)

/*------------------------------------------------------------
-- Table: adresse
------------------------------------------------------------*/
CREATE TABLE Adresse(
	adresse_reference              INT IDENTITY (1,1) NOT NULL ,
	client_adresse                 VARCHAR (100) NOT NULL ,
	client_code_postal             VARCHAR (10) NOT NULL ,
	client_ville                    VARCHAR (30) NOT NULL ,
	client_facturation_adresse     VARCHAR (100) NOT NULL ,
	client_facturation_code_postal VARCHAR (10) NOT NULL ,
	client_facturation_ville       VARCHAR (30) NOT NULL ,
	client_livraison_adresse       VARCHAR (100) NOT NULL ,
	client_livraison_code_postal   VARCHAR (10) NOT NULL ,
	client_livraison_ville         VARCHAR (30) NOT NULL ,
	client_reference               INT  REFERENCES Client(client_reference) ,
	CONSTRAINT prk_constraint_adresse PRIMARY KEY NONCLUSTERED (adresse_reference)
);


/*------------------------------------------------------------
-- Table: Rubrique
------------------------------------------------------------*/
CREATE TABLE Rubrique(
	rubrique_reference INT IDENTITY (1,1) NOT NULL ,
	sous_rubrique_nom  VARCHAR (30) NOT NULL ,
	CONSTRAINT prk_constraint_Rubrique PRIMARY KEY NONCLUSTERED (rubrique_reference)
);


/*------------------------------------------------------------
-- Table: Fournit
------------------------------------------------------------*/
CREATE TABLE Fournit(
	quantite_produit_fournit INT   ,
	produit_reference        INT  REFERENCES Produits(produit_reference) NOT NULL ,
	fournisseur_reference    INT  REFERENCES Fournisseur(fournisseur_reference)NOT NULL ,
	CONSTRAINT prk_constraint_Fournit PRIMARY KEY NONCLUSTERED (produit_reference,fournisseur_reference)
);


/*------------------------------------------------------------
-- Table: Sont présent
------------------------------------------------------------*/
CREATE TABLE Sont_present(
	quantite_acheter        INT   ,
	produit_reference       INT REFERENCES Produits(produit_reference) NOT NULL ,
	commande_numero         INT REFERENCES Commande(commande_numero) NOT NULL ,
	prix_total              INT NOT NULL,
	CONSTRAINT prk_constraint_Sont_present PRIMARY KEY NONCLUSTERED (produit_reference,commande_numero)
);


/*------------------------------------------------------------
-- Table: S'occupe
------------------------------------------------------------*/
CREATE TABLE S_occupe(
	client_reference     INT  REFERENCES Client(client_reference) NOT NULL ,
	commercial_matricule INT  REFERENCES Commercial(commercial_matricule) NOT NULL ,
	CONSTRAINT prk_constraint_S_occupe PRIMARY KEY NONCLUSTERED (client_reference,commercial_matricule)
);


/*------------------------------------------------------------
-- Table: Livrer
------------------------------------------------------------*/
CREATE TABLE Livrer(
	bon_livraison_numero INT IDENTITY (1,1) NOT NULL ,
	bon_livraison_nom    VARCHAR (30)  ,
	quantite_livrer      INT   ,
	adresse_reference    INT REFERENCES Adresse(adresse_reference) NOT NULL ,
	commande_numero      INT REFERENCES Commande(commande_numero) NOT NULL ,
	produit_reference    INT REFERENCES Produits(produit_reference)NOT NULL ,
	CONSTRAINT prk_constraint_Livrer PRIMARY KEY NONCLUSTERED (adresse_reference,commande_numero,produit_reference)
);

create index quantite
On Livrer (quantite_livrer)

/*------------------------------------------------------------
-- Table: Reference
------------------------------------------------------------*/
CREATE TABLE Reference(
	produit_reference  INT REFERENCES Produits(produit_reference) NOT NULL ,
	rubrique_reference INT REFERENCES Rubrique(rubrique_reference) NOT NULL ,
	CONSTRAINT prk_constraint_Reference PRIMARY KEY NONCLUSTERED (produit_reference,rubrique_reference)
);


/*------------------------------------------------------------
-- Table: Contient
------------------------------------------------------------*/
CREATE TABLE Contient(
	rubrique_reference         INT REFERENCES Rubrique(rubrique_reference) NOT NULL ,
	rubrique_reference_Rubrique   INT  REFERENCES Rubrique(rubrique_reference)  NOT NULL ,
	CONSTRAINT prk_constraint_Contient PRIMARY KEY NONCLUSTERED (rubrique_reference,rubrique_reference_Rubrique)
);






