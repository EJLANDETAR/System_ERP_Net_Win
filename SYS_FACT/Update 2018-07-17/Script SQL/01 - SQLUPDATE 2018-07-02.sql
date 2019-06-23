USE DB
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Tipo_Ingreso_DGII') = 0
Begin
    Alter Table TVentas
	add Tipo_Ingreso_DGII int
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Fecha_Retencion') = 0
Begin
    Alter Table TVentas
	add Fecha_Retencion Datetime
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Itbis_Retenido') = 0
Begin
    Alter Table TVentas
	add Itbis_Retenido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Itbis_Percibido') = 0
Begin
    Alter Table TVentas
	add Itbis_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Retencion_Renta') = 0
Begin
    Alter Table TVentas
	add Retencion_Renta Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'ISR_Percibido') = 0
Begin
    Alter Table TVentas
	add ISR_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TVentas
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TVentas
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TVentas
	add Propina_Legal Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'EnBonos') = 0
Begin
    Alter Table TVentas
	add EnBonos Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'EnPermuta') = 0
Begin
    Alter Table TVentas
	add EnPermuta Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS') AND name = 'EnOtros') = 0
Begin
    Alter Table TVentas
	add EnOtros Numeric(18, 2)
End
GO



--AGREGAMOS LOS CAMPOS A LA TABLA TEMPORAL
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Tipo_Ingreso_DGII') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Tipo_Ingreso_DGII int
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Fecha_Retencion') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Fecha_Retencion Datetime
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Itbis_Retenido') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Itbis_Retenido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Itbis_Percibido') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Itbis_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Retencion_Renta') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Retencion_Renta Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'ISR_Percibido') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add ISR_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add Propina_Legal Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'EnBonos') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add EnBonos Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'EnPermuta') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add EnPermuta Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS') AND name = 'EnOtros') = 0
Begin
    Alter Table TTEMPORAL_VENTAS
	add EnOtros Numeric(18, 2)
End
GO



--AGREGAMOS CAMPOS A LA TABLA TCAJA_RECIBOS
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Tipo_Ingreso_DGII') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Tipo_Ingreso_DGII int
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Fecha_Retencion') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Fecha_Retencion Datetime
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Itbis_Retenido') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Itbis_Retenido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Itbis_Percibido') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Itbis_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Retencion_Renta') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Retencion_Renta Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'ISR_Percibido') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add ISR_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add Propina_Legal Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'EnBonos') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add EnBonos Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'EnPermuta') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add EnPermuta Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCAJAS_RECIBOS') AND name = 'EnOtros') = 0
Begin
    Alter Table TCAJAS_RECIBOS
	add EnOtros Numeric(18, 2)
End
GO




--NUEVOS CAMPOS PARA LAS COMPRAS
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'EnServicios') = 0
Begin
    Alter Table TCXP
	add EnServicios Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'EnBienes') = 0
Begin
    Alter Table TCXP
	add EnBienes Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Itbis_Proporcionalidad') = 0
Begin
    Alter Table TCXP
	add Itbis_Proporcionalidad Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Itbis_Costo') = 0
Begin
    Alter Table TCXP
	add Itbis_Costo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Itbis_Por_Adelantar') = 0
Begin
    Alter Table TCXP
	add Itbis_Por_Adelantar Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Itbis_Percivido') = 0
Begin
    Alter Table TCXP
	add Itbis_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Tipo_Retencion_ISR') = 0
Begin
    Alter Table TCXP
	add Tipo_Retencion_ISR Int
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'ISR_Percivido') = 0
Begin
    Alter Table TCXP
	add ISR_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TCXP
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TCXP
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TCXP
	add Propina_Legal Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'Forma_Pago_DGII') = 0
Begin
    Alter Table TCXP
	add Forma_Pago_DGII Int
End
GO


--TABLA TEMPORAL COMPRA
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'EnServicios') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add EnServicios Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'EnBienes') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add EnBienes Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Itbis_Proporcionalidad') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Itbis_Proporcionalidad Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Itbis_Costo') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Itbis_Costo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Itbis_Por_Adelantar') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Itbis_Por_Adelantar Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Itbis_Percivido') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Itbis_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Tipo_Retencion_ISR') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Tipo_Retencion_ISR Int
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'ISR_Percivido') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add ISR_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Propina_Legal Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP') AND name = 'Forma_Pago_DGII') = 0
Begin
    Alter Table TTEMPORAL_CXP
	add Forma_Pago_DGII Int
End
GO


--TEMPORAL DGII 606
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'EnServicios') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add EnServicios Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'EnBienes') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add EnBienes Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Itbis_Proporcionalidad') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Itbis_Proporcionalidad Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Itbis_Costo') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Itbis_Costo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Itbis_Por_Adelantar') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Itbis_Por_Adelantar Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Itbis_Percivido') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Itbis_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Tipo_Retencion_ISR') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Tipo_Retencion_ISR Int
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'ISR_Percivido') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add ISR_Percivido Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Propina_Legal Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_606') AND name = 'Forma_Pago_DGII') = 0
Begin
    Alter Table TTEMPORAL_DGII_606
	add Forma_Pago_DGII Int
End
GO




--TABLA TEMPORAL 607
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Tipo_Ingreso_DGII') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Tipo_Ingreso_DGII int
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Fecha_Retencion') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Fecha_Retencion Datetime
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Itbis_Retenido') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Itbis_Retenido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Itbis_Percibido') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Itbis_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Retencion_Renta') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Retencion_Renta Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'ISR_Percibido') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add ISR_Percibido Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Impuesto_Selectivo_Consumo') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Impuesto_Selectivo_Consumo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Otros_Impuestos') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Otros_Impuestos Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'Propina_Legal') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add Propina_Legal Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnEfectivo') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnEfectivo Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnChequesODep') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnChequesODep Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnTarjeta') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnTarjeta Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnVentaACredito') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnVentaACredito Numeric(18, 2)
End
GO


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnBonos') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnBonos Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnPermuta') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnPermuta Numeric(18, 2)
End
GO



if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_DGII_607') AND name = 'EnOtros') = 0
Begin
    Alter Table TTEMPORAL_DGII_607
	add EnOtros Numeric(18, 2)
End
GO 




--AGREGAMOS EL CAMPO ESSERVICOS A LOS PRODUCTOS
if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCLASIFICADOR_PRODUCTOS') AND name = 'EsServicio') = 0
Begin
    Alter Table TCLASIFICADOR_PRODUCTOS
	add EsServicio bit
End
GO 


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TVENTAS_DETALLES') AND name = 'EsServicio') = 0
Begin
    Alter Table TVENTAS_DETALLES
	add EsServicio bit
End
GO 


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_VENTAS_DETALLES') AND name = 'EsServicio') = 0
Begin
    Alter Table TTEMPORAL_VENTAS_DETALLES
	add EsServicio bit
End
GO 


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP_DETALLES') AND name = 'EsServicio') = 0
Begin
    Alter Table TCXP_DETALLES
	add EsServicio bit
End
GO 


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TCXP') AND name = 'NCF_Valido_Hasta') = 0
Begin
    Alter Table TCXP
	add NCF_Valido_Hasta Datetime
End
GO 


if (SELECT COUNT(*) FROM sys.columns WHERE object_id = object_id('TTEMPORAL_CXP_DETALLES') AND name = 'EsServicio') = 0
Begin
    Alter Table TTEMPORAL_CXP_DETALLES
	add EsServicio bit
End
GO 






/****** Object:  View [dbo].[VCATEGORIA_PRODUCTOS]    Script Date: 06/06/2018 9:29:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



 ALTER View [dbo].[VCATEGORIA_PRODUCTOS]
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
      ,IsNull(P.Codigo_Barra, '') + ISNULL(P.Nombre_Corto, '') as Campo_Busqueda
      ,IsNull(M.Nombre, '') as Marca
	  ,IsNull(MD.Abreviatura, 'UND') AS Unidad
	  ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1)  then P.Precio_Minimo else  P.Precio_Minimo + (P.Precio_Minimo * C.Tasa_Itbis/100.0) end as PrecioM
	  ,Case when (PrecioConItbis = 1) Or (IsNull(EsExcentoItbis, 0) = 1)  then P.Precio_Oferta else  P.Precio_Oferta + (P.Precio_Oferta * C.Tasa_Itbis/100.0) end as PrecioO
	  ,IsNull(P.EsServicio, 0) EsServicio
  FROM [TCLASIFICADOR_PRODUCTOS] P
       Inner Join TCLASIFICADOR_PRODUCTOS_CATEGORIAS C On (C.Categoria_Id = P.Categoria_Id)
       Left Outer Join TCLASIFICADOR_MARCAS M ON (M.Marca_Id = P.Marca_Id)
	   Left Outer Join TCLASIFICADOR_PRODUCTOS_UNIDADES_MEDIDAS MD ON (MD.UMedida_Id = P.UMedida_Id)
go


DELETE FROM TSISTEMA_VARIABLES WHERE Variable IN ('MOSTRAR_MENU_FLAT_PANEL', 'FACTURA_TIPO_TICKET', 'FACTURA_TIPO_MATRICIAL', 'MOSTRAR_PRINT_DIALOG', 'IMPRIME_EN_SU_CAMBIO', 'PRINT_PREVIEW', 'IMPRIME_OTRO_FORMATO', 'IMPRIME_MATRICIAL', 'FDSFSAF')

GO


UPDATE TSISTEMA_VARIABLES
SET
   Variable  = 'CAJA_METODO_IMPRIME'
WHERE Variable = 'FACTURA_RECIBO_FORMA_IMPRIMIR'
GO


UPDATE TSISTEMA_VARIABLES
SET
   Valor  = '1'
WHERE Variable = 'TIPO_FORM_FACTURA'
GO

alter table TSISTEMA_VARIABLES
alter column Variable Varchar(100)
go


UPDATE TACCESOS_OPCIONES_MENU
SET 
   Nombre = 'Facturas de Ventas'
WHERE Formulario_AEjecutar = 'ELRFacturas.FormFacturasList'
go



if OBJECT_ID('TTEMPORAL_DGII_607_RESUMEN_FC') Is Null
Begin
	CREATE TABLE [dbo].[TTEMPORAL_DGII_607_RESUMEN_FC](
		[Unico] [int] IDENTITY(1,1) NOT NULL,
		[Titulo] [varchar](100) NOT NULL,
		[NoOrden] [int] NOT NULL,
		[Descripcion] [varchar](150) NOT NULL,
		[Valor] [numeric](18, 2) NOT NULL,
		[Adicionado_Por] [varchar](50) NULL,
		[Fecha_Adicionado] [datetime] NULL,
		[Modificado_Por] [varchar](50) NULL,
		[Fecha_Modificado] [datetime] NULL,
		[IdentificadorTemp] [varchar](150) NOT NULL,
		[Fecha_Desde] [datetime] NULL,
		[Fecha_Hasta] [datetime] NULL,
		[Periodo] [int] NULL
	) ON [PRIMARY]
End
GO