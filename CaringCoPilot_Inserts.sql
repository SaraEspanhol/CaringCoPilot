USE caring_copilot;

INSERT INTO ong_responsavel (nome, telefone, celular, email, cpf)
	VALUES('Joaquim', '11564894', '54849846', 'teste@teste.com', '987.654.321-66');

INSERT INTO ong (cnpj, inscr_municipal, telefone, celular, email, responsavel_id)
	VALUES('123.456/0001-22', '156165', '119645862', '52165165', 'teste@teste.com', 1);

INSERT INTO ativos (descr_ativo) VALUE ('Caixa');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Luz');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Bazar');
    
SELECT * FROM contas;
SELECT * FROM ativos;

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id) 
	VALUES (1, '2006-10-18', 'teste2', 1, 1, 658.39, 1);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id) 
	VALUES (1, '1998-10-16', 'teste3', 2, 1, 427.55, 1);
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id) 
	VALUES (1, '1997-10-16', 'teste4', 1, 1, 848.48, 1);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id) 
	VALUES (1, '1996-10-16', 'teste5', 2, 1, 116.8, 1);
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id) 
	VALUES (1, '1995-10-16', 'teste6', 2, 1, 979.47, 1);

SELECT mov_financeira.id, data_mov, mov_financeira.descricao, descr_conta, ativos.descr_ativo, valor, doadores.nome
	FROM mov_financeira JOIN contas 
		ON mov_financeira.conta_id = contas.id JOIN ativos
		ON mov_financeira.ativo_id = ativos.idAtivos JOIN doadores
        ON doadores.id = mov_financeira.doador_id

