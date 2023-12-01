-- Inserir uma ONG
INSERT INTO ong (cnpj, inscr_municipal, telefone, celular, email)
VALUES ('12.345.678/0001-90', '12345-678', '987654321', '987654321', 'ong@email.com');

-- Inserir um endereço para a ONG
INSERT INTO ong_endereco (ong_id, cep, logradouro, numero, bairro, cidade, UF)
VALUES (1, '12345-678', 'Rua Principal', '123', 'Centro', 'Cidade A', 'SP');

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


-- Janeiro
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor)
VALUES
    (1, '2023-01-01', 'Pagamento de Salários', 1, 1, -5000.00),
    (1, '2023-01-02', 'Doação da Empresa XYZ', 9, 2, 10000.00),
    (1, '2023-01-03', 'Compra de Material Pedagógico', 5, 3, -3000.00),
    (1, '2023-01-04', 'Receita com Venda de Produtos', 8, 4, 8000.00),
    (1, '2023-01-05', 'Pagamento de Contas de Energia', 6, 1, -200.00),
    (1, '2023-01-06', 'Doação Individual', 9, 2, 600.00),
    (1, '2023-01-07', 'Manutenção de Equipamentos', 7, 3, -1500.00),
    (1, '2023-01-08', 'Receita com Venda de Produtos', 8, 4, 4000.00),
    (1, '2023-01-09', 'Despesas Administrativas', 2, 1, -1000.00),
    (1, '2023-01-10', 'Doação de Parceiro', 9, 2, 3000.00),
    (1, '2023-01-11', 'Palestra Educacional', 3, 3, -500.00),
    (1, '2023-01-12', 'Receita com Venda de Produtos', 8, 4, 2000.00),
    (1, '2023-01-13', 'Despesas Diversas', 1, 1, -300.00),
    (1, '2023-01-14', 'Doação de Voluntário', 9, 2, 1200.00),
    (1, '2023-01-15', 'Compra de Livros', 5, 3, -200.00),
    (1, '2023-01-16', 'Receita com Venda de Produtos', 8, 4, 800.00),
    (1, '2023-01-17', 'Despesas Operacionais', 4, 1, -100.00),
    (1, '2023-01-18', 'Doação Anônima', 9, 2, 400.00),
    (1, '2023-01-19', 'Ação de Natal', 10, 3, -50.00),
    (1, '2023-01-20', 'Ações Diversas', 3, 4, 200.00);

-- Fevereiro
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor)
VALUES
    (1, '2023-02-01', 'Pagamento de Salários', 1, 1, -4800.00),
    (1, '2023-02-02', 'Doação de Pessoa Física', 9, 2, 1500.00),
    (1, '2023-02-03', 'Compra de Equipamentos', 5, 3, -2500.00),
    (1, '2023-02-04', 'Receita com Cursos', 8, 4, 6000.00),
    (1, '2023-02-05', 'Pagamento de Contas de Água', 6, 1, -150.00),
    (1, '2023-02-06', 'Doação Individual', 9, 2, 700.00),
    (1, '2023-02-07', 'Despesas Administrativas', 2, 1, -1200.00),
    (1, '2023-02-08', 'Receita com Venda de Produtos', 8, 4, 3500.00),
    (1, '2023-02-09', 'Doação de Empresa', 9, 2, 2000.00),
    (1, '2023-02-10', 'Evento de Captação de Recursos', 3, 3, -800.00),
    (1, '2023-02-11', 'Receita com Venda de Serviços', 8, 4, 1800.00),
    (1, '2023-02-12', 'Despesas Operacionais', 4, 1, -300.00),
    (1, '2023-02-13', 'Doação Anônima', 9, 2, 500.00),
    (1, '2023-02-14', 'Ação de Voluntariado', 10, 3, -50.00);

-- Março
INSERT INTO mov_financeira (ong_id, data_mov, descricao, conta_id, ativo_id, valor)
VALUES
    (1, '2023-03-01', 'Pagamento de Salários', 1, 1, -5200.00),
    (1, '2023-03-02', 'Doação de Pessoa Jurídica', 9, 2, 12000.00),
    (1, '2023-03-03', 'Compra de Material de Escritório', 5, 3, -1500.00),
    (1, '2023-03-04', 'Receita com Workshop', 8, 4, 5000.00),
    (1, '2023-03-05', 'Pagamento de Contas de Internet', 6, 1, -180.00),
    (1, '2023-03-06', 'Doação Individual', 9, 2, 800.00),
    (1, '2023-03-07', 'Manutenção de Equipamentos', 7, 3, -2000.00),
    (1, '2023-03-08', 'Receita com Venda de Produtos', 8, 4, 6000.00),
    (1, '2023-03-09', 'Despesas Administrativas', 2, 1, -800.00),
    (1, '2023-03-10', 'Doação de Parceiro', 9, 2, 2500.00),
    (1, '2023-03-11', 'Palestra Educacional', 3, 3, -600.00),
    (1, '2023-03-12', 'Receita com Venda de Produtos', 8, 4, 3000.00),
    (1, '2023-03-13', 'Despesas Diversas', 1, 1, -400.00),
    (1, '2023-03-14', 'Doação de Voluntário', 9, 2, 900.00),
    (1, '2023-03-15', 'Compra de Livros', 5, 3, -300.00);

-- Inserir doadores
-- Inserir doadores com telefone no formato (DDD + telefone)
INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email)
VALUES
    ('Pessoa Física', '111.222.333-44', 'Doador 1', '1990-01-01', '(11) 1111-1111', 'doador1@email.com'),
    ('Pessoa Jurídica', '00.123.456/0001-99', 'Empresa 1', NULL, '(22) 2222-2222', 'empresa1@email.com'),
    ('Pessoa Física', '555.666.777-88', 'Doador 2', '1985-05-05', '(33) 3333-3333', 'doador2@email.com'),
    ('Pessoa Física', '999.888.777-66', 'Doador 3', '1978-10-15', '(44) 4444-4444', 'doador3@email.com'),
    ('Pessoa Jurídica', '99.888.777/0002-66', 'Empresa 2', NULL, '(55) 5555-5555', 'empresa2@email.com'),
    ('Pessoa Física', '444.555.666-77', 'Doador 4', '1992-03-20', '(66) 6666-6666', 'doador4@email.com'),
    ('Pessoa Jurídica', '11.222.333/0002-44', 'Empresa 3', NULL, '(77) 7777-7777', 'empresa3@email.com'),
    ('Pessoa Física', '777.888.999-00', 'Doador 5', '1980-12-25', '(88) 8888-8888', 'doador5@email.com'),
    ('Pessoa Física', '123.456.789-09', 'Doador 6', '1987-06-30', '(99) 9999-9999', 'doador6@email.com'),
    ('Pessoa Jurídica', '33.444.555/0001-11', 'Empresa 4', NULL, '(00) 0000-0000', 'empresa4@email.com');

    
-- Inserir beneficiários
INSERT INTO beneficiarios (nome_beneficiario, rg, orgao_emissor, telefone, email, data_nasc)
VALUES
    ('Maria Silva', '1234567', 'SSP', '(11) 98765-4321', 'maria@email.com', '1990-05-15'),
    ('João Santos', '7654321', 'SSP', '(21) 98765-4321', 'joao@email.com', '1985-02-20'),
    ('Ana Oliveira', '9876543', 'SSP', '(31) 98765-4321', 'ana@email.com', '1998-09-10'),
    ('Carlos Pereira', '5432167', 'SSP', '(41) 98765-4321', 'carlos@email.com', '1973-12-25'),
    ('Fernanda Lima', '8765432', 'SSP', '(51) 98765-4321', 'fernanda@email.com', '1988-07-03'),
    ('Ricardo Souza', '2345678', 'SSP', '(61) 98765-4321', 'ricardo@email.com', '1970-11-18'),
    ('Luciana Santos', '4567890', 'SSP', '(71) 98765-4321', 'luciana@email.com', '1995-03-30'),
    ('Pedro Almeida', '7890123', 'SSP', '(81) 98765-4321', 'pedro@email.com', '1982-08-12'),
    ('Isabel Pereira', '3210987', 'SSP', '(91) 98765-4321', 'isabel@email.com', '1978-06-05'),
    ('Felipe Costa', '6543210', 'SSP', '(01) 98765-4321', 'felipe@email.com', '1992-04-28');

