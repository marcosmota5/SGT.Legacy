
-- Queries da tabela de tb_clientes
CREATE TABLE tb_clientes(
    id_cliente INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    considerar_percentuais_tabela_kion TINYINT(1),
    percentual_tabela_kion_1 DECIMAL(20, 10),
    percentual_tabela_kion_2 DECIMAL(20, 10),
    percentual_tabela_kion_3 DECIMAL(20, 10),
    considerar_acrescimo_especifico TINYINT(1),
    percentual_acrescimo_especifico DECIMAL(20, 10),
    PRIMARY KEY (id_cliente),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );

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

DELIMITER $$
CREATE PROCEDURE sp_excluir_cliente(
IN p_id_cliente INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_clientes WHERE id_cliente=p_id_cliente))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_clientes WHERE id_cliente=p_id_cliente;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;