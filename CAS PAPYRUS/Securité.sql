create login util1
with password = 'pwd',
DEFAULT_DATABASE=[master],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF
 
	use Papyrus
		create user util2 for login util2
		create user util3 for login util3

 create login util2
with password = 'pwd',
DEFAULT_DATABASE=[papyrus],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF

create login util3
with password = 'pwd',
DEFAULT_DATABASE=[papyrus],
CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF

	use Papyrus

grant select on stg02.FOURNIS to util2
grant select on stg02.ENTCOM to util2
grant select on stg02.VENTE to util2
grant select on stg02.PRODUIT to util2
grant select on stg02.LIGCOM to util2
go

deny delete on stg02.FOURNIS to util2
deny delete on stg02.ENTCOM to util2
deny delete on stg02.VENTE to util2
deny delete on stg02.PRODUIT to util2
deny delete on stg02.LIGCOM to util2
go

select * from stg02.FOURNIS
go


use papyrus

grant select on stg02.FOURNIS to public
grant select on stg02.ENTCOM to public
grant select on stg02.VENTE to public
grant select on stg02.PRODUIT to public
grant select on stg02.LIGCOM to public
go

create role gestion

execute sp_addrolemember 'gestion','util3'

grant select on stg02.FOURNIS to gestion
grant update on stg02.FOURNIS to gestion


