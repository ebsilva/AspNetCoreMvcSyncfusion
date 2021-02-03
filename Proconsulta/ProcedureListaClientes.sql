CREATE PROCEDURE dbo.ListaClientes
AS
	Select * from Clientes Order by NomeCliente;
						
GO