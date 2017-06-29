IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Clients] (
    [Id] int NOT NULL IDENTITY,
    [DateEnded] datetime2 NOT NULL,
    [DateStarded] datetime2 NOT NULL,
    [FirstName] nvarchar(max),
    [LastName] nvarchar(max),
    [PhoneNumber] float NOT NULL,
    [RoomId] int NOT NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Rooms] (
    [Id] int NOT NULL IDENTITY,
    [Capacity] int NOT NULL,
    [Description] nvarchar(max),
    [IsReserved] bit NOT NULL,
    [PricePerDay] float NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20170628150622_Init', N'1.1.2');

GO

