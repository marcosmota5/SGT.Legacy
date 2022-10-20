DROP PROCEDURE IF EXISTS sp_inserir_termo;

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
OUT p_id_termo INT,
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
SET p_id_termo=LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

ALTER TABLE tb_clientes DROP FOREIGN KEY tb_clientes_ibfk_2;
ALTER TABLE tb_clientes DROP COLUMN id_termo;

DROP PROCEDURE IF EXISTS sp_inserir_cliente;
DROP PROCEDURE IF EXISTS sp_editar_cliente;

DELIMITER $$
CREATE PROCEDURE sp_inserir_cliente(
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_considerar_percentuais_tabela_kion TINYINT(1),
IN p_percentual_tabela_kion_1 DECIMAL(20, 10),
IN p_percentual_tabela_kion_2 DECIMAL(20, 10),
IN p_percentual_tabela_kion_3 DECIMAL(20, 10),
IN p_considerar_acrescimo_especifico TINYINT(1),
IN p_percentual_acrescimo_especifico DECIMAL(20, 10),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_clientes WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_clientes
(nome,
id_status,
considerar_percentuais_tabela_kion,
percentual_tabela_kion_1,
percentual_tabela_kion_2,
percentual_tabela_kion_3,
considerar_acrescimo_especifico,
percentual_acrescimo_especifico)
VALUES
(p_nome,
p_id_status,
p_considerar_percentuais_tabela_kion,
p_percentual_tabela_kion_1,
p_percentual_tabela_kion_2,
p_percentual_tabela_kion_3,
p_considerar_acrescimo_especifico,
p_percentual_acrescimo_especifico);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_cliente(
IN p_id_cliente INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_considerar_percentuais_tabela_kion TINYINT(1),
IN p_percentual_tabela_kion_1 DECIMAL(20, 10),
IN p_percentual_tabela_kion_2 DECIMAL(20, 10),
IN p_percentual_tabela_kion_3 DECIMAL(20, 10),
IN p_considerar_acrescimo_especifico TINYINT(1),
IN p_percentual_acrescimo_especifico DECIMAL(20, 10),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_clientes WHERE id_cliente=p_id_cliente))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_clientes SET 
nome = p_nome,
id_status = p_id_status,
considerar_percentuais_tabela_kion = p_considerar_percentuais_tabela_kion,
percentual_tabela_kion_1 = p_percentual_tabela_kion_1,
percentual_tabela_kion_2 = p_percentual_tabela_kion_2,
percentual_tabela_kion_3 = p_percentual_tabela_kion_3,
considerar_acrescimo_especifico = p_considerar_acrescimo_especifico,
percentual_acrescimo_especifico = p_percentual_acrescimo_especifico
WHERE id_cliente=p_id_cliente;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

