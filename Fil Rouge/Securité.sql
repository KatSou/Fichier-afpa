create login administrateur
with password = 'a1234',
DEFAULT_DATABASE=[master],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF
 

 create login commercial
with password = 'com',
DEFAULT_DATABASE=[Fil_rouge],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF


create login service_gestion
with password = 'gestion123',
DEFAULT_DATABASE=[Fil_rouge],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF

create login client
with password = 'provisoir',
DEFAULT_DATABASE=[Fil_rouge],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF

use Fil_rouge

		create user administrateur for login administrateur
		create user com for login commercial
		create user serv_gest for login service_gestion
		create user client for login client




-- Administrateur 

ALTER ROLE db_owner
	Add member administrateur 


-- Commercial

grant select on Adresse to com
grant select on Produits to com
grant select on S_occupe to com
grant select on Client to com
grant select on Sont_present to com
grant select on Livrer to com
grant select on Contient to com
grant select on Commande to com
grant select on Commercial to com
go

grant update on Client to com
grant update on Commande to com
grant update on Adresse to com
go

grant insert on Client to com
grant insert on Commande to com
go


-- Service_gestion

grant select on Fournisseur to serv_gest
grant select on Produits to serv_gest
grant select on Rubrique to serv_gest
grant select on Fournit to serv_gest
grant select on Sont_present to serv_gest
grant select on reference to serv_gest
grant select on contient to serv_gest
go

grant update on Fournisseur to serv_gest
grant update on Produits to serv_gest
grant update on Rubrique to serv_gest
grant update on fournit to serv_gest
grant update on sont_present to serv_gest
grant update on reference to serv_gest
grant update on contient to serv_gest
go

grant insert on Fournisseur to serv_gest
grant insert on Produits to serv_gest
grant insert on Rubrique to serv_gest
grant insert on Fournit to serv_gest
grant insert on Sont_present to serv_gest
grant insert on Reference to serv_gest
grant insert on Contient to serv_gest
go

grant delete on Fournisseur to serv_gest
grant delete on Produits to serv_gest
grant delete on Rubrique to serv_gest
grant delete on fournit to serv_gest
grant delete on sont_present to serv_gest
grant delete on reference to serv_gest
grant delete on contient to serv_gest
go

-- Client

grant select on commande to client
grant select on adresse to client
grant update on adresse to client
grant insert on adresse to client 
grant select on produits to client





