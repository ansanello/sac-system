
-- SCRIPT DE CRIAÇÃO DO BANCO DE DADOS

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'cliente'))
BEGIN
    CREATE TABLE cliente (
    ClienteID int IDENTITY(1,1) PRIMARY KEY,
    Nome varchar(255) NOT NULL
);
END
GO


IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'departamento'))
BEGIN
    CREATE TABLE departamento (
    departamentoID int IDENTITY(1,1) PRIMARY KEY,
    Nome varchar(255) NOT NULL
);
END
GO

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuario'))
BEGIN
    CREATE TABLE usuario (
    usuarioID int IDENTITY(1,1) PRIMARY KEY,
    Nome varchar(255) NOT NULL,
    Email varchar(255) NOT NULL,
    Senha varchar(10) NOT NULL,
    Foto varchar(50) NULL
);
END
GO

IF (NOT EXISTS (SELECT * FROM usuario WHERE Email = 'admin@uni.com.br'))
BEGIN
    INSERT INTO usuario (nome, email, senha, foto) values ('admin', 'admin@uni.com.br', '123456', 'user.png')
END
GO
