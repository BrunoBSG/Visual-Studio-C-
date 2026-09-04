CREATE DATABASE dbBiblioteca

GO
USE dbBiblioteca
GO

CREATE TABLE Livro(
idLivro INT PRIMARY KEY IDENTITY(1,1),
Nome char,
Categoria char,
Quantidade int
);

ALTER TABLE Livro

ALTER COLUMN Categoria VARCHAR(100);
select * from Livro

truncate table Livro