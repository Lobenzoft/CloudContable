delimiter $$
CREATE PROCEDURE registrarComprobante ( 
	IN `_empresa` int,
	IN `_n_comprobante` varchar(100),
	IN `_comprobante_tipo` varchar(100),
	IN `_comprobante_razon` varchar(100),
	IN `_comprobante_glosa` varchar(512),
	IN `_comprobante_cheque` varchar(100),
	IN `_comprobante_fecha` date,
	IN `_comprobante_usd` double,
	IN `_comprobante_ufv` double,
	IN `_comprobante_valido` tinyint,
	IN `_idproyecto` int
 )
BEGIN 
	INSERT INTO comprobante
	( idempresa, n_comprobante, comprobante_tipo, comprobante_razon, comprobante_glosa, comprobante_cheque, comprobante_fecha, comprobante_usd, comprobante_ufv, comprobante_valido, idproyecto) VALUES 
	( _empresa, _n_comprobante, _comprobante_tipo, _comprobante_razon, _comprobante_glosa, _comprobante_cheque, _comprobante_fecha, _comprobante_usd, _comprobante_ufv, _comprobante_valido, _idproyecto );
END$$
delimiter ;