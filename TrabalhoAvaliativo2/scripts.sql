CREATE TABLE [dbo].[Marcas] (
    [ID]    INT           NOT NULL,
    [Marca] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
     
go

CREATE TABLE [dbo].[Modelos] (
    [MarcaID]  INT           NULL,
    [ModeloID] INT           NOT NULL,
    [Modelo]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED ([ModeloID] ASC),
    CONSTRAINT [FK_Modelos_Marcas] FOREIGN KEY ([MarcaID]) REFERENCES [dbo].[Marcas] ([ID])
);


go


CREATE TABLE [dbo].[TabelaFIPE] (
    [MarcaID]  INT             NULL,
    [ModeloID] INT             NULL,
    [Ano]      INT             NULL,
    [Valor]    DECIMAL (10, 2) NOT NULL,
    FOREIGN KEY ([MarcaID]) REFERENCES [dbo].[Marcas] ([ID]),
    FOREIGN KEY ([ModeloID]) REFERENCES [dbo].[Modelos] ([ModeloID])
);


go


CREATE TABLE [dbo].[Clientes] (
    [ClienteID]      INT            NOT NULL,
    [Nome]           NVARCHAR (100) NOT NULL,
    [Endereco]       NVARCHAR (100) NOT NULL,
    [CEP]            NVARCHAR (10)  NOT NULL,
    [Cidade]         NVARCHAR (50)  NOT NULL,
    [UF]             NVARCHAR (2)   NOT NULL,
    [Telefone]       NVARCHAR (20)  NOT NULL,
    [Celular]        NVARCHAR (20)  NULL,
    [CPF]            NVARCHAR (14)  NOT NULL,
    [RG]             NVARCHAR (20)  NOT NULL,
    [OrgaoEmissor]   NVARCHAR (50)  NOT NULL,
    [CartMotorista]  NVARCHAR (20)  NULL,
    [EmissaoCartMot] DATE           NULL,
    [CategoriaMot]   NVARCHAR (10)  NULL,
    [DataNascimento] DATE           NULL,
    [Email]          NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ClienteID] ASC)
);

go
     

CREATE TABLE [dbo].[Apolices] (
    [ApoliceID]      INT           NOT NULL,
    [ClienteID]      INT           NULL,
    [Marca]          INT           NULL,
    [Modelo]         INT           NULL,
    [AnoFabricacao]  INT           NULL,
    [AnoModelo]      INT           NULL,
    [Combustivel]    TINYINT       NULL,
    [Chassi]         NVARCHAR (17) NOT NULL,
    [Placa]          NVARCHAR (10) NOT NULL,
    [Roubo]          BIT           NULL,
    [Vidros]         BIT           NULL,
    [Acidentes]      BIT           NULL,
    [DanosTerceiros] BIT           NULL,
    [FranquiaRed]    BIT           NULL,
    [ValorDoBem]     MONEY         NULL,
    [ValorFranquia]  MONEY         NULL,
    [ValorApolice]   MONEY         NULL,
    [ValorPremio]    MONEY         NULL,
    PRIMARY KEY CLUSTERED ([ApoliceID] ASC),
    CONSTRAINT [FK_Apolices_Clientes] FOREIGN KEY ([ClienteID]) REFERENCES [dbo].[Clientes] ([ClienteID]),
    CONSTRAINT [FK_Apolices_Marcas] FOREIGN KEY ([Marca]) REFERENCES [dbo].[Marcas] ([ID]),
    CONSTRAINT [FK_Apolices_Modelos] FOREIGN KEY ([Modelo]) REFERENCES [dbo].[Modelos] ([ModeloID])
);





