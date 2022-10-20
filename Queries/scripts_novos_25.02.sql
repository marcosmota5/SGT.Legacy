
ALTER TABLE tb_filiais DROP COLUMN prazo_adicional;

DROP PROCEDURE IF EXISTS sp_inserir_filial;
DROP PROCEDURE IF EXISTS sp_editar_filial;

DELIMITER $$
CREATE PROCEDURE sp_inserir_filial(
IN p_nome VARCHAR(60),
IN p_id_empresa INT,
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_endereco TEXT,
IN p_CEP VARCHAR(10),
IN p_telefone_geral VARCHAR(30),
IN p_telefone_pecas VARCHAR(30),
IN p_telefone_servicos VARCHAR(30),
IN p_email_geral VARCHAR(60),
IN p_email_pecas VARCHAR(60),
IN p_email_servicos VARCHAR(60), 
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_filiais WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_filiais
(nome,
id_empresa,
id_pais,
id_estado,
id_cidade,
endereco,
CEP,
telefone_geral,
telefone_pecas,
telefone_servicos,
email_geral,
email_pecas,
email_servicos,
id_status)
VALUES
(p_nome,
p_id_empresa,
p_id_pais,
p_id_estado,
p_id_cidade,
p_endereco,
p_CEP,
p_telefone_geral,
p_telefone_pecas,
p_telefone_servicos,
p_email_geral,
p_email_pecas,
p_email_servicos,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_filial(
IN p_id_filial INT,
IN p_id_empresa INT,
IN p_nome VARCHAR(60),
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_endereco TEXT,
IN p_CEP VARCHAR(10),
IN p_telefone_geral VARCHAR(30),
IN p_telefone_pecas VARCHAR(30),
IN p_telefone_servicos VARCHAR(30),
IN p_email_geral VARCHAR(60),
IN p_email_pecas VARCHAR(60),
IN p_email_servicos VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_filiais WHERE id_filial=p_id_filial))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_filiais SET 
nome = p_nome,
id_empresa = p_id_empresa,
id_pais = p_id_pais,
id_estado = p_id_estado,
id_cidade = p_id_cidade,
endereco = p_endereco,
CEP = p_CEP,
telefone_geral = p_telefone_geral,
telefone_pecas = p_telefone_pecas,
telefone_servicos = p_telefone_servicos,
email_geral = p_email_geral,
email_pecas = p_email_pecas,
email_servicos = p_email_servicos,
id_status = p_id_status
WHERE id_filial=p_id_filial;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

ALTER TABLE tb_setores ADD prazo_adicional INT NOT NULL AFTER nome;
UPDATE tb_setores SET prazo_adicional = 15 WHERE id_setor > 0;

DROP PROCEDURE IF EXISTS sp_inserir_setor;
DROP PROCEDURE IF EXISTS sp_editar_setor;

DELIMITER $$
CREATE PROCEDURE sp_inserir_setor(
IN p_nome VARCHAR(60),
IN p_prazo_adicional INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_setores WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_setores 
(nome,
prazo_adicional,
id_status) 
VALUES 
(p_nome,
p_prazo_adicional,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_setor(
IN p_id_setor INT,
IN p_nome VARCHAR(60),
IN p_prazo_adicional INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_setores WHERE id_setor=p_id_setor))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_setores SET 
nome = p_nome,
prazo_adicional = p_prazo_adicional,
id_status = p_id_status
WHERE id_setor=p_id_setor;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

ALTER TABLE tb_itens_propostas ADD id_conjunto INT AFTER id_tipo_item;
ALTER TABLE tb_itens_propostas ADD id_especificacao INT AFTER id_conjunto;
ALTER TABLE tb_itens_propostas ADD FOREIGN KEY (id_conjunto) REFERENCES tb_conjuntos (id_conjunto);
ALTER TABLE tb_itens_propostas ADD FOREIGN KEY (id_especificacao) REFERENCES tb_especificacoes (id_especificacao);

-- UPDATE tb_itens_propostas SET id_conjunto = 25 WHERE id_tipo_item = 1;
-- UPDATE tb_itens_propostas SET id_especificacao = 148 WHERE id_tipo_item = 1;

DROP PROCEDURE IF EXISTS sp_inserir_item_proposta;
DROP PROCEDURE IF EXISTS sp_editar_item_proposta;

DELIMITER $$
CREATE PROCEDURE sp_inserir_item_proposta(
IN p_data_insercao DATETIME,
IN p_id_usuario INT,  
IN p_id_status INT,
IN p_id_proposta INT,
IN p_id_status_aprovacao INT,
IN p_id_justificativa_aprovacao INT,
IN p_id_tipo_item INT,
IN p_id_conjunto INT,
IN p_id_especificacao INT,
IN p_id_fornecedor INT,
IN p_codigo_item VARCHAR(255),
IN p_descricao_item TEXT,
IN p_quantidade_item DECIMAL(20, 2),
IN p_preco_unitario_inicial_item DECIMAL(20, 2),
IN p_percentual_ipi_item DECIMAL(20, 10),
IN p_percentual_icms_item DECIMAL(20, 10),
IN p_ncm_item VARCHAR(30),
IN p_mva_item DECIMAL(20, 10),
IN p_valor_st_item DECIMAL(20, 2),
IN p_valor_total_inicial_item DECIMAL(20, 2),
IN p_prazo_inicial_item VARCHAR(255),
IN p_frete_unitario_item DECIMAL(20, 2),
IN p_desconto_inicial_item DECIMAL(20, 10),
IN p_id_tipo_substituicao_tributaria_item INT,
IN p_id_origem_item INT,
IN p_preco_apos_desconto_inicial_item DECIMAL(20, 2),
IN p_preco_com_ipi_e_icms_item DECIMAL(20, 2),
IN p_percentual_aliquota_externa_icms_item DECIMAL(20, 10),
IN p_valor_icms_credito_item DECIMAL(20, 2),
IN p_percentual_mva_item DECIMAL(20, 10),
IN p_valor_mva_item DECIMAL(20, 2),
IN p_preco_com_mva_item DECIMAL(20, 2),
IN p_percentual_aliquota_interna_icms_item DECIMAL(20, 10),
IN p_valor_icms_debito_item DECIMAL(20, 2),
IN p_saldo_icms_item DECIMAL(20, 2),
IN p_preco_unitario_para_revendedor_item DECIMAL(20, 2),
IN p_impostos_federais_item DECIMAL(20, 10),
IN p_rateio_despesa_fixa_item DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item DECIMAL(20, 10),
IN p_preco_lista_venda_item DECIMAL(20, 2),
IN p_desconto_final_item DECIMAL(20, 10),
IN p_preco_unitario_final_item DECIMAL(20, 2),
IN p_preco_total_final_item DECIMAL(20, 2),
IN p_quantidade_estoque_codigo_completo_item DECIMAL(20, 2),
IN p_quantidade_estoque_codigo_abreviado_item DECIMAL(20, 2),
IN p_informacao_estoque_codigo_completo_item VARCHAR(255),
IN p_informacao_estoque_codigo_abreviado_item VARCHAR(255),
IN p_prazo_final_item VARCHAR(255),
IN p_comentarios_item TEXT,
IN p_data_aprovacao_item DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
INSERT INTO tb_itens_propostas 
(data_insercao,
id_usuario, 
id_status,
id_proposta,
id_status_aprovacao,
id_justificativa_aprovacao,
id_tipo_item,
id_conjunto,
id_especificacao,
id_fornecedor,
codigo_item,
descricao_item,
quantidade_item,
preco_unitario_inicial_item,
percentual_ipi_item,
percentual_icms_item,
ncm_item,
mva_item,
valor_st_item,
valor_total_inicial_item,
prazo_inicial_item,
frete_unitario_item,
desconto_inicial_item,
id_tipo_substituicao_tributaria_item,
id_origem_item,
preco_apos_desconto_inicial_item,
preco_com_ipi_e_icms_item,
percentual_aliquota_externa_icms_item,
valor_icms_credito_item,
percentual_mva_item,
valor_mva_item,
preco_com_mva_item,
percentual_aliquota_interna_icms_item,
valor_icms_debito_item,
saldo_icms_item,
preco_unitario_para_revendedor_item,
impostos_federais_item,
rateio_despesa_fixa_item,
percentual_lucro_necessario_item,
preco_lista_venda_item,
desconto_final_item,
preco_unitario_final_item,
preco_total_final_item,
quantidade_estoque_codigo_completo_item,
quantidade_estoque_codigo_abreviado_item,
informacao_estoque_codigo_completo_item,
informacao_estoque_codigo_abreviado_item,
prazo_final_item,
comentarios_item,
data_aprovacao_item) 
VALUES 
(p_data_insercao,
p_id_usuario, 
p_id_status,
p_id_proposta,
p_id_status_aprovacao,
p_id_justificativa_aprovacao,
p_id_tipo_item,
p_id_conjunto,
p_id_especificacao,
p_id_fornecedor,
p_codigo_item,
p_descricao_item,
p_quantidade_item,
p_preco_unitario_inicial_item,
p_percentual_ipi_item,
p_percentual_icms_item,
p_ncm_item,
p_mva_item,
p_valor_st_item,
p_valor_total_inicial_item,
p_prazo_inicial_item,
p_frete_unitario_item,
p_desconto_inicial_item,
p_id_tipo_substituicao_tributaria_item,
p_id_origem_item,
p_preco_apos_desconto_inicial_item,
p_preco_com_ipi_e_icms_item,
p_percentual_aliquota_externa_icms_item,
p_valor_icms_credito_item,
p_percentual_mva_item,
p_valor_mva_item,
p_preco_com_mva_item,
p_percentual_aliquota_interna_icms_item,
p_valor_icms_debito_item,
p_saldo_icms_item,
p_preco_unitario_para_revendedor_item,
p_impostos_federais_item,
p_rateio_despesa_fixa_item,
p_percentual_lucro_necessario_item,
p_preco_lista_venda_item,
p_desconto_final_item,
p_preco_unitario_final_item,
p_preco_total_final_item,
p_quantidade_estoque_codigo_completo_item,
p_quantidade_estoque_codigo_abreviado_item,
p_informacao_estoque_codigo_completo_item,
p_informacao_estoque_codigo_abreviado_item,
p_prazo_final_item,
p_comentarios_item,
p_data_aprovacao_item);
SET p_mensagem='Valor inserido com sucesso';
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_item_proposta(
IN p_id_item_proposta INT,
IN p_id_status INT,
IN p_id_proposta INT,
IN p_id_status_aprovacao INT,
IN p_id_justificativa_aprovacao INT,
IN p_id_tipo_item INT,
IN p_id_conjunto INT,
IN p_id_especificacao INT,
IN p_id_fornecedor INT,
IN p_codigo_item VARCHAR(255),
IN p_descricao_item TEXT,
IN p_quantidade_item DECIMAL(20, 2),
IN p_preco_unitario_inicial_item DECIMAL(20, 2),
IN p_percentual_ipi_item DECIMAL(20, 10),
IN p_percentual_icms_item DECIMAL(20, 10),
IN p_ncm_item VARCHAR(30),
IN p_mva_item DECIMAL(20, 10),
IN p_valor_st_item DECIMAL(20, 2),
IN p_valor_total_inicial_item DECIMAL(20, 2),
IN p_prazo_inicial_item VARCHAR(255),
IN p_frete_unitario_item DECIMAL(20, 2),
IN p_desconto_inicial_item DECIMAL(20, 10),
IN p_id_tipo_substituicao_tributaria_item INT,
IN p_id_origem_item INT,
IN p_preco_apos_desconto_inicial_item DECIMAL(20, 2),
IN p_preco_com_ipi_e_icms_item DECIMAL(20, 2),
IN p_percentual_aliquota_externa_icms_item DECIMAL(20, 10),
IN p_valor_icms_credito_item DECIMAL(20, 2),
IN p_percentual_mva_item DECIMAL(20, 10),
IN p_valor_mva_item DECIMAL(20, 2),
IN p_preco_com_mva_item DECIMAL(20, 2),
IN p_percentual_aliquota_interna_icms_item DECIMAL(20, 10),
IN p_valor_icms_debito_item DECIMAL(20, 2),
IN p_saldo_icms_item DECIMAL(20, 2),
IN p_preco_unitario_para_revendedor_item DECIMAL(20, 2),
IN p_impostos_federais_item DECIMAL(20, 10),
IN p_rateio_despesa_fixa_item DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item DECIMAL(20, 10),
IN p_preco_lista_venda_item DECIMAL(20, 2),
IN p_desconto_final_item DECIMAL(20, 10),
IN p_preco_unitario_final_item DECIMAL(20, 2),
IN p_preco_total_final_item DECIMAL(20, 2),
IN p_quantidade_estoque_codigo_completo_item DECIMAL(20, 2),
IN p_quantidade_estoque_codigo_abreviado_item DECIMAL(20, 2),
IN p_informacao_estoque_codigo_completo_item VARCHAR(255),
IN p_informacao_estoque_codigo_abreviado_item VARCHAR(255),
IN p_prazo_final_item VARCHAR(255),
IN p_comentarios_item TEXT,
IN p_data_aprovacao_item DATETIME,
IN p_data_edicao_item DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_itens_propostas WHERE id_item_proposta=p_id_item_proposta))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_itens_propostas SET 
id_status = p_id_status,
id_proposta = p_id_proposta,
id_status_aprovacao = p_id_status_aprovacao,
id_justificativa_aprovacao = p_id_justificativa_aprovacao,
id_tipo_item = p_id_tipo_item,
id_conjunto = p_id_conjunto,
id_especificacao = p_id_especificacao,
id_fornecedor = p_id_fornecedor,
codigo_item = p_codigo_item,
descricao_item = p_descricao_item,
quantidade_item = p_quantidade_item,
preco_unitario_inicial_item = p_preco_unitario_inicial_item,
percentual_ipi_item = p_percentual_ipi_item,
percentual_icms_item = p_percentual_icms_item,
ncm_item = p_ncm_item,
mva_item = p_mva_item,
valor_st_item = p_valor_st_item,
valor_total_inicial_item = p_valor_total_inicial_item,
prazo_inicial_item = p_prazo_inicial_item,
frete_unitario_item = p_frete_unitario_item,
desconto_inicial_item = p_desconto_inicial_item,
id_tipo_substituicao_tributaria_item = p_id_tipo_substituicao_tributaria_item,
id_origem_item = p_id_origem_item,
preco_apos_desconto_inicial_item = p_preco_apos_desconto_inicial_item,
preco_com_ipi_e_icms_item = p_preco_com_ipi_e_icms_item,
percentual_aliquota_externa_icms_item = p_percentual_aliquota_externa_icms_item,
valor_icms_credito_item = p_valor_icms_credito_item,
percentual_mva_item = p_percentual_mva_item,
valor_mva_item = p_valor_mva_item,
preco_com_mva_item = p_preco_com_mva_item,
percentual_aliquota_interna_icms_item = p_percentual_aliquota_interna_icms_item,
valor_icms_debito_item = p_valor_icms_debito_item,
saldo_icms_item = p_saldo_icms_item,
preco_unitario_para_revendedor_item = p_preco_unitario_para_revendedor_item,
impostos_federais_item = p_impostos_federais_item,
rateio_despesa_fixa_item = p_rateio_despesa_fixa_item,
percentual_lucro_necessario_item = p_percentual_lucro_necessario_item,
preco_lista_venda_item = p_preco_lista_venda_item,
desconto_final_item = p_desconto_final_item,
preco_unitario_final_item = p_preco_unitario_final_item,
preco_total_final_item = p_preco_total_final_item,
quantidade_estoque_codigo_completo_item = p_quantidade_estoque_codigo_completo_item,
quantidade_estoque_codigo_abreviado_item = p_quantidade_estoque_codigo_abreviado_item,
informacao_estoque_codigo_completo_item = p_informacao_estoque_codigo_completo_item,
informacao_estoque_codigo_abreviado_item = p_informacao_estoque_codigo_abreviado_item,
prazo_final_item = p_prazo_final_item,
comentarios_item = p_comentarios_item,
data_aprovacao_item = p_data_aprovacao_item,
data_edicao_item = p_data_edicao_item
WHERE id_item_proposta=p_id_item_proposta;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;