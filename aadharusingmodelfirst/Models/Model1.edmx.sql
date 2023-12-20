
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/07/2023 11:10:43
-- Generated from EDMX file: E:\Aman\aadharusingmodelfirst\aadharusingmodelfirst\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Aadharmodeldemoes'
CREATE TABLE [dbo].[Aadharmodeldemoes] (
    [Aadhar_number] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Fathers_name] nvarchar(max)  NOT NULL,
    [Dob] datetime  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Aadhar_number] in table 'Aadharmodeldemoes'
ALTER TABLE [dbo].[Aadharmodeldemoes]
ADD CONSTRAINT [PK_Aadharmodeldemoes]
    PRIMARY KEY CLUSTERED ([Aadhar_number] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------