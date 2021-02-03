CREATE PROCEDURE dbo.DeleteCliente
@Id int
AS
    declare @nome as varchar(100)	
	Select @nome= NomeCliente  from Clientes where Id = @id;
	if(len(@nome) > 0)
	begin
	    delete from Clientes where Id = @Id;
	end
						
GO