SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [State]) 
VALUES (1, N'Admin', N'Admin', 'admin@sigcomt.com', 1)
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO

SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [PersonId], [UserName], [Password], [State], [CreatedAt], [CreatedBy]) 
VALUES (1, 1, 'admin', 'tjD14tYvJgcRqLMP9+tjeQ==', 1, GETDATE(), N'admin')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO

SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([Id], [Name], [State], [CreatedAt], [CreatedBy]) 
VALUES (1, 'Administrador',  1, GETDATE(), N'admin')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO

SET IDENTITY_INSERT [dbo].[UserRole] ON 
GO
INSERT [dbo].[UserRole] ([Id], [UserId], [RoleId]) 
VALUES (1, 1,  1)
GO
SET IDENTITY_INSERT [dbo].[UserRole] OFF
GO

SET IDENTITY_INSERT [dbo].[Master] ON 
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (1, N'REDIRECTIONS', N'Direcciones url')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (2, N'STATES', N'Estados lógicos')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (3, N'CONFIG_TABLES', N'Tablas de configuracion')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (4, N'TYPE_PRODUCT', N'Tipos de productos')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (5, N'TYPE_CUT', N'Tipos de corte')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (6, N'TYPE_REASON_INCOME', N'Tipo Motivo Ingreso')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (7, N'TYPE_REASON_DEPARTURE', N'Tipo Motivo Salida')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (8, N'TYPE_OPERATING_STATUS', N'Tipo Estado Operación')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (9, N'TYPE_ACTIVITY', N'Tipo Actividad')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (10, N'BANKS', N'Bancos')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (11, N'TYPE_PAYMENT_CONDITION', N'Tipo Condición Pago')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (12, N'BANK_ACCOUNTS', N'Cuentas Bancarias')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (13, N'TYPE_REASON_ISSUE', N'Tipo Motivo Emisión')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (14, N'TYPE_REASON_DEBIT', N'Tipo Motivo Debito')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (15, N'TYPE_REASON_TRANSFER', N'Tipo Motivo Traslado')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (16, N'METHOD_PAYMENT', N'Forma de Pago')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (17, N'TYPE_REPORT', N'Tipo Reporte')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (18, N'ADDITIONAL_FEATURES', N'Características Adicional')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (19, N'CHARGES', N'Cargos')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (20, N'AREA', N'Área')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (21, N'RUBRO', N'Rubro')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (22, N'TYPE_PRICE', N'Tipo Precio')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (23, N'PURCHASE_REQUISITIONER', N'Solicitante compra')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (24, N'TYPE_DATA', N'Tipo Dato')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (25, N'TYPE_ACCOUNT', N'Tipo Cuenta')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (25, N'BRAND_PRODUCT', N'Marca de producto')
GO
INSERT [dbo].[Master] ([Id], [Key], [Description]) VALUES (26, N'FILE_REPOSITORY', N'Rutas donde se almacenan los archivos')
GO
SET IDENTITY_INSERT [dbo].[Master] OFF
GO
SET IDENTITY_INSERT [dbo].[MasterDetail] ON 
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (1, 1, 'FRONT_URL', N'http://sigcomt-dc.novaltek.pe:8052/front', 'Front url', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (2, 2, '0', N'Inactivo', 'Estado inactivo', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (3, 2, '1', N'Activo', 'Estado activo', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (4, 3, 'TYPE_PRODUCT', 'Tipo Producto', 'Tipos de Productos', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (5, 3, 'TYPE_CUT', 'Tipo Corte', 'Tipos de Cortes', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (6, 3, 'TYPE_REASON_INCOME', 'Tipo Motivo Ingreso', 'Tipo Motivo Ingreso', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (7, 3, 'TYPE_REASON_DEPARTURE', 'Tipo Motivo Salida', 'Tipo Motivo Salida', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (8, 3, 'TYPE_OPERATING_STATUS', 'Tipo Estado Operación', 'Tipo Estado Operación', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (9, 3, 'TYPE_ACTIVITY', 'Tipo Actividad', 'Tipo Actividad', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (10, 3, 'BANKS', 'Bancos', 'Bancos', 1)
GO																								  
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (11, 3, 'TYPE_PAYMENT_CONDITION', 'Tipo Condición Pago', 'Tipo Condición Pago', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (12, 3, 'BANK_ACCOUNTS', 'Cuentas Bancarias', 'Cuentas Bancarias', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (13, 3, 'TYPE_REASON_ISSUE', 'Tipo Motivo Emisión', 'Tipo Motivo Emisión', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (14, 3, 'TYPE_REASON_DEBIT', 'Tipo Motivo Debito', 'Tipo Motivo Debito', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (15, 3, 'TYPE_REASON_TRANSFER', 'Tipo Motivo Traslado', 'Tipo Motivo Traslado', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (16, 3, 'METHOD_PAYMENT', 'Forma de Pago', 'Forma de Pago', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (17, 3, 'TYPE_REPORT', 'Tipo Reporte', 'Tipo Reporte', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (18, 3, 'ADDITIONAL_FEATURES', 'Características Adicional', 'Características Adicional', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (19, 3, 'CHARGES', 'Cargos', 'Cargos', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (20, 3, 'AREA', 'Área', 'Área', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (21, 3, 'RUBRO', 'Rubro', 'Rubro', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (22, 3, 'TYPE_PRICE', 'Tipo Precio', 'Tipo Precio', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (23, 3, 'PURCHASE_REQUISITIONER', 'Solicitante compra', 'Solicitante compra', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (24, 3, 'TYPE_DATA', 'Tipo Dato', 'Tipo Dato', 1)
GO																								   
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (25, 3, 'TYPE_ACCOUNT', 'Tipo Cuenta', 'Tipo Cuenta', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (26, 3, 'BRAND_PRODUCT', 'Tipo Marca', 'Marca de producto', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (27, 26, 'FILE_WRITE', 'C:\inetpub\wwwroot\Repository', 'Ruta de escritura de archivos.', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (28, 26, 'FILE_READ', 'http://sigcomt-dc.novaltek.pe:8052/Repository/', 'Ruta de lectura de archivos.', 1)
GO
INSERT [dbo].[MasterDetail] ([Id], [MasterId], [Key], [Value], [Description], [State]) VALUES (29, 26, 'IMAGE_PRODUCT', 'Images/Product/', 'Ruta de imagenes de productos.', 1)
GO
SET IDENTITY_INSERT [dbo].[MasterDetail] OFF
GO

SET IDENTITY_INSERT [dbo].[Menu] ON 
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (1, N'Inicio', N'/home', N'home', 1, NULL, 0)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (2, N'Administración', N'/administration', N'build', 2, NULL, 1)
GO
	INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (3, N'Mantenimiento', NULL, NULL, 1, 2, 1)
	GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (4, N'Tabla', N'/administration/table', NULL, 1, 3, 1)
		GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (5, N'Logistica', N'/logistics', N'settings', 3, NULL, 1)
GO
	INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (6, N'Mantenimiento', NULL, NULL, 1, 5, 1)
	GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (7, N'Almacen', N'/logistics/warehouse', NULL, 1, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (8, N'Proveedor', N'/logistics/supplier', NULL, 2, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (9, N'Familia', N'/logistics/family', NULL, 3, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (10, N'SubFamilia', N'/logistics/subfamily', NULL, 4, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (11, N'Producto', N'/logistics/product', NULL, 5, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (12, N'Precio costo', N'/logistics/price-cost', NULL, 6, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (13, N'Transportista', N'/logistics/carrier', NULL, 7, 6, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (14, N'Unidad Transporte', N'/logistics/transport-unit', NULL, 8, 6, 1)
		GO
	INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (15, N'Operaciones', NULL, NULL, 1, 5, 1)
	GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (16, N'Shop', N'/logistics/shop', NULL, 1, 15, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (17, N'Nota de Ingreso', N'/logistics/entry-note', NULL, 2, 15, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (18, N'Nota de Sálida', N'/logistics/output-note', NULL, 3, 15, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (19, N'Guía Remisión', N'/logistics/referral-guide', NULL, 4, 15, 1)
		GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (20, N'Gastos Operativos', N'/operating-expenses', N'paid', 4, NULL, 1)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (21, N'Comercial', N'/comercial', N'sell', 5, NULL, 1)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (22, N'Planilla', N'/spreadsheet', N'article', 6, NULL, 1)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (23, N'Web tienda virtual', N'/storefront', N'storefront', 7, NULL, 1)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (24, N'Seguridad', N'/security', N'security', 8, NULL, 1)
GO
	INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (25, N'Mantenimiento', NULL, NULL, 1, 24, 1)
	GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (26, N'Usuario', N'/security/user', NULL, 1, 25, 1)
		GO
		INSERT [dbo].[Menu] ([Id], [Name], [Url], [Icon], [Order], [MenuParentId], [State]) VALUES (27, N'Rol', N'/security/role', NULL, 2, 25, 1)
		GO
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO

SET IDENTITY_INSERT [dbo].[MenuAction] ON 
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (1, 4, N'management.table.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (2, 4, N'management.table.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (3, 4, N'management.table.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (4, 7, N'logistics.warehouse.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (5, 7, N'logistics.warehouse.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (6, 7, N'logistics.warehouse.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (7, 8, N'logistics.supplier.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (8, 8, N'logistics.supplier.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (9, 8, N'logistics.supplier.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (10, 9, N'logistics.family.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (11, 9, N'logistics.family.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (12, 9, N'logistics.family.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (13, 10, N'logistics.subfamily.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (14, 10, N'logistics.subfamily.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (15, 10, N'logistics.subfamily.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (16, 11, N'logistics.product.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (17, 11, N'logistics.product.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (18, 11, N'logistics.product.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (19, 12, N'logistics.pricecost.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (20, 12, N'logistics.pricecost.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (21, 12, N'logistics.pricecost.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (22, 13, N'logistics.carrier.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (23, 13, N'logistics.carrier.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (24, 13, N'logistics.carrier.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (25, 14, N'logistics.transportunit.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (26, 14, N'logistics.transportunit.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (27, 14, N'logistics.transportunit.changestate', N'Cambiar estado', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (28, 16, N'logistics.shop.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (29, 16, N'logistics.shop.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (30, 17, N'logistics.entrynote.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (31, 17, N'logistics.entrynote.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (32, 18, N'logistics.outputnote.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (33, 18, N'logistics.outputnote.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (34, 19, N'logistics.referralguide.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (35, 19, N'logistics.referralguide.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (36, 20, N'logistics.operatingexpenses.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (37, 20, N'logistics.operatingexpenses.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (38, 21, N'logistics.comercial.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (39, 21, N'logistics.comercial.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (40, 22, N'logistics.spreadsheet.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (41, 22, N'logistics.spreadsheet.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (42, 23, N'logistics.storefront.add', N'Agregar', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (43, 23, N'logistics.storefront.edit', N'Editar',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (44, 26, N'security.user.add', N'Agregar usuarios', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (45, 26, N'security.user.edit', N'Editar usuarios',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (46, 26, N'security.user.changestate', N'Cambiar estado usuarios', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (47, 27, N'security.role.add', N'Agregar roles', 1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (48, 27, N'security.role.edit', N'Editar roles',  1)
GO
INSERT [dbo].[MenuAction] ([Id], [MenuId], [Code], [Description], [State]) VALUES (49, 27, N'security.role.changestate', N'Cambiar estado roles', 1)
GO
SET IDENTITY_INSERT [dbo].[MenuAction] OFF
GO