delimiter $$
CREATE PROCEDURE obtenerNComprobante ( 
	IN `_empresa` int
 )
BEGIN 
	select (count(*)+1) as 'NComprobante' from comprobante where idempresa=_empresa;
END$$
delimiter ;