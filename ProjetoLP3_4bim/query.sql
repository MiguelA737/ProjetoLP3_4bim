--0 (NO CASO DO DB N�O EXISTIR)
DROP DATABASE Livrarias

--1
CREATE DATABASE Livrarias

--2
USE Livrarias

--3
CREATE TABLE Pais (

	idPais INTEGER PRIMARY KEY IDENTITY,
	nomePais VARCHAR(60) NOT NULL

)

CREATE TABLE Bairro (

	idBairro INTEGER PRIMARY KEY IDENTITY,
	Pais_idPais INTEGER REFERENCES Pais(idPais) NOT NULL,
	nomeBairro VARCHAR(60) NOT NULL

)

CREATE TABLE Rua (

	idRua INTEGER PRIMARY KEY IDENTITY,
	Bairro_idBairro INTEGER REFERENCES Bairro(idBairro) NOT NULL,
	nomeRua VARCHAR(60) NOT NULL

)

CREATE TABLE Endereco (

	idEndereco INTEGER PRIMARY KEY IDENTITY,
	Rua_idRua INTEGER REFERENCES Rua(idRua) NOT NULL,
	numeroEndereco INTEGER NOT NULL

)

CREATE TABLE Livraria (

	idLivraria INTEGER PRIMARY KEY IDENTITY,
	Endereco_idEndereco INTEGER REFERENCES Endereco(idEndereco) NOT NULL,
	nomeLivraria VARCHAR(60) NOT NULL,
	telLivraria VARCHAR(11) NOT NULL,
	emailLivraria VARCHAR(20) NOT NULL

)

CREATE TABLE Usuario (

	idUsuario INTEGER PRIMARY KEY IDENTITY,
	nomeUsuario VARCHAR(60) NOT NULL,
	dataNascUsuario DATE NOT NULL,
	telUsuario VARCHAR(11) NOT NULL,
	emailUSUARIO VARCHAR(20) NOT NULL

)

CREATE TABLE GeneroLivro (

	idGeneroLivro INTEGER PRIMARY KEY IDENTITY,
	nomeGeneroLivro VARCHAR(60) NOT NULL,
	desGeneroLivro VARCHAR(100)

)

CREATE TABLE Editora (

	idEditora INTEGER PRIMARY KEY IDENTITY,
	nomeEditora VARCHAR(60) NOT NULL,
	telEditora VARCHAR(11) NOT NULL,
	emailEditora VARCHAR(20) NOT NULL

)

CREATE TABLE Autor (

	idAutor INTEGER PRIMARY KEY IDENTITY,
	nomeAutor VARCHAR(60) NOT NULL,
	dataNascAutor DATE NOT NULL,
	nacionalidadeAutor VARCHAR(20),
	telAutor VARCHAR(11) NOT NULL,
	emailAutor VARCHAR(20) NOT NULL

)

CREATE TABLE Livro (

	idLivro INTEGER PRIMARY KEY IDENTITY,
	Editora_idEditora INTEGER REFERENCES Editora(idEditora) NOT NULL,
	GeneroLivro_idGeneroLivro INTEGER REFERENCES GeneroLivro(idGeneroLivro) NOT NULL,
	Autor_idAutor INTEGER REFERENCES Autor(idAutor) NOT NULL,
	tituloLivro VARCHAR(60) NOT NULL,
	dataLancamentoLivro DATE NOT NULL,
	qtdPaginasLivro INTEGER NOT NULL,
	precoLivro DECIMAL NOT NULL,
	sinopseLivro VARCHAR(100)

)

CREATE TABLE Compra (

	idCompra INTEGER PRIMARY KEY IDENTITY,
	Livro_idLivro INTEGER REFERENCES Livro(idLivro) NOT NULL,
	Usuario_idUsuario INTEGER REFERENCES Usuario(idUsuario) NOT NULL

)

CREATE TABLE Estoque (

	idEstoque INTEGER PRIMARY KEY IDENTITY,
	Livro_idLivro INTEGER REFERENCES Livro(idLivro) NOT NULL,
	Livraria_idLivraria INTEGER REFERENCES Livraria(idLivraria) NOT NULL,
	qtdLivro INTEGER NOT NULL

)