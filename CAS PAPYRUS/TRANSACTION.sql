USE papyrus_test
go


BEGIN TRAN
PRINT 'Valeur de Trancount: ' + CAST(@@TRANCOUNT AS varchar(5))
PRINT 'Avant MaJ:'
SELECT nomfou FROM stg02.FOURNIS WHERE numfou=540
UPDATE stg02.FOURNIS
SET nomfou= 'LEBRIGAND' WHERE numfou=9120
PRINT 'Après MaJ:'
SELECT nomfou FROM stg02.FOURNIS WHERE numfou=540
PRINT 'Valeur de Trancount: ' + CAST(@@TRANCOUNT AS varchar(5)) 
COMMIT TRAN
ROLLBACK TRAN




-- DEMANDER A FRANCOIS LE SET TRANSACTION ET LE SET LOCK ou se place t-il ?  et a quoi cela sert ?