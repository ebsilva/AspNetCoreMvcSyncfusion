USE [dbteste]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 01/02/2021 12:29:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [nvarchar](max) NULL,
	[TipoCliente] [nvarchar](max) NULL,
	[NomeContato] [nvarchar](max) NULL,
	[TelefoneContato] [nvarchar](max) NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Complemento] [nvarchar](max) NULL,
	[Bairro] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[DataCadastro] [datetime2](7) NOT NULL,
	[DataAtualizacao] [datetime2](7) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


