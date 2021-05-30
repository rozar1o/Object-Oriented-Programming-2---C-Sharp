CREATE TABLE [dbo].[Users] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [UserName]          NVARCHAR (50) NOT NULL,
    [EmailAddress]      NVARCHAR (50) NOT NULL,
    [UpdatedDate]       DATETIME      NOT NULL,
    [Password]          NVARCHAR (50) NOT NULL,
    [UserType]          INT           NOT NULL,
    [Information_given] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

