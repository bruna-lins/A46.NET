IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Agendamento] (
    [Id_Agendamento] int NOT NULL IDENTITY,
    [Id_Viagem] int NOT NULL,
    [Id_Cliente] int NOT NULL,
    [Num_Voo] int NOT NULL,
    [Assento] int NOT NULL,
    CONSTRAINT [PK_Agendamento] PRIMARY KEY ([Id_Agendamento])
);
GO

CREATE TABLE [Destinos] (
    [Id_Destino] int NOT NULL IDENTITY,
    [Nome_Dest] nvarchar(40) NOT NULL,
    [Pais] nvarchar(40) NOT NULL,
    [Preco] money NOT NULL,
    [Status] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Destinos] PRIMARY KEY ([Id_Destino])
);
GO

CREATE TABLE [Origem] (
    [Id_Origem] int NOT NULL IDENTITY,
    [Nome_Ori] nvarchar(40) NOT NULL,
    [Pais] nvarchar(40) NOT NULL,
    CONSTRAINT [PK_Origem] PRIMARY KEY ([Id_Origem])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(40) NOT NULL,
    [Email] nvarchar(40) NOT NULL,
    [CPF] char(11) NOT NULL,
    [Endereco] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Viagem] (
    [Id_Viagem] int NOT NULL IDENTITY,
    [Id_Origem] int NOT NULL,
    [Id_Destino] nvarchar(max) NOT NULL,
    [Id_Pagamento] nvarchar(max) NOT NULL,
    [Tipo_pag] nvarchar(max) NOT NULL,
    [Parcelas] int NOT NULL,
    [data_pagamento] date NOT NULL,
    CONSTRAINT [PK_Viagem] PRIMARY KEY ([Id_Viagem])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211220151508_AgenciaMigration', N'5.0.13');
GO

COMMIT;
GO

