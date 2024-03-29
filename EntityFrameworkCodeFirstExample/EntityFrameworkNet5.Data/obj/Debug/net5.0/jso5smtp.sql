﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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

CREATE TABLE [Leagues] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Leagues] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Teams] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [LeaugeId] int NOT NULL,
    [LeagueId] int NULL,
    CONSTRAINT [PK_Teams] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Teams_Leagues_LeagueId] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Teams_LeagueId] ON [Teams] ([LeagueId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220605180208_InitialMigration', N'5.0.0');
GO

COMMIT;
GO

