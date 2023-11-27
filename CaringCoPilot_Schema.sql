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
    cpf CHAR (14) NOT NULL UNIQUE,
    usuario VARCHAR (30) NOT NULL UNIQUE,
    senha VARCHAR (100) NOT NULL
);

CREATE TABLE ong (
	id INT PRIMARY KEY AUTO_INCREMENT,
	cnpj CHAR (18) NOT NULL UNIQUE,
    inscr_municipal CHAR (15) NOT NULL UNIQUE,
    telefone VARCHAR (14) NOT NULL,
    celular VARCHAR (14) NOT NULL,
    email VARCHAR (100) NOT NULL
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

# ****************************************
# CRIACAO DOS DOADORES
# ****************************************


CREATE TABLE doadores (
	id INT PRIMARY KEY AUTO_INCREMENT,
    tipo_doador VARCHAR (20) NOT NULL,
    documento CHAR (18) NOT NULL UNIQUE,
    nome VARCHAR (100) NOT NULL,
    data_nasc DATE,
    telefone VARCHAR (15),
    email VARCHAR (100)
	
);

# ****************************************
# CRIACAO DAS CONTAS E MOV FIN
# ****************************************

CREATE TABLE contas (
	id INT PRIMARY KEY AUTO_INCREMENT,
    tipo_conta VARCHAR (50) NOT NULL,
	descr_conta VARCHAR (50) NOT NULL UNIQUE
);

CREATE TABLE ativos (
	idAtivos INT PRIMARY KEY AUTO_INCREMENT,
    descr_ativo VARCHAR (50) NOT NULL UNIQUE
);

CREATE TABLE mov_financeira (
	id INT PRIMARY KEY AUTO_INCREMENT,
    ong_id INT NOT NULL,
    data_mov DATE NOT NULL,
    descricao VARCHAR (100) NOT NULL,
    conta_id INT NOT NULL,
    ativo_id INT NOT NULL,
    valor DOUBLE NOT NULL,
    FOREIGN KEY (conta_id) REFERENCES contas(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (ativo_id) REFERENCES ativos(idAtivos)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
	FOREIGN KEY (ong_id) REFERENCES ong(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);

# ****************************************
# CRIACAO DOS VOLUNTARIOS 
# ****************************************

CREATE TABLE pessoa (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR (100) NOT NULL,
    data_nasc DATE NOT NULL,
    cpf CHAR (14) NOT NULL UNIQUE
    );

CREATE TABLE voluntario (
	pessoa_id INT PRIMARY KEY NOT NULL,
    profissao VARCHAR (50),
    menor BOOL NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE responsavel (
	pessoa_id INT PRIMARY KEY NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE telefone (
	pessoa_id INT PRIMARY KEY NOT NULL,
	telefone VARCHAR (14) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE email (
	pessoa_id INT PRIMARY KEY NOT NULL,
	email VARCHAR (100) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE rg (
	pessoa_id INT PRIMARY KEY NOT NULL,
	rg VARCHAR (20) NOT NULL,
    digito VARCHAR (2),
    orgao_emissor VARCHAR (20) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE endereco (
	pessoa_id INT PRIMARY KEY NOT NULL,
	cep VARCHAR(10) NOT NULL,
    logradouro varchar(150) NOT NULL,
    numero VARCHAR (20) NOT NULL,
    bairro VARCHAR (50) NOT NULL,
    cidade VARCHAR (50) NOT NULL,
    UF CHAR(2) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE voluntario_responsavel (
	id INT PRIMARY KEY AUTO_INCREMENT,
    voluntario_id INT NOT NULL UNIQUE,
    responsavel_id INT NOT NULL,
    FOREIGN KEY (voluntario_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE,
	FOREIGN KEY (responsavel_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);


CREATE TABLE atividade (
	id INT PRIMARY KEY AUTO_INCREMENT,
    voluntario_id INT NOT NULL,
	mes_ano DATE NOT NULL,
    descricao VARCHAR (150) NOT NULL,
    salario_mercado DOUBLE NOT NULL,
    qtde_horas DOUBLE NOT NULL,
    FOREIGN KEY (voluntario_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE servico_termo (
	id INT PRIMARY KEY AUTO_INCREMENT,
    voluntario_id INT NOT NULL,
    mes_ano DATE NOT NULL,
    dia_semana VARCHAR(30) NOT NULL,
    horario TIME NOT NULL,
    local_servico VARCHAR(100) NOT NULL,
    caracteristicas VARCHAR(150) NOT NULL,
    FOREIGN KEY (voluntario_id) REFERENCES pessoa(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

# ****************************************
# CRIACAO DO ESTOQUE
# ****************************************

CREATE TABLE produto (
	id INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR (100) NOT NULL,
    valor_unitario DOUBLE NOT NULL
);

CREATE TABLE bazar (
	id INT PRIMARY KEY AUTO_INCREMENT,
    data_bazar DATE NOT NULL,
    descricao VARCHAR (100) NOT NULL
);

CREATE TABLE mov_estoque (
	id INT PRIMARY KEY AUTO_INCREMENT,
    data_mov DATE NOT NULL,
    produto_id INT NOT NULL,
    qtde INT NOT NULL,
    entrada_saida BOOL NOT NULL,
    FOREIGN KEY (produto_id) REFERENCES produto(id)
		ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE beneficiarios (
	pessoa_id INT PRIMARY KEY AUTO_INCREMENT,
	nome_beneficiario VARCHAR (100) NOT NULL,
	rg VARCHAR (20) NOT NULL,
    orgao_emissor VARCHAR (20) NOT NULL,
    telefone VARCHAR (15) NOT NULL,
    email VARCHAR (100) NOT NULL,
    data_nasc DATE NOT NULL
	
);

CREATE TABLE doacao_recebida (
	mov_id INT PRIMARY KEY NOT NULL,
    doador_id INT NOT NULL,
    data_doacao DATE NOT NULL,
    descricao VARCHAR (150),
    FOREIGN KEY (mov_id) REFERENCES mov_estoque(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
	FOREIGN KEY (doador_id) REFERENCES doadores(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);
    
CREATE TABLE doacao_efetuada (
	mov_id INT PRIMARY KEY NOT NULL,
    data_doacao DATE NOT NULL,
    beneficiario_id INT NOT NULL,
    descricao VARCHAR (150),
    FOREIGN KEY (mov_id) REFERENCES mov_estoque(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT,
	FOREIGN KEY (beneficiario_id) REFERENCES beneficiarios(pessoa_id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE mov_bazar (
	mov_id INT PRIMARY KEY NOT NULL,
    bazar_id INT NOT NULL,
	FOREIGN KEY (bazar_id) REFERENCES bazar(id)
		ON UPDATE CASCADE
        ON DELETE RESTRICT
)
