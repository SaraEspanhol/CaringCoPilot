DROP SCHEMA IF EXISTS caring_copilot;
CREATE SCHEMA caring_copilot;

USE caring_copilot;

# ****************************************
# CRIAÇÃO DA ONG
# ****************************************

CREATE TABLE ong_responsavel (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR (100) NOT NULL,
    telefone VARCHAR (14) NOT NULL,
    celular VARCHAR (14) NOT NULL, 
    email VARCHAR (100) NOT NULL,
    cpf CHAR (14) NOT NULL UNIQUE
);

CREATE TABLE ong (
	id INT PRIMARY KEY AUTO_INCREMENT,
	cnpj CHAR (18) NOT NULL UNIQUE,
    inscr_municipal CHAR (15) NOT NULL UNIQUE,
    telefone VARCHAR (14) NOT NULL,
    celular VARCHAR (14) NOT NULL,
    email VARCHAR (100) NOT NULL,
    responsavel_id INT NOT NULL,
    FOREIGN KEY(responsavel_id) REFERENCES ong_responsavel(id)
		ON UPDATE CASCADE
		ON DELETE RESTRICT
);

CREATE TABLE ong_endereco (
	ong_id INT PRIMARY KEY,
    cep VARCHAR(10) NOT NULL,
    logradouro varchar(150) NOT NULL,
    numero VARCHAR (20) NOT NULL,
    bairro VARCHAR (50) NOT NULL,
    cidade VARCHAR (50) NOT NULL,
    UF CHAR(2) NOT NULL,
	FOREIGN KEY(ong_id) REFERENCES ong(id)
		ON UPDATE CASCADE
		ON DELETE RESTRICT
);


CREATE TABLE acesso (
	responsavel_id INT PRIMARY KEY NOT NULL,
    usuario VARCHAR (30) NOT NULL UNIQUE,
    senha VARCHAR (30) NOT NULL,
    FOREIGN KEY (responsavel_id) REFERENCES ong_responsavel(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);

# ****************************************
# CRIACAO DOS DOADORES
# ****************************************

CREATE TABLE tipo_doador (
	id BOOL PRIMARY KEY NOT NULL UNIQUE,
    tipo CHAR (2) NOT NULL
);

INSERT INTO tipo_doador (id, tipo) VALUES (1, 'PF');
INSERT INTO tipo_doador (id, tipo) VALUES (0, 'PJ');

CREATE TABLE doadores (
	id INT PRIMARY KEY AUTO_INCREMENT,
    tipo_doador BOOL NOT NULL,
    documento CHAR (18) NOT NULL UNIQUE,
    nome VARCHAR (100) NOT NULL,
    data_nasc DATE,
    telefone VARCHAR (14),
    email VARCHAR (100),
	FOREIGN KEY (tipo_doador) REFERENCES tipo_doador(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);

INSERT INTO doadores (tipo_doador, documento, nome) VALUES (1, 0, 'Anonimo');
INSERT INTO doadores (tipo_doador, documento, nome) VALUES (0, 1, 'Anonimo');

# ****************************************
# CRIACAO DAS CONTAS E MOV FIN
# ****************************************

CREATE TABLE tipo_contas (
	id BOOL PRIMARY KEY NOT NULL UNIQUE,
    tipo VARCHAR (7) NOT NULL
);

# Insere na tabela tipo_contas os tipos "ENTRADA" e "SAIDA"

INSERT INTO tipo_contas (id, tipo) VALUES (1, 'Entrada');
INSERT INTO tipo_contas (id, tipo) VALUES (0, 'Saída');


CREATE TABLE contas (
	id INT PRIMARY KEY AUTO_INCREMENT,
    tipo_conta BOOL NOT NULL,
	descr_conta VARCHAR (20) NOT NULL UNIQUE,
    FOREIGN KEY (tipo_conta) REFERENCES tipo_contas(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE ativos (
	id INT PRIMARY KEY AUTO_INCREMENT,
	descr_ativo VARCHAR (20) NOT NULL UNIQUE
);

CREATE TABLE mov_financeira (
	id INT PRIMARY KEY AUTO_INCREMENT,
    ong_id INT NOT NULL,
    data_mov DATE NOT NULL,
    descricao VARCHAR (100) NOT NULL,
    conta_id INT NOT NULL,
    ativo_id INT NOT NULL,
    valor DOUBLE NOT NULL,
    doador_id INT NOT NULL,
    FOREIGN KEY (conta_id) REFERENCES contas(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (ativo_id) REFERENCES ativos(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (doador_id) REFERENCES doadores(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
	FOREIGN KEY (ong_id) REFERENCES ong(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);


