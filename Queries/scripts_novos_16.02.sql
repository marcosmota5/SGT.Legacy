-- Cria nova coluna na tabela de usuários e refaz os procedimentos

ALTER TABLE tb_usuarios ADD id_setor INT NOT NULL AFTER id_perfil;
UPDATE tb_usuarios SET id_setor = 1 WHERE id_usuario > 0;
ALTER TABLE tb_usuarios ADD FOREIGN KEY (id_setor) REFERENCES tb_setores (id_setor);

DROP PROCEDURE IF EXISTS sp_inserir_usuario;
DROP PROCEDURE IF EXISTS sp_editar_usuario;
DROP PROCEDURE IF EXISTS sp_efetua_login;

DELIMITER $$
CREATE PROCEDURE sp_inserir_usuario(
IN p_nome VARCHAR(60),
IN p_sexo VARCHAR(30),
IN p_cpf VARCHAR(30),
IN p_telefone VARCHAR(30),
IN p_email VARCHAR(60),
IN p_login VARCHAR(30),
IN p_senha VARCHAR(255),
IN p_id_status INT,
IN p_id_filial INT,
IN p_id_perfil INT,
IN p_id_setor INT,
IN p_data_cadastro DATETIME,
IN p_imagem LONGBLOB,
IN p_texto_resposta_email TEXT,
IN p_emails_copia TEXT,
OUT p_id_usuario INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE login=p_login)) THEN
SET p_mensagem='Valor já existe 1';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE login=p_login);
ELSE
IF(EXISTS(SELECT * FROM tb_usuarios WHERE cpf=p_cpf)) THEN
SET p_mensagem='Valor já existe 2';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE cpf=p_cpf);
ELSE
IF(EXISTS(SELECT * FROM tb_usuarios WHERE email=p_email)) THEN
SET p_mensagem='Valor já existe 3';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE email=p_email);
ELSE
INSERT INTO tb_usuarios 
(nome,
sexo,
cpf,
telefone,
email,
login,
senha,
id_status,
id_filial,
id_perfil,
id_setor,
data_cadastro,
data_ultima_alteracao_senha,
imagem,
texto_resposta_email,
emails_copia) 
VALUES 
(p_nome,
p_sexo,
p_cpf,
p_telefone,
p_email,
p_login,
SHA1(p_senha),
p_id_status,
p_id_filial,
p_id_perfil,
p_id_setor,
p_data_cadastro,
p_data_cadastro,
p_imagem,
p_texto_resposta_email,
p_emails_copia);
SET p_id_usuario = LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
END IF;
END IF;
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_usuario(
IN p_id_usuario INT,
IN p_nome VARCHAR(60),
IN p_sexo VARCHAR(30),
IN p_cpf VARCHAR(30),
IN p_telefone VARCHAR(30),
IN p_email VARCHAR(60),
IN p_login VARCHAR(30),
IN p_id_status INT,
IN p_id_filial INT,
IN p_id_perfil INT,
IN p_id_setor INT,
IN p_data_ultima_alteracao_login DATETIME,
IN p_data_ultima_alteracao_email DATETIME,
IN p_imagem LONGBLOB,
IN p_texto_resposta_email TEXT,
IN p_emails_copia TEXT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_usuarios SET 
nome = p_nome,
sexo = p_sexo,
cpf = p_cpf,
telefone = p_telefone,
email = p_email,
login = p_login,
id_status = p_id_status,
id_filial = p_id_filial,
id_perfil = p_id_perfil,
id_setor = p_id_setor,
data_ultima_alteracao_login = p_data_ultima_alteracao_login,
data_ultima_alteracao_email = p_data_ultima_alteracao_email,
imagem = p_imagem,
texto_resposta_email = p_texto_resposta_email,
emails_copia = p_emails_copia
WHERE id_usuario=p_id_usuario;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_efetua_login(
IN p_login VARCHAR(30),
IN p_email VARCHAR(60),
IN p_senha VARCHAR(255),
OUT p_id_usuario INT,
OUT p_mensagem VARCHAR(255),
OUT po_login VARCHAR(30),
OUT po_email VARCHAR(60),
OUT p_nome VARCHAR(60),
OUT p_id_perfil INT,
OUT p_nome_perfil VARCHAR(60),
OUT p_id_setor INT,
OUT p_nome_setor VARCHAR(60),
OUT p_id_filial INT,
OUT p_nome_filial VARCHAR(60),
OUT p_id_pais INT,
OUT p_nome_pais VARCHAR(60),
OUT p_id_estado INT,
OUT p_nome_estado VARCHAR(60),
OUT p_id_cidade INT,
OUT p_nome_cidade VARCHAR(60),
OUT p_imagem LONGBLOB,
OUT p_data_ultima_alteracao_senha DATETIME,
OUT p_texto_resposta_email TEXT,
OUT p_emails_copia TEXT)
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE login=p_login OR email=p_email)) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE (login=p_login OR email=p_email) AND senha=SHA1(p_senha))) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE (login=p_login OR email=p_email) AND id_status=1)) THEN
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_mensagem='Logado com sucesso';
SET p_nome=(SELECT nome FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_login=(SELECT login FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_email=(SELECT email FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_id_perfil=(SELECT id_perfil FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_nome_perfil=(SELECT pf.nome FROM tb_usuarios as us INNER JOIN tb_perfis as pf ON us.id_perfil = pf.id_perfil WHERE login=p_login OR email=p_email);
SET p_id_setor=(SELECT id_setor FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_nome_setor=(SELECT se.nome FROM tb_usuarios as us INNER JOIN tb_setores as se ON us.id_setor = se.id_setor WHERE login=p_login OR email=p_email);
SET p_id_filial=(SELECT id_filial FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_nome_filial=(SELECT fl.nome FROM tb_usuarios as us INNER JOIN tb_filiais as fl ON us.id_filial = fl.id_filial WHERE login=p_login OR email=p_email);
SET p_id_pais=(SELECT pa.id_pais FROM tb_filiais as fl INNER JOIN tb_paises as pa ON fl.id_pais = pa.id_pais WHERE id_filial=p_id_filial);
SET p_nome_pais=(SELECT pa.nome FROM tb_filiais as fl INNER JOIN tb_paises as pa ON fl.id_pais = pa.id_pais WHERE id_filial=p_id_filial);
SET p_id_estado=(SELECT es.id_estado FROM tb_filiais as fl INNER JOIN tb_estados as es ON fl.id_estado = es.id_estado WHERE id_filial=p_id_filial);
SET p_nome_estado=(SELECT es.nome FROM tb_filiais as fl INNER JOIN tb_estados as es ON fl.id_estado = es.id_estado WHERE id_filial=p_id_filial);
SET p_id_cidade=(SELECT ci.id_cidade FROM tb_filiais as fl INNER JOIN tb_cidades as ci ON fl.id_cidade = ci.id_cidade WHERE id_filial=p_id_filial);
SET p_nome_cidade=(SELECT ci.nome FROM tb_filiais as fl INNER JOIN tb_cidades as ci ON fl.id_cidade = ci.id_cidade WHERE id_filial=p_id_filial);
SET p_imagem=(SELECT imagem FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_data_ultima_alteracao_senha=(SELECT data_ultima_alteracao_senha FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_texto_resposta_email=(SELECT texto_resposta_email FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_emails_copia=(SELECT emails_copia FROM tb_usuarios WHERE login=p_login OR email=p_email);
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_setor=0;
SET p_nome_setor='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Valor inativo';
END IF;
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_setor=0;
SET p_nome_setor='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Senha inválida';
END IF;
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_setor=0;
SET p_nome_setor='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Login e/ou e-mail não existe';
END IF;
END$$
DELIMITER ;

-- Cria nova coluna na tabela de termos e refaz os procedimentos

ALTER TABLE tb_termos ADD texto_padrao TEXT AFTER nome;

UPDATE tb_termos SET texto_padrao = 'Prezado (a), em atenção a vossa solicitação, segue a proposta referente a (s) peça (s) e/ou serviço (s). No aguardo de vossa análise e aprovação.' WHERE id_termo > 0;

DROP PROCEDURE IF EXISTS sp_inserir_termo;
DROP PROCEDURE IF EXISTS sp_editar_termo;

DELIMITER $$
CREATE PROCEDURE sp_inserir_termo(
IN p_nome VARCHAR(60),
IN p_texto_padrao TEXT,
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_termos WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_termos
(nome,
texto_padrao,
observacoes,
prazo_entrega,
condicao_pagamento,
garantia,
validade,
id_status)
VALUES
(p_nome,
p_texto_padrao,
p_observacoes,
p_prazo_entrega,
p_condicao_pagamento,
p_garantia,
p_validade,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_termo(
IN p_id_termo INT,
IN p_nome VARCHAR(60),
IN p_texto_padrao TEXT,
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_termos WHERE id_termo=p_id_termo))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_termos SET 
nome = p_nome,
texto_padrao = p_texto_padrao,
observacoes = p_observacoes,
prazo_entrega = p_prazo_entrega,
condicao_pagamento = p_condicao_pagamento,
garantia = p_garantia,
validade = p_validade,
id_status = p_id_status
WHERE id_termo=p_id_termo;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

-- Cria novas colunas na tabela de propostas e refaz os procedimentos

ALTER TABLE tb_propostas ADD texto_padrao TEXT AFTER id_ultima_proposta;
ALTER TABLE tb_propostas ADD observacoes TEXT AFTER texto_padrao;
ALTER TABLE tb_propostas ADD prazo_entrega TEXT AFTER observacoes;
ALTER TABLE tb_propostas ADD condicao_pagamento TEXT AFTER prazo_entrega;
ALTER TABLE tb_propostas ADD garantia TEXT AFTER condicao_pagamento;
ALTER TABLE tb_propostas ADD validade TEXT AFTER garantia;

UPDATE tb_propostas SET 
texto_padrao = 'Prezado (a), em atenção a vossa solicitação, segue a proposta referente a (s) peça (s) e/ou serviço (s). No aguardo de vossa análise e aprovação.',
observacoes = 'Somos Serviço autorizado LINDE/STILL onde trabalhamos rigorosamente seguindo as normas e recomendações do fabricante, dispomos de todo o ferramental necessário para correta realização dos serviços, só utilizamos produtos de primeira linha que atendem e/ou superam os especificados pela fabricante. Prestamos serviços que visam atender as Normas Regulamentadoras NR11 e NR12.
Necessário ponto de energia 220V e área de lavagem com esgoto.',
prazo_entrega = 'Nosso prazo de entrega considera as condições normais de fluxo no Brasil. Devido a pandemia do Covid-19 PODE OCORRER O AUMENTO DO PRAZO DE ENTREGA em virtude de Ações Governamentais, Parada de transportadora, companhias aéreas, Aeroportos ou outros que possam interferir neste fluxo.
Peças: Obedecendo os prazos informados item a item acima, mediante a disponibilidade de estoque na data da apresentação da proposta, podendo ser alterado até a data da efetiva confirmação do pedido.
Serviços: Agendamento segundo disponibilidade de mão de obra para execução dos serviços, melhor data possível a ser definida entre as partes mediante a confirmação do pedido.',
condicao_pagamento = 'Para Peças e Serviços: 20 dias do faturamento.',
garantia = 'Garantia de 90 dias para peças e serviços fornecidos pela EUROLIFT;Condições: 1 - Garantia válida se as peças forem aplicadas pela Rede de Serviços Autorizados Linde STILL, norma da Fábrica; 2 - Peças e Serviços posto na EUROLIFT, não incluso deslocamentos e fretes; 3 - Não se caracteriza garantia desgaste natural de peças e serviços fornecidos; 4 - Obrigatório cumprimento do plano de manutenção preventiva conforme normas da Fábrica; 5 - Garantia compreende falha de fabricação de peças e componentes e/ou erro de execução dos serviços fornecidos.',
validade = '05 dias, exceto modificação do Fabricante no período.' WHERE id_proposta > 0;

DROP PROCEDURE IF EXISTS sp_inserir_proposta;
DROP PROCEDURE IF EXISTS sp_editar_proposta;

DELIMITER $$
CREATE PROCEDURE sp_inserir_proposta(
IN p_data_solicitacao DATETIME,
IN p_data_insercao DATETIME,
IN p_data_envio_faturamento DATETIME,
IN p_data_faturamento DATETIME,
IN p_nota_fiscal INT,
IN p_valor_faturamento DOUBLE,
IN p_id_filial INT,
IN p_id_cliente INT,
IN p_id_contato INT,
IN p_codigo_proposta VARCHAR(30),
IN p_id_usuario_insercao INT,
IN p_id_status INT,
IN p_id_prioridade INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_id_ano INT,
IN p_id_serie INT,
IN p_horimetro DECIMAL(20, 2),
IN p_data_envio DATETIME,
IN p_id_proposta_origem INT,
IN p_id_ultima_proposta INT,

IN p_texto_padrao TEXT,
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,

IN p_comentarios TEXT,
OUT p_id_proposta INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_propostas WHERE id_cliente=p_id_cliente AND codigo_proposta=p_codigo_proposta)) THEN
SET p_mensagem='Valor já existe';
SET p_id_proposta=(SELECT id_proposta FROM tb_propostas WHERE id_cliente=p_id_cliente AND codigo_proposta=p_codigo_proposta);
ELSE
INSERT INTO tb_propostas 
(data_solicitacao,
data_insercao,
data_envio_faturamento,
data_faturamento,
nota_fiscal,
valor_faturamento,
id_filial,
id_cliente,
id_contato,
codigo_proposta,
id_usuario_insercao,
id_status,
id_prioridade,
id_fabricante,
id_tipo_equipamento,
id_modelo,
id_ano,
id_serie,
horimetro,
data_envio,
id_proposta_origem,
id_ultima_proposta,

texto_padrao,
observacoes,
prazo_entrega,
condicao_pagamento,
garantia,
validade,

comentarios) 
VALUES 
(p_data_solicitacao,
p_data_insercao,
p_data_envio_faturamento,
p_data_faturamento,
p_nota_fiscal,
p_valor_faturamento,
p_id_filial,
p_id_cliente,
p_id_contato,
p_codigo_proposta,
p_id_usuario_insercao,
p_id_status,
p_id_prioridade,
p_id_fabricante,
p_id_tipo_equipamento,
p_id_modelo,
p_id_ano,
p_id_serie,
p_horimetro, 
p_data_envio,
p_id_proposta_origem,
p_id_ultima_proposta,

p_texto_padrao,
p_observacoes,
p_prazo_entrega,
p_condicao_pagamento,
p_garantia,
p_validade,

p_comentarios);
SET p_id_proposta=LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_proposta(
IN p_id_proposta INT,
IN p_data_solicitacao DATETIME,
IN p_data_envio_faturamento DATETIME,
IN p_data_faturamento DATETIME,
IN p_nota_fiscal INT,
IN p_valor_faturamento DOUBLE,
IN p_id_filial INT,
IN p_id_cliente INT,
IN p_id_contato INT,
IN p_codigo_proposta VARCHAR(30),
IN p_id_usuario_edicao INT,
IN p_id_status INT,
IN p_id_prioridade INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_id_ano INT,
IN p_id_serie INT,
IN p_horimetro DECIMAL(20, 2),  
IN p_data_envio DATETIME,
IN p_data_edicao DATETIME,
IN p_id_proposta_origem INT,
IN p_id_ultima_proposta INT,

IN p_texto_padrao TEXT,
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,

IN p_comentarios TEXT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_propostas WHERE id_proposta=p_id_proposta))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_propostas SET 
data_solicitacao = p_data_solicitacao,
data_envio_faturamento = p_data_envio_faturamento,
data_faturamento = p_data_faturamento,
nota_fiscal = p_nota_fiscal,
valor_faturamento = p_valor_faturamento,
id_filial = p_id_filial,
id_cliente = p_id_cliente,
id_contato = p_id_contato,
codigo_proposta = p_codigo_proposta,
id_usuario_edicao = p_id_usuario_edicao,
id_status = p_id_status,
id_prioridade = p_id_prioridade,
id_fabricante = p_id_fabricante,
id_tipo_equipamento = p_id_tipo_equipamento,
id_modelo = p_id_modelo,
id_ano = p_id_ano,
id_serie = p_id_serie,
horimetro = p_horimetro,
data_envio = p_data_envio,
data_edicao = p_data_edicao,
id_proposta_origem = p_id_proposta_origem,
id_ultima_proposta = p_id_ultima_proposta,

texto_padrao = p_texto_padrao,
observacoes = p_observacoes,
prazo_entrega = p_prazo_entrega,
condicao_pagamento = p_condicao_pagamento,
garantia = p_garantia,
validade = p_validade,

comentarios = p_comentarios
WHERE id_proposta=p_id_proposta;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;
