USE caring_copilot;

# ****************************************
# Criação da ONG e cadastro do Responsável
# ****************************************

INSERT INTO ong_responsavel (nome, telefone, celular, email, cpf, usuario, senha)
	VALUES('Joaquim', '11564894', '54849846', 'teste@teste.com', '987.654.321-66', 'adm', 'adm');

INSERT INTO ong (cnpj, inscr_municipal, telefone, celular, email, responsavel_id)
	VALUES('123.456/0001-22', '156165', '119645862', '52165165', 'teste@teste.com', 1);
    
# ****************************************
# Cadastro dos doadores anonimos
# ****************************************
    
INSERT INTO doadores (tipo_doador, documento, nome) VALUES ('Pessoa Física', 0, 'Anonimo - PF');
INSERT INTO doadores (tipo_doador, documento, nome) VALUES ('Pessoa Jurídica', 1, 'Anonimo - PJ');

# ****************************************
# Inserção dos ATIVOS e CONTAS
# ****************************************

INSERT INTO ativos (descr_ativo) VALUE ('Caixa');

INSERT INTO ativos (descr_ativo) VALUE ('Banco do Brasil');

INSERT INTO ativos (descr_ativo) VALUE ('Banco Caixa');

INSERT INTO ativos (descr_ativo) VALUE ('Banco Santander');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'RH');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Encargos Sociais');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Fundo Reserva');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Alimentação');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Material Pedagógico');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Concessionária');
    
INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Saída', 'Oficineiro');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Venda de Bazar');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Doação');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Mensalidade de Associados');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Ação de Natal');

INSERT INTO contas (tipo_conta, descr_conta)
	VALUES ('Entrada', 'Ações Diversas');
    
# ****************************************
# Criação de movimentações financeiras
# ****************************************

-- Inserir dados na tabela mov_financeira (Entradas)
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-08', 'Venda de Bazar', 8, 1, 1600.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-09', 'Doação Financeira', 9, 1, 3000.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-10', 'Mensalidade de Associados', 10, 1, 2000.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-11', 'Ação de Natal', 11, 1, 800.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-12', 'Doação Financeira', 9, 1, 1000.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-13', 'Mensalidade de Associados', 10, 1, 1500.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-16', 'Ação de Natal', 11, 1, 1000.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-18', 'Doação Financeira', 9, 1, 1900.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-20', 'Ação de Natal', 11, 1, 700.00, NULL);

-- Inserir dados na tabela mov_financeira (Saídas)
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-01', 'Pagamento de Salários', 1, 1, -5000.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-02', 'Encargos Sociais', 2, 1, -1500.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-03', 'Fundo Reserva', 3, 1, -800.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-04', 'Alimentação', 4, 1, -500.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-05', 'Material Pedagógico', 5, 1, -800.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-06', 'Pagamento de Conta de Energia', 6, 1, -300.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-07', 'Pagamento a Oficineiro', 7, 1, -500.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-14', 'Pagamento de Conta de Água', 6, 1, -300.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-15', 'Alimentação', 4, 1, -500.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-17', 'Material Pedagógico', 5, 1, -200.00, NULL);

INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor, doador_id)
VALUES (1, '2023-01-19', 'Pagamento de Salários', 1, 1, -800.00, NULL);

-- Inserir dados na tabela doadores
INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES ('Pessoa Física', '111.111.111-11', 'Doador A', '1990-01-01', '1111-1111', 'doadorA@email.com');

INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES ('Pessoa Física', '222.222.222-22', 'Doador B', '1985-02-15', '2222-2222', 'doadorB@email.com');

INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES ('Pessoa Física', '333.333.333-33', 'Doador C', '1992-03-20', '3333-3333', 'doadorC@email.com');

INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES ('Pessoa Física', '444.444.444-44', 'Doador D', '1988-04-25', '4444-4444', 'doadorD@email.com');

INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES ('Pessoa Física', '555.555.555-55', 'Doador E', '1995-05-30', '5555-5555', 'doadorE@email.com');

# ****************************************
# Inserção dos BENEFICIARIOS e DOADORES
# ****************************************

-- Inserir dados na tabela beneficiarios
INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário A', '1234567', 'SSP', '1234-5678', 'beneficiarioA@email.com', '1998-07-10');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário B', '7654321', 'SSP', '2345-6789', 'beneficiarioB@email.com', '2000-09-15');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário C', '9876543', 'SSP', '3456-7890', 'beneficiarioC@email.com', '1996-11-20');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário D', '2345678', 'SSP', '4567-8901', 'beneficiarioD@email.com', '1993-01-25');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário E', '8765432', 'SSP', '5678-9012', 'beneficiarioE@email.com', '1990-03-30');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário F', '3456789', 'SSP', '6789-0123', 'beneficiarioF@email.com', '1997-05-05');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário G', '6543210', 'SSP', '7890-1234', 'beneficiarioG@email.com', '1994-07-10');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário H', '2109876', 'SSP', '8901-2345', 'beneficiarioH@email.com', '1991-09-15');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário I', '5678901', 'SSP', '9012-3456', 'beneficiarioI@email.com', '1998-11-20');

INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES ('Beneficiário J', '1098765', 'SSP', '0123-4567', 'beneficiarioJ@email.com', '1995-01-25');

