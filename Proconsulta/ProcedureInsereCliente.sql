USE dbteste
GO

CREATE PROCEDURE dbo.InsereClientes
@nome nvarchar(50),
@tipo nvarchar(20),
@contato nvarchar(50),
@fone char(9),
@logradouro nvarchar(100),
@complemento nvarchar(50),
@bairro  nvarchar(50),
@cidade  nvarchar(500),
@cadastro DateTime,
@atualizacao DateTime
AS
insert Clientes 
     values  (@nome,@tipo,@contato,@fone,@logradouro,
			  @complemento,@bairro,@cidade,@cadastro,@atualizacao,1)
						
GO