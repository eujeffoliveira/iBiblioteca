-- Cria��o do banco de dados

CREATE DATABASE DB_IBIBLIOTECA;

GO

-- Uso do banco de dados

USE DB_IBIBLIOTECA;

GO

-- Cria��o da tabela TBAUTOR

CREATE TABLE TBAUTOR (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NOME VARCHAR(50) NOT NULL,
    SOBRENOME VARCHAR(50) NOT NULL,
    NOME_COMPLETO AS (NOME + ' ' + SOBRENOME) PERSISTED,
    NACIONALIDADE VARCHAR(50) NOT NULL
);

GO

-- Cria��o da tabela TBEDITORA

CREATE TABLE TBEDITORA (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NOME VARCHAR(50) NOT NULL
);

GO

-- Cria��o da tabela TBCOLECAO

CREATE TABLE TBCOLECAO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NOME VARCHAR(50) NOT NULL
);

GO

-- Cria��o da tabela TBCAPA_LIVRO

CREATE TABLE TBCAPA_LIVRO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NOME VARCHAR(50) NOT NULL,
    CAPA VARBINARY(MAX) NOT NULL,
    CAMINHO VARCHAR(255)
);

GO

-- Cria��o da tabela TBLIVRO

CREATE TABLE TBLIVRO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TITULO VARCHAR(100) NOT NULL,
    ID_AUTOR INT NOT NULL,
    DATA_PUBLICACAO DATE NOT NULL,
    ISBN VARCHAR(20) NOT NULL,
    ID_EDITORA INT NOT NULL,
    PAGINAS INT NOT NULL,
    PRECO DECIMAL(10, 2) NOT NULL,
    ID_CAPA INT,
    ID_COLECAO INT,
    CONSTRAINT FK_LIVRO_AUTOR FOREIGN KEY (ID_AUTOR) REFERENCES TBAUTOR(ID),
    CONSTRAINT FK_LIVRO_EDITORA FOREIGN KEY (ID_EDITORA) REFERENCES TBEDITORA(ID),
    CONSTRAINT FK_LIVRO_CAPA FOREIGN KEY (ID_CAPA) REFERENCES TBCAPA_LIVRO(ID),
    CONSTRAINT FK_LIVRO_COLECAO FOREIGN KEY (ID_COLECAO) REFERENCES TBCOLECAO(ID)
);

GO

-- Adiciona �ndices � tabela TBLIVRO

CREATE INDEX IX_TBLIVRO_TITULO ON TBLIVRO (TITULO);
CREATE INDEX IX_TBLIVRO_ID_AUTOR ON TBLIVRO (ID_AUTOR);
CREATE INDEX IX_TBLIVRO_ISBN ON TBLIVRO (ISBN);

GO

