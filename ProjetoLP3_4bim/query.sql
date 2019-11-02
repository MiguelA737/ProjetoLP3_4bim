--0 (NO CASO DO DB NÃO EXISTIR)
DROP DATABASE Livrarias

--1
CREATE DATABASE Livrarias

--2
USE Livrarias

--3
CREATE TABLE Pais (

	idPais INTEGER PRIMARY KEY IDENTITY,
	nomePais VARCHAR NOT NULL

)

CREATE TABLE Bairro (

	idBairro INTEGER PRIMARY KEY IDENTITY,
	Pais_idPais INTEGER REFERENCES Pais(idPais) NOT NULL,
	nomeBairro VARCHAR NOT NULL

)

CREATE TABLE Rua (

	idRua INTEGER PRIMARY KEY IDENTITY,
	Bairro_idBairro INTEGER REFERENCES Bairro(idBairro) NOT NULL,
	nomeRua VARCHAR NOT NULL

)

CREATE TABLE Endereco (

	idEndereco INTEGER PRIMARY KEY IDENTITY,
	Rua_idRua INTEGER REFERENCES Rua(idRua) NOT NULL,
	numeroEndereco INTEGER NOT NULL

)

CREATE TABLE Livraria (

	idLivraria INTEGER PRIMARY KEY IDENTITY,
	Endereco_idEndereco INTEGER REFERENCES Endereco(idEndereco) NOT NULL,
	nomeLivraria VARCHAR NOT NULL,
	telLivraria VARCHAR(11) NOT NULL,
	emailLivraria VARCHAR NOT NULL

)

CREATE TABLE Usuario (

	idUsuario INTEGER PRIMARY KEY IDENTITY,
	nomeUsuario VARCHAR NOT NULL,
	dataNascUsuario DATE NOT NULL,
	telUsuario VARCHAR(11) NOT NULL,
	emailUSUARIO VARCHAR NOT NULL

)

CREATE TABLE GeneroLivro (

	idGeneroLivro INTEGER PRIMARY KEY IDENTITY,
	nomeGeneroLivro VARCHAR NOT NULL,
	desGeneroLivro TEXT

)

CREATE TABLE Editora (

	idEditora INTEGER PRIMARY KEY IDENTITY,
	nomeEditora VARCHAR NOT NULL,
	telEditora VARCHAR NOT NULL,
	emailEditora VARCHAR NOT NULL

)

CREATE TABLE Autor (

	idAutor INTEGER PRIMARY KEY IDENTITY,
	nomeAutor VARCHAR NOT NULL,
	dataNascAutor DATE NOT NULL,
	nacionalidadeAutor VARCHAR,
	telAutor VARCHAR(11) NOT NULL,
	emailAutor VARCHAR NOT NULL

)

CREATE TABLE Livro (

	idLivro INTEGER PRIMARY KEY IDENTITY,
	Editora_idEditora INTEGER REFERENCES Editora(idEditora) NOT NULL,
	GeneroLivro_idGeneroLivro INTEGER REFERENCES GeneroLivro(idGeneroLivro) NOT NULL,
	Autor_idAutor INTEGER REFERENCES Autor(idAutor) NOT NULL,
	tituloLivro VARCHAR NOT NULL,
	dataLancamentoLivro DATE NOT NULL,
	qtdPaginasLivro INTEGER NOT NULL,
	precoLivro DECIMAL NOT NULL,
	sinopseLivro TEXT

)

CREATE TABLE Compra (

	idCompra INTEGER PRIMARY KEY IDENTITY,
	Livro_idLivro INTEGER REFERENCES Livro(idLivro) NOT NULL,
	Usuario_idUsuario INTEGER REFERENCES Usuario(idUsuario) NOT NULL

)

CREATE TABLE Estoque (

	idEstoque INTEGER PRIMARY KEY IDENTITY,
	Livro_idLivro INTEGER REFERENCES Livro(idLivro) NOT NULL,
	qtdLivro INTEGER NOT NULL

)