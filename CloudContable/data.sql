CREATE TABLE zencloud.listclientes ( 
	listid               int  NOT NULL  AUTO_INCREMENT,
	clientenombre        varchar(100)  NOT NULL  ,
	clientetelf          varchar(100)  NOT NULL  ,
	clientedireccion     varchar(100)    ,
	clientenit           varchar(100)    ,
	clientelicencia      varchar(100)  NOT NULL  ,
	clientefechalicencia date  NOT NULL  ,
	CONSTRAINT pk_listclientes PRIMARY KEY ( listid )
 );

CREATE TABLE zencloud.notificacion ( 
	notificacionid       int  NOT NULL  AUTO_INCREMENT,
	notificacion_text    varchar(1024)  NOT NULL  ,
	notificacion_destino int  NOT NULL  ,
	notificacion_fecha   date    ,
	CONSTRAINT pk_notificacion PRIMARY KEY ( notificacionid )
 );

CREATE TABLE zencloud.plan ( 
	planid               int  NOT NULL  AUTO_INCREMENT,
	codigoplan           int  NOT NULL  ,
	cuenta               varchar(100)  NOT NULL  ,
	padre                int  NOT NULL  ,
	nivel                int  NOT NULL  ,
	tipo                 varchar(100)  NOT NULL  ,
	clase                varchar(100)  NOT NULL  ,
	CONSTRAINT pk_plan PRIMARY KEY ( planid )
 );

CREATE TABLE zencloud.usuarios ( 
	userid               int  NOT NULL  AUTO_INCREMENT,
	username             varchar(100)  NOT NULL  ,
	userpass             varchar(100)  NOT NULL  ,
	usertype             varchar(100)  NOT NULL  ,
	usernombre           varchar(100)  NOT NULL  ,
	userestado           varchar(100)  NOT NULL  ,
	cliente              int  NOT NULL  ,
	CONSTRAINT pk_usuarios PRIMARY KEY ( userid )
 );

CREATE INDEX idx_usuarios_usercliente ON zencloud.usuarios ( cliente );

CREATE TABLE zencloud.chat ( 
	chatid               int  NOT NULL  AUTO_INCREMENT,
	iduser               int  NOT NULL  ,
	chat_tipo            varchar(100)  NOT NULL  ,
	chat_text            varchar(1024)  NOT NULL  ,
	chat_estado          varchar(100)  NOT NULL  ,
	CONSTRAINT pk_chat PRIMARY KEY ( chatid )
 );

CREATE INDEX idx_chat_iduser ON zencloud.chat ( iduser );

CREATE TABLE zencloud.empresa ( 
	empresaid            int  NOT NULL  AUTO_INCREMENT,
	cliente              int  NOT NULL  ,
	razonsocial          varchar(100)  NOT NULL  ,
	nit                  varchar(100)  NOT NULL  ,
	direccion            varchar(100)  NOT NULL  ,
	telf                 varchar(100)  NOT NULL  ,
	lugar                varchar(100)  NOT NULL  ,
	actividad            varchar(100)  NOT NULL  ,
	iniciogestion        date  NOT NULL  ,
	fingestion           date  NOT NULL  ,
	propietario          varchar(100)  NOT NULL  ,
	contador             varchar(100)  NOT NULL  ,
	plancuentas          varchar(100)  NOT NULL  ,
	CONSTRAINT pk_empresa PRIMARY KEY ( empresaid )
 );

CREATE INDEX idx_empresa_cliente ON zencloud.empresa ( cliente );

CREATE TABLE zencloud.libro_compra ( 
	libro_compraid       int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	compra_estado        varchar(100)  NOT NULL DEFAULT 'No Contabilizado' ,
	compra_especificacion int  NOT NULL  ,
	compra_fecha_factura date  NOT NULL  ,
	compra_nit           int  NOT NULL DEFAULT 0 ,
	compra_razon_social  varchar(100)  NOT NULL  ,
	compra_num_factura   int  NOT NULL DEFAULT 0 ,
	compra_num_dui       int  NOT NULL DEFAULT 0 ,
	compra_num_aut       int  NOT NULL DEFAULT 0 ,
	compra_importe_total double  NOT NULL DEFAULT 0 ,
	compra_importe_nosujeto double  NOT NULL DEFAULT 0 ,
	compra_descuento     double  NOT NULL DEFAULT 0 ,
	compra_cod_control   varchar(100)  NOT NULL DEFAULT '0' ,
	compra_tipo          int  NOT NULL DEFAULT 0 ,
	compra_debe          int  NOT NULL  ,
	compra_haber         int  NOT NULL  ,
	CONSTRAINT pk_libro_compra PRIMARY KEY ( libro_compraid )
 );

CREATE INDEX idx_libro_compra_idempresa ON zencloud.libro_compra ( idempresa );

CREATE TABLE zencloud.libro_compra_aux ( 
	libro_compra_auxid   int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	compra_aux_modalidad int  NOT NULL DEFAULT 0 ,
	compra_aux_fecha     date  NOT NULL  ,
	compra_aux_tipo      int  NOT NULL DEFAULT 0 ,
	compra_aux_nit       int  NOT NULL DEFAULT 0 ,
	compra_aux_razon_social varchar(100)  NOT NULL  ,
	compra_aux_num_doc   int  NOT NULL DEFAULT 0 ,
	compra_aux_num_contrato int  NOT NULL DEFAULT 0 ,
	compra_aux_importe   double  NOT NULL DEFAULT 0 ,
	compra_aux_num_aut   int  NOT NULL DEFAULT 0 ,
	compra_aux_num_cuenta_doc int  NOT NULL DEFAULT 0 ,
	compra_aux_monto_pagado double  NOT NULL DEFAULT 0 ,
	compra_aux_monto_acum double  NOT NULL DEFAULT 0 ,
	compra_aux_nit_entidad int  NOT NULL DEFAULT 0 ,
	compra_aux_num_doc_pago int  NOT NULL DEFAULT 0 ,
	compra_aux_fecha_doc_pago date  NOT NULL  ,
	CONSTRAINT pk_libro_compra_aux PRIMARY KEY ( libro_compra_auxid )
 );

CREATE INDEX idx_libro_compra_aux_idempresa ON zencloud.libro_compra_aux ( idempresa );

CREATE TABLE zencloud.libro_venta ( 
	libro_venta_id       int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	venta_estado         varchar(100)  NOT NULL DEFAULT 'No Contabilizado' ,
	venta_especificacion int  NOT NULL DEFAULT 0 ,
	venta_fecha_factura  date  NOT NULL  ,
	venta_num_factura    int  NOT NULL DEFAULT 0 ,
	venta_num_aut        int  NOT NULL DEFAULT 0 ,
	venta_estado_factura int  NOT NULL DEFAULT 0 ,
	venta_nit            int  NOT NULL DEFAULT 0 ,
	venta_razon_social   varchar(100)  NOT NULL  ,
	venta_importe_total  double  NOT NULL DEFAULT 0 ,
	venta_iit            double  NOT NULL DEFAULT 0 ,
	venta_exento         double  NOT NULL DEFAULT 0 ,
	venta_tasa_cero      double  NOT NULL DEFAULT 0 ,
	venta_descuento      double  NOT NULL DEFAULT 0 ,
	venta_cod_control    varchar(100)  NOT NULL DEFAULT '0' ,
	venta_debe           int  NOT NULL  ,
	venta_haber          int  NOT NULL  ,
	CONSTRAINT pk_libro_venta PRIMARY KEY ( libro_venta_id )
 );

CREATE INDEX idx_libro_venta__idempresa ON zencloud.libro_venta ( idempresa );

CREATE TABLE zencloud.libro_venta_aux ( 
	libro_venta_auxid    int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	venta_aux_modalidad  int  NOT NULL  ,
	venta_aux_fecha_factura date  NOT NULL  ,
	venta_aux_num_factura int  NOT NULL DEFAULT 0 ,
	venta_aux_importe    double  NOT NULL DEFAULT 0 ,
	venta_aux_num_contrato int  NOT NULL DEFAULT 0 ,
	venta_aux_num_aut    int  NOT NULL DEFAULT 0 ,
	venta_aux_nit        int  NOT NULL DEFAULT 0 ,
	venta_aux_razon_social varchar(100)  NOT NULL  ,
	venta_aux_num_cuenta int  NOT NULL DEFAULT 0 ,
	venta_aux_monto_pagado double  NOT NULL DEFAULT 0 ,
	venta_aux_monto_acum double  NOT NULL DEFAULT 0 ,
	venta_aux_nit_entidad int  NOT NULL DEFAULT 0 ,
	venta_aux_num_doc_pago int  NOT NULL DEFAULT 0 ,
	venta_aux_tipo_doc_pago int  NOT NULL DEFAULT 0 ,
	venta_aux_fecha_doc_pago date  NOT NULL  ,
	CONSTRAINT pk_libro_venta_aux PRIMARY KEY ( libro_venta_auxid )
 );

CREATE INDEX idx_libro_venta_aux_idempresa ON zencloud.libro_venta_aux ( idempresa );

CREATE TABLE zencloud.proyecto ( 
	proyectoid           int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	proyecto_nombre      varchar(100)  NOT NULL  ,
	CONSTRAINT pk_proyecto PRIMARY KEY ( proyectoid )
 );

CREATE INDEX idx_proyecto_idempresa ON zencloud.proyecto ( idempresa );

CREATE TABLE zencloud.comprobante ( 
	comprobanteid        int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	n_comprobante        int  NOT NULL  ,
	comprobante_tipo     varchar(100)  NOT NULL  ,
	comprobante_razon    varchar(100)  NOT NULL  ,
	comprobante_glosa    varchar(512)    ,
	comprobante_cheque   varchar(100)    ,
	comprobante_fecha    date  NOT NULL  ,
	comprobante_usd      double   DEFAULT 0 ,
	comprobante_ufv      double   DEFAULT 0 ,
	comprobante_valido   boolean  NOT NULL DEFAULT 1 ,
	idproyecto           int  NOT NULL  ,
	CONSTRAINT pk_comprobante PRIMARY KEY ( comprobanteid )
 );

CREATE INDEX idx_comprobante_idempresa ON zencloud.comprobante ( idempresa );

CREATE INDEX idx_comprobante_idproyecto ON zencloud.comprobante ( idproyecto );

CREATE TABLE zencloud.comprobante_detalle ( 
	comprobante_detalleid int  NOT NULL  AUTO_INCREMENT,
	idcomprobante        int  NOT NULL  ,
	codigoplan           int  NOT NULL  ,
	detalle              varchar(512)    ,
	debe                 double  NOT NULL DEFAULT 0 ,
	haber                double  NOT NULL DEFAULT 0 ,
	CONSTRAINT pk_comprobante_detalle PRIMARY KEY ( comprobante_detalleid )
 );

CREATE INDEX idx_comprobante_detalle_idcomprobante ON zencloud.comprobante_detalle ( idcomprobante );

CREATE TABLE zencloud.cuentas_predefinidas ( 
	cuentas_predefinidasid int  NOT NULL  AUTO_INCREMENT,
	idempresa            int  NOT NULL  ,
	codigoplan           int  NOT NULL  ,
	tipo_cuenta          varchar(100)    ,
	CONSTRAINT pk_cuentas_predefinidas PRIMARY KEY ( cuentas_predefinidasid )
 );

CREATE INDEX idx_cuentas_predefinidas_idempresa ON zencloud.cuentas_predefinidas ( idempresa );

delimiter $$
CREATE PROCEDURE zencloud.loginUser ( 
	IN `_cliente` varchar(100),
	IN `_usuario` varchar(100),
	IN `_pass` varchar(100)
 )
BEGIN 
	set @idcliente = (select listid from listclientes where clientenombre = _cliente);
	set @ingreso = (select count(*) from usuarios where cliente=@idcliente and username=_usuario and userpass=_pass);
	IF @ingreso > 0 then
      select empresaid as 'Empresa', razonsocial as 'Nombre de la Empresa',nit as 'NIT',iniciogestion as 'Gestión',propietario as 'Propietario' from empresa where cliente=@idcliente;
    end IF;
END$$
delimiter ;

ALTER TABLE zencloud.chat ADD CONSTRAINT fk_chat_usuarios FOREIGN KEY ( iduser ) REFERENCES zencloud.usuarios( userid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.comprobante ADD CONSTRAINT fk_comprobante_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.comprobante ADD CONSTRAINT fk_comprobante_proyecto FOREIGN KEY ( idproyecto ) REFERENCES zencloud.proyecto( proyectoid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.comprobante_detalle ADD CONSTRAINT fk_comprobante_detalle_comprobante FOREIGN KEY ( idcomprobante ) REFERENCES zencloud.comprobante( comprobanteid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.cuentas_predefinidas ADD CONSTRAINT fk_cuentas_predefinidas_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.empresa ADD CONSTRAINT fk_empresa_listclientes FOREIGN KEY ( cliente ) REFERENCES zencloud.listclientes( listid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.libro_compra ADD CONSTRAINT fk_libro_compra_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.libro_compra_aux ADD CONSTRAINT fk_libro_compra_aux_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.libro_venta ADD CONSTRAINT fk_libro_venta__empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.libro_venta_aux ADD CONSTRAINT fk_libro_venta_aux_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.proyecto ADD CONSTRAINT fk_proyecto_empresa FOREIGN KEY ( idempresa ) REFERENCES zencloud.empresa( empresaid ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE zencloud.usuarios ADD CONSTRAINT fk_usuarios_listclientes FOREIGN KEY ( cliente ) REFERENCES zencloud.listclientes( listid ) ON DELETE NO ACTION ON UPDATE NO ACTION;
