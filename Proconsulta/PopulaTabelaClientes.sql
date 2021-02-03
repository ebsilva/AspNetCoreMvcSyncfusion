DECLARE @contador INT = 1;
DECLARE @totalRegistros INT = 5000;
DECLARE @sufix varchar(5) = '';

truncate table clientes;
WHILE @contador <= @totalRegistros
BEGIN
   set @sufix =  cast(@contador as varchar(5)); 
   insert Clientes values  ('Teste' +@sufix,
                            'TipoCliente'  + @sufix,
							'NomeContato' + @sufix,
							 REPLICATE(@sufix, 4)+'-'+ REPLICATE(@sufix, 4),
							'Rua ' + @sufix,
							'',
							'Bairro' + @sufix,
							'Cidade' + @sufix,
							GETDATE(),
							GETDATE(),
							1);
   SET @contador = @contador + 1
END;


select  * from clientes
