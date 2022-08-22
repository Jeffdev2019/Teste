CREATE TABLE TBUsuarios
(
	IdUsuarios int identity(1,1) primary key,
	Nome varchar(50) not null,
	SobreNome varchar(50) not null,
	Email varchar(50) not null,
	DataDeNascimento DateTime not null,
	IdEscolaridade int null,
	IdhistoricoEscolar int null
)

CREATE TABLE TBEscolaridade
(
	IdEscolaridade int identity(1,1) primary key,
	Descricao varchar(200)
)

CREATE TABLE TBHistoricoEscolar
(
	IdhistoricoEscolar int identity(1,1) primary key,
	Formato varchar(10) not null,
	Nome varchar(50) not null,
	FileBase64 nvarchar(max) NOT NULL
)

ALTER TABLE TBUsuarios
	ADD CONSTRAINT FK_IdEscolaridade FOREIGN KEY (IdEscolaridade)
      REFERENCES TBEscolaridade (IdEscolaridade)

ALTER TABLE TBUsuarios
	ADD CONSTRAINT FK_IdHistoricoEscolar FOREIGN KEY (IdhistoricoEscolar)
      REFERENCES TBHistoricoEscolar (IdhistoricoEscolar)