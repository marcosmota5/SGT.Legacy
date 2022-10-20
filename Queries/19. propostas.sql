
-- Queries da tabela de propostas
CREATE TABLE tb_propostas(
id_proposta INT NOT NULL AUTO_INCREMENT,
data_solicitacao DATETIME NOT NULL,
data_insercao DATETIME NOT NULL,
data_envio_faturamento DATETIME,
data_faturamento DATETIME,
nota_fiscal INT,
valor_faturamento DECIMAL(20, 2),
id_filial INT NOT NULL,
id_cliente INT NOT NULL,
id_contato INT,
codigo_proposta VARCHAR(30),
id_usuario_insercao INT,
id_usuario_edicao INT,
id_status INT NOT NULL,
id_prioridade INT,
id_fabricante INT,
id_tipo_equipamento INT,
id_modelo INT,
id_ano INT,
id_serie INT,
horimetro DECIMAL(20, 2),
ordem_servico INT,
data_envio DATETIME,
data_edicao DATETIME,
id_proposta_origem INT,
id_ultima_proposta INT,

texto_padrao TEXT,
observacoes TEXT,
prazo_entrega TEXT,
condicao_pagamento TEXT,
garantia TEXT,
validade TEXT,

comentarios TEXT,
PRIMARY KEY (id_proposta),
FOREIGN KEY (id_filial) REFERENCES tb_filiais (id_filial),
FOREIGN KEY (id_cliente) REFERENCES tb_clientes (id_cliente),
FOREIGN KEY (id_contato) REFERENCES tb_contatos (id_contato),
FOREIGN KEY (id_usuario_insercao) REFERENCES tb_usuarios (id_usuario),
FOREIGN KEY (id_usuario_edicao) REFERENCES tb_usuarios (id_usuario),
FOREIGN KEY (id_prioridade) REFERENCES tb_prioridades (id_prioridade),
FOREIGN KEY (id_fabricante) REFERENCES tb_fabricantes (id_fabricante),
FOREIGN KEY (id_tipo_equipamento) REFERENCES tb_tipos_equipamento (id_tipo_equipamento),
FOREIGN KEY (id_modelo) REFERENCES tb_modelos (id_modelo),
FOREIGN KEY (id_ano) REFERENCES tb_anos (id_ano),
FOREIGN KEY (id_serie) REFERENCES tb_series (id_serie),
FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
);

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


DELIMITER $$
CREATE PROCEDURE sp_excluir_proposta(
IN p_id_proposta INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_propostas WHERE id_proposta=p_id_proposta))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_propostas
WHERE id_proposta=p_id_proposta;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_contagem_propostas_iniciais(
IN p_id_cliente INT,
IN p_data_insercao DATETIME,
OUT p_contagem INT)
BEGIN
SET p_contagem=(SELECT COUNT(id_proposta) FROM tb_propostas WHERE id_cliente=p_id_cliente AND DATE(data_insercao)=DATE(p_data_insercao) AND id_proposta_origem IS NULL);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_contagem_propostas_revisadas(
IN p_id_proposta_origem INT,
IN p_id_cliente INT,
OUT p_contagem INT,
OUT p_codigo_proposta VARCHAR(30))
BEGIN
SET p_contagem=(SELECT COUNT(id_proposta) FROM tb_propostas WHERE id_cliente=p_id_cliente AND id_proposta_origem=p_id_proposta_origem);
SET p_codigo_proposta=(SELECT codigo_proposta FROM tb_propostas WHERE id_cliente=p_id_cliente AND id_proposta=p_id_proposta_origem);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_atualiza_ultima_proposta(
IN p_id_proposta INT,
IN p_id_ultima_proposta INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_propostas WHERE id_proposta=p_id_proposta))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_propostas SET 
id_ultima_proposta = p_id_ultima_proposta
WHERE id_proposta=p_id_proposta;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_atualiza_data_envio(
IN p_id_proposta INT,
IN p_data_envio DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_propostas WHERE id_proposta=p_id_proposta))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_propostas SET 
data_envio = p_data_envio
WHERE id_proposta=p_id_proposta;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;