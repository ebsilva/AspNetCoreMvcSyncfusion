CREATE PROCEDURE [dbo].[AtualizaCliente]
@Id int,
@nome nvarchar(50),
@tipo nvarchar(20),
@contato nvarchar(50),
@fone char(9),
@logradouro nvarchar(100),
@complemento nvarchar(50),
@bairro  nvarchar(50),
@cidade  nvarchar(500)
AS
   declare @nomecliente as varchar(100)	
	Select @nomecliente = NomeCliente  from Clientes where Id = @id;
	if(len(@nome) > 0)
	begin
	   update Clientes
	     set NomeCliente = @nome,
		 TipoCliente = @tipo,
		 NomeContato = @contato,
		 TelefoneContato = @fone,
		 Logradouro = @logradouro,
		 Complemento = @complemento,
		 Bairro = @bairro,
		 Cidade = @cidade,
		 DataAtualizacao = GETDATE()
	   where Id = @Id;
	end
						
GO