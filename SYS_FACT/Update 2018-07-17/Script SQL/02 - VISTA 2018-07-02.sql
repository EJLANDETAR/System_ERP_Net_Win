USE [DB]
GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_OTROS_DOCUMENTOS_DETALLES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_OTROS_DOCUMENTOS_DETALLES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_OTROS_DOCUMENTOS_DETALLES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_OTROS_DOCUMENTOS_DETALLES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_DETALLE', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_DETALLE'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_DETALLE', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_DETALLE'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_TASA_INTERES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_TASA_INTERES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_TASA_INTERES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_TASA_INTERES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_DEMORA_GENERADAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_DEMORA_GENERADAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_DEMORA_GENERADAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_DEMORA_GENERADAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_AMORTIZACION', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_AMORTIZACION'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_AMORTIZACION', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_AMORTIZACION'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VMODULOS_REPORTES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VMODULOS_REPORTES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VMODULOS_REPORTES', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VMODULOS_REPORTES'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VEMPRESAS_OFICINAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VEMPRESAS_OFICINAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VEMPRESAS_OFICINAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VEMPRESAS_OFICINAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_RECIBOS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_RECIBOS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_RECIBOS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_RECIBOS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_ABIERTAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_ABIERTAS'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_ABIERTAS', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_ABIERTAS'

GO
/****** Object:  View [dbo].[VZONAS_SECTORES_ALL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VZONAS_SECTORES_ALL]'))
DROP VIEW [dbo].[VZONAS_SECTORES_ALL]
GO
/****** Object:  View [dbo].[VZONAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VZONAS]'))
DROP VIEW [dbo].[VZONAS]
GO
/****** Object:  View [dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]'))
DROP VIEW [dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]
GO
/****** Object:  View [dbo].[VVENTAS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS_DETALLE]'))
DROP VIEW [dbo].[VVENTAS_DETALLE]
GO
/****** Object:  View [dbo].[VVENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS]'))
DROP VIEW [dbo].[VVENTAS]
GO
/****** Object:  View [dbo].[VVENDEDORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENDEDORES]'))
DROP VIEW [dbo].[VVENDEDORES]
GO
/****** Object:  View [dbo].[VUSUARIOS_X_ROLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VUSUARIOS_X_ROLES]'))
DROP VIEW [dbo].[VUSUARIOS_X_ROLES]
GO
/****** Object:  View [dbo].[VTABLAS_COLUMNAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VTABLAS_COLUMNAS]'))
DROP VIEW [dbo].[VTABLAS_COLUMNAS]
GO
/****** Object:  View [dbo].[VSMART_PHONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSMART_PHONES]'))
DROP VIEW [dbo].[VSMART_PHONES]
GO
/****** Object:  View [dbo].[VSISTEMA_TIPOS_NCF]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_TIPOS_NCF]'))
DROP VIEW [dbo].[VSISTEMA_TIPOS_NCF]
GO
/****** Object:  View [dbo].[VSISTEMA_PROCESOS_SCHEDULE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_PROCESOS_SCHEDULE]'))
DROP VIEW [dbo].[VSISTEMA_PROCESOS_SCHEDULE]
GO
/****** Object:  View [dbo].[VSISTEMA_PROCESOS_CONTROL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_PROCESOS_CONTROL]'))
DROP VIEW [dbo].[VSISTEMA_PROCESOS_CONTROL]
GO
/****** Object:  View [dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]'))
DROP VIEW [dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]
GO
/****** Object:  View [dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]'))
DROP VIEW [dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]
GO
/****** Object:  View [dbo].[VSISTEMA_DIAS_NO_LABORABLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_DIAS_NO_LABORABLES]'))
DROP VIEW [dbo].[VSISTEMA_DIAS_NO_LABORABLES]
GO
/****** Object:  View [dbo].[VSISTEMA_COLUMNAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_COLUMNAS]'))
DROP VIEW [dbo].[VSISTEMA_COLUMNAS]
GO
/****** Object:  View [dbo].[VREPORTES_X_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VREPORTES_X_USUARIOS]'))
DROP VIEW [dbo].[VREPORTES_X_USUARIOS]
GO
/****** Object:  View [dbo].[VPROVINCIAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPROVINCIAS]'))
DROP VIEW [dbo].[VPROVINCIAS]
GO
/****** Object:  View [dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]'))
DROP VIEW [dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]
GO
/****** Object:  View [dbo].[VPRESTAMOS_TASA_INTERES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_TASA_INTERES]'))
DROP VIEW [dbo].[VPRESTAMOS_TASA_INTERES]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUDES]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]
GO
/****** Object:  View [dbo].[VPRESTAMOS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DETALLE]'))
DROP VIEW [dbo].[VPRESTAMOS_DETALLE]
GO
/****** Object:  View [dbo].[VPRESTAMOS_DEMORA_GENERADAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DEMORA_GENERADAS]'))
DROP VIEW [dbo].[VPRESTAMOS_DEMORA_GENERADAS]
GO
/****** Object:  View [dbo].[VPRESTAMOS_AMORTIZACION]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_AMORTIZACION]'))
DROP VIEW [dbo].[VPRESTAMOS_AMORTIZACION]
GO
/****** Object:  View [dbo].[VOPCIONES_X_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VOPCIONES_X_USUARIOS]'))
DROP VIEW [dbo].[VOPCIONES_X_USUARIOS]
GO
/****** Object:  View [dbo].[VOPCIONES_X_MODULOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VOPCIONES_X_MODULOS]'))
DROP VIEW [dbo].[VOPCIONES_X_MODULOS]
GO
/****** Object:  View [dbo].[VNOMINAS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VNOMINAS_DETALLE]'))
DROP VIEW [dbo].[VNOMINAS_DETALLE]
GO
/****** Object:  View [dbo].[VMUNICIPIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMUNICIPIOS]'))
DROP VIEW [dbo].[VMUNICIPIOS]
GO
/****** Object:  View [dbo].[VMODULOS_REPORTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMODULOS_REPORTES]'))
DROP VIEW [dbo].[VMODULOS_REPORTES]
GO
/****** Object:  View [dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]'))
DROP VIEW [dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]
GO
/****** Object:  View [dbo].[VENTIDADES_DEMORAS_PENDIENTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDADES_DEMORAS_PENDIENTES]'))
DROP VIEW [dbo].[VENTIDADES_DEMORAS_PENDIENTES]
GO
/****** Object:  View [dbo].[VENTIDADES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDADES]'))
DROP VIEW [dbo].[VENTIDADES]
GO
/****** Object:  View [dbo].[VENTIDAD_CXC]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDAD_CXC]'))
DROP VIEW [dbo].[VENTIDAD_CXC]
GO
/****** Object:  View [dbo].[VEMPRESAS_REPRESENTANTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_REPRESENTANTES]'))
DROP VIEW [dbo].[VEMPRESAS_REPRESENTANTES]
GO
/****** Object:  View [dbo].[VEMPRESAS_OFICINAS_TODAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_OFICINAS_TODAS]'))
DROP VIEW [dbo].[VEMPRESAS_OFICINAS_TODAS]
GO
/****** Object:  View [dbo].[VEMPRESAS_NCF_X_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_NCF_X_OFICINAS]'))
DROP VIEW [dbo].[VEMPRESAS_NCF_X_OFICINAS]
GO
/****** Object:  View [dbo].[VDOCUMENTOS_POR_COBRAR]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDOCUMENTOS_POR_COBRAR]'))
DROP VIEW [dbo].[VDOCUMENTOS_POR_COBRAR]
GO
/****** Object:  View [dbo].[VDEVOLUCIONES_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDEVOLUCIONES_DETALLES]'))
DROP VIEW [dbo].[VDEVOLUCIONES_DETALLES]
GO
/****** Object:  View [dbo].[VCXP_PAGOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_PAGOS]'))
DROP VIEW [dbo].[VCXP_PAGOS]
GO
/****** Object:  View [dbo].[VCXP_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_DETALLES]'))
DROP VIEW [dbo].[VCXP_DETALLES]
GO
/****** Object:  View [dbo].[VCREDITOS_OTORGADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCREDITOS_OTORGADOS]'))
DROP VIEW [dbo].[VCREDITOS_OTORGADOS]
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]'))
DROP VIEW [dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_GENERADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_GENERADOS]'))
DROP VIEW [dbo].[VCONTA_ESTADOS_GENERADOS]
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_CUENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_CUENTAS]'))
DROP VIEW [dbo].[VCONTA_ESTADOS_CUENTAS]
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_ANEXOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_ANEXOS]'))
DROP VIEW [dbo].[VCONTA_ESTADOS_ANEXOS]
GO
/****** Object:  View [dbo].[VCONTA_ENLACES_CUENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ENLACES_CUENTAS]'))
DROP VIEW [dbo].[VCONTA_ENLACES_CUENTAS]
GO
/****** Object:  View [dbo].[VCONTA_DIARIO_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_DIARIO_DETALLE]'))
DROP VIEW [dbo].[VCONTA_DIARIO_DETALLE]
GO
/****** Object:  View [dbo].[VCONTA_DIARIO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_DIARIO]'))
DROP VIEW [dbo].[VCONTA_DIARIO]
GO
/****** Object:  View [dbo].[VCONTA_CATALOGO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_CATALOGO]'))
DROP VIEW [dbo].[VCONTA_CATALOGO]
GO
/****** Object:  View [dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]'))
DROP VIEW [dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]
GO
/****** Object:  View [dbo].[VCONTA_AUXILIARES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_AUXILIARES]'))
DROP VIEW [dbo].[VCONTA_AUXILIARES]
GO
/****** Object:  View [dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]'))
DROP VIEW [dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]
GO
/****** Object:  View [dbo].[VCONFIGURACION_RETRINCIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONFIGURACION_RETRINCIONES]'))
DROP VIEW [dbo].[VCONFIGURACION_RETRINCIONES]
GO
/****** Object:  View [dbo].[VCONFIGURACION_DOC_TEMPLATES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONFIGURACION_DOC_TEMPLATES]'))
DROP VIEW [dbo].[VCONFIGURACION_DOC_TEMPLATES]
GO
/****** Object:  View [dbo].[VCOMPRAS_REQUISICIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCOMPRAS_REQUISICIONES]'))
DROP VIEW [dbo].[VCOMPRAS_REQUISICIONES]
GO
/****** Object:  View [dbo].[VCATEGORIA_PRODUCTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCATEGORIA_PRODUCTOS]'))
DROP VIEW [dbo].[VCATEGORIA_PRODUCTOS]
GO
/****** Object:  View [dbo].[VCAPTACIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAPTACIONES]'))
DROP VIEW [dbo].[VCAPTACIONES]
GO
/****** Object:  View [dbo].[VCAJAS_TRANSACCIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_TRANSACCIONES]'))
DROP VIEW [dbo].[VCAJAS_TRANSACCIONES]
GO
/****** Object:  View [dbo].[VCAJAS_RECIBOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_RECIBOS]'))
DROP VIEW [dbo].[VCAJAS_RECIBOS]
GO
/****** Object:  View [dbo].[VCAJAS_APERTURA_CIERRE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_APERTURA_CIERRE]'))
DROP VIEW [dbo].[VCAJAS_APERTURA_CIERRE]
GO
/****** Object:  View [dbo].[VCAJAS_ABIERTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_ABIERTAS]'))
DROP VIEW [dbo].[VCAJAS_ABIERTAS]
GO
/****** Object:  View [dbo].[VCAJAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS]'))
DROP VIEW [dbo].[VCAJAS]
GO
/****** Object:  View [dbo].[VBANCOS_TRANS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_TRANS]'))
DROP VIEW [dbo].[VBANCOS_TRANS]
GO
/****** Object:  View [dbo].[VBANCOS_CONCILIACIONES_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CONCILIACIONES_DETALLES]'))
DROP VIEW [dbo].[VBANCOS_CONCILIACIONES_DETALLES]
GO
/****** Object:  View [dbo].[VBANCOS_CONCILIACIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CONCILIACIONES]'))
DROP VIEW [dbo].[VBANCOS_CONCILIACIONES]
GO
/****** Object:  View [dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]'))
DROP VIEW [dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]
GO
/****** Object:  View [dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]'))
DROP VIEW [dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]
GO
/****** Object:  View [dbo].[VACTIVOS_FIJOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACTIVOS_FIJOS]'))
DROP VIEW [dbo].[VACTIVOS_FIJOS]
GO
/****** Object:  View [dbo].[VACCESOS_USUARIOS_X_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_USUARIOS_X_OFICINAS]'))
DROP VIEW [dbo].[VACCESOS_USUARIOS_X_OFICINAS]
GO
/****** Object:  View [dbo].[VACCESOS_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_USUARIOS]'))
DROP VIEW [dbo].[VACCESOS_USUARIOS]
GO
/****** Object:  View [dbo].[VACCESOS_OPCIONES_MENU]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_OPCIONES_MENU]'))
DROP VIEW [dbo].[VACCESOS_OPCIONES_MENU]
GO
/****** Object:  View [dbo].[VACCESOS_SESIONES_ACTIVAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_SESIONES_ACTIVAS]'))
DROP VIEW [dbo].[VACCESOS_SESIONES_ACTIVAS]
GO
/****** Object:  View [dbo].[VEMPRESAS_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_OFICINAS]'))
DROP VIEW [dbo].[VEMPRESAS_OFICINAS]
GO
/****** Object:  View [dbo].[VCOLUMNAS_SQL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCOLUMNAS_SQL]'))
DROP VIEW [dbo].[VCOLUMNAS_SQL]
GO
/****** Object:  View [dbo].[VCATALOGO_SQL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCATALOGO_SQL]'))
DROP VIEW [dbo].[VCATALOGO_SQL]
GO
/****** Object:  View [dbo].[VRRHH_EMPLEADOS_HISTORICOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VRRHH_EMPLEADOS_HISTORICOS]'))
DROP VIEW [dbo].[VRRHH_EMPLEADOS_HISTORICOS]
GO
/****** Object:  View [dbo].[VEMPLEADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPLEADOS]'))
DROP VIEW [dbo].[VEMPLEADOS]
GO
/****** Object:  View [dbo].[VCXC_ANTIGUEDAD_SALDO2]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXC_ANTIGUEDAD_SALDO2]'))
DROP VIEW [dbo].[VCXC_ANTIGUEDAD_SALDO2]
GO
/****** Object:  View [dbo].[VCXC_ANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXC_ANTIGUEDAD_SALDO]'))
DROP VIEW [dbo].[VCXC_ANTIGUEDAD_SALDO]
GO
/****** Object:  View [dbo].[VPRESTAMOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS]'))
DROP VIEW [dbo].[VPRESTAMOS]
GO
/****** Object:  View [dbo].[VSECTORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSECTORES]'))
DROP VIEW [dbo].[VSECTORES]
GO
/****** Object:  View [dbo].[VCAJAS_CARPETAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_CARPETAS]'))
DROP VIEW [dbo].[VCAJAS_CARPETAS]
GO
/****** Object:  View [dbo].[VMONEDAS_BILLETES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMONEDAS_BILLETES]'))
DROP VIEW [dbo].[VMONEDAS_BILLETES]
GO
/****** Object:  View [dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]'))
DROP VIEW [dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]'))
DROP VIEW [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]
GO
/****** Object:  View [dbo].[VANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VANTIGUEDAD_SALDO]'))
DROP VIEW [dbo].[VANTIGUEDAD_SALDO]
GO
/****** Object:  View [dbo].[VPRESTAMOS_DETALLE_PENDIENTE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DETALLE_PENDIENTE]'))
DROP VIEW [dbo].[VPRESTAMOS_DETALLE_PENDIENTE]
GO
/****** Object:  View [dbo].[VCXP_ANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_ANTIGUEDAD_SALDO]'))
DROP VIEW [dbo].[VCXP_ANTIGUEDAD_SALDO]
GO
/****** Object:  View [dbo].[VCXP_DIAS_ATRAZOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_DIAS_ATRAZOS]'))
DROP VIEW [dbo].[VCXP_DIAS_ATRAZOS]
GO
/****** Object:  View [dbo].[VCXP_DIAS_ATRAZOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_DIAS_ATRAZOS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VCXP_DIAS_ATRAZOS]
AS
SELECT Suplidor_Id, Monto_Pendiente, Factura_Fecha_Vence, Fecha_Ultimo_Abono, PROXIMO,
       DATEDIFF(dd, Factura_Fecha_Vence, Getdate()) as diasAtrazo
FROM [TCXP]
WHERE Proximo = ''CXP'' and Monto_Pendiente > 0
' 
GO
/****** Object:  View [dbo].[VCXP_ANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_ANTIGUEDAD_SALDO]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/


CREATE VIEW [dbo].[VCXP_ANTIGUEDAD_SALDO]
AS
SELECT
     E.Entidad_Id, E.CedulaRNC, E.Nombres + '' '' + E.Apellidos as ANombre,
	 E.Telefono1, E.Telefono2, E.Direccion, E.Tipo_NCF,
	 d.Monto_Pendiente, d.P0_30, d.P31_60, d.P61_90, d.P91_120, d.PM_121
FROM TCLASIFICADOR_ENTIDADES E
    Inner Join
	 (
		SELECT Suplidor_Id, 
		       Sum(Monto_Pendiente) Monto_Pendiente,
			   Sum(Case when diasAtrazo <= 30 then Monto_Pendiente else 0 End) as P0_30,
			   Sum(Case when (diasAtrazo >= 31 and diasAtrazo <= 60 ) then Monto_Pendiente else 0 End) as P31_60,
			   Sum(Case when (diasAtrazo >= 61 and diasAtrazo <= 90 ) then Monto_Pendiente else 0 End) as P61_90,
			   Sum(Case when (diasAtrazo >= 91 and diasAtrazo <= 120 ) then Monto_Pendiente else 0 End) as P91_120,
			   Sum(Case when (diasAtrazo >= 121) then Monto_Pendiente else 0 End) as PM_121
        FROM VCXP_DIAS_ATRAZOS
        WHERE Proximo = ''CXP'' and Monto_Pendiente > 0
        GROUP by Suplidor_Id
	 ) d on d.Suplidor_Id = E.Entidad_Id

' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_DETALLE_PENDIENTE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DETALLE_PENDIENTE]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_DETALLE_PENDIENTE]
AS
SELECT D.*
	  ,DATEDIFF(dd,  Cast(GetDate() as Date), D.Fecha ) as Cantidad_Dias
	  ,(D.Capital_Pendiente + D.Interes_Pendiente + D.Demora_Pendiente + D.Otros_Pendiente) as Monto
	  ,PO.Monto as Monto_Prestado, PO.Monto_Cuota, PO.Tasa_Demora_Mensual
	  ,PO.Empresa_Id, PO.Oficina_Id, PO.Tipo_Garantia, PO.Entidad_Id, PO.ANombre
	  ,IsNull(TSD.Tasa_Demora, 0) as Tasa_Demora, IsNull(TSD.Dias_Atrazo, 0) AS Dias_Demora
	  ,PO.Tasa_Interes_Anual
	  ,PO.Capital_Pendiente as Balance_Capital 
	  ,PO.Tipo_Saldo
	  ,PO.Fecha_Ultimo_Devengo
	  ,D.Concepto + Case when PO.Factura_No > 0 then '', FACTURA NO.: '' + Cast( PO.Factura_No as Varchar) 
	                     else '', PRESTAMO NO.: '' + Cast(PO.Prestamo_Id as Varchar) 
					End as Descripcion
  FROM [TPRESTAMOS_DETALLE] D
       Inner Join TPRESTAMOS PO On (PO.Prestamo_Id = D.Prestamo_Id)
       Left outer Join
         (
            SELECT TOP 1 Tasa_Demora, Dias_Atrazo FROM TPRESTAMOS_CARGOS WHERE EsDemora = 1
         ) TSD ON (1=1)
  WHERE (D.Capital_Pendiente + D.Interes_Pendiente + D.Demora_Pendiente + D.Otros_Pendiente) > 0
        And PO.Estatus_Id Not In (''R'', ''N'')
        And PO.Rechazado_Fecha Is Null



' 
GO
/****** Object:  View [dbo].[VANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VANTIGUEDAD_SALDO]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VANTIGUEDAD_SALDO]
AS
SELECT
      D.Prestamo_Id, P.Empresa_Id, P.Oficina_Id,
	  P.Entidad_Id, P.CedulaRNC, P.ANombre, P.Factura_No,
	  Sum(Monto_Vencido)    as Monto_Vencido,
	  Sum(Monto_P0_30)      as Monto_P0_30,
	  Sum(Monto_P31_60)     as Monto_P31_60,
	  Sum(Monto_P61_90)     as Monto_P61_90,
	  Sum(Monto_P91_120)    as Monto_P91_120,
	  Sum(Monto_P121)       as Monto_P121,
	  Sum(Monto_Vencido) + Sum(Monto_P0_30) + Sum(Monto_P31_60) + Sum(Monto_P61_90) + Sum(Monto_P91_120) + Sum(Monto_P121) as Total
FROM 
    (
		SELECT 
			  D.Prestamo_Id,
			  Case When (Cantidad_Dias < -10 ) Then Monto else 0  End as Monto_Vencido,
			  Case When (Cantidad_Dias >= -10 And Cantidad_Dias <= 30) Then Monto else 0  End as Monto_P0_30,
			  Case When (Cantidad_Dias >= 31 And Cantidad_Dias <= 60) Then Monto else 0  End as Monto_P31_60,
			  Case When (Cantidad_Dias >= 61 And Cantidad_Dias <= 90) Then Monto else 0  End as Monto_P61_90,
			  Case When (Cantidad_Dias >= 91 And Cantidad_Dias <= 120) Then Monto else 0  End as Monto_P91_120,
			  Case When (Cantidad_Dias >= 121) Then Monto else 0  End as Monto_P121
		FROM VPRESTAMOS_DETALLE_PENDIENTE D
		WHERE (D.Capital_Pendiente + D.Interes_Pendiente + D.Demora_Pendiente + D.Otros_Pendiente) > 0
	) AS D INNER JOIN TPRESTAMOS P ON P.Prestamo_Id = D.PRESTAMO_ID
GROUP BY D.Prestamo_Id,
         P.Empresa_Id, P.Oficina_Id,
	     P.Entidad_Id, P.CedulaRNC, P.ANombre, P.Factura_No

' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]'))
EXEC dbo.sp_executesql @statement = N'





/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES]
AS
SELECT S.[Unico], S.[Solicitud_Id], [Empresa_Id], [Oficina_Id], [Fecha], [Tipo_Garantia]
       ,[Monto_Solicitado], [Plazo], [Forma_Pago], [Motivo_Id]
       ,[Fecha_Caduca], [Estatus_Id], [Estatus]
	   ,S.[Adicionado_Por], S.[Fecha_Adicionado], S.[Modificado_Por], S.[Fecha_Modificado]
       ,[EsEvaluado], [Fecha_Aprobado], [Monto_Aprobado], [Tasa_Aprobada]
       ,[Aprobado_Por], [Rechazada_Fecha], [Rechazada_Por], [Rechazada_Comentario]
       ,[EsAmortizacionCreada], [Fecha_Desembolso], [Prestamo_Id], s.[Entidad_Id]
       ,E.[CedulaRNC], S.[Motivo], s.[Zona_Id]
       ,[Supervisor_Id], [Supervisor_Nombre], [Oficial_Credito_Id]
       ,[Oficial_Nombre], [Garantia_Id], [Dia_APagar], [Producto],
       Case
          When (S.Tipo_Garantia = ''P'')  then ''SOLICITUD PRESTAMO PERSONAL''
          When (S.Tipo_Garantia = ''H'') then ''SOLICITUD PRESTAMO HIPOTECARIO''
          When (S.Tipo_Garantia = ''V'') then ''SOLICITUD PRESTAMO DE VEHICULO''
          When (S.Tipo_Garantia = ''HV'') then ''SOLICITUD PRESTAMO HIPOTECARIO PARA VIVIENDA''
          When (S.Tipo_Garantia = ''E'') then ''SOLICITUD PRESTAMO DE EMPLEADO'' 
          When (S.Tipo_Garantia = ''C'') then ''SOLICITUD PRESTAMO DE CERTIFICADO''
          else ''SOLICTUD DE PRESTAMO PERSONAL''
       End AS Tipo_Solicitud,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Nombre_Completo,
       Cast(Solicitud_Id as Varchar) + REPLACE( IsNull(E.CedulaRNC, ''''), ''-'', '''') + dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Campo_Busqueda
       ,Case 
			 When S.Forma_Pago = ''Q'' then ''QUINCENAS''
			 When S.Forma_Pago = ''S'' then ''SEMANAS''
			 When S.Forma_Pago = ''I'' then ''INTERDIARIO''
			 When S.Forma_Pago = ''D'' then ''DIARIO''
			 When S.Forma_Pago = ''T'' then ''A TERMINO''
			 ELSE ''MENSES''
	    End as Forma_Pago_Descipcion,
		S.Garante_Id, dbo.FCOMBINA_NOMBRES_APELLIDOS(G.NOMBRES, G.APELLIDOS, G.APODOS) as Garante_Nombre
FROM [TPRESTAMOS_SOLICITUD] S
     Inner join TCLASIFICADOR_ENTIDADES E on E.Entidad_Id = S.Entidad_Id
	 Left Outer Join TCLASIFICADOR_ENTIDADES G on (G.Entidad_Id = S.Garante_Id and S.Tipo_Garantia = ''P'')
WHERE 
      ISNULL(S.Prestamo_Id, 0) = 0
	  And S.Fecha_Aprobado Is Null
      And ISNULL(S.Fecha_Caduca, GetDate() ) >= CAST( GETDATE() as DATE)






' 
GO
/****** Object:  View [dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]'))
EXEC dbo.sp_executesql @statement = N'








CREATE VIEW [dbo].[VDOCUMENTOS_PENDIENTE_AMORTIZAR]
AS
SELECT 
       ''VC-'' + CAST(OP.Unico as Varchar) as Unico, op.Identificador_Id, ''VC'' as Tipo, ''VENTA A CREDITO'' Tipo_Documento, op.Numero
	   ,''VC'' Tipo_Garantia, ''FACTURA VENTA A CREDITO'' Descripcion_Garantia
       ,op.Empresa_Id, op.Oficina_Id, op.Fecha
       ,op.Entidad_Id, op.CedulaRNC, op.Nombre  as ANombre, op.Telefonos
	   ,op.Monto_ACredito Monto_Aprobado, DateDiff(mm, op.Fecha, op.Fecha_Vencimiento) Plazo, 0.00 Tasa_Interes_Anual
	   ,DATEADD(mm, 1, GetDate() ) Fecha_Primer_Pago
	   ,IsNull(op.Vendedor_Id, 0) as Evaluador_Id
	   ,Replace(IsNull(op.CedulaRNC, ''''), ''-'', '''') + op.Nombre as Campo_Busqueda
	   ,dbo.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.Apodos) as Nombre_Completo
	   ,dbo.FCOMBINA_NOMBRES_APELLIDOS(V.Nombres, V.Apellidos, V.Apodo) as Oficial_Nombre
	   ,0 as Supervisor_Id
	   ,'''' as Supervisor_Nombre
	   ,op.Numero as FacturaNo
	   ,0 as SolicitudNO
	   ,CAST(0 as Bit) as EsAmortizacionCreada
	   ,op.Monto_ACredito as Monto_Solicitado
	   ,0 as Monto_Inicial
	   ,''M'' as Forma_Pago
  FROM [TVENTAS] op
       Inner Join TCLASIFICADOR_ENTIDADES E on E.Entidad_Id = op.Entidad_Id
       Left Outer Join TRRHH_EMPLEADOS V ON V.Empleado_Id = op.Vendedor_Id
  WHERE OP.Proximo = ''AMT'' AND OP.Monto_ACredito > 0 
        AND IsNull(OP.EsAmortizado, 0) = 0
		And OP.Prestamo_Id Is Null
		And OP.Monto > 0

UNION ALL
SELECT  
       ''SC-'' + CAST(S.Unico as Varchar) as Unico, [Solicitud_Id] as Identificador_Id, ''SC'' AS Tipo, S.TIPO_SOLICITUD Tipo_Documento, Solicitud_Id as Numero
	  ,IsNull(Tipo_Garantia, ''N'') as Tipo_Garantia 
	  ,Case
          When (S.Tipo_Garantia = ''P'')  then ''SOLICITUD PRESTAMO PERSONAL''
          When (S.Tipo_Garantia = ''H'') then ''SOLICITUD PRESTAMO HIPOTECARIO''
          When (S.Tipo_Garantia = ''V'') then ''SOLICITUD PRESTAMO DE VEHICULO''
          When (S.Tipo_Garantia = ''HV'') then ''SOLICITUD PRESTAMO HIPOTECARIO PARA VIVIENDA''
          When (S.Tipo_Garantia = ''E'') then ''SOLICITUD PRESTAMO DE EMPLEADO'' 
          When (S.Tipo_Garantia = ''C'') then ''SOLICITUD PRESTAMO DE CERTIFICADO''
          else ''SOLICTUD DE PRESTAMO PERSONAL''
       End AS [Descripcion_Garantia]
	  ,S.Empresa_Id, S.Oficina_Id, [Fecha]
      ,S.Entidad_Id, E.CedulaRNC, E.Nombres, E.Telefono1
      ,IsNull(Monto_Aprobado, 0) as Monto_Aprobado 
      ,S.Plazo, IsNull(S.Tasa_Aprobada, 0) as Tasa_Interes_Anual
	  ,DATEADD(mm, 1, GetDate() ) Fecha_Primer_Pago
	  ,Oficial_Credito_Id as Evaluador_Id
	  ,Replace(IsNull(E.CedulaRNC, ''''), ''-'', '''') + E.Nombres as Campo_Busqueda
	  ,S.Nombre_Completo
	  ,S.Oficial_Nombre
	  ,S.Supervisor_Id
	  ,S.Supervisor_Nombre
	  ,0 as FacturaNO
	  ,Solicitud_Id as SolicitudNo
	  ,ISNULL(EsAmortizacionCreada, 0) as EsAmortizacionCreada
	  ,Monto_Solicitado
	  ,0 as Monto_Inicial
	  ,S.Forma_Pago
  FROM VPRESTAMOS_SOLICITUDES_PENDIENTES S
       Inner Join TCLASIFICADOR_ENTIDADES E On (S.Entidad_Id = E.Entidad_Id)
WHERE  S.Prestamo_Id Is Null and Rechazada_Fecha Is Null
       And S.Monto_Solicitado > 0









' 
GO
/****** Object:  View [dbo].[VMONEDAS_BILLETES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMONEDAS_BILLETES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VMONEDAS_BILLETES]
AS
SELECT B.Moneda_Id,
       B.Billete,
       B.Valor,
       0 as Cantidad,
       0.00 as Total,
       B.Unico,
	   M.codigo
FROM [TMONEDAS_BILLETES] B
     Inner Join TMONEDAS M on M.Moneda_Id = B.Moneda_Id
WHERE B.EsActivo = 1

' 
GO
/****** Object:  View [dbo].[VCAJAS_CARPETAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_CARPETAS]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE View [dbo].[VCAJAS_CARPETAS]
AS
SELECT 
       C.Empresa_Id, C.Oficina_Id, C.Apertura_No, C.Caja_Id
      ,C.Fecha_Trabajo, C.Fecha_Apertura, C.Usuario_En_Caja
      ,C.Supervisor_Apertura, Monto_Apertura, C.Desglose_Apertura
      ,C.Fecha_Cierre, Case When C.Fecha_Cierre IS Null then ''ABIERTA; NO CERRADA'' Else ''''  End AS Estatus
      ,[Supervisor_Cierre], [Desglose_Cierre]
      ,IsNull(EnEfectivo_Cierre, 0) as EnEfectivo_Cierre
      ,IsNull(EnCheques_Cierre, 0)  as EnCheques_Cierre
      ,IsNull(EnTarjeta_Cierre, 0)  as EnTarjeta_Cierre
      ,IsNull(Faltante, 0)          as Faltante
      ,IsNull(Sobrante, 0)          as Sobrante
      ,IsNull(Venta_AlContado, 0)   as Venta_AlContado
      ,IsNull(Venta_ACredito, 0)    as Venta_ACredito
      ,IsNull(Cobro_Capital, 0)     as Cobro_Capital
      ,IsNull(Cobro_Interes, 0)     as Cobro_Interes
      ,IsNull(Cobro_Demora, 0)      as Cobro_Demora
      ,IsNull(Cobro_Otros, 0)       as Cobro_Otros
      ,IsNull(En_Efectivo, 0)       as En_Efectivo
      ,IsNull(En_Cheques, 0)        as En_Cheques
      ,IsNull(En_Tarjetas, 0)       as En_Tarjetas
      ,IsNull(En_Depositos, 0)      as En_Depositos
      ,IsNull(En_Otros, 0)          as En_Otros
      ,IsNull(Total_Ventas, 0)      as Total_Ventas
      ,IsNull(Total_Recibos, 0)     as Total_Recibos
      ,IsNull(Total_Ingresos, 0)    as Total_Ingresos 
      ,IsNull(Total_Esperado, 0)    as Total_Esperado
      ,[Billete]
      ,IsNull(Valor, 0)             as Valor
	  ,[dbo].FGetCantidadEnDesglose(B.Billete, C.Desglose_Apertura) Cantidad_Apertura
	  ,Valor * [dbo].FGetCantidadEnDesglose(B.Billete, C.Desglose_Apertura) AS Total_Apertura
	  ,[dbo].FGetCantidadEnDesglose(B.Billete, C.Desglose_Cierre) Cantidad_Cierre
	  ,Valor * [dbo].FGetCantidadEnDesglose(B.Billete, C.Desglose_Cierre) AS Total_Cierre
	  ,IsNull(EnNotaCredito, 0)    as EnNotaCredito
  FROM [dbo].[TCAJAS_APERTURA_CIERRE] C
       full outer join VMONEDAS_BILLETES B ON (1=1)


' 
GO
/****** Object:  View [dbo].[VSECTORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSECTORES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSECTORES]
AS
SELECT ST.*,
       IsNull(ZN.Nombre, ''(NO ASIGNADO)'') as Zona,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.Apodo) as Responsable,
       MN.Nombre             as Municipio,
       PV.Provincia_Id,
       PV.Nombre             as Provincia,
       P.Pais_Id,
       P.Nombre              AS Pais,
       ZN.Evaluador_Id,
       ZN.Supervisor_Id,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(S.Nombres, S.Apellidos, S.Apodo) as Supervisor,
	  ST.Nombre + ''/ MUNICIPIO '' + MN.Nombre + ''/ PROVINCIA '' + PV.Nombre as Descripcion_Larga
FROM [TZONAS_SECTORES] ST
     LEFT OUTER JOIN TZONAS ZN ON ZN.Zona_Id = ST.Zona_Id
     LEFT OUTER JOIN TRRHH_EMPLEADOS E ON E.Empleado_Id = ZN.Evaluador_Id
     LEFT OUTER JOIN TRRHH_EMPLEADOS S ON S.Empleado_Id = ZN.Supervisor_Id
     INNER JOIN TZONAS_MUNICIPIOS MN ON MN.Municipio_Id = ST.Municipio_Id
     INNER JOIN TZONAS_PROVINCIAS PV ON MN.Provincia_Id = PV.Provincia_Id
     INNER JOIN TZONAS_PAISES P ON P.Pais_Id = PV.Pais_Id

' 
GO
/****** Object:  View [dbo].[VPRESTAMOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS]'))
EXEC dbo.sp_executesql @statement = N'










/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS]
AS
SELECT P.[Unico]
      ,P.[Oficina_Id]
      ,P.[Prestamo_Id]
      ,P.[Fecha_Otorgado]
      ,P.[Empresa_Id]
      ,P.[Solicitud_Id]
      ,P.[Factura_No]
      ,P.[Entidad_Id]
      ,P.[CedulaRNC]
      ,P.[ANombre]
      ,P.[EsEmpleado]
      ,P.[Motivo_Id]
      ,P.[Codigo_Motivo_SIB]
      ,P.[Tipo_Documento_SIB]
      ,P.[Tipo_Garantia]
      ,P.[Garantia_Id]
      ,P.[Codigo_Garantia_SIB]
      ,P.[Monto]
      ,P.[Moneda_Id]
      ,P.[Simbolo_Moneda]
      ,P.[Concepto]
      ,P.[Plazo]
      ,P.[Forma_Pago_Capital]
      ,P.[Forma_Pago_Interes]
      ,P.[Tasa_Interes_Anual]
      ,P.[Tipo_Saldo]
      ,P.[Monto_Cuota]
      ,P.[Tasa_Demora_Mensual]
      ,P.[Fecha_Primera_Cuota]
      ,P.[Fecha_Termino]
      ,P.[Capital_Pendiente]
      ,P.[Interes_Pendiente]
      ,P.[Demora_Pendiente]
      ,P.[Otros_Pendiente]
      ,P.[Balance]
      ,P.[Capital_P0_30]
      ,P.[Capital_P31_90]
      ,P.[Capital_P91]
      ,P.[Capital_Castigado]
      ,P.[Interes_P0_30]
      ,P.[Interes_P31_90]
      ,P.[Interes_P91_120]
      ,P.[Interes_P121]
      ,P.[Interes_Castigado]
      ,P.[Fecha_Ultimo_Abono]
      ,P.[Dias_Atrazo]
      ,P.[Dias_Atrazo_SIB]
      ,P.[Evaluador_Id]
      ,P.[Evaluador_Nombre]
      ,P.[Supervisor_Id]
      ,P.[Supervisor_Nombre]
      ,P.[Oficial_Id]
      ,P.[Oficial_Nombre]
      ,P.[Zona_Id]
      ,P.[Zona_Nombre]
      ,P.[Estatus_Id]
      ,P.[Estatus]
      ,P.[Fecha_Cancelado]
      ,P.[Clasificacion]
      ,P.[Fecha_Ultimo_Devengo]
      ,P.[Fecha_Proximo_Devengo]
      ,P.[Fecha_Proximo_Pago]
      ,P.[Proximo]
      ,P.[Adicionado_Por]
      ,P.[Fecha_Adicionado]
      ,P.[Modificado_Por]
      ,P.[Fecha_Modificado]
      ,P.[Capital_Adjudicado]
      ,P.[Interes_Adjudicado]
      ,P.[Fecha_Ult_Zonificacion]
      ,P.[No_Cuota_VP]
      ,P.[Capital_VP]
      ,P.[Interes_VP]
      ,P.[Demora_VP]
      ,P.[Otros_VP]
      ,P.[Total_VP]
      ,P.[Rechazado_Por]
      ,P.[Rechazado_Fecha]
      ,P.[Rechazado_Comentario]
      ,P.[Forma_Cobro2]
      ,P.[Forma_Cobro]
      ,P.[Codigo_Anterior]
      ,P.[Empleado_Id]
      ,P.[Cantidad_Cuota_Pendiente]
      ,P.[Cantidad_Cuota_Vencida]
      ,P.[Cantidad_Cuota_Cobrada]
      ,P.[Formula], 
       Case WHEN Tipo_Saldo = ''S'' then ''SALDO SOLUTO'' else ''SALDO INSOLUTO'' End + '' SOBRE INTERES '' + Case When Formula = ''D'' then ''SIMPLE'' else ''AMORTIZADO'' End AS Descripcion_Formula, 
       IsNull(TG.Descripcion, ''NO GARANTIA'') as Descripcion_Tipo_Garantia, P.Fecha_Otorgado as Fecha,
       IsNull(E.Direccion, '''') + '', MUNICIPIO: '' + IsNull(ZT.Municipio, '''') + '', PROVINCIA: '' + IsNull(ZT.Provincia, '''') as Direccion, 
	   IsNull(E.Telefono1, '''') + '' '' + IsNull( E.Telefono2, '''') as Telefonos,
       Cast(P.Prestamo_Id as Varchar) +   Replace(P.CedulaRNC, ''-'', '''') + Replace( IsNull(P.ANombre, ''''), ''-'', '''') + REPLACE( IsNull(P.Garantia_Id, ''''), ''-'', '''') as Campo_Busqueda,
	   IsNull(ZT.Provincia_Id, 0) as Provincia_Id, IsNull(ZT.Provincia, ''NO PROVINCIA'') AS Provincia,
	   IsNull(ZT.Municipio_Id, 0) as Municipio_Id, IsNull(ZT.Municipio, ''NO MUNICIPIO'') AS Municipio,
	   IsNull(E.Sector_Id, 0) as Sector_Id,
	   IsNull(ZT.Nombre, '''') AS Nombre_Sector,
	   Case
	       when Forma_Pago_Capital = ''M'' then ''MENSUALES''
		   when Forma_Pago_Capital = ''Q'' then ''QUINCENALES''
		   when Forma_Pago_Capital = ''S'' then ''SEMANALES''
		   when Forma_Pago_Capital = ''I'' then ''INTERDIARIO''
		   when Forma_Pago_Capital = ''D'' then ''DIARIO''
		   when Forma_Pago_Capital = ''T'' then ''INTERES A TERMINO'' 
	   End as Descripcion_Frecuencia_Pago,
	   IsNull(E.Tipo_NCF, 0) as Tipo_NCF,
	   (Tasa_Interes_Anual/12.0) AS Tasa_Interes_Mensual ,
	   ZT.Descripcion_Larga as Descripcion_Sector
  FROM [TPRESTAMOS] P
       LEFT OUTER JOIN TPRESTAMOS_TIPO_GARANTIAS TG ON (TG.Tipo_Garantia_Id = P.Tipo_Garantia)
	   LEFT OUTER JOIN TCLASIFICADOR_ENTIDADES E ON (E.Entidad_Id = P.Entidad_Id)
	   LEFT OUTER JOIN VSECTORES ZT ON ZT.Sector_Id = E.Sector_Id
WHERE P.Estatus_Id Not In(''R'', ''N'')
      And Rechazado_Fecha Is Null











' 
GO
/****** Object:  View [dbo].[VCXC_ANTIGUEDAD_SALDO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXC_ANTIGUEDAD_SALDO]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCXC_ANTIGUEDAD_SALDO]
AS
SELECT
      D.Prestamo_Id, P.Empresa_Id, P.Oficina_Id,
	  IsNull(P.Entidad_Id, 0) as Entidad_Id, 
	  Factura_No,
	  Sum(Monto_Vencido)    as Monto_Vencido,
	  Sum(Monto_P0_30)      as Monto_P0_30,
	  Sum(Monto_P31_60)     as Monto_P31_60,
	  Sum(Monto_P61_90)     as Monto_P61_90,
	  Sum(Monto_P91_120)    as Monto_P91_120,
	  Sum(Monto_P121)       as Monto_P121,
	  Sum(Monto_Vencido) + Sum(Monto_P0_30) + Sum(Monto_P31_60) + Sum(Monto_P61_90) + Sum(Monto_P91_120) + Sum(Monto_P121) as Total
FROM 
    (
		SELECT 
			  D.Prestamo_Id,
			  Case When (Cantidad_Dias < -10 ) Then Monto else 0  End as Monto_Vencido,
			  Case When (Cantidad_Dias >= -10 And Cantidad_Dias <= 30) Then Monto else 0  End as Monto_P0_30,
			  Case When (Cantidad_Dias >= 31 And Cantidad_Dias <= 60) Then Monto else 0  End as Monto_P31_60,
			  Case When (Cantidad_Dias >= 61 And Cantidad_Dias <= 90) Then Monto else 0  End as Monto_P61_90,
			  Case When (Cantidad_Dias >= 91 And Cantidad_Dias <= 120) Then Monto else 0  End as Monto_P91_120,
			  Case When (Cantidad_Dias >= 121) Then Monto else 0  End as Monto_P121
		FROM VPRESTAMOS_DETALLE_PENDIENTE D
		WHERE (D.Capital_Pendiente + D.Interes_Pendiente + D.Demora_Pendiente + D.Otros_Pendiente) > 0
	) AS D INNER JOIN TPRESTAMOS P ON P.Prestamo_Id = D.PRESTAMO_ID
	Left Outer Join TCLASIFICADOR_ENTIDADES E ON E.Entidad_Id = P.Entidad_Id
WHERE p.Factura_No > 0
GROUP BY
      D.Prestamo_Id, P.Empresa_Id, P.Oficina_Id,
	  IsNull(P.Entidad_Id, 0), 
	  Factura_No


' 
GO
/****** Object:  View [dbo].[VCXC_ANTIGUEDAD_SALDO2]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXC_ANTIGUEDAD_SALDO2]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VCXC_ANTIGUEDAD_SALDO2]
AS
     SELECT S.*,
	        E.CedulaRNC,
			dbo.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.CedulaRNC) AS ANombre,
			P.Fecha_Otorgado as Fecha,
			P.Fecha_Ultimo_Abono,
			P.Fecha_Proximo_Pago,
			P.Dias_Atrazo,
			ROW_NUMBER() OVER(Order by S.Prestamo_Id) as Unico 
	 FROM [dbo].[VCXC_ANTIGUEDAD_SALDO] S
	      Left Outer Join TCLASIFICADOR_ENTIDADES E ON E.Entidad_Id = S.Entidad_Id
		  Inner Join TPRESTAMOS P ON P.Prestamo_Id = S.Prestamo_Id
' 
GO
/****** Object:  View [dbo].[VEMPLEADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPLEADOS]'))
EXEC dbo.sp_executesql @statement = N'




/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VEMPLEADOS]
AS
SELECT 
      E.*,
      IsNull(E.Nombres, '''') + '' '' + IsNull(E.Apellidos, '''') as Nombre_Completo,
      Replace(CedulaRNC, ''-'', '''') + IsNull(E.Nombres, '''') + '' '' + IsNull(E.Apellidos, '''') Campo_Busqueda,
	  Case When O.Oficina_Id Is Null then ''NO OFICINA'' ELSE  O.Nombre  End as Nombre_Oficina
  FROM TRRHH_EMPLEADOS E
       LEFT OUTER Join TEMPRESAS_OFICINAS O ON O.Oficina_Id = E.Oficina_Id

' 
GO
/****** Object:  View [dbo].[VRRHH_EMPLEADOS_HISTORICOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VRRHH_EMPLEADOS_HISTORICOS]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VRRHH_EMPLEADOS_HISTORICOS]
AS
SELECT H.[Unico]
      ,H.[Empleado_Id]
      ,H.[Empresa_Id]
      ,H.[Fecha]
      ,H.[Tipo]
      ,H.[Concepto]
      ,H.[EsNulo]
      ,H.[Adicionado_Por]
      ,H.[Fecha_Adicionado]
      ,H.[Modificado_Por]
      ,H.[Fecha_Modificado]
      ,H.[Valor_Anterior]
      ,H.[Valor_Nuevo]
      ,H.[Fecha_Desde]
      ,H.[Fecha_Hasta]
	  ,VE.Nombre_Completo
	  ,VE.Nombre_Oficina
	  ,Case when H.Tipo = ''CAMBIO-SALARIO'' THEN (Valor_Nuevo - Valor_Anterior) else 0 End as Aum_Salario
  FROM [TRRHH_EMPLEADOS_HISTORICOS] H
       INNER JOIN VEMPLEADOS VE ON VE.Empleado_Id = H.Empleado_Id

' 
GO
/****** Object:  View [dbo].[VCATALOGO_SQL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCATALOGO_SQL]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VCATALOGO_SQL]
AS
SELECT SCHEMA_NAME(schema_id)  + ''.'' + name AS name 
  ,Case
      when type_desc LIKE ''%PROCEDURE'' then ''SP''
	  when type_desc LIKE ''%FUNCTION'' then ''FN''
	  when type_desc LIKE ''%TABLE'' then ''TB''
	  when type_desc LIKE ''%VIEW'' then ''V''
	  else ''''
   end as Tipo,
   type, object_id as Tabla_Id, object_id
FROM sys.objects
WHERE  type in (''V'', ''U'')

' 
GO
/****** Object:  View [dbo].[VCOLUMNAS_SQL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCOLUMNAS_SQL]'))
EXEC dbo.sp_executesql @statement = N'











CREATE VIEW [dbo].[VCOLUMNAS_SQL]
AS
SELECT COL.object_id AS table_Id, COL.column_id,         
       COL.name,         
       TYP.name AS type_name,   
	   case
	      When  TYP.name = ''nvarchar'' Then COL.max_length/2
		  else COL.max_length
	   end as Size,      
       case
	      When  TYP.name = ''nvarchar'' Then Cast(COL.max_length/2 as Varchar)            
		  when col.max_length = 9 then Convert(Varchar(20),col.precision)+'',''+Convert(Varchar(20),col.scale) 
		  else Convert(Varchar(20),col.max_length) 
	   end  as Long,        
       COL.precision,        
       COL.scale,        
       COL.is_nullable,
	   Case
           When COL.name =  ''Unico'' then ''Campo AutoIncrementar que identifica de forma unica a Cada Registro''
           When COL.name =  ''Autor'' then ''Usuario que Inserto o Modifico el Registro por Ultima Vez''
           When COL.name =  ''AutorAccion'' then ''I= Inserto       M= Modifico''
		   When COL.name =  ''Adicionado_Por'' then ''Usuario que Inserto el Registro''
           When COL.name =  ''Modificado_Por'' then ''Usuario que Modifico el Registro por ultima vez''
		   When COL.name =  ''Fecha_Modificado'' then ''Fecha en que se modifico el registro por ultima vez''
		   When COL.name =  ''Fecha_Adicionado'' then ''Fecha en que se Inserto el registro''
		   else
		      IsNull( (SELECT TOP 1 VALUE FROM Sys.extended_properties WHERE Name = ''MS_Description'' and major_id = COL.object_id AND minor_id = COL.column_id ), '''')
	   End   as Description,
	   T.name as Tabla                      
FROM SYS.columns COL      
     JOIN [sys].[types] TYP ON col.system_type_id = TYP.system_type_id 
	 INNER JOIN VCATALOGO_SQL  T ON (T.object_id = COL.object_id)
WHERE TYP.name <> ''SYSNAME''  



' 
GO
/****** Object:  View [dbo].[VEMPRESAS_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_OFICINAS]'))
EXEC dbo.sp_executesql @statement = N'

CREATE VIEW [dbo].[VEMPRESAS_OFICINAS]
AS
SELECT        O.Unico, O.Empresa_Id, O.Oficina_Id, O.Nombre, O.Tipo, O.Direccion, O.Telefono1, O.Telefono2, O.Pais_Id, O.Provincia_Id, O.Municipio_Id, O.Oficina_Madre_Id, O.Latitud, O.Longitud, O.Gerente, 
                         O.Telefonos_Gerente, O.EMail, O.Fecha_Trabajo, O.Fecha_Contable, O.EsActivo, O.Adicionado_Por, O.Fecha_Adicionado, O.Modificado_Por, O.Fecha_Modificado, E.RNC AS Empresa_RNC, 
                         E.Nombre AS Empresa_Nombre, E.Siglas AS Empresa_Siglas, E.Logo AS Empresa_Logo, E.Direccion_Web AS Empresa_Direccion_WEB, E.Moneda_Id AS Empresa_Moneda_Id,
						 IsNull(E.slogan, '''') as Empresa_Slogan,
						 ISNULL(SC.Logo, '''') as Imagen_Logo_Sys,
						 ISNULL(SC.BackGround, '''') as Imagen_Fondo_Sys,
						 IsNull(E.Mensaje_Factura, '''') as Mensaje_Factura,
						 dbo.FN_GET_SIGUIENTE_FECHA_LABORAL(O.Fecha_Trabajo, 1) as Proxima_Fecha_Trabajo
FROM            dbo.TEMPRESAS AS E 
                INNER JOIN dbo.TEMPRESAS_OFICINAS AS O ON E.Empresa_Id = O.Empresa_Id
                LEFT OUTER JOIN (SELECT TOP 1 * FROM TSISTEMA_CONFIG) SC ON (1=1)
WHERE O.EsActivo = 1


' 
GO
/****** Object:  View [dbo].[VACCESOS_SESIONES_ACTIVAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_SESIONES_ACTIVAS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VACCESOS_SESIONES_ACTIVAS]
AS
SELECT S.[Unico]
      ,S.[Session_Id]
      ,S.[Empresa_Id]
      ,S.[Oficina_Id]
      ,S.[Token]
      ,S.[Usuario]
      ,S.[Fecha_Inicio]
      ,S.[Fecha_Fin]
      ,S.[Fecha_Ultimo_Acceso]
      ,S.[ReporteURL]
      ,S.[Mensaje_Error]
      ,S.[Smart_UID]
      ,S.[Caja_Id]
      ,S.[Fecha_Trabajo]
      ,S.[Fecha_Contable]
	  ,S.Nombre_PC
	  ,S.Direccion_IP
	  ,EO.Nombre AS Oficina_Nombre, EO.Direccion, EO.Telefono1, EO.Telefono2, EO.EMail
	  ,EO.Empresa_Nombre, EO.Mensaje_Factura
  FROM [TACCESOS_SESIONES] S
       left outer join VEMPRESAS_OFICINAS EO ON EO.Oficina_Id = S.Oficina_Id
  WHERE S.Fecha_Fin Is Null and s.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VACCESOS_OPCIONES_MENU]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_OPCIONES_MENU]'))
EXEC dbo.sp_executesql @statement = N'





/****** Script for SelectTopNRows command from SSMS  ******/
CREATE View [dbo].[VACCESOS_OPCIONES_MENU]
As
SELECT M.[Unico]
      ,M.[Menu_Id]
      ,M.[Nombre]
      ,M.[Codigo]
      ,M.[Comentario]
      ,M.[GlyphIcon]
      ,M.[Estado_URL]
      ,M.[Formulario_AEjecutar]
      ,M.[Titulo]
      ,M.[EsModal]
      ,M.[Menu_Madre_Id]
      ,M.[Proximo]
      ,M.[EsReporte]
      ,M.[EsActivo]
      ,M.[FormaImprimir]
      ,M.[TipoFormulario]
      ,M.[Adicionado_Por]
      ,M.[Fecha_Adicionado]
      ,M.[Modificado_Por]
      ,M.[Fecha_Modificado]
      ,M.[Modulo_Id]
      ,M.[Image]
      ,M.[OrdenNo]
      ,M.[EsMenuConsulta]
      ,M.[Sub_Modulo_Id]
      ,M.[URL]
      ,SM.Carpeta
	  ,SM.Carpeta as Modulo
	  ,M.EsWeb
  FROM [TACCESOS_OPCIONES_MENU] M
       LEFT OUTER JOIN TSISTEMA_MODULOS SM ON (SM.Modulo_Id = M.Modulo_Id)






' 
GO
/****** Object:  View [dbo].[VACCESOS_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_USUARIOS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VACCESOS_USUARIOS]
AS
SELECT [Unico]
      ,[Nombre_Usuario]
      ,[Empresa_Id]
      ,[Oficina_Id]
      ,[Nombres]
      ,[Apellidos]
      ,[EsClave_Expira]
      ,[EsActivo]
      ,[EsBloqueado]
      ,[EsOficinalCredito]
      ,[EsSupervisor]
      ,[EsCajero]
      ,[Fecha_Vence_Clave]
      ,[Motivo_Bloqueo]
      ,[Fecha_Bloqueado]
      ,[Adicionado_Por]
      ,[Fecha_Adicionado]
      ,[Modificado_Por]
      ,[Fecha_Modificado]
      ,[Tipo_Interop]
	  , Case when Nombre_Usuario = ''SYS.ADMIN'' then ''(ADMINISTRADOR)   '' else '''' End
	  + Case when EsSupervisor = 1 then ''(SUPERVISOR)   '' else '''' End
	  + Case when EsOficinalCredito = 1 then ''(OFICIAL DE CREDITO)   '' else '''' End
	  + Case when EsCajero = 1 then ''(CAJERO)   '' else '''' End as Atributos
  FROM [TACCESOS_USUARIOS]
' 
GO
/****** Object:  View [dbo].[VACCESOS_USUARIOS_X_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACCESOS_USUARIOS_X_OFICINAS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VACCESOS_USUARIOS_X_OFICINAS]
AS
SELECT UO.Unico, UO.Oficina_Id, UO.Nombre_Usuario, O.Nombre, O.Oficina_Madre_Id, 
       O.Direccion, O.Telefono1, O.Telefono2, O.EMail, O.Fecha_Trabajo, O.Fecha_Contable,
	   O.Gerente, O.Telefonos_Gerente,
	   U.EsCajero, U.EsActivo, U.EsSupervisor, U.EsOficinalCredito,
	   U.Nombres +  '' '' + IsNull(U.Apellidos, '''') + '' ('' + U.Nombre_Usuario + '')'' as Usuario
FROM TACCESOS_USUARIOS_X_OFICINAS UO
     INNER JOIN TEMPRESAS_OFICINAS O ON O.Oficina_Id = UO.Oficina_Id
	 INNER JOIN TACCESOS_USUARIOS U ON U.Nombre_Usuario = UO.Nombre_Usuario
WHERE UO.EsActivo = 1 AND O.EsActivo = 1 AND U.EsActivo = 1

' 
GO
/****** Object:  View [dbo].[VACTIVOS_FIJOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACTIVOS_FIJOS]'))
EXEC dbo.sp_executesql @statement = N'



/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VACTIVOS_FIJOS]
AS
SELECT AF.Activo_Id, AF.Oficina_Id, AF.Tipo_Id, AF.Vida_Util, af.Ubicacion_Id,
       AF.Nombre, AF.Valor_Adquisicion, AF.Valor_En_Libro, AF.Valor_Libro_Depreciar,
	   AF.Depre_Acumulada, AF.Depre_Periodo, AF.Depre_Calculada, AF.Fecha_Ultima_Depre,
	   AF.EsActivo, AF.Estatus_Id, AF.Estatus, AF.Fecha_Baja, AF.Responsable, AF.Fecha_Adquisicion,
       T.Descripcion as Descripcion_Tipo, IsNull(T.Valor_Residual, 0) as Valor_Residual,
	   O.Nombre      as Descripcion_Oficina,
	   IsNull(UB.Nombre, '''')     as Descripcion_Ubicacion
	   ,Cast(AF.Fecha_Adquisicion as Date) as Fecha
	   ,IsNull(AF.Serial_No, '''') as Serial_No
	   ,AF.Unico
  FROM [TACTIVOS_FIJOS] AF
       INNER JOIN TACTIVOS_FIJOS_TIPOS T ON T.Tipo_Id = AF.Tipo_Id
	   Left Outer Join TEMPRESAS_OFICINAS O ON O.Oficina_Id = AF.Oficina_Id
	   Left Outer Join TACTIVOS_FIJOS_UBICACIONES UB ON UB.Ubicacion_Id = AF.Ubicacion_Id




' 
GO
/****** Object:  View [dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VACTIVOS_FIJOS_MOVIMIENTOS]
AS
SELECT M.[Unico]
      ,M.[Id]
      ,M.[Tipo]
      ,M.[Fecha]
      ,M.[Fecha_Contable]
      ,M.[Activo_Id]
      ,M.[Nombre]
      ,M.[Valor_Adquisicion]
      ,M.[Tipo_Id]
      ,M.[Vida_Util]
      ,M.[Empresa_Id]
      ,M.[Oficina_Id]
      ,M.[Depre_Calculada]
      ,M.[Concepto]
      ,M.[Valor_Libro_Depreciar]
      ,M.[Depre_Periodo]
      ,M.[Depre_Acumulada]
      ,M.[DeTipo_Id]
      ,M.[ATipo_Id]
      ,M.[DeOficina_Id]
      ,M.[AOficina_Id]
      ,M.[DeUbicacion_Id]
      ,M.[AUbicacion_Id]
      ,M.[DeResponsable]
      ,M.[AResponsable]
      ,M.[Monto]
      ,M.[Monto_Ganancia]
      ,M.[Descripcion]
      ,M.[Estatus_Id]
      ,M.[Estatus]
      ,M.[Adicionado_Por]
      ,M.[Fecha_Adicionado]
      ,M.[Modificado_Por]
      ,M.[Fecha_Modificado]
      ,M.[Asiento_Id]
      ,M.[EsNulo]
      ,M.[Metodo_Depre]
      ,M.[Fecha_Deleted]
	  ,T.Descripcion as Descripcion_Tipo
	  ,O.Nombre      as Descripcion_Oficina
  FROM [TACTIVOS_FIJOS_MOVIMIENTOS] M
       INNER JOIN TACTIVOS_FIJOS_TIPOS T ON T.Tipo_Id = M.Tipo_Id
	   Left Outer Join TEMPRESAS_OFICINAS O ON O.Oficina_Id = M.Oficina_Id
WHERE M.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VBANCOS_CHEQUES_PREDEFINIDOS]
AS
SELECT P.[Unico]
      ,P.[Id]
      ,P.[Empresa_Id]
      ,P.[Cuenta_Id]
      ,P.[Cuenta_Contable]
      ,P.[Concepto]
      ,P.[EsActivo]
      ,P.[Adicionado_Por]
      ,P.[Fecha_Adicionado]
      ,P.[Modificado_Por]
      ,P.[Fecha_Modificado]
      ,P.[UFecha_Generado]
      ,P.[Generado_Por]
	  ,C.Nombre + '' ['' + C.Numero + '']'' as Cuenta_Bancaria
	  ,CC.Descripcion as Descripcion_Cuenta
	  ,P.UBeneficiario
	  ,P.UMonto
  FROM [TBANCOS_CHEQUES_PREDEFINIDOS] P
       Inner Join TBANCOS_CUENTAS_BANCARIAS C on C.Cuenta_Id = P.Cuenta_Id
	   Left Outer Join TCONTA_CATALOGO CC ON (CC.Cuenta_Contable = P.Cuenta_Contable And P.Empresa_Id = CC.Empresa_Id)


' 
GO
/****** Object:  View [dbo].[VBANCOS_CONCILIACIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CONCILIACIONES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VBANCOS_CONCILIACIONES]
AS
SELECT C.[Unico]
      ,C.[Conciliacion_Id]
      ,C.[Cuenta_Id]
      ,C.[Cuenta_Numero]
      ,C.[Cuenta_Contable]
      ,C.[Oficina_Id]
      ,C.[Anio]
      ,C.[Mes]
      ,C.[Balance_En_Banco]
      ,C.[Cheques_En_Transitos]
      ,C.[Depositos_En_Transitos]
      ,C.[Nota_Debito_Banco]
      ,C.[Nota_Credito_Banco]
      ,C.[Balance_Conciliado_Banco]
      ,C.[Balance_En_Libro]
      ,C.[Nota_Debito_Libro]
      ,C.[Nota_Credito_Libro]
      ,C.[Balance_Conciliado_Libro]
      ,C.[Comentario]
      ,C.[EsNulo]
      ,C.[EsConciliado]
      ,C.[Fecha]
      ,C.[Conciliado_Por]
      ,C.[Adicionado_Por]
      ,C.[Fecha_Adicionado]
      ,C.[Modificado_Por]
      ,C.[Fecha_Modificado]
      ,C.[Diferencia]
	  ,CB.Nombre as NombreCuenta
	  ,CASE WHEN C.EsConciliado = 0 Or Diferencia <> 0 then ''TEMPORAL'' else '''' END as Estatus
  FROM [TBANCOS_CONCILIACIONES] C
       INNER JOIN TBANCOS_CUENTAS_BANCARIAS CB ON CB.Cuenta_Id = C.Cuenta_Id
  WHERE C.EsNulo = 0

' 
GO
/****** Object:  View [dbo].[VBANCOS_CONCILIACIONES_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_CONCILIACIONES_DETALLES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VBANCOS_CONCILIACIONES_DETALLES]
AS
SELECT  D.[Unico]
      ,D.[Conciliacion_Id]
      ,D.[Fecha]
      ,D.[Oficina_Id]
      ,D.[Concepto]
      ,D.[Debito]
      ,D.[Credito]
      ,D.[Fecha_Deleted]
      ,D.[Asiento_Id]
      ,D.[Adicionado_Por]
      ,D.[Fecha_Adicionado]
      ,D.[Modificado_Por]
      ,D.[Fecha_Modificado]
      ,D.[Cuenta_Contable]
      ,D.[Tipo]
	  ,C.Cuenta_Id
	  ,C.Cuenta_Numero
	  ,C.EsConciliado
  FROM [TBANCOS_CONCILIACIONES_DETALLES] D
       INNER JOIN TBANCOS_CONCILIACIONES C ON C.Conciliacion_Id = D.Conciliacion_Id
  WHERE D.Fecha_Deleted Is Null AND IsNull(C.EsNulo, 0) = 0' 
GO
/****** Object:  View [dbo].[VBANCOS_TRANS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VBANCOS_TRANS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VBANCOS_TRANS]
AS
SELECT T.[Unico]
      ,T.[Trans_Id]
      ,T.[Fecha]
      ,T.[Empresa_Id]
      ,T.[Oficina_Id]
      ,T.[Cuenta_Id]
      ,T.[Tipo]
      ,T.[Numero]
      ,T.[Referencia]
      ,T.[Concepto]
      ,T.[Beneficiario]
      ,T.[Monto]
      ,T.[EsImpreso]
      ,T.[Impreso_Por]
      ,T.[Fecha_Impreso]
      ,T.[Debito]
      ,T.[Credito]
      ,T.[Digitado_Por]
      ,T.[Asiento_Id]
      ,T.[Prestamo_Id]
      ,T.[EsNulo]
      ,T.[Anulado_Por]
      ,T.[Fecha_Anulado]
      ,T.[EsRecibido]
      ,T.[Conciliacion_Id]
      ,T.[Adicionado_Por]
      ,T.[Fecha_Adicionado]
      ,T.[Modificado_Por]
      ,T.[Fecha_Modificado]
      ,T.[Estatus_Id]
      ,T.[Estatus]
	  ,CB.Nombre as Nombre_Cuenta
	  ,CB.Numero as Cuenta_Numero
  FROM [TBANCOS_TRANS] T
       INNER JOIN TBANCOS_CUENTAS_BANCARIAS CB ON (CB.Cuenta_Id = T.Cuenta_Id)
' 
GO
/****** Object:  View [dbo].[VCAJAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCAJAS]
AS
SELECT C.[Unico]
      ,C.[Empresa_Id]
      ,C.[Oficina_Id]
      ,C.[Caja_Id]
      ,C.[Nombre]
      ,C.[Comentario]
      ,C.[EsActivo]
      ,C.[Monto_Fondo]
      ,C.[Fecha_Apertura]
      ,C.[Usuario_En_Caja]
      ,C.[Adicionado_Por]
      ,C.[Fecha_Adicionado]
      ,C.[Modificado_Por]
      ,C.[Fecha_Modificado]
      ,C.[Cuenta_Contable]
      ,C.[Fecha_Deleted]
	  ,IsNull(O.Nombre, '''') as Oficina_Nombre
  FROM [TCAJAS] C
       LEFT OUTER JOIN TEMPRESAS_OFICINAS O ON (O.Oficina_Id = C.Oficina_Id)
WHERE C.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VCAJAS_ABIERTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_ABIERTAS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VCAJAS_ABIERTAS]
AS
SELECT     C.Nombre, CA.Apertura_No, CA.Caja_Id, CA.Fecha_Apertura, CA.Usuario_En_Caja, CA.Unico, C.Empresa_Id, C.Oficina_Id, CA.Fecha_Cierre
FROM         dbo.TCAJAS AS C INNER JOIN
                      dbo.TCAJAS_APERTURA_CIERRE AS CA ON C.Caja_Id = CA.Caja_Id
WHERE     (CA.Fecha_Cierre IS NULL)
' 
GO
/****** Object:  View [dbo].[VCAJAS_APERTURA_CIERRE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_APERTURA_CIERRE]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCAJAS_APERTURA_CIERRE]
AS
SELECT CC.[Unico]
      ,CC.[Empresa_Id]
      ,CC.[Oficina_Id]
      ,CC.[Apertura_No]
      ,CC.[Caja_Id]
      ,CC.[Fecha_Trabajo]
      ,CC.[Fecha_Apertura]
      ,CC.[Usuario_En_Caja]
      ,CC.[Supervisor_Apertura]
      ,CC.[Monto_Apertura]
      ,CC.[Desglose_Apertura]
      ,CC.[Fecha_Cierre]
      ,CC.[Supervisor_Cierre]
      ,CC.[Desglose_Cierre]
      ,CC.[EnEfectivo_Cierre]
      ,CC.[EnCheques_Cierre]
      ,CC.[EnTarjeta_Cierre]
      ,CC.[Faltante]
      ,CC.[Sobrante]
      ,CC.[Venta_AlContado]
      ,CC.[Venta_ACredito]
      ,CC.[Cobro_Capital]
      ,CC.[Cobro_Interes]
      ,CC.[Cobro_Demora]
      ,CC.[Cobro_Otros]
      ,CC.[En_Efectivo]
      ,CC.[En_Cheques]
      ,CC.[En_Tarjetas]
      ,CC.[En_Depositos]
      ,CC.[EnNotaCredito]
      ,CC.[En_Otros]
      ,CC.[Adicionado_Por]
      ,CC.[Fecha_Adicionado]
      ,CC.[Modificado_Por]
      ,CC.[Fecha_Modificado]
      ,CC.[Total_Ventas]
      ,CC.[Total_Recibos]
      ,CC.[Total_Ingresos]
      ,CC.[Total_Esperado]
	  ,O.Nombre as Oficina_Nombre
  FROM [TCAJAS_APERTURA_CIERRE] CC
       inner join TEMPRESAS_OFICINAS O on O.Oficina_Id = CC.Oficina_Id' 
GO
/****** Object:  View [dbo].[VCAJAS_RECIBOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_RECIBOS]'))
EXEC dbo.sp_executesql @statement = N'








CREATE VIEW [dbo].[VCAJAS_RECIBOS]
AS
SELECT        
              RC.Unico,
			  RC.Recibo_Id, RC.Empresa_Id, RC.Oficina_Id, RC.Caja_Id, 
              RC.Tipo_Trans, RC.Fecha, RC.Concepto, RC.Documento_Id, 
			  RC.Entidad_Id, 
			  Case When E.Entidad_Id Is Null then RC.CedulaRNC else E.CedulaRNC End as CedulaRNC , 
			  Case when E.Entidad_Id IS NULL then Nombre else DBO.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.Apodos) End as Nombre,
			  E.Direccion,
			  IsNull(E.Telefono1, '''') + '' '' + IsNull(E.Telefono2, '''') as Telefonos,
			  IsNull(RC.Tipo_NCF, 0) as Tipo_NCF, IsNull(RC.NCF, '''') as NCF, 
			  RC.Monto, RC.Capital, RC.Interes, RC.Demora, RC.Otros, 
			  RC.En_Efectivo, RC.En_Cheques, RC.En_Tarjetas, RC.En_Otros, RC.ADevolver, 
			  RC.EsNulo, RC.Tipo, RC.Fecha_Adicionado, replace( RC.Adicionado_Por, ''.'', ''  '') as Cajero,
			  TT.Descripcion, RC.Adicionado_Por, RC.Apertura_Caja_No,
			  (SELECT TOP 1 Descripcion FROM TSISTEMA_TIPOS_NCF WHERE Tipo_NCF = RC.Tipo_NCF) as Nombre_NCF,
			  Cast(Recibo_Id as Varchar) + ''CD'' + IsNull(RC.CedulaRNC, '''') + IsNull(RC.Nombre, '''') + ''NCF'' + ISNULL(NCF, '''') Campo_Busqueda,
              Case
                  when IsNull(NCF, '''') = '''' then ''''
				  When ISNULL(RC.Tipo_NCF, 0) > 0 THEN IsNull(CF.Descripcion, '''')
                  Else ''''
              End  AS Descripcion_NCF,
              RC.Capital_PFinal,
              IsNull(RC.Factura_No, 0) Factura_No,
			  IsNull(RC.Capital_PAnterior, 0) as Capital_PAnterior,
			  TT.EsOtro
FROM            dbo.TCAJAS_TIPO_TRANS AS TT 
                INNER JOIN dbo.TCAJAS_RECIBOS AS RC ON TT.Tipo_Trans = RC.Tipo_Trans
                Left Outer Join TSISTEMA_TIPOS_NCF CF ON (CF.Tipo_NCF = RC.Tipo_NCF)
				Left Outer Join TCLASIFICADOR_ENTIDADES E ON E.Entidad_Id = RC.Entidad_Id
WHERE IsNull(RC.EsNulo, 0) = 0






' 
GO
/****** Object:  View [dbo].[VCAJAS_TRANSACCIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAJAS_TRANSACCIONES]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCAJAS_TRANSACCIONES]
AS
SELECT 
      V.Identificador_Id, V.Numero,
      V.Caja_Id, V.Fecha, V.Oficina_Id, V.Empresa_Id,
      V.Concepto, V.Monto,
      V.Monto_AlContado, V.Monto_ACredito,
      V.EnEfectivo, V.EnCheques, V.EnTarjeta, ADevolver,
      V.Adicionado_Por,
      ''VENTAS'' Tipo_Trans, ''V'' AS Tipo,
      0 Capital, 0 Interes, 0 Demora, 0 Otros,
      Nombre, NCF, Apertura_Caja_No,
      IsNull(Nota_Credito_Monto, 0) EnNotaCredito,
	  0 as Tipo_Id
  FROM [TVENTAS] V
WHERE EsNulo = 0

--UNIMOS CON LOS RECIBO registrado
UNION ALL
SELECT
     R.Recibo_Id as Identificador_Id, R.Recibo_Id as Numero,
     R.Caja_Id, R.Fecha, R.Oficina_Id, R.Empresa_Id,
     R.Concepto, R.Monto,
     0 AS Monto_AlContado, 0 as Monto_ACredito,
     R.En_Efectivo AS EnEfectivo, R.En_Cheques AS EnCheques, R.En_Tarjetas AS EnTarjeta, ADevolver,
     R.Adicionado_Por,
     T.Descripcion as Tipo_Trans, ''R'' AS Tipo,
     R.Capital, R.Interes, R.Demora, R.Otros,
     R.Nombre, R.NCF, R.Apertura_Caja_No,
     0 EnNotaCredito,
	 R.Tipo_Trans as Tipo_Id
FROM TCAJAS_RECIBOS R
     Left Outer Join TCAJAS_TIPO_TRANS T on (T.Tipo_Trans = R.Tipo_Trans)
where EsNulo = 0


' 
GO
/****** Object:  View [dbo].[VCAPTACIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCAPTACIONES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCAPTACIONES]
AS
SELECT CA.[Unico]
      ,CA.[Numero]
      ,CA.[Oficina_Id]
      ,CA.[Fecha]
      ,CA.[Entidad_Id]
      ,CA.[CedulaRNC]
      ,CA.[ANombre]
      ,CA.[CodigoSha]
      ,CA.[Monto]
      ,CA.[Debito]
      ,CA.[Credito]
      ,CA.[Balance]
      ,CA.[EsCertificado]
      ,CA.[Plazo]
      ,CA.[Fecha_Termino]
      ,CA.[Fecha_Renovado]
      ,CA.[Fecha_Cancelado]
      ,CA.[UFecha_Generado]
      ,CA.[Estatus_Id]
      ,CA.[Estatus]
      ,CA.[Adicionado_Por]
      ,CA.[Fecha_Adicionado]
      ,CA.[Modificado_Por]
      ,CA.[Fecha_Modificado]
      ,CA.[EsBloqueado]
      ,CA.[TipoId]
	  ,TC.Descripcion AS Tipo_Cuenta
  FROM [TCAPTACIONES] CA
       INNER JOIN TCAPTACIONES_TIPO_CUENTAS TC ON TC.Codigo = CA.TipoId
' 
GO
/****** Object:  View [dbo].[VCATEGORIA_PRODUCTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCATEGORIA_PRODUCTOS]'))
EXEC dbo.sp_executesql @statement = N'


 CREATE View [dbo].[VCATEGORIA_PRODUCTOS]
 AS
 SELECT P.[Unico]
      ,P.[Producto_Id]
      ,P.[Nombre_Corto]
      ,P.[Descripcion]
      ,P.[Costo_Ultima_Compra]
      ,P.[Categoria_Id]
      ,P.[Marca_Id]
      ,P.[Precio_Regular]
      ,P.[Precio_Nivel_B]
      ,P.[Precio_Nivel_A]
      ,P.[Precio_Oferta]
      ,P.[Codigo_Barra]
      ,P.[EsOferta]
      ,P.[EsActivo]
      ,P.[EsInventario]
      ,P.[UMedida_Id]
      ,P.[EnExistencia]
      ,P.[Punto_Reorden]
      ,P.[EsCompra]
      ,P.[EsVenta]
      ,P.[PrecioConItbis]
      ,P.[Tipo_Producto_DGII]
      ,P.[Observaciones]
      ,P.[Adicionado_Por]
      ,P.[Fecha_Adicionado]
      ,P.[Modificado_Por]
      ,P.[Fecha_Modificado]
      ,P.[Fecha_Ultima_Compra]
      ,P.[Fecha_Ultima_Venta]
      ,P.[Codigo_Producto_Ant]
      ,P.[Garantias]
      ,P.[Precio_Minimo]
      ,P.[EsExcentoItbis] 
      ,C.Nombre Categoria
      ,Case When IsNull(EsExcentoItbis, 0) = 1 then 0 else  C.Tasa_Itbis End as Tasa_Itbis
      ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1)  then P.Precio_Regular else  P.Precio_Regular + (P.Precio_Regular * C.Tasa_Itbis/100.0) end as PrecioR
      ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1) then P.Precio_Nivel_A else P.Precio_Nivel_A + (P.Precio_Nivel_A * C.Tasa_Itbis/100.0) end as PrecioA
      ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1) then P.Precio_Nivel_B else  P.Precio_Nivel_B + (P.Precio_Nivel_B * C.Tasa_Itbis/100.0) end as PrecioB
      ,IsNull(P.Codigo_Barra, '''') + ISNULL(P.Nombre_Corto, '''') as Campo_Busqueda
      ,IsNull(M.Nombre, '''') as Marca
	  ,IsNull(MD.Abreviatura, ''UND'') AS Unidad
	  ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1)  then P.Precio_Minimo else  P.Precio_Minimo + (P.Precio_Minimo * C.Tasa_Itbis/100.0) end as PrecioM
	  ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1)  then P.Precio_Oferta else  P.Precio_Oferta + (P.Precio_Oferta * C.Tasa_Itbis/100.0) end as PrecioO
	  ,IsNull(P.EsServicio, 0) EsServicio
  FROM [TCLASIFICADOR_PRODUCTOS] P
       Inner Join TCLASIFICADOR_PRODUCTOS_CATEGORIAS C On (C.Categoria_Id = P.Categoria_Id)
       Left Outer Join TCLASIFICADOR_MARCAS M ON (M.Marca_Id = P.Marca_Id)
	   Left Outer Join TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS MD ON (MD.UMedida_Id = P.UMedida_Id)
' 
GO
/****** Object:  View [dbo].[VCOMPRAS_REQUISICIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCOMPRAS_REQUISICIONES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCOMPRAS_REQUISICIONES]
AS
SELECT C.[Unico]
      ,[CXP_Id]
      ,[Modulo]
      ,[Codigo_Transaccion]
      ,[Codigo_Sub_Transaccion]
      ,[Numero]
      ,[Proximo]
      ,C.[Empresa_Id]
      ,C.[Oficina_Id]
      ,[Fecha]
      ,[Suplidor_Id]
      ,C.[CedulaRNC]
      ,C.[Nombre]
      ,C.[Direccion]
      ,[Telefono]
      ,[Tipo_NCF]
      ,[Factura_Numero]
      ,[Factura_Fecha]
      ,[Factura_Dias_Credito]
      ,[Factura_Fecha_Vence]
      ,[NCF]
      ,[Tipo_Gastos_DGII]
      ,[Orden_Id]
      ,[Concepto]
      ,[Sub_Total]
      ,[Descuento]
      ,[Neto]
      ,[Itbis]
      ,[Otros_Tipo]
      ,[Otros]
      ,[Total]
      ,[Retencion_Itbis]
      ,[Retencion_Neto]
      ,[Monto_APagar]
      ,[Entidad_ReEmbolsar_Id]
      ,[Total_Debitado]
      ,[Total_ACreditado]
      ,[Monto_Pendiente]
      ,[Fecha_Ultimo_Abono]
      ,[Forma_Ultimo_Pago]
      ,[Referencia_Ultimo_Pago]
      ,[Estatus_Id]
      ,C.[Estatus]
      ,C.[Adicionado_Por]
      ,C.[Fecha_Adicionado]
      ,C.[Modificado_Por]
      ,C.[Fecha_Modificado]
      ,[Gastos_Fijo_Id]
      ,[Asiento_Id]
      ,[CXP_OrigenId]
      ,[Moneda]
      ,[Tasa_Cambio]
      ,[Fecha_Requerida]
      ,[EsNulo]
      ,[Fecha_Anulado]
      ,c.[Empleado_Id]
      ,C.[Departamento_Id]
      ,[Cantidad_Pendiente]
      ,[Aprobado_Por]
      ,[Fecha_Aprobado]
      ,[Fecha_Rechazado]
	  ,D.Nombre as Departamento
	  ,dbo.FCOMBINA_NOMBRES_APELLIDOS( E.Nombres, E.Apellidos, E.Apodo) as Empleado
  FROM [TCXP] C
       LEFT OUTER JOIN TRRHH_DEPARTAMENTOS D ON D.Departamento_Id = C.Departamento_Id
	   Left Outer Join TRRHH_EMPLEADOS E on E.Empleado_Id = C.Empleado_Id
  WHERE EsNulo = 0 AND Modulo = ''REQ''

' 
GO
/****** Object:  View [dbo].[VCONFIGURACION_DOC_TEMPLATES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONFIGURACION_DOC_TEMPLATES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONFIGURACION_DOC_TEMPLATES]
AS
SELECT T.[Unico]
      ,T.[Codigo]
      ,T.[DocTemplate]
      ,T.[Producto_Id]
      ,T.[EsActivo]
      ,T.[EsReimprimir]
      ,T.[Adicionado_Por]
      ,T.[Fecha_Adicionado]
      ,T.[Modificado_Por]
      ,T.[Fecha_Modificado]
      ,T.[ConAbogado]
      ,T.[ConNotario]
      ,T.[ConAlguacil]
      ,T.[ConTestigo]
      ,T.[ConGerente]
      ,T.[EsLegal]
      ,T.[Tipo_Garantia_Id]
      ,T.[Cantidad_Deudores]
      ,T.[Evento]
	  ,T.[Descripcion] 
	   + Case when P.Unico Is Null then '''' else '', '' + P.Nombre End 
	   + Case when G.Unico Is Null then '', SIN GARANTIA'' else '', GARANTIA: '' + G.Descripcion End as Descripcion
  FROM [TCONFIGURACION_DOC_TEMPLATES] T
       Left Outer Join TPRODUCTOS_FINANCIEROS P on P.Codigo = T.Producto_Id
	   Left Outer Join TPRESTAMOS_TIPO_GARANTIAS G on G.Tipo_Garantia_Id = T.Tipo_Garantia_Id
' 
GO
/****** Object:  View [dbo].[VCONFIGURACION_RETRINCIONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONFIGURACION_RETRINCIONES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONFIGURACION_RETRINCIONES]
AS
SELECT R.[Unico]
      ,R.[Codigo]
      ,R.[Valor]
      ,R.[Adicionado_Por]
      ,R.[Fecha_Adicionado]
      ,R.[Modificado_Por]
      ,R.[Fecha_Modificado]
      ,R.[Fecha_Deleted]
	  ,IsNull(A.Descripcion, ''NO DEFINIDO'') as Descripcion
	  ,R.EsActivo, R.Comentario
  FROM [TCONFIGURACION_RETRINCIONES] R
       Left Join
	   (
	      SELECT Id, Descripcion 
		  FROM  TSISTEMA_TABLA_AUXILIAR  
		  WHERE Nombre_Tabla = ''TIPO_RESTRINCION''
	   ) A on A.Id = R.Codigo
  WHERE R.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_ASIENTOS_PREDEFINIDOS]
AS
SELECT A.[Unico]
      ,A.[Plantilla_Id]
      ,A.[Empresa_Id]
      ,A.[Concepto]
      ,A.[Cuenta_Debito]
	  ,IsNull(cd.Descripcion, '''') Cuenta_Debito_Nombre
      ,A.[Cuenta_Credito]
	  ,IsNull(cc.Descripcion, '''') Cuenta_Credito_Nombre
      ,A.[Codigo_Auxiliar]
      ,A.[Adicionado_Por]
      ,A.[Fecha_Adicionado]
      ,A.[Modificado_Por]
      ,A.[Fecha_Modificado]
      ,A.[EsActivo]
      ,A.[Fe_Ult_Generado]
      ,A.[UAsiento_Id]
	  ,IsNull(A.Monto, 0) as Monto
  FROM [TCONTA_ASIENTOS_PREDEFINIDOS] A
       Left Outer Join TCONTA_CATALOGO CD ON (CD.Cuenta_Contable = A.Cuenta_Debito and CD.Empresa_Id = A.Empresa_Id)
	   Left Outer Join TCONTA_CATALOGO CC ON (CC.Cuenta_Contable = A.Cuenta_Debito and CC.Empresa_Id = A.Empresa_Id)
' 
GO
/****** Object:  View [dbo].[VCONTA_AUXILIARES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_AUXILIARES]'))
EXEC dbo.sp_executesql @statement = N'
CREATE View [dbo].[VCONTA_AUXILIARES]
As
SELECT
      O.Empresa_Id,
	  O.Oficina_Id,
	  A.Codigo,
	  IsNull(A.EsActivo, 0) EsActivo,
	  Cast(O.Oficina_Id as Varchar) + RIGHT(''000'' + Cast(A.Codigo as Varchar), 3) Codigo_Auxiliar,
	  Case
           when IsNull(A.Concepto, '''') = '''' then O.Nombre
		   else 
		      O.NOMBRE + '' '' + A.Concepto
       end Descripcion
FROM TEMPRESAS_OFICINAS O
     Full outer join  TCONTA_AUXILIARES A on (1=1)

UNION ALL
SELECT 
    Empresa_Id, Oficina_Id, 0, EsActivo, Cast(Oficina_Id as Varchar) + ''000'' as Codigo_Auxiliar,
    O.Nombre as Descripcion
 FROM TEMPRESAS_OFICINAS O

' 
GO
/****** Object:  View [dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_CARTERA_CREDITO_RESUMEN]
AS 
SELECT [Unico]
      ,IsNull([Tipo_SIB], 1) as Tipo_SIB
      ,[Oficina_Id]
      ,[Fecha]
      ,[Codigo_Cartera]
      ,[Descripcion]
      ,[Cartera_Origen]
      ,[Monto]
      ,[NoOrden]
      ,[Adicionado_Por]
      ,[Fecha_Adicionado]
      ,[Modificado_Por]
      ,[Fecha_Modificado]
      ,[EsAprobado]
      ,[Asiento_Id]
      ,[Fecha_Ant]
	  ,Case
	      when Codigo_Cartera = ''C0'' THEN ''CAPITAL VIGENTE 0-30''
		  when Codigo_Cartera = ''C31'' THEN ''CAPITAL VENCIDO 31-90''
		  when Codigo_Cartera = ''C91'' THEN ''CAPITAL VENCIDO +90''
		  when Codigo_Cartera = ''I0'' THEN ''INTERES VIGENTE 0-30''
		  when Codigo_Cartera = ''I31'' THEN ''INTERES VENCIDO 31-90''
		  when Codigo_Cartera = ''I91'' THEN ''INTERES VENCIDO 91-120''
		  when Codigo_Cartera = ''I121'' THEN ''INTERES SUSPENSO +121''
		  ELSE ''OTROS''
	   End as Titulo 
	   ,Case
	      when Codigo_Cartera = ''C0'' THEN  3
		  when Codigo_Cartera = ''C31'' THEN 2
		  when Codigo_Cartera = ''C91'' THEN 1
		  when Codigo_Cartera = ''I0'' THEN 7
		  when Codigo_Cartera = ''I31'' THEN 6
		  when Codigo_Cartera = ''I91'' THEN 5
		  when Codigo_Cartera = ''I121'' THEN 4
		  ELSE ''-1''
	   End as Titulo_NoOrden
  FROM [TCONTA_CARTERA_CREDITO_RESUMEN]
  WHERE Oficina_Id > 0

' 
GO
/****** Object:  View [dbo].[VCONTA_CATALOGO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_CATALOGO]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VCONTA_CATALOGO]
AS
SELECT Cuenta_Contable, Descripcion, 0 as Codigo_Auxiliar, 
       IsNull(Saldo_Mes_Anterior, 0) as Saldo_Mes_Anterior, IsNull(Debito_Mes, 0) as Debito_Mes, IsNull(Credito_Mes, 0) as Credito_Mes, IsNull(Saldo_Actual, 0) as Saldo_Actual, 
       EsControl, Empresa_Id, Fecha_Actualizado,
	   Saldo_Anio_Anterior, Debito_Acumulado, Credito_Acumulado
FROM TCONTA_CATALOGO
WHERE EsControl = 1

UNION ALL
SELECT Cuenta_Contable, Descripcion, Codigo_Auxiliar,
       IsNull(Saldo_Mes_Anterior, 0) as Saldo_Mes_Anterior, IsNull(Debito_Mes, 0) as Debito_Mes, IsNull(Credito_Mes, 0) as Credito_Mes, IsNull(Saldo_Actual, 0) as Saldo_Actual, 
       Cast(0 as Bit) EsControl, Empresa_Id, NULL AS Fecha_Actualizado,
	   Saldo_Anio_Anterior, Debito_Acumulado, Credito_Acumulado
FROM TCONTA_CATALOGO_AUXILIAR

' 
GO
/****** Object:  View [dbo].[VCONTA_DIARIO]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_DIARIO]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_DIARIO]
AS
SELECT D.*
       ,IsNull(MD.Carpeta, ''CONTABILIDAD GENERAL'')      as Aplicacion
	   ,IsNull(TS.Nombre, ''N/A'')       as Transaccion
	   ,IsNull(STS.Nombre, ''N/A'')      as SubTransaccion
  FROM TCONTA_DIARIO D
       LEFT OUTER JOIN TSISTEMA_MODULOS MD ON MD.Codigo = D.Codigo_Aplicacion
	   LEFT OUTER JOIN TSISTEMA_MODULOS_TRANSACCIONES TS ON TS.Codigo = D.Codigo_Transaccion
	   LEFT OUTER JOIN TSISTEMA_MODULOS_SUB_TRANSACCIONES STS ON STS.Codigo_Sub_Transaccion = D.SubTransaccion_Id


' 
GO
/****** Object:  View [dbo].[VCONTA_DIARIO_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_DIARIO_DETALLE]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_DIARIO_DETALLE]
AS
SELECT 
       DT.[Asiento_Id]
      ,DT.[Empresa_Id]
      ,[Codigo_Auxiliar]
      ,[Descripcion]
      ,DT.[Fecha]
      ,DT.[Mes]
      ,DT.[Tipo_Movimiento]
      ,DT.[Referencia]
      ,DT.[Asiento_No]
      ,DT.[Cuenta_Contable]
      ,DT.[Debito]
      ,DT.[Credito]
      ,D.[Estatus_Id]
      ,D.[Estatus]
	  ,D.Monto
	  ,D.Concepto
  FROM [TCONTA_DIARIO_DETALLE] DT
       INNER JOIN TCONTA_DIARIO D ON D.Asiento_Id = DT.Asiento_Id
  WHERE DT.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VCONTA_ENLACES_CUENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ENLACES_CUENTAS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_ENLACES_CUENTAS]
AS
SELECT CE.[Unico]
      ,CE.[Enlace_Id]
      ,CE.[Codigo]
      ,CE.[Descripcion]
      ,CE.[EsDebito]
      ,CE.[EsCredito]
      ,CE.[Adicionado_Por]
      ,CE.[Fecha_Adicionado]
      ,CE.[Modificado_Por]
      ,CE.[Fecha_Modificado]
      ,CE.[Cuenta_Contable]
      ,CE.[Fecha_Deleted]
      ,CE.[Empresa_Id]
      ,CE.[Oficina_Id]
      ,CE.[EsSistema]
	  ,IsNull(CC.Descripcion, '''') as CuentaContableNombre
  FROM [TCONTA_ENLACES_CUENTAS] CE
       LEFT OUTER JOIN TCONTA_CATALOGO CC ON (CC.Cuenta_Contable = CE.Cuenta_Contable and cc.Empresa_Id = ce.Empresa_Id)
 WHERE CE.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_ANEXOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_ANEXOS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VCONTA_ESTADOS_ANEXOS]
AS
SELECT 0 as Anexo_Id, ''(NO APLICA)'' as Concepto
UNION ALL
SELECT Anexo_Id, Concepto FROM TCONTA_ESTADOS_ANEXOS
WHERE Anexo_Id > 0 and EsActivo = 1
' 
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_CUENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_CUENTAS]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_ESTADOS_CUENTAS]
AS
SELECT distinct CA.Cuenta_Contable, CA.Codigo_Auxiliar, EC.Formula_Id, CA.Saldo_Actual, (CA.Debito_Mes - CA.Credito_Mes) as Saldo_Mes, F.Estado_Id, F.AnexoNo, CA.Descripcion,
       CA.Saldo_Mes_Anterior, IsNull(CA.Debito_Mes_Ant, 0) - IsNull(CA.Credito_Mes_Ant, 0) AS Mov_Mes_Ant, Saldo_Anio_Anterior, F.LineaNo, F.Tipo_Linea
FROM [TCONTA_ESTADOS_CUENTAS] ec
     LEFT OUTER Join TCONTA_CATALOGO_AUXILIAR CA ON CA.Cuenta_Contable Like ec.Cuenta_Contable + ''%''
	 Inner Join TCONTA_ESTADOS_FORMULAS F ON (F.Formula_Id = EC.Formula_Id and F.Fecha_Deleted Is Null)
WHERE ec.Fecha_Deleted Is Null AND CA.Cuenta_Contable Is Not Null



' 
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_GENERADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_GENERADOS]'))
EXEC dbo.sp_executesql @statement = N'



/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCONTA_ESTADOS_GENERADOS]
AS
SELECT [Unico]
      ,[Registro_Id]
      ,[Estado_Id]
      ,[Anio]
      ,[Mes]
      ,[Titulo]
      ,[Adicionado_Por]
      ,[Fecha_Adicionado]
      ,[Modificado_Por]
      ,[Fecha_Modificado]
      ,[EsNulo]
      ,[EsAnexo]
      ,[EsAcumulado]
	  ,[Fecha_Deleted]
	  ,dbo.FGet_Nombre_Mes(Mes) as Nombre_Mes
	  ,Fecha
	  ,Empresa_Id, Oficina_Id
	  ,Mes_Ant_Anio
	  ,Mes_Ant
	  ,dbo.FGet_Nombre_Mes(IsNull(Mes_Ant, 0)) as Nombre_Mes_Ant
  FROM [TCONTA_ESTADOS_GENERADOS]
WHERE Fecha_Deleted Is Null And EsNulo = 0




' 
GO
/****** Object:  View [dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]'))
EXEC dbo.sp_executesql @statement = N'


CREATE VIEW [dbo].[VCONTA_ESTADOS_GENERADOS_DETALLES]
AS
SELECT 
       DT.[Registro_Id]
      ,DT.[Descripcion]
      ,DT.[LineaNo]
      ,DT.[Tipo_Linea]
      ,DT.[EsVisible]
      ,DT.[EsNegrita]
      ,DT.[Tipo_Subrayado]
      ,DT.[Adicionado_Por]
      ,DT.[Fecha_Adicionado]
      ,DT.[Modificado_Por]
      ,DT.[Fecha_Modificado]
      ,DT.[Estado_Id]
      ,DT.[Fecha_Deleted]
      ,DT.[Formula]
      ,DT.[Valor]
      ,DT.[Anexo_Id]
      ,DT.[Linea]
	  ,G.Titulo
	  ,G.Anio
	  ,G.Mes
	  ,G.EsAcumulado, G.EsAnexo
	  ,UPPER( dbo.FGet_Nombre_Mes(G.Mes) ) as Nombre_Mes
	  ,Anexo, Cuenta_Contable, DT.Unico
	  ,IsNull(DT.Valor_Mes_Ant, 0) as Valor_Mes_Ant
	  ,IsNull(DT.Valor_Anio_Ant, 0) as Valor_Anio_Ant
	  ,IsNull(DT.Variacion, 0) as Variacion
	  ,IsNull(Mes_Ant, 0) as Mes_Ant, IsNull(Mes_Ant_Anio, 0) as Mes_Ant_Anio, UPPER( dbo.FGet_Nombre_Mes(G.Mes_Ant) ) as Nombre_Mes_Anterior
  FROM [TCONTA_ESTADOS_GENERADOS_DETALLES] DT
       Inner Join TCONTA_ESTADOS_GENERADOS G on G.Registro_Id = DT.Registro_Id
  WHERE DT.Fecha_Deleted Is Null and DT.EsVisible = 1



' 
GO
/****** Object:  View [dbo].[VCREDITOS_OTORGADOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCREDITOS_OTORGADOS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VCREDITOS_OTORGADOS]
AS
SELECT
       P.*, Fecha_Otorgado as Fecha
  FROM [TPRESTAMOS] P
  WHERE Estatus_Id <> ''R''

' 
GO
/****** Object:  View [dbo].[VCXP_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_DETALLES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCXP_DETALLES]
AS
SELECT 
       [Modulo]
      ,[Numero]
      ,[Proximo]
      ,[Empresa_Id]
      ,[Oficina_Id]
      ,[Fecha]
      ,[Suplidor_Id]
      ,[CedulaRNC]
      ,E.[Nombre]
      ,[Direccion]
      ,[Telefono]
      ,[Tipo_NCF]
      ,[Factura_Numero]
      ,[Factura_Fecha]
      ,[Factura_Dias_Credito]
      ,[Factura_Fecha_Vence]
      ,[NCF]
      ,[Tipo_Gastos_DGII]
      ,E.[Orden_Id]
      ,[Concepto]
      ,E.[Sub_Total]
      ,E.[Descuento]
      ,E.[Neto]
      ,E.[Itbis]
      ,[Otros_Tipo]
      ,[Otros]
      ,E.[Total]
      ,E.[Retencion_Itbis]
      ,E.[Retencion_Neto]
      ,E.[Monto_APagar]
      ,[Entidad_ReEmbolsar_Id]
      ,[Total_Debitado]
      ,[Total_ACreditado]
      ,[Monto_Pendiente]
      ,[Fecha_Ultimo_Abono]
      ,[Forma_Ultimo_Pago]
      ,[Referencia_Ultimo_Pago]
      ,[Estatus_Id]
      ,[Estatus]
      ,E.[Adicionado_Por]
      ,E.[Fecha_Adicionado]
      ,E.[Modificado_Por]
      ,E.[Fecha_Modificado]
      ,[Gastos_Fijo_Id]
      ,[Asiento_Id]
      ,[CXP_OrigenId]
      ,[Moneda]
      ,[Tasa_Cambio]
      ,[Fecha_Requerida]
      ,[Fecha_Anulado]
      ,[Empleado_Id]
      ,[Departamento_Id]
      ,[Cantidad_Pendiente]
      ,[Aprobado_Por]
      ,[Fecha_Aprobado]
      ,[Fecha_Rechazado]
      ,[URegistro_Id]
	  ,D.Categoria_Id, Producto_Id, D.Descripcion, Cantidad, Precio, D.Sub_Total AS DSub_Total, D.Descuento AS DDescuento, D.Neto AS DNeto
	  ,D.Tasa_Itbis, d.Itbis as DItbis, D.Total AS DTotal
	  ,D.Retencion_Itbis as DRetencion_Itbis, D.Retencion_Neto as DRetencion_Neto, D.Monto_APagar as DMonto_APagar
	  ,Case When D.Categoria_Id > 0 THEN C.Nombre else '''' End as Categoria
	  ,IsNull(D.Cantidad_Recibida, 0) as DCantidad_Recibida
  FROM [TCXP] E
       Inner Join TCXP_DETALLES D ON D.Identificador_Id = E.CXP_Id
	   Left Outer Join TCLASIFICADOR_PRODUCTOS_CATEGORIAS C ON C.Categoria_Id = D.Categoria_Id
  WHERE IsNull(E.EsNulo, 0) = 0 and IsNull(D.EsNulo, 0) = 0 and D.Fecha_Deleted Is Null

' 
GO
/****** Object:  View [dbo].[VCXP_PAGOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VCXP_PAGOS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VCXP_PAGOS]
AS
SELECT C.[Unico]
      ,C.[Pago_Id]
      ,C.[Empresa_Id]
      ,C.[Oficina_Id]
      ,C.[Fecha]
      ,C.[Entidad_Id]
      ,C.[Beneficiario]
      ,C.[Concepto]
      ,C.[Monto]
      ,C.[EsNulo]
      ,C.[Adicionado_Por]
      ,C.[Fecha_Adicionado]
      ,C.[Modificado_Por]
      ,C.[Fecha_Modificado]
      ,C.[Forma_Pago]
      ,C.[Documento_PagoNo]
      ,C.[Aplicado_Por]
      ,C.[Fecha_Aplicado]
      ,C.[Cuenta_Id]
      ,C.[Trans_Banco_Id]
      ,C.[Estatus_Id]
      ,C.[Estatus]
	  ,E.CedulaRNC
	  ,Cast(C.Pago_Id as Varchar) + IsNull(Beneficiario, '''') + IsNull(E.CedulaRNC, '''') as Campo_Busqueda
  FROM [TCXP_PAGOS] C
  LEFT OUTER JOIN TCLASIFICADOR_ENTIDADES E ON E.Entidad_Id = C.Entidad_Id' 
GO
/****** Object:  View [dbo].[VDEVOLUCIONES_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDEVOLUCIONES_DETALLES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VDEVOLUCIONES_DETALLES]
AS
SELECT 
     E.*,
     D.Producto_Id, IsNull(D.Descripcion, ''DESCUENTO'') as Descripcion, D.Cantidad, D.Precio, IsNull(D.Sub_Total, E.Sub_Total) as Sub_Total_D, D.Tasa_Itbis, IsNull(D.Itbis, 0) as Itbis, IsNull(D.Total, E.Total) as Total_D
     ,UM.Abreviatura Medida
  FROM [TVENTAS_DEVOLUCIONES] E
       LEFT OUTER JOIN TVENTAS_DEVOLUCIONES_DETALLES D ON (D.Identificador_Id = E.Identificador_Id)
       LEFT OUTER JOIN TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS UM ON (UM.UMedida_Id = D.UMedida_Id)
WHERE IsNull(IsNull(D.EsNulo, E.EsNulo), 0) = 0

' 
GO
/****** Object:  View [dbo].[VDOCUMENTOS_POR_COBRAR]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VDOCUMENTOS_POR_COBRAR]'))
EXEC dbo.sp_executesql @statement = N'



CREATE VIEW [dbo].[VDOCUMENTOS_POR_COBRAR]
AS
SELECT 
	  C.Unico, Prestamo_Id as Documento_Id, 
	  C.Empresa_Id, C.Oficina_Id,
	  C.Fecha_Otorgado as Fecha, C.Fecha_Termino AS Fecha_Vencimiento, C.Fecha_Ultimo_Abono,
	  C.Entidad_Id, E.CedulaRNC, C.ANombre, C.Tipo_Garantia, C.Garantia_Id, E.Tipo_NCF,
	  C.Monto AS Prestamo_Monto,
	  C.Tasa_Interes_Anual,
	  C.Tasa_Interes_Anual/12.0 as Tasa_Interes_Mensual,
	  C.Tasa_Demora_Mensual,
	  IsNull(C.Monto_Cuota, 0) Monto_Cuota,
	  IsNull(C.Capital_Pendiente, 0)   as Capital_Pendiente,
	  IsNull(C.Interes_Pendiente, 0)   as Interes_Pendiente,  
	  IsNull(C.Demora_Pendiente, 0)    as Demora_Pendiente, 
	  IsNull(C.Otros_Pendiente, 0)     as Otros_Pendiente,
	  IsNull(C.Balance, 0)   as Balance_Pendiente,
	  C.Estatus_Id, C.Estatus, 
	  C.Concepto,
	  ''VC'' as Tipo, ''VENTA A CREDITO'' AS Tipo_Documento, Factura_No as Referencia,
	  Proximo, C.Dias_Atrazo, Dias_Atrazo_SIB,
	  Capital_P0_30, Capital_P31_90, Capital_P91, Capital_Castigado,
	  Interes_P0_30, Interes_P31_90, Interes_P91_120, Interes_P121, Interes_Castigado,
	  Cast(C.Prestamo_Id as Varchar) +   Replace(C.CedulaRNC, ''-'', '''') + Replace( IsNull(C.ANombre, ''''), ''-'', '''') + REPLACE( IsNull(C.Garantia_Id, ''''), ''-'', '''') as Campo_Busqueda
	  ,IsNull(C.Factura_No, 0) as Factura_No
FROM TPRESTAMOS C
     Left Outer Join TCLASIFICADOR_ENTIDADES E on (E.Entidad_Id = C.Entidad_Id)
WHERE Balance > 0 
	  And Proximo = ''CXC''
	  And Estatus_Id <> ''R''
	  And Rechazado_Fecha Is Null




' 
GO
/****** Object:  View [dbo].[VEMPRESAS_NCF_X_OFICINAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_NCF_X_OFICINAS]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VEMPRESAS_NCF_X_OFICINAS]
AS
SELECT CO.[Unico]
      ,CO.[Empresa_Id]
      ,CO.[Oficina_Id]
      ,CO.[Tipo_NCF]
      ,CO.[Prefijo]
      ,CO.[NumeroNCF]
      ,CO.[Numero_Maximo]
      ,CO.[Punto_Reorden]
      ,CO.[Adicionado_Por]
      ,CO.[Fecha_Adicionado]
      ,CO.[Modificado_Por]
      ,CO.[Fecha_Modificado]
	  ,CO.Fecha_Deleted,
       T.Descripcion,
       IsNull(CO.Numero_Maximo, 0) - IsNull(NumeroNCF, 0) NCF_Disponible,
	   Valido_Hasta
FROM [TEMPRESAS_NCF_X_OFICINAS] CO
     INNER JOIN TSISTEMA_TIPOS_NCF T ON (T.Tipo_NCF = CO.Tipo_NCF)
WHERE T.Tipo_NCF > 0 and CO.Fecha_Deleted Is Null



' 
GO
/****** Object:  View [dbo].[VEMPRESAS_OFICINAS_TODAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_OFICINAS_TODAS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VEMPRESAS_OFICINAS_TODAS]
AS
SELECT 0 as Oficina_Id, ''(TODAS)'' as Nombre, 0 as Empresa_Id
UNION ALL
SELECT Oficina_Id, Nombre, Empresa_Id
FROM TEMPRESAS_OFICINAS
WHERE EsActivo = 1
' 
GO
/****** Object:  View [dbo].[VEMPRESAS_REPRESENTANTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VEMPRESAS_REPRESENTANTES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VEMPRESAS_REPRESENTANTES]
AS
SELECT R.[Unico]
      ,R.[Empresa_Id]
      ,R.[CedulaRNC]
      ,R.[Nombres]
      ,R.[Apellidos]
	  ,R.Nombres + R.Apellidos as Nombre_Completo
      ,R.[Sexo]
      ,R.[Direccion]
      ,R.[Telefono1]
      ,R.[Telefono2]
      ,R.[Estado_Civil]
      ,R.[Oficina_Id]
      ,R.[EsAbogado]
      ,R.[EsNotario]
      ,R.[EsAlguacil]
      ,R.[NoOficio]
      ,R.[EsGerente]
      ,R.[EsTestigo]
      ,R.[EsActivo]
      ,R.[Adicionado_Por]
      ,R.[Fecha_Adicionado]
      ,R.[Modificado_Por]
      ,R.[Fecha_Modificado]
      ,R.[Fecha_Deleted]
      ,R.[Titulo]
      ,R.[Municipio_Id]
	  ,IsNull(O.Nombre, ''TODAS'') as Oficina_Nombre
	  ,LTrim(Case 
	      when EsGerente = 1 then '' GERENTE'' ELSE ''''
	   End 
	   + Case 
	      when EsAbogado = 1 then '' ABOGADO'' ELSE ''''
	   End
	   + Case 
	      when EsNotario = 1 then '' NOTARIO'' ELSE ''''
	   End
	   + Case 
	      when EsAlguacil = 1 then '' ALGUACIL'' ELSE ''''
	   End
	   + Case 
	      when EsTestigo = 1 then '' TESTIGO'' ELSE ''''
	   End
	   + ''; OFICINA: '' + IsNull(O.Nombre, ''TODAS'') ) as Descripcion
  FROM [TEMPRESAS_REPRESENTANTES] R
       LEFT OUTER JOIN TEMPRESAS_OFICINAS O ON O.Oficina_Id = R.Oficina_Id
  WHERE R.Fecha_Deleted Is Null

' 
GO
/****** Object:  View [dbo].[VENTIDAD_CXC]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDAD_CXC]'))
EXEC dbo.sp_executesql @statement = N'



CREATE VIEW [dbo].[VENTIDAD_CXC]
AS
SELECT E.Entidad_Id, CedulaRNC, dbo.FCOMBINA_NOMBRES_APELLIDOS(Nombres, Apellidos, apodos) Nombre_Completo, 
       E.Telefono1, E.Telefono2, E.Direccion, E.Tipo_NCF,
	   P.Monto,
	   P.Capital_Pendiente,
	   P.Interes_Pendiente,
	   P.Demora_Pendiente,
	   P.Otros_Pendiente
FROM TCLASIFICADOR_ENTIDADES E
  Inner Join
   (
		SELECT Entidad_Id, 
			   Sum(IsNull(Capital_Pendiente, 0) + IsNull(Interes_Pendiente, 0) + IsNull(Demora_Pendiente, 0) + IsNull(Otros_Pendiente, 0)) as Monto,
			   Sum(IsNull(Capital_Pendiente, 0)) Capital_Pendiente,
			   Sum(IsNull(Interes_Pendiente, 0)) Interes_Pendiente,
			   Sum(IsNull(Demora_Pendiente, 0)) Demora_Pendiente,
			   Sum(IsNull(Otros_Pendiente, 0)) Otros_Pendiente
		FROM TPRESTAMOS
		WHERE ( IsNull(Capital_Pendiente, 0) + IsNull(Interes_Pendiente, 0) + IsNull(Demora_Pendiente, 0) + IsNull(Otros_Pendiente, 0) ) > 0
		      and Monto > 0 and Estatus_Id <> ''N''
		Group by Entidad_Id
   ) P ON P.Entidad_Id = E.Entidad_Id



' 
GO
/****** Object:  View [dbo].[VENTIDADES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDADES]'))
EXEC dbo.sp_executesql @statement = N'









/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VENTIDADES]
AS
SELECT E.[Unico]
      ,E.[Tipo_Entidad]
      ,E.[Entidad_Id]
      ,E.[Tipo_Documento]
      ,E.[CedulaRNC]
      ,E.[Nombres]
      ,E.[Apellidos]
      ,E.[Apodos]
      ,E.[Fecha_Nacimiento]
      ,E.[Sexo]
      ,E.[Pais_Id]
      ,E.[Provincia_Id]
      ,E.[Municipio_Id]
      ,E.[Sector_Id]
      ,E.[Zona_Id]
      ,E.[Oficial_Credito]
      ,E.[Supervisado_Por]
      ,E.[Calle_Numero]
      ,E.[Proximo_A]
      ,E.[Direccion]
      ,E.[Telefono1]
      ,E.[Telefono2]
      ,E.[TelWhatsaap]
      ,E.[EMail]
      ,E.[EsViviendaPropia]
      ,E.[Vivienda_Anio]
      ,E.[Vivienda_Mes]
      ,E.[Empresa_Nombre]
      ,E.[Empresa_Tipo]
      ,E.[Empresa_Telefono]
      ,E.[Empresa_Anio]
      ,E.[Empresa_Mes]
      ,E.[Empresa_Provincia]
      ,E.[Empresa_Municipio]
      ,E.[Empresa_Sector]
      ,E.[Empresa_Direccion]
      ,E.[Empresa_Salario]
      ,E.[Empresa_Supervisor]
      ,E.[Ocupacion]
      ,E.[Ingreso_Mensual]
      ,E.[Estado_Civil]
      ,E.[EsCasado]
      ,E.[Conyugue_Nombres]
      ,E.[Conyugue_Telefono]
      ,E.[Familiar_Nombres]
      ,E.[Familiar_Telefono]
      ,E.[Familiar_Parentesco]
      ,IsNull(E.[Tipo_NCF], 0) as Tipo_NCF
      ,E.[Nivel_Precio]
      ,E.[EsActivo]
      ,E.[EsGarante]
      ,E.[EsSuplidor]
      ,E.[EsRetencion]
      ,E.[EsReembolso]
      ,E.[EsDGII]
      ,E.[EsCreditoDisponible]
      ,E.[Adicionado_Por]
      ,E.[Fecha_Adicionado]
      ,E.[Modificado_Por]
      ,IsNull(E.[Fecha_Modificado], E.Fecha_Adicionado) as Fecha_Modificado
      ,E.[Prestamo_Documento_Id]
      ,E.[Fecha_Ultima_Compra]
      ,E.[Fecha_Ultima_Venta]
      ,E.[Fecha_Ultimo_Abono]
      ,E.[Dias_Credito]
      ,E.[Codigo_Cliente_Ant]
      ,E.[Balance_CXC]
      ,E.[Balance_CXP]
      ,E.[Capital_Pendiente]
      ,E.[Interes_Pendiente]
      ,E.[Demora_Pendiente]
      ,E.[Otros_Pendiente]
      ,E.[Latitude]
      ,E.[Longitude]
      ,E.[Cantidad_Cuota_Vencida]
      ,E.[Dias_Atrazo], dbo.FCOMBINA_NOMBRES_APELLIDOS(Nombres, Apellidos, Apodos) as Nombre_Completo
      ,''TIPO NCF: '' + CF.Descripcion as NombreNCF
      ,IsNull(P.Nombre, '''') as Pais_Nombre
      ,ISNULL(P.Nacionalidad, P.Nombre) as Pais_Nacionalidad
      ,IsNull( ( SELECT top 1 Descripcion FROM TSISTEMA_TABLA_AUXILIAR WHERE Id = E.Estado_Civil and Nombre_Tabla = ''ESTADO_CIVIL'' ), '''') Estado_Civil_Descripcion
      ,IsNull(( SELECT top 1 Descripcion FROM TSISTEMA_TABLA_AUXILIAR WHERE Id = E.Sexo and Nombre_Tabla = ''SEXO'' ), '''') Sexo_Descripcion
      ,Replace(IsNull(CedulaRNC, ''''), ''-'', '''') + dbo.FCOMBINA_NOMBRES_APELLIDOS(Nombres, Apellidos, Apodos) as Campo_Busqueda
      ,Case When Fecha_Nacimiento IS Null Then 0 Else  Day(Fecha_Nacimiento) End as NacimientoDia
      ,Case When Fecha_Nacimiento IS Null Then 0 Else MONTH(Fecha_Nacimiento) End as NacimientoMes
      ,Case When Fecha_Nacimiento IS Null Then 0 Else YEAR(Fecha_Nacimiento) end as NacimientoAnio
	  ,E.CedulaRNC + ''   '' + dbo.FCOMBINA_NOMBRES_APELLIDOS(Nombres, Apellidos, Apodos) as Entidad
	  ,[Referencia_Nombre]
      ,[Referencia_Telefono]
      ,[Referencia_Parentesco]
	  ,E.Familiar_Direccion
  FROM TCLASIFICADOR_ENTIDADES E 
       Left Outer Join TSISTEMA_TIPOS_NCF CF on (CF.Tipo_NCF = E.Tipo_NCF)
       left outer join TZONAS_PAISES P on (P.Pais_Id = E.Pais_Id)










' 
GO
/****** Object:  View [dbo].[VENTIDADES_DEMORAS_PENDIENTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VENTIDADES_DEMORAS_PENDIENTES]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VENTIDADES_DEMORAS_PENDIENTES]
AS
SELECT E.Entidad_Id, E.CedulaRNC,
       DBO.FCOMBINA_NOMBRES_APELLIDOS(E.NOmbres, E.Apellidos, E.Apodos) as ANombre,
	   D.Interes, D.Demora, D.Otros,
	   REPLACE(E.CedulaRNC, ''-'', '''') + DBO.FCOMBINA_NOMBRES_APELLIDOS(E.NOmbres, E.Apellidos, E.Apodos) as Campo_Busqueda
FROM TCLASIFICADOR_ENTIDADES E
     INNER JOIN
	 (
		SELECT Entidad_Id, 
			   Sum(Interes_Pendiente) as Interes, 
			   Sum(Demora_Pendiente) as Demora,
			   Sum(Otros_Pendiente) as Otros 
		FROM TPRESTAMOS
		WHERE Interes_Pendiente + Demora_Pendiente + Otros_Pendiente > 0
		Group by Entidad_Id
	 ) D ON D.Entidad_Id = E.Entidad_Id
' 
GO
/****** Object:  View [dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]'))
EXEC dbo.sp_executesql @statement = N'Create View [dbo].[VF_TOTAL_CARTERA_BALANCE_CIERRE]
AS
SELECT 0 as Nivel_Id, 0 as Monto, '''' as Nivel
' 
GO
/****** Object:  View [dbo].[VMODULOS_REPORTES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMODULOS_REPORTES]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VMODULOS_REPORTES]
AS
SELECT        SM.Carpeta, RP.*
FROM            dbo.TSISTEMA_MODULOS AS SM INNER JOIN
                         dbo.TSISTEMA_MODULOS_REPORTES AS RP ON SM.Modulo_Id = RP.Modulo_Id
' 
GO
/****** Object:  View [dbo].[VMUNICIPIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VMUNICIPIOS]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VMUNICIPIOS]
AS
SELECT
       M.*,
	   PV.Nombre as Provincia,
	   P.Nombre  as Pais,
	   P.Pais_Id,
	   P.Nacionalidad,
	   P.Nacionalidad_M
FROM [TZONAS_MUNICIPIOS] M
     INNER JOIN TZONAS_PROVINCIAS PV ON (M.Provincia_Id = PV.Provincia_Id)
	 Inner Join TZONAS_PAISES P on (P.Pais_Id = PV.Pais_Id)

' 
GO
/****** Object:  View [dbo].[VNOMINAS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VNOMINAS_DETALLE]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VNOMINAS_DETALLE]
AS
SELECT D.[Unico]
      ,D.[Nomina_Id]
      ,D.[Fecha]
      ,D.[Empresa_Id]
      ,D.[Oficina_Id]
      ,D.[Mes]
      ,D.[Quincena]
      ,D.[Empleado_Id]
      ,D.[CedulaRNC]
      ,D.[Nombre]
      ,D.[Departamento_Id]
      ,D.[Cargo_Id]
      ,D.[EsAdministrativo]
      ,D.[Supervisor_Id]
      ,D.[Salario]
      ,D.[Salario_Quincena]
      ,D.[Monto_Bruto]
      ,D.[D_AFP]
      ,D.[D_ARS]
      ,D.[D_ARL]
      ,D.[D_ISR]
      ,D.[D_Seguro_Dep]
      ,D.[D_Prestamo]
      ,D.[D_Otros]
      ,D.[Monto_APagar]
      ,D.[Provision_Regalia]
      ,D.[E_AFP]
      ,D.[E_ARS]
      ,D.[E_ARL]
      ,D.[E_INFOTEP]
      ,D.[Comentario]
      ,Case when IsNull(E.Forma_Pago, '''') = '''' then D.Forma_Pago else E.Forma_Pago End  as Forma_Pago
      ,Case WHEN IsNull(E.Cuenta_Banco_No, '''') = '''' then  D.[Cuenta_Banco_Destino] else E.Cuenta_Banco_No End as Cuenta_Banco_Destino
      ,D.[Aprobado_Por]
      ,D.[Fecha_Aprobado]
      ,D.[Adicionado_Por]
      ,D.[Fecha_Adicionado]
      ,D.[Modificado_Por]
      ,D.[Fecha_Modificado]
      ,D.[Provicion_Regalia]
      ,D.[Total_Descuento]
      ,D.[Fecha_Deleted]
      ,D.[Estatus_Id]
	  ,IsNull(O.Nombre, ''NO OFICINA'') AS Nombre_Oficina
	  ,IsNull(DP.Nombre, ''NO DEPARTAMENTO'') as Departamento
	  ,IsNull(C.Nombre, ''NO CARGO'') as Cargo
	  ,IsNull(D.Acumulado, 0) as Acumulado
	  ,IsNull(D.Pendiente, 0) as Pendiente
	  ,IsNull(QuincenasRest, 0) as QuincenasRest
  FROM [TNOMINAS_DETALLE] as D
  INNER JOIN TRRHH_EMPLEADOS E ON E.Empleado_Id = D.Empleado_Id
  LEFT OUTER JOIN TEMPRESAS_OFICINAS O ON O.Oficina_Id = D.Oficina_Id
  LEFT OUTER JOIN TRRHH_DEPARTAMENTOS DP ON DP.Departamento_Id = D.Departamento_Id
  LEFT OUTER JOIN TRRHH_CARGOS C ON C.Cargo_Id = D.Cargo_Id
  WHERE D.Fecha_Deleted Is Null 


' 
GO
/****** Object:  View [dbo].[VOPCIONES_X_MODULOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VOPCIONES_X_MODULOS]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VOPCIONES_X_MODULOS]
AS
SELECT MN.*, SM.Carpeta as Modulo
  FROM [TACCESOS_OPCIONES_MENU] MN
       LEFT OUTER JOIN TSISTEMA_MODULOS SM ON SM.Modulo_Id = MN.Modulo_Id



' 
GO
/****** Object:  View [dbo].[VOPCIONES_X_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VOPCIONES_X_USUARIOS]'))
EXEC dbo.sp_executesql @statement = N'



CREATE VIEW [dbo].[VOPCIONES_X_USUARIOS]
AS
SELECT DISTINCT RO.Rol_Id, RO.Menu_Id, 
       RO.EsActivo, RO.EsConsulta, RO.EsInsertar, RO.EsAnular, RO.EsModificar,
       RO.EsCambiar_Fecha, RO.EsAprobar, RO.EsRechazar, RO.EsGenerar,
       MN.Nombre, MN.Codigo, MN.EsModal, MN.FormaImprimir, MN.Formulario_AEjecutar, MN.Titulo, MN.TipoFormulario, MN.Proximo,
       MN.Menu_Madre_Id, SM.Carpeta as Menu_Principal, MN.EsMenuConsulta,
       UR.Nombre_Usuario,
       MN.Modulo_Id, SM.Carpeta,
       MN.Image, IsNull(MN.OrdenNo, 0) as OrdenNo,
	   IsNull(MN.URL, '''') as URL,
	   IsNull(MN.EsWeb, 0) as EsWeb
FROM [TACCESOS_OPCIONES_X_ROLES] RO
     INNER JOIN TACCESOS_OPCIONES_MENU MN ON (MN.Menu_Id = RO.Menu_Id) 
     LEFT OUTER JOIN TSISTEMA_MODULOS SM ON (SM.Modulo_Id = MN.Modulo_Id) 
     INNER JOIN TACCESOS_USUARIOS_X_ROLES UR ON (UR.Rol_Id = RO.Rol_Id AND UR.EsActivo = 1)
WHERE (RO.EsActivo = 1 or EsConsulta = 1) 
       AND MN.EsActivo = 1




' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_AMORTIZACION]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_AMORTIZACION]'))
EXEC dbo.sp_executesql @statement = N'


CREATE VIEW [dbo].[VPRESTAMOS_AMORTIZACION]
AS
SELECT     D.Cuota_No, D.Fecha, D.Saldo_Inicial, D.Capital, D.Interes, D.Saldo_Final, PO.Prestamo_Id, PO.Fecha_Otorgado, PO.Empresa_Id, PO.Solicitud_Id, PO.Factura_No, PO.Entidad_Id, PO.CedulaRNC, 
                      PO.ANombre, PO.Monto, PO.Plazo, PO.Forma_Pago_Capital, PO.Forma_Pago_Interes, PO.Tasa_Interes_Anual, PO.Tipo_Saldo, PO.Monto_Cuota, PO.Tasa_Demora_Mensual, 
                      PO.Fecha_Primera_Cuota, PO.Fecha_Termino, PO.Evaluador_Id, PO.Evaluador_Nombre, PO.Supervisor_Id, PO.Supervisor_Nombre, PO.Oficial_Id, PO.Oficial_Nombre,
					  D.Identificador_Id, D.Tipo
FROM         dbo.TPRESTAMOS_AMORTIZACION_DETALLE AS D
             Left Outer JOIN dbo.TPRESTAMOS AS PO ON D.Prestamo_Id = PO.Prestamo_Id
WHERE     (D.EsNulo = 0) AND (D.FechaDeleted IS NULL) 



' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_DEMORA_GENERADAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DEMORA_GENERADAS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VPRESTAMOS_DEMORA_GENERADAS]
AS
SELECT  DM.*,      
        ISNULL(DM.Tipo_Garantia, ''N/A'') + '' - '' + ISNULL(TG.Descripcion, ''SIN GARANTIA'') AS Descripcion_Garantia
FROM            dbo.TPRESTAMOS_DEVENGO_DEMORA AS DM LEFT OUTER JOIN
                         dbo.TPRESTAMOS_TIPO_GARANTIAS AS TG ON DM.Tipo_Garantia = TG.Tipo_Garantia_Id
WHERE        (DM.Demora > 0) AND (ISNULL(DM.EsNulo, 0) = 0)

' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_DETALLE]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_DETALLE]
AS
SELECT D.[Unico]
      ,D.[Prestamo_Id]
      ,D.[Tipo]
      ,D.[No]
      ,D.[Fecha]
      ,D.[Concepto]
      ,D.[Capital]
      ,D.[Interes]
      ,D.[Demora]
      ,D.[Otros]
      ,D.[Capital_Pendiente]
      ,D.[Interes_Pendiente]
      ,D.[Demora_Pendiente]
      ,D.[Otros_Pendiente]
      ,D.[Nivel_Capital]
      ,D.[Nivel_Interes]
      ,D.[EsNulo]
      ,D.[Fecha_Devengado]
      ,D.[Fecha_Ultimo_Abono]
      ,D.[Fecha_Demora_Generada]
      ,D.[Adicionado_Por]
      ,D.[Fecha_Adicionado]
      ,D.[Modificado_Por]
      ,D.[Fecha_Modificado]
      ,D.[Fecha_Anterior]
      ,D.[Estatus]
      ,D.[Dias_Atrazo]
      ,D.[Dias_Atrazo_SIB]
	  ,P.Entidad_Id
  FROM [TPRESTAMOS_DETALLE] D
       INNER JOIN TPRESTAMOS P ON P.Prestamo_Id = D.Prestamo_Id
' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUD_DEUDORES]
AS
SELECT 
   SD.Unico  as DUnico,
   SD.Solicitud_Id,
   SD.Concepto,
   SD.EsNulo,
   SD.Fecha_Deleted,
   SD.EsPrincipal,
   E.Entidad_Id, E.CedulaRNC, E.Nombres, E.Apellidos, E.Direccion, E.Telefono1, E.Telefono2, E.TelWhatsaap, E.EMail,
   dbo.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.Apodos) as Nombre_Completo,
   SD.Prestamo_Id
FROM [TPRESTAMOS_SOLICITUD_DEUDORES] SD
     INNER JOIN TCLASIFICADOR_ENTIDADES E ON (E.Entidad_Id = SD.Entidad_Id)
WHERE SD.Fecha_Deleted Is Null



' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]'))
EXEC dbo.sp_executesql @statement = N'

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUD_GARANTIAS]
AS
SELECT SG.*,
       TG.Descripcion as Tipo_Garantia
  FROM [TPRESTAMOS_SOLICITUD_GARANTIAS] SG
  LEFT OUTER JOIN TPRESTAMOS_TIPO_GARANTIAS TG ON TG.Tipo_Garantia_Id = SG.Tipo_Garantia_Id
WHERE sg.Fecha_Deleted Is Null 
      and ISNULL(EsNulo, 0) = 0


' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES]'))
EXEC dbo.sp_executesql @statement = N'





/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUDES]
AS
SELECT S.[Unico], S.[Solicitud_Id], S.[Empresa_Id], S.[Oficina_Id], [Fecha], [Tipo_Garantia]
       ,[Monto_Solicitado], [Plazo], S.[Forma_Pago], [Motivo_Id]
       ,[Fecha_Caduca], [Estatus_Id], S.[Estatus]
	   ,S.[Adicionado_Por], S.[Fecha_Adicionado], S.[Modificado_Por], S.[Fecha_Modificado]
       ,[EsEvaluado], [Fecha_Aprobado], [Monto_Aprobado], [Tasa_Aprobada]
       ,[Aprobado_Por], [Rechazada_Fecha], [Rechazada_Por], [Rechazada_Comentario]
       ,[EsAmortizacionCreada], [Fecha_Desembolso], [Prestamo_Id], s.[Entidad_Id]
       ,E.[CedulaRNC], S.[Motivo], s.[Zona_Id]
       ,[Supervisor_Id], [Supervisor_Nombre], [Oficial_Credito_Id]
       ,[Garantia_Id], [Dia_APagar], [Producto],
       Case
          When (S.Tipo_Garantia = ''P'')  then ''SOLICITUD PRESTAMO PERSONAL''
          When (S.Tipo_Garantia = ''H'') then ''SOLICITUD PRESTAMO HIPOTECARIO''
          When (S.Tipo_Garantia = ''V'') then ''SOLICITUD PRESTAMO DE VEHICULO''
          When (S.Tipo_Garantia = ''HV'') then ''SOLICITUD PRESTAMO HIPOTECARIO PARA VIVIENDA''
          When (S.Tipo_Garantia = ''E'') then ''SOLICITUD PRESTAMO DE EMPLEADO'' 
          When (S.Tipo_Garantia = ''C'') then ''SOLICITUD PRESTAMO DE CERTIFICADO''
          else ''SOLICTUD DE PRESTAMO PERSONAL''
       End AS Tipo_Solicitud,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Nombre_Completo,
       Cast(Solicitud_Id as Varchar) + REPLACE( IsNull(E.CedulaRNC, ''''), ''-'', '''') + dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Campo_Busqueda
       ,Case 
			 When S.Forma_Pago = ''Q'' then ''QUINCENALES''
			 When S.Forma_Pago = ''S'' then ''SEMANALES''
			 When S.Forma_Pago = ''I'' then ''INTERDIARIO''
			 When S.Forma_Pago = ''D'' then ''DIARIO''
			 When S.Forma_Pago = ''T'' then ''A TERMINO''
			 ELSE ''MENSUALES''
	    End as Forma_Pago_Descipcion,
		S.Garante_Id, dbo.FCOMBINA_NOMBRES_APELLIDOS(G.NOMBRES, G.APELLIDOS, G.APODOS) as Garante_Nombre,
		dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as ANombre,
		E.Nombres, E.Apellidos,
		S.Moneda_Id,
	    dbo.FCOMBINA_NOMBRES_APELLIDOS(em.Nombres, em.Apellidos, '''') as Oficial_Nombre,
		S.Tasa_Interes,
		S.[Tasa_Interes_Minima]
      ,S.[Tasa_Demora]
      ,S.[Costo_Legalizacion]
      ,S.[EsDescontarLegal]
      ,S.[Dias_Gracias_Demora]
	  ,S.Comentario
FROM [TPRESTAMOS_SOLICITUD] S
     Inner join TCLASIFICADOR_ENTIDADES E on E.Entidad_Id = S.Entidad_Id
	 Left Outer Join TCLASIFICADOR_ENTIDADES G on (G.Entidad_Id = S.Garante_Id and S.Tipo_Garantia = ''P'')
	 Left Outer Join TRRHH_EMPLEADOS EM on EM.Empleado_Id = S.Oficial_Credito_Id






' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]'))
EXEC dbo.sp_executesql @statement = N'



/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUDES_NO_DESEMBOLSADAS]
AS
SELECT A.Unico, A.Empresa_Id, A.Oficina_Id, 
       S.Solicitud_Id, S.Monto_Solicitado, S.Fecha, S.Motivo,
       E.Entidad_Id, E.CedulaRNC, A.Monto_Aprobado, A.Plazo, A.Frecuencia_Pago, A.Tipo_Saldo,
	   A.Tasa_Interes, A.Tasa_Interes/12.0 as Tasa_Interes_Mensual, A.Tasa_Demora, A.Costo_Legalizacion, A.Descontar_Legalizacion, A.Monto_Prestamo, 
	   A.Fecha_Primer_Pago, A.Monto_Cuota, A.Evaluador_Id, A.Evaluador_Nombre, A.Fecha_Termino,
	   A.Formula, A.Total_Interes, A.Dia_APagar, A.Prestamo_Id,
       Case
          When (S.Tipo_Garantia = ''P'')  then ''SOLICITUD PRESTAMO PERSONAL''
          When (S.Tipo_Garantia = ''H'') then ''SOLICITUD PRESTAMO HIPOTECARIO''
          When (S.Tipo_Garantia = ''V'') then ''SOLICITUD PRESTAMO DE VEHICULO''
          When (S.Tipo_Garantia = ''HV'') then ''SOLICITUD PRESTAMO HIPOTECARIO PARA VIVIENDA''
          When (S.Tipo_Garantia = ''E'') then ''SOLICITUD PRESTAMO DE EMPLEADO'' 
          When (S.Tipo_Garantia = ''C'') then ''SOLICITUD PRESTAMO DE CERTIFICADO''
          else ''SOLICTUD DE PRESTAMO PERSONAL''
       End AS Tipo_Solicitud,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Nombre
       ,Case 
			 When A.Frecuencia_Pago = ''Q'' then ''QUINCENALES''
			 When A.Frecuencia_Pago = ''S'' then ''SEMANALES''
			 When A.Frecuencia_Pago = ''I'' then ''INTERDIARIO''
			 When A.Frecuencia_Pago = ''D'' then ''DIARIO''
			 When A.Frecuencia_Pago = ''T'' then ''A TERMINO''
			 ELSE ''MENSUALES''
	    End as Forma_Pago_Descipcion,
		O.Nombre as Oficina_Nombre,
		dbo.FCOMBINA_NOMBRES_APELLIDOS(OC.NOMBRES, OC.APELLIDOS, OC.APODO) as OficialCredito,
      S.Fecha as Fecha_Solicitud,
      Cast(A.Solicitud_Id as Varchar) + A.Nombre_Entidad + A.CedulaRNC as Campo_Busqueda,
	  Case WHEN A.Tipo_Saldo = ''S'' then ''SALDO SOLUTO'' else ''SALDO INSOLUTO'' End + '' SOBRE INTERES '' + Case When Formula = ''D'' then ''SIMPLE'' else ''AMORTIZADO'' End as Descripcion_Formula
FROM [TPRESTAMOS_AMORTIZACION] A
     LEFT OUTER JOIN TPRESTAMOS_SOLICITUD S ON (S.Solicitud_Id = A.Solicitud_Id)
	 Inner Join TCLASIFICADOR_ENTIDADES E on E.Entidad_Id = S.Entidad_Id
	 Left Outer Join TEMPRESAS_OFICINAS O on O.Oficina_Id = A.Oficina_Id
	 Left Outer Join TRRHH_EMPLEADOS OC on OC.Empleado_Id = A.Evaluador_Id
WHERE IsNull(A.Prestamo_Id, 0) = 0
      and A.Tipo = ''SC'' And A.Solicitud_Id > 0
	  and A.Fecha_Aprobado Is Not Null
	  and S.Fecha_Aprobado Is Not Null




' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]'))
EXEC dbo.sp_executesql @statement = N'







/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPRESTAMOS_SOLICITUDES_PENDIENTES_AUTORIZACION]
AS
SELECT A.Unico, A.Empresa_Id, A.Oficina_Id, 
       S.Solicitud_Id, S.Monto_Solicitado, S.Fecha, S.Motivo,
       E.Entidad_Id, E.CedulaRNC, A.Monto_Aprobado, A.Plazo, A.Frecuencia_Pago, A.Tipo_Saldo,
	   A.Tasa_Interes, A.Tasa_Interes/12.0 as Tasa_Interes_Mensual, A.Tasa_Demora, A.Costo_Legalizacion, A.Descontar_Legalizacion, A.Monto_Prestamo, 
	   A.Fecha_Primer_Pago, A.Monto_Cuota, A.Evaluador_Id, A.Evaluador_Nombre, A.Fecha_Termino,
	   A.Formula, A.Total_Interes, A.Dia_APagar,
       Case
          When (S.Tipo_Garantia = ''P'')  then ''SOLICITUD PRESTAMO PERSONAL''
          When (S.Tipo_Garantia = ''H'') then ''SOLICITUD PRESTAMO HIPOTECARIO''
          When (S.Tipo_Garantia = ''V'') then ''SOLICITUD PRESTAMO DE VEHICULO''
          When (S.Tipo_Garantia = ''HV'') then ''SOLICITUD PRESTAMO HIPOTECARIO PARA VIVIENDA''
          When (S.Tipo_Garantia = ''E'') then ''SOLICITUD PRESTAMO DE EMPLEADO'' 
          When (S.Tipo_Garantia = ''C'') then ''SOLICITUD PRESTAMO DE CERTIFICADO''
          else ''SOLICTUD DE PRESTAMO PERSONAL''
       End AS Tipo_Solicitud,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Nombre,
       Cast(S.Solicitud_Id as Varchar) + REPLACE( IsNull(S.CedulaRNC, ''''), ''-'', '''') + dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, E.APODOS) as Campo_Busqueda
       ,Case 
			 When A.Frecuencia_Pago = ''Q'' then ''QUINCENALES''
			 When A.Frecuencia_Pago = ''S'' then ''SEMANALES''
			 When A.Frecuencia_Pago = ''I'' then ''INTERDIARIO''
			 When A.Frecuencia_Pago = ''D'' then ''DIARIO''
			 When A.Frecuencia_Pago = ''T'' then ''A TERMINO''
			 ELSE ''MENSUALES''
	    End as Forma_Pago_Descipcion,
		O.Nombre as Oficina_Nombre,
		dbo.FCOMBINA_NOMBRES_APELLIDOS(OC.NOMBRES, OC.APELLIDOS, OC.APODO) as OficialCredito,
		S.Estatus, S.Estatus_Id
FROM [TPRESTAMOS_SOLICITUD] S
     Inner Join TPRESTAMOS_AMORTIZACION A on (A.Solicitud_Id = S.Solicitud_Id and A.Tipo = ''SC'')
	 Inner Join TCLASIFICADOR_ENTIDADES E on E.Entidad_Id = S.Entidad_Id
	 Left Outer Join TEMPRESAS_OFICINAS O on O.Oficina_Id = A.Oficina_Id
	 Left Outer Join TRRHH_EMPLEADOS OC on OC.Empleado_Id = A.Evaluador_Id
WHERE 
      ISNULL(S.Prestamo_Id, 0) = 0
	  And S.Rechazada_Fecha Is Null
      And ISNULL(S.Fecha_Caduca, GetDate() ) >= CAST( GETDATE() as DATE)




' 
GO
/****** Object:  View [dbo].[VPRESTAMOS_TASA_INTERES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRESTAMOS_TASA_INTERES]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VPRESTAMOS_TASA_INTERES]
AS
SELECT     TG.Descripcion, TS.Unico, TS.Tipo_Garantia_Id, TS.Monto_Desde, TS.Monto_Hasta, TS.Tasa_Interes_Anual, TS.Tasa_Interes_Anual_Minima, TS.Tasa_Demora_Mensual, TS.Frecuencia_Pago, 
                      TS.Plazo, TS.EsActivo, TS.Adicionado_Por, TS.Fecha_Adicionado, TS.Modificado_Por, TS.Fecha_Modificado, TS.FechaDeleted
FROM         dbo.TPRESTAMOS_TIPO_GARANTIAS AS TG INNER JOIN
                      dbo.TPRESTAMOS_TASA_INTERES AS TS ON TG.Tipo_Garantia_Id = TS.Tipo_Garantia_Id
WHERE     (TS.FechaDeleted IS NULL) AND (TG.EsActivo = 1)
' 
GO
/****** Object:  View [dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VPRODUCTOS_FINANCIEROS_TARIFAS]
AS
SELECT  TR.[Unico]
      ,TR.[Codigo]
      ,TR.[Desde]
      ,TR.[Hasta]
      ,TR.[Tasa_Interes_Anual]
      ,TR.[Tasa_Interes_Anual_Min]
      ,TR.[Porcentaje_Legal]
      ,TR.[Monto_Legal]
      ,TR.[Adicionado_Por]
      ,TR.[Fecha_Adicionado]
      ,TR.[Modificado_Por]
      ,TR.[Fecha_Modificado]
      ,TR.[Fecha_Deleted]
      ,TR.[Tipo_Garantia]
	  ,T.Nombre + Case  When (tg.Unico Is Null) OR tr.Tipo_Garantia = ''NA'' then '' (SIN GARANTIA)'' 
						ELSE '' CON GARANTIA: '' + tg.Descripcion 
				  End as Descripcion
	  ,Case 
	      when Porcentaje_Legal > 0 then FORMAT(Porcentaje_Legal, ''N'', ''en-us'') + '' %''
		  else  FORMAT(Monto_Legal, ''N'', ''en-us'') 
	   End as Descripcion_Legal
				
  FROM [TPRODUCTOS_FINANCIEROS_TARIFAS] tr
       Inner Join TPRODUCTOS_FINANCIEROS T on T.Codigo = tr.Codigo
	   Left Outer Join TPRESTAMOS_TIPO_GARANTIAS tg ON tg.Tipo_Garantia_Id = tr.Tipo_Garantia
  WHERE TR.Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VPROVINCIAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VPROVINCIAS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VPROVINCIAS]
AS
SELECT PV.*,
       P.Nombre AS Pais
FROM [TZONAS_PROVINCIAS] PV
     INNER JOIN TZONAS_PAISES P ON P.Pais_Id = PV.Pais_Id
' 
GO
/****** Object:  View [dbo].[VREPORTES_X_USUARIOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VREPORTES_X_USUARIOS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VREPORTES_X_USUARIOS]
AS
SELECT DISTINCT RO.Reporte_Id, 
       RO.EsActivo, MR.Nombre, SM.Carpeta, SM.Modulo_Id,
       UR.Nombre_Usuario
FROM [TACCESOS_REPORTES_X_ROLES] RO
     INNER JOIN TSISTEMA_MODULOS_REPORTES MR ON (MR.Reporte_Id = RO.Reporte_Id) 
     INNER JOIN TSISTEMA_MODULOS SM ON (SM.Modulo_Id = MR.Modulo_Id) 
     INNER JOIN TACCESOS_USUARIOS_X_ROLES UR ON (UR.Rol_Id = RO.Rol_Id AND UR.EsActivo = 1)
WHERE (RO.EsActivo = 1) 
       AND SM.EsActivo = 1
' 
GO
/****** Object:  View [dbo].[VSISTEMA_COLUMNAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_COLUMNAS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VSISTEMA_COLUMNAS]
AS
SELECT SO.NAME Tabla, SC.NAME Columna
FROM sys.objects SO INNER JOIN sys.columns SC ON SO.OBJECT_ID = SC.OBJECT_ID
WHERE SO.TYPE = ''U''
' 
GO
/****** Object:  View [dbo].[VSISTEMA_DIAS_NO_LABORABLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_DIAS_NO_LABORABLES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSISTEMA_DIAS_NO_LABORABLES]
AS
SELECT [Unico]
      ,[Anio]
      ,[Mes]
      ,[Dia]
      ,[Descripcion]
      ,[Adicionado_Por]
      ,[Fecha_Adicionado]
      ,[Modificado_Por]
      ,[Fecha_Modificado]
      ,[Fecha_Deleted]
	  ,[EsActivo]
	  ,Cast(Dia as Varchar) + '' '' + dbo.FGet_Nombre_Mes(Mes) + '' '' + Case when anio > 0 then Cast(anio as Varchar) else '''' End as Titulo
	  ,Cast( Cast(Case when Anio > 0 then anio else Year(GetDate()) End * 10000 + (Mes * 100) + dia as Varchar) as Date) as Fecha
  FROM [TSISTEMA_DIAS_NO_LABORABLES]
WHERE Fecha_Deleted Is Null
' 
GO
/****** Object:  View [dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]'))
EXEC dbo.sp_executesql @statement = N'


/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSISTEMA_DOCUMENTOS_CONTRACTOS]
AS 
SELECT SDC.[Unico]
      ,SDC.[Codigo]
      ,SDC.[Producto_Id]
      ,SDC.[Fecha]
      ,SDC.[Autorizado_Por]
      ,SDC.[EsNulo]
      ,SDC.[Impreso_Por]
      ,SDC.[Fecha_Impresion]
      ,SDC.[Numero]
      ,SDC.[CedulaRNC]
      ,SDC.[Nombre]
      ,SDC.[Adicionado_Por]
      ,SDC.[Fecha_Adicionado]
      ,SDC.[Modificado_Por]
      ,SDC.[Fecha_Modificado]
      ,SDC.[EsLegal]
      ,IsNull(SDC.[Solicitud_Id], 0) as Solicitud_Id
	  ,IsNull(SDC.Prestamo_Id, 0) as Prestamo_Id
      ,SDC.[Oficina_Id]
	  ,IsNull(SDC.Monto, 0) as Monto
	  ,IsNull(SDC.Itbis, 0) as Itbis
	  ,IsNull(SDC.Ret_Itbis, 0) as Ret_Itbis
	  ,IsNull(SDC.Ret_ISR, 0) as Ret_ISR
	  ,IsNull(SDC.MonedaSimbolo, '''') as Moneda
	  , Case when ISNULL(SDC.Descripcion, '''') = '''' then  DT.Descripcion else SDC.Descripcion End AS Descripcion
	  ,DT.DocTemplate
	  ,DT.ConAbogado
	  ,DT.ConNotario
	  ,DT.ConAlguacil
	  ,DT.ConTestigo
      ,DT.ConGerente
	  ,DT.EsReimprimir
  FROM [TSISTEMA_DOCUMENTOS_CONTRACTOS] SDC
       INNER JOIN TCONFIGURACION_DOC_TEMPLATES DT ON (DT.Unico = SDC.ValorUnicoTemplate )
  WHERE SDC.EsNulo = 0 AND (EsReimprimir = 1 Or Impreso_Por IS NULL)



' 
GO
/****** Object:  View [dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VSISTEMA_NOTIFICACIONES_TIPOS]
AS
SELECT ''0'' as Codigo, ''(TODO)'' as Concepto
UNION ALL
SELECT Codigo, Concepto FROM TSISTEMA_NOTIFICACIONES_TIPOS
' 
GO
/****** Object:  View [dbo].[VSISTEMA_PROCESOS_CONTROL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_PROCESOS_CONTROL]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSISTEMA_PROCESOS_CONTROL]
AS
SELECT  [Unico]
      ,[Fecha]
      ,[Estatus_Id]
      ,[Estatus]
      ,[Adiccionado_Por]
      ,[Fecha_Adicionado]
      ,[Fecha_Generado]
      ,[Generado_Por]
      ,[Cierre_Iniciado]
      ,[Fecha_Cierre]
      ,[Modificado_Por]
      ,[Fecha_Modificado]
	  ,DBO.FN_GET_DESCRIPCION_FECHA(Fecha) as Descripcion_Fecha
	  ,DBO.FN_GET_SIGUIENTE_FECHA_LABORAL(Fecha, 1) as Proxima_Fecha
	  ,DBO.FN_GET_DESCRIPCION_FECHA(DBO.FN_GET_SIGUIENTE_FECHA_LABORAL(Fecha, 1)) as Proxima_Fecha_Descripcion
  FROM [DB].[dbo].[TSISTEMA_PROCESOS_CONTROL]' 
GO
/****** Object:  View [dbo].[VSISTEMA_PROCESOS_SCHEDULE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_PROCESOS_SCHEDULE]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSISTEMA_PROCESOS_SCHEDULE]
AS
SELECT S.[Unico]
      ,S.[Codigo]
      ,S.[Descripcion]
      ,S.[EsActivo]
      ,S.[EsLunes]
      ,S.[EsMartes]
      ,S.[EsMiercoles]
      ,S.[EsJueves]
      ,S.[EsViernes]
      ,S.[EsSabado]
      ,S.[EsDomingo]
      ,S.[Fecha_Inicio]
      ,S.[Fecha_Fin]
      ,S.[Hora_Inicio]
      ,S.[Hora_Fin]
      ,S.[Adicionado_Por]
      ,S.[Fecha_Adicionado]
      ,S.[Modificado_Por]
      ,S.[Fecha_Modificado]
      ,S.[Fecha_Ult_Cola]
      ,S.[onlyOnce]
      ,S.[Tarea_Id]
      ,S.[CantSegundoRepite]
      ,S.[Fecha_Ultima_Ejecusion]
	  ,DATEDIFF(ss, Fecha_Ultima_Ejecusion, GetDate() ) as segundosTrascurridos
	  ,Case When Fecha_Ult_Cola Is Null then 0 else DATEDIFF(ss, Fecha_Ult_Cola, GetDate() )  End as CantSegundosEnCola
	  ,Cast(Case when Fecha_Ultima_Ejecusion Is Null then 0 else 1 End as Bit) as EsEjecutado
  FROM TSISTEMA_PROCESOS_SCHEDULE S
' 
GO
/****** Object:  View [dbo].[VSISTEMA_TIPOS_NCF]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSISTEMA_TIPOS_NCF]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSISTEMA_TIPOS_NCF]
AS
SELECT 0 as Tipo_NCF, ''SIN COMPROBANTE FISCAL'' as Descripcion, Cast(1 as Bit) EsCompra, Cast(1 as Bit) EsVenta
UNION ALL
SELECT Tipo_NCF, UPPER(Descripcion) AS Descripcion, EsCompra, EsVenta FROM [TSISTEMA_TIPOS_NCF]
' 
GO
/****** Object:  View [dbo].[VSMART_PHONES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VSMART_PHONES]'))
EXEC dbo.sp_executesql @statement = N'
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VSMART_PHONES]
AS
SELECT SM.[Unico]
      ,SM.[Smart_UID]
      ,SM.[Usuario]
      ,SM.[EsActivo]
      ,SM.[Adicionado_Por]
      ,SM.[Fecha_Adicionado]
      ,SM.[Modificado_Por]
      ,SM.[Fecha_Modificado]
      ,SM.[Aprobado_Por]
      ,SM.[Fecha_Aprobado]
      ,SM.[Empleado_Id]
      ,SM.[Fecha_Deleted]
	  ,dbo.FCOMBINA_NOMBRES_APELLIDOS(E.Nombres, E.Apellidos, E.Apodo) as Asignado_A
	  ,SM.Latitude, sm.Longitude, sm.Platform
  FROM [TSMART_PHONES] SM
       LEFT OUTER JOIN TRRHH_EMPLEADOS E ON E.Empleado_Id = SM.Empleado_Id
 WHERE SM.Fecha_Deleted Is Null

' 
GO
/****** Object:  View [dbo].[VTABLAS_COLUMNAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VTABLAS_COLUMNAS]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[VTABLAS_COLUMNAS]
AS
SELECT SO.NAME TableName, SC.NAME ColumnName
FROM sys.objects SO INNER JOIN sys.columns SC
ON SO.OBJECT_ID = SC.OBJECT_ID
WHERE SO.TYPE = ''U''
' 
GO
/****** Object:  View [dbo].[VUSUARIOS_X_ROLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VUSUARIOS_X_ROLES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VUSUARIOS_X_ROLES]
AS
SELECT R.Rol_Id, Nombre as Nombre_Rol,
       Nombre_Usuario, IsNull(UR.EsActivo, 0) Aplica
FROM TACCESOS_ROLES R
     Left Outer Join TACCESOS_USUARIOS_X_ROLES UR ON (UR.Rol_Id = R.Rol_Id)
WHERE R.EsActivo = 1
' 
GO
/****** Object:  View [dbo].[VVENDEDORES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENDEDORES]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VVENDEDORES]
AS
SELECT 
      E.*,
      IsNull(E.Nombres, '''') + '' '' + IsNull(E.Apellidos, '''') as Nombre_Completo,
      Replace(CedulaRNC, ''-'', '''') + IsNull(E.Nombres, '''') + '' '' + IsNull(E.Apellidos, '''') Campo_Busqueda
  FROM TRRHH_EMPLEADOS E
  WHERE EsActivo = 1 And EsVendedor = 1
' 
GO
/****** Object:  View [dbo].[VVENTAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS]'))
EXEC dbo.sp_executesql @statement = N'








CREATE VIEW [dbo].[VVENTAS]
AS
SELECT        V.Unico,
              Identificador_Id, V.Empresa_Id, V.Oficina_Id, V.Caja_Id, Numero, Fecha, 
              Entidad_Id, V.CedulaRNC, Nivel_Precio, V.Nombre, V.Direccion, Telefonos, V.Tipo_NCF, NCF, 
			  Monto, Concepto, IsNull(Monto_AlContado, 0) as Monto_AlContado , IsNull(Monto_ACredito, 0) as Monto_ACredito, 
              IsNull(EsNulo, 0) EsNulo, V.Estatus, Estatus_Id, Prestamo_Id, 
			  V.Adicionado_Por, Vendedor_Id, 
			  IsNull(EnEfectivo, 0)  as EnEfectivo,  IsNull(EnCheques, 0) as EnCheques,  IsNull(EnTarjeta, 0) EnTarjeta, IsNull(ADevolver, 0) ADevolver,
			  Cast(Numero as Varchar) + ''CD'' + IsNull(V.CedulaRNC, '''') + ''NE'' + IsNull(V.Nombre, '''') + ''NCF'' + ISNULL(NCF, '''') as Campo_Busqueda,
			  DATEDIFF(HH, V.Fecha_Adicionado, GETDATE()) as C_Horas,
			  DATEDIFF(DD, V.Fecha_Adicionado, GETDATE()) as C_Dias,
			  DATEDIFF(MM, V.Fecha_Adicionado, GETDATE()) as C_Mes,
			  Monto_US, IsNull(Monto_AlContado_US, 0) as Monto_AlContado_US , IsNull(Monto_ACredito_US, 0) as Monto_ACredito_US,
			  IsNull(EnEfectivo_US, 0) - IsNull(ADevolver_US, 0) as EnEfectivo_US,  IsNull(EnCheques_US, 0) as EnCheques_US,  IsNull(EnTarjeta_US, 0) EnTarjeta_US,
			  Case When V.Vendedor_Id > 0 then dbo.FCOMBINA_NOMBRES_APELLIDOS(E.NOMBRES, E.APELLIDOS, '''') ELSE ''USUARIO DE CAJA, '' + V.Adicionado_Por  End  as Nombre_Vendedor,
			  Case When V.Caja_Id > 0 THEN CJ.Nombre else ''SIN CAJA'' End as Nombre_Caja,
			  Sub_Total, Descuento, Itbis, V.Total_Costo, (V.Monto - V.Total_Costo) AS Ganancia,
			  UPPER(IsNull(TC.Descripcion, '''')) as NCF_Nombre,
			  Case
			     When V.Tipo_NCF > 0 then ''NCF: '' + NCF
				 else ''''
			  end as NCF2,
			  V.NCF_Valido_Hasta
FROM            dbo.TVENTAS AS V
        LEFT OUTER JOIN TRRHH_EMPLEADOS E ON E.Empleado_Id = V.Vendedor_Id
		Left Outer Join TCAJAS CJ ON CJ.Caja_Id = V.Caja_Id
		left outer join 
		  (
		   SELECT * FROM TSISTEMA_TIPOS_NCF
		   WHERE Tipo_NCF > 0
		  ) as TC on (TC.Tipo_NCF = v.Tipo_NCF)













' 
GO
/****** Object:  View [dbo].[VVENTAS_DETALLE]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS_DETALLE]'))
EXEC dbo.sp_executesql @statement = N'










CREATE VIEW [dbo].[VVENTAS_DETALLE]
AS
SELECT        V.Identificador_Id, V.Empresa_Id, V.Oficina_Id, V.Caja_Id, V.Numero, V.Fecha, V.Entidad_Id, V.CedulaRNC, V.Nombre, V.Direccion, V.Telefonos, V.Dias_Credito, V.Fecha_Vencimiento, V.Tipo_NCF, V.NCF, 
              V.Concepto, V.Monto_AlContado, V.Monto_ACredito, V.Estatus_Id, V.Estatus, V.Adicionado_Por, V.Fecha_Adicionado, V.Vendedor_Id, 
			  D.Producto_Id, D.Descripcion, D.Categoria_Id, D.UMedida_Id, D.Cantidad, 
              D.Precio_Sin_Itbis, D.Precio, D.Sub_Total, D.Descuento, D.Tasa_Itbis, D.Itbis, D.Monto, D.Nivel_Precio, D.EsOferta,
			  IsNull( ( SELECT TOP 1 Descripcion FROM TSISTEMA_TIPOS_NCF WHERE Tipo_NCF = V.Tipo_NCF and Tipo_NCF > 0 ), '''') as Nombre_NCF,
			  V.EnEfectivo, V.EnTarjeta, V.EnCheques, V.ADevolver,
			  CT.Nombre as Categoria,
			  0 as Marca_Id, '''' as Marca,
			  IsNull(D.Costo, 0) as Costo,
			  D.Monto - IsNull(D.Costo, 0) as Beneficios,
			  IsNull(UM.Abreviatura, ''UND'') Medida,
			  D.Precio_Sin_Itbis_US, D.Precio_US, D.Sub_Total_US, D.Descuento_US, D.Itbis_US, V.Monto_US, V.Tasa_Cambio_US
			  ,V.PorcDescto, V.Sub_Total as VSub_Total, V.Descuento as VDescuento, V.Itbis as VItbis, V.Monto as VMonto
			  ,IsNull(V.EsNulo, 0) EsNulo, D.Unico
			  ,dbo.FCOMBINA_NOMBRES_APELLIDOS(U.Nombres, U.Apellidos, '''') as Nombre_Usuario
			  ,IsNull(E.Mensaje_Factura, '''') as Mensaje_Factura
			  ,IsNull(D.Tipo, '''') as Tipo_Detalle
			  ,Case When V.Vendedor_Id > 0 then dbo.FCOMBINA_NOMBRES_APELLIDOS(Emp.NOMBRES, Emp.APELLIDOS, '''') ELSE ''USUARIO DE CAJA, '' + V.Adicionado_Por  End  as Nombre_Vendedor
			  ,V.NCF_Valido_Hasta
FROM            dbo.TVENTAS AS V 
                INNER JOIN dbo.TVENTAS_DETALLES AS D ON V.Identificador_Id = D.Identificador_Id
				Left Outer Join TCLASIFICADOR_PRODUCTOS_CATEGORIAS CT on CT.Categoria_Id = D.Categoria_Id
				left outer join TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS UM ON (UM.UMedida_Id = D.UMedida_Id)
				Left Outer Join TACCESOS_USUARIOS U ON U.Nombre_Usuario = V.Adicionado_Por
				Left Outer Join TEMPRESAS E ON E.Empresa_Id = V.Empresa_Id
				LEFT OUTER JOIN TRRHH_EMPLEADOS Emp ON Emp.Empleado_Id = V.Vendedor_Id
WHERE        (D.FechaDeleted IS NULL) AND (ISNULL(V.EsNulo, 0) = 0)











' 
GO
/****** Object:  View [dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]'))
EXEC dbo.sp_executesql @statement = N'


CREATE VIEW [dbo].[VVENTAS_OTROS_DOCUMENTOS_DETALLES]
AS
SELECT        E.Identificador_Id, E.Tipo, E.Numero, E.Empresa_Id, E.Oficina_Id, E.Fecha, E.Entidad_Id, E.Nombre, E.CedulaRNC, E.Telefonos, E.Direccion, E.Sub_Total, E.Total_Itbis, E.Total_Descuento, E.Caja_Id, E.EsNulo, 
                         E.Fecha_Anulado, E.Anulado_Por, E.Comentario_Anulacion, E.Adicionado_Por, E.Fecha_Adicionado, E.Modificado_Por, E.Fecha_Modificado, E.Aprobado_Por, E.Fecha_Aprobado, E.Factura_Id, E.Dias_Credito, 
                         E.Fecha_Vencimiento, E.Estatus_Id, E.Estatus, E.Vendedor_Id, E.Monto, E.Monto_US, E.Tasa_Cambio_US, E.Moneda, E.PorcDescto, D.Producto_Id, D.Descripcion, D.Cantidad, D.Precio, 
                         D.Sub_Total AS DSub_Total, D.Descuento AS DDescuento, D.Neto AS DNeto, D.Tasa_Itbis AS DTasa_Itbis, D.Itbis AS DItbis, D.Total AS DTotal, D.UMedida_Id, D.UMedida, D.Precio_Sin_Itbis, D.Nivel_Precio, 
                         D.EsOferta, D.ItemNumero, D.EsInventario, D.EsExcentoItbis, D.PrecioConItbis,
						 UM.Descripcion as Medida,
						 IsNull(TE.Mensaje_Factura, '''') as Mensaje_Factura,
						 dbo.FCOMBINA_NOMBRES_APELLIDOS(U.Nombres, U.Apellidos, '''') as Nombre_Usuario
FROM            dbo.TVENTAS_OTROS_DOCUMENTOS AS E INNER JOIN
                         dbo.TVENTAS_OTROS_DOCUMENTOS_DETALLES AS D ON E.Identificador_Id = D.Identificador_Id
						 left Outer Join TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS UM ON UM.UMedida_Id = D.UMedida_Id
						 Left Outer Join TEMPRESAS TE on TE.Empresa_Id = E.Empresa_Id 
						 Left Outer Join TACCESOS_USUARIOS U on u.Nombre_Usuario = e.Adicionado_Por
WHERE        (D.FechaDeleted IS NULL)



' 
GO
/****** Object:  View [dbo].[VZONAS]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VZONAS]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VZONAS]
AS
SELECT Z.*,
       dbo.FCOMBINA_NOMBRES_APELLIDOS(EV.Nombres, EV.Apellidos, EV.Apodo) as Evaluador_Nombre,
	   dbo.FCOMBINA_NOMBRES_APELLIDOS(SP.Nombres, SP.Apellidos, SP.Apodo) as Supervisor_Nombre
FROM [TZONAS] Z
     LEFT OUTER JOIN  TRRHH_EMPLEADOS EV ON (Z.Evaluador_Id = EV.Empleado_Id)
	 Left Outer Join  TRRHH_EMPLEADOS SP ON (Z.Supervisor_Id = SP.Empleado_Id)
' 
GO
/****** Object:  View [dbo].[VZONAS_SECTORES_ALL]    Script Date: 01/07/2018 7:25:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VZONAS_SECTORES_ALL]'))
EXEC dbo.sp_executesql @statement = N'/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[VZONAS_SECTORES_ALL]
AS
SELECT [Sector_Id]
      ,[Municipio_Id]
      ,[Nombre]
      ,[EsActivo]
  FROM [TZONAS_SECTORES]
UNION ALL
SELECT 0 as Sector_Id,
       0 as Municipio_Id,
	   ''(DESCONOCIDO)'' as Nombre,
	   Cast(1 as Bit) as EsActivo
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_ABIERTAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 228
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CA"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 217
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2475
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_ABIERTAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_ABIERTAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_ABIERTAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_RECIBOS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TT"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RC"
            Begin Extent = 
               Top = 6
               Left = 268
               Bottom = 136
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 31
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_RECIBOS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VCAJAS_RECIBOS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VCAJAS_RECIBOS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VEMPRESAS_OFICINAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "E"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "O"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 136
               Right = 449
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VEMPRESAS_OFICINAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VEMPRESAS_OFICINAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VEMPRESAS_OFICINAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VMODULOS_REPORTES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SM"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "RP"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 136
               Right = 450
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VMODULOS_REPORTES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VMODULOS_REPORTES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VMODULOS_REPORTES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_AMORTIZACION', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "D"
            Begin Extent = 
               Top = 6
               Left = 267
               Bottom = 231
               Right = 451
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "PO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 199
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 67
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_AMORTIZACION'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_AMORTIZACION', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_AMORTIZACION'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_DEMORA_GENERADAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DM"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 186
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "TG"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 136
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_DEMORA_GENERADAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_DEMORA_GENERADAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_DEMORA_GENERADAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_TASA_INTERES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TG"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 179
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TS"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 126
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 22
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_TASA_INTERES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VPRESTAMOS_TASA_INTERES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VPRESTAMOS_TASA_INTERES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "V"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 39
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_DETALLE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "V"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 162
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 28
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 6
               Left = 268
               Bottom = 136
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 22
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_DETALLE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_DETALLE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_DETALLE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_OTROS_DOCUMENTOS_DETALLES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "E"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 33
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 6
               Left = 287
               Bottom = 179
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 23
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_OTROS_DOCUMENTOS_DETALLES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VVENTAS_OTROS_DOCUMENTOS_DETALLES', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VVENTAS_OTROS_DOCUMENTOS_DETALLES'
GO
