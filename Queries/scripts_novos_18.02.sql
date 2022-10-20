ALTER TABLE tb_propostas ADD ordem_servico INT AFTER horimetro;

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
IN p_ordem_servico INT,
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
ordem_servico,
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
p_ordem_servico,
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
IN p_ordem_servico INT,
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
ordem_servico = p_ordem_servico,
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