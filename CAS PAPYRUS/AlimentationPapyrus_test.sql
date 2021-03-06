SET dateformat ymd

USE [papyrus_test]
GO
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'B001', N'Bande magnétique 1200', 20, 87, 240, N'unité')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'B002', N'Bande magnétique 6250', 20, 12, 410, N'unité')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'D035', N'CD R slim 80 mm', 40, 42, 150, N'B010')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'D050', N'CD R-W 80 mm', 50, 4, 0, N'B010')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'l100', N'Papier 1 ex continu', 100, 557, 3500, N'B1000')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'l105', N'Papier 2 ex continu', 75, 5, 2300, N'B1000')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'l108', N'Papier 3 ex continu', 200, 557, 3500, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'l110', N'Papier 4 ex continu', 10, 12, 63, N'B400')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'P220', N'Pré imprimé commande', 500, 2500, 24500, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'P230', N'Pré imprimé facture', 500, 250, 12500, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'P240', N'Pré imprimé bulletin paie', 500, 3000, 6250, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'P250', N'Pré imprimé livraison', 500, 2500, 24500, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'P270', N'Pré imprimé fabrication', 500, 2500, 24500, N'B500')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'R080', N'Ruban Epson 850', 10, 2, 120, N'unité')
INSERT [stg02].[PRODUIT] ([CODART], [LIBART], [STKALE], [STKPHY], [QTEANN], [UNIMES]) VALUES (N'R132', N'Ruban imp1200 lignes', 25, 200, 182, N'unité')
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (120, N'GROBRIGAN', N'20 rue du papier', N'92200', N'papercity', N'Georges', 8)
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (540, N'ECLIPSE', N'53, rue laisse flotter les rubans', N'78250', N'Bugbugville', N'Nestor', 7)
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (8700, N'MEDICIS', N'120 rue des plantes', N'75014', N'Paris', N'Lison', NULL)
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (9120, N'DISCOBOL', N'11 rue des sports', N'85100', N'La roche sur Yon', N'Hercule', 8)
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (9150, N'DEPANPAP', N'26, avenue des locomotive', N'59987', N'Coroncountry', N'Pollux', 5)
INSERT [stg02].[FOURNIS] ([NUMFOU], [NOMFOU], [RUEFOU], [POSFOU], [VILFOU], [CONFOU], [SATISF]) VALUES (9180, N'HURRYTAPE', N'68, boulevard des octets', N'04044', N'Dumpville', N'Track', NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'B001', 8700, 15, 0, CAST(150.00 AS Numeric(6, 2)), 50, CAST(145.00 AS Numeric(6, 2)), 100, CAST(140.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'B002', 8700, 15, 0, CAST(210.00 AS Numeric(6, 2)), 50, CAST(200.00 AS Numeric(6, 2)), 100, CAST(185.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'D035', 120, 0, 0, CAST(40.00 AS Numeric(6, 2)), NULL, NULL, NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'D035', 9120, 5, 0, CAST(40.00 AS Numeric(6, 2)), 100, CAST(30.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l100', 120, 90, 0, CAST(700.00 AS Numeric(6, 2)), 50, CAST(600.00 AS Numeric(6, 2)), 120, CAST(500.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l100', 540, 70, 0, CAST(710.00 AS Numeric(6, 2)), 60, CAST(630.00 AS Numeric(6, 2)), 100, CAST(600.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l100', 9120, 60, 0, CAST(800.00 AS Numeric(6, 2)), 70, CAST(600.00 AS Numeric(6, 2)), 90, CAST(500.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l100', 9150, 90, 0, CAST(650.00 AS Numeric(6, 2)), 90, CAST(600.00 AS Numeric(6, 2)), 200, CAST(590.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l100', 9180, 30, 0, CAST(720.00 AS Numeric(6, 2)), 50, CAST(670.00 AS Numeric(6, 2)), 100, CAST(490.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l105', 120, 90, 10, CAST(705.00 AS Numeric(6, 2)), 50, CAST(630.00 AS Numeric(6, 2)), 120, CAST(500.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l105', 540, 70, 0, CAST(810.00 AS Numeric(6, 2)), 60, CAST(645.00 AS Numeric(6, 2)), 100, CAST(600.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l105', 8700, 30, 0, CAST(720.00 AS Numeric(6, 2)), 50, CAST(670.00 AS Numeric(6, 2)), 100, CAST(510.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l105', 9120, 60, 0, CAST(920.00 AS Numeric(6, 2)), 70, CAST(800.00 AS Numeric(6, 2)), 90, CAST(700.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l105', 9150, 90, 0, CAST(685.00 AS Numeric(6, 2)), 90, CAST(600.00 AS Numeric(6, 2)), 200, CAST(590.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l108', 120, 90, 5, CAST(795.00 AS Numeric(6, 2)), 30, CAST(720.00 AS Numeric(6, 2)), 100, CAST(680.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l108', 9120, 60, 0, CAST(920.00 AS Numeric(6, 2)), 70, CAST(820.00 AS Numeric(6, 2)), 100, CAST(780.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l110', 9120, 60, 0, CAST(950.00 AS Numeric(6, 2)), 70, CAST(850.00 AS Numeric(6, 2)), 90, CAST(790.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'l110', 9180, 90, 0, CAST(900.00 AS Numeric(6, 2)), 70, CAST(870.00 AS Numeric(6, 2)), 90, CAST(835.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P220', 120, 15, 0, CAST(3700.00 AS Numeric(6, 2)), 100, CAST(3500.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P220', 8700, 20, 50, CAST(3500.00 AS Numeric(6, 2)), 100, CAST(3350.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P230', 120, 30, 0, CAST(5200.00 AS Numeric(6, 2)), 100, CAST(5000.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P230', 8700, 60, 0, CAST(5000.00 AS Numeric(6, 2)), 50, CAST(4900.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P240', 120, 15, 0, CAST(2200.00 AS Numeric(6, 2)), 100, CAST(2000.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P250', 120, 30, 0, CAST(1500.00 AS Numeric(6, 2)), 100, CAST(1400.00 AS Numeric(6, 2)), 500, CAST(1200.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'P250', 9120, 30, 0, CAST(1500.00 AS Numeric(6, 2)), 100, CAST(1400.00 AS Numeric(6, 2)), 500, CAST(1200.00 AS Numeric(6, 2)))
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'R080', 9120, 10, 0, CAST(120.00 AS Numeric(6, 2)), 100, CAST(100.00 AS Numeric(6, 2)), NULL, NULL)
INSERT [stg02].[VENTE] ([CODART], [NUMFOU], [DELLIV], [QTE1], [PRIX1], [QTE2], [PRIX2], [QTE3], [PRIX3]) VALUES (N'R132', 9120, 5, 0, CAST(275.00 AS Numeric(6, 2)), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [stg02].[ENTCOM] ON 

INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (1, NULL, CAST(N'2007-02-10 00:00:00' AS SmallDateTime), 120)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (2, N'Commande urgente', CAST(N'2007-03-01 00:00:00' AS SmallDateTime), 540)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (3, NULL, CAST(N'2007-04-25 00:00:00' AS SmallDateTime), 9180)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (4, N'Commande urgente', CAST(N'2007-04-30 00:00:00' AS SmallDateTime), 9150)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (5, N'Commande cadencéé', CAST(N'2007-05-05 00:00:00' AS SmallDateTime), 120)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (6, NULL, CAST(N'2007-06-06 00:00:00' AS SmallDateTime), 9120)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (7, N'Commande cadencée', CAST(N'2007-10-02 00:00:00' AS SmallDateTime), 8700)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (8, NULL, CAST(N'2007-10-02 00:00:00' AS SmallDateTime), 540)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (9, NULL, CAST(N'2007-10-09 00:00:00' AS SmallDateTime), 120)
INSERT [stg02].[ENTCOM] ([NUMCOM], [OBSCOM], [DATCOM], [NUMFOU]) VALUES (10, NULL, CAST(N'2007-10-12 00:00:00' AS SmallDateTime), 9180)
SET IDENTITY_INSERT [stg02].[ENTCOM] OFF
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'l100', 1, 3000, 470.0000, 3000, CAST(N'2007-03-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'l105', 2, 2000, 485.0000, 2000, CAST(N'2007-07-05 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'l108', 3, 1000, 680.0000, 1000, CAST(N'2007-08-20 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'D035', 4, 200, 40.0000, 250, CAST(N'2007-02-20 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'P220', 5, 6000, 3500.0000, 6000, CAST(N'2007-03-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (1, N'P240', 6, 6000, 2000.0000, 2000, CAST(N'2007-03-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (2, N'l105', 1, 1000, 600.0000, 1000, CAST(N'2007-05-16 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (3, N'B001', 1, 200, 140.0000, 0, CAST(N'2007-12-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (3, N'B002', 2, 200, 140.0000, 0, CAST(N'2007-12-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (4, N'l100', 1, 1000, 590.0000, 1000, CAST(N'2007-05-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (4, N'l105', 2, 500, 590.0000, 500, CAST(N'2007-05-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (5, N'l100', 1, 1000, 470.0000, 1000, CAST(N'2007-07-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (5, N'P220', 2, 10000, 3500.0000, 10000, CAST(N'2007-08-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (6, N'l110', 1, 50, 790.0000, 50, CAST(N'2007-10-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (7, N'P230', 1, 15000, 4900.0000, 12000, CAST(N'2007-12-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (7, N'P220', 2, 10000, 3350.0000, 10000, CAST(N'2007-11-10 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (8, N'l105', 1, 200, 600.0000, 200, CAST(N'2007-11-01 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (9, N'l100', 1, 1000, 470.0000, 1000, CAST(N'2007-10-15 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (9, N'P220', 2, 10000, 3500.0000, 10000, CAST(N'2007-10-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (10, N'B001', 1, 200, 140.0000, 0, CAST(N'2007-12-31 00:00:00' AS SmallDateTime))
INSERT [stg02].[LIGCOM] ([NUMCOM], [CODART], [NUMLIG], [QTECDE], [PRIUNI], [QTELIV], [DERLIV]) VALUES (10, N'B002', 2, 200, 140.0000, 0, CAST(N'2007-12-31 00:00:00' AS SmallDateTime))
