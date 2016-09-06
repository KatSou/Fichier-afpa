use papyrus_test
go

CREATE proc Lst_fournis
as
SELECT NUMFOU,COUNT (numcom) as 'nombre de commande' from stg02.ENTCOM GROUP BY NUMFOU
go

exec Lst_fournis
go




create proc Lst_Commandes
    @libelle varchar (50)
    as
    select numcom from stg02.ENTCOM
    where obscom like @libelle
go
exec Lst_commandes '%urgente'
go


create proc CA_Fournisseur 
    @codefournis    int,
    @annee             int
    as
    select sum((qtecde * priuni)*1.2) as 'chiffre d''affaire' from stg02.ligcom,stg02.entcom
    where ligcom.numcom = entcom.numcom
	and YEAR(datcom) = @annee
	and numfou = @codefournis
	group by numfou
go
exec CA_Fournisseur 9180, 2007
go