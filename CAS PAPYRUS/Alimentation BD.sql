SET dateformat ymd
Use papyrus
go

insert into stg02.FOURNIS
	Values (00120,'GROBRIGAN','20 rue du papier','92200','papercity','Georges',08)

insert into stg02.FOURNIS
	Values (00540,'ECLIPSE','53, rue laisse flotter les rubans','78250','Bugbugville','Nestor',07)

insert into stg02.FOURNIS
	Values (08700,'MEDICIS','120 rue des plantes','75014','Paris','Lison',null)

insert into stg02.FOURNIS
	Values (09120,'DISCOBOL','11 rue des sports','85100','La roche sur Yon','Hercule',08)

insert into stg02.FOURNIS
	Values (09150,'DEPANPAP','26, avenue des locomotive','59987','Coroncountry','Pollux',05)

insert into stg02.FOURNIS
	Values (09180,'HURRYTAPE','68, boulevard des octets','04044','Dumpville','Track',null)


insert into stg02.PRODUIT
	Values ('l100','Papier 1 ex continu',100,557,3500,'B1000')

insert into stg02.PRODUIT
	Values ('l105','Papier 2 ex continu',75,5,2300,'B1000')

insert into stg02.PRODUIT
	Values ('l108','Papier 3 ex continu',200,557,3500,'B500')

insert into stg02.PRODUIT
	Values ('l110','Papier 4 ex continu',10,12,63,'B400')

insert into stg02.PRODUIT
	Values ('P220','Pré imprimé commande',500,2500,24500,'B500')

insert into stg02.PRODUIT
	Values ('P230','Pré imprimé facture',500,250,12500,'B500')

insert into stg02.PRODUIT
	Values ('P240','Pré imprimé bulletin paie',500,3000,6250,'B500')

insert into stg02.PRODUIT
	Values ('P250','Pré imprimé livraison',500,2500,24500,'B500')

insert into stg02.PRODUIT
	Values ('P270','Pré imprimé fabrication',500,2500,24500,'B500')

insert into stg02.PRODUIT
	Values ('R080','Ruban Epson 850',10,2,120,'unité')
	
insert into stg02.PRODUIT
	Values ('R132','Ruban imp1200 lignes',25,200,182,'unité')
	
insert into stg02.PRODUIT
	Values ('B002','Bande magnétique 6250',20,12,410,'unité')
	
insert into stg02.PRODUIT
	Values ('B001','Bande magnétique 1200',20,87,240,'unité')
	
insert into stg02.PRODUIT
	Values ('D035','CD R slim 80 mm',40,42,150,'B010')	

insert into stg02.PRODUIT
	Values ('D050','CD R-W 80 mm',50,4,0,'B010')


insert into stg02.ENTCOM
	Values (null,'10/02/2007',00120)

insert into stg02.ENTCOM
	Values ('Commande urgente','01/03/2007',00540)

insert into stg02.ENTCOM
	Values (null,'25/04/2007',09180)

insert into stg02.ENTCOM
	Values ('Commande urgente','30/04/2007',09150)

insert into stg02.ENTCOM
	Values ('Commande cadencéé','05/05/2007',00120)

insert into stg02.ENTCOM
	Values (null,'06/06/2007',09120)

insert into stg02.ENTCOM
	Values ('Commande cadencée','02/10/2007',08700)

insert into stg02.ENTCOM
	Values (null,'02/10/2007',00540)

insert into stg02.ENTCOM
	Values (null,'09/10/2007',00120)

insert into stg02.ENTCOM
	Values (null,'12/10/2007',09180)
