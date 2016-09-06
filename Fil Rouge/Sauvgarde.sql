exec sp_addumpdevice 'disk','sav_fil_rouge','C:\Backup\Fil_rouge.bak'

backup database Fil_rouge to sav_fil_rouge

restore database Fil_rouge from sav_fil_rouge with replace
