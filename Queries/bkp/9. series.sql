
-- Queries da tabela de series
CREATE TABLE tb_series(
    id_serie INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    id_cliente INT NOT NULL,
	id_fabricante INT NOT NULL,
	id_tipo_equipamento INT NOT NULL,
	id_modelo INT NOT NULL,
    id_ano INT,
    PRIMARY KEY (id_serie),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
	FOREIGN KEY (id_cliente) REFERENCES tb_clientes (id_cliente),
    FOREIGN KEY (id_fabricante) REFERENCES tb_fabricantes (id_fabricante),
    FOREIGN KEY (id_tipo_equipamento) REFERENCES tb_tipos_equipamento (id_tipo_equipamento),
    FOREIGN KEY (id_modelo) REFERENCES tb_modelos (id_modelo),
	FOREIGN KEY (id_ano) REFERENCES tb_anos (id_ano)
    );

-- INSERT INTO tb_series (nome, id_status, id_cliente, id_fabricante, id_tipo_equipamento, id_modelo, id_ano) VALUES ('340260D05102', 1, 2, 2, 3, 56, 34);

DELIMITER $$
CREATE PROCEDURE sp_inserir_serie(
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_cliente INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_id_ano INT,
OUT p_mensagem VARCHAR(255),
OUT p_id_serie INT)
BEGIN
IF(EXISTS(SELECT id_serie FROM tb_series WHERE nome=p_nome AND id_cliente=p_id_cliente)) THEN
SET p_mensagem='Valor já existe';
SET p_id_serie=(SELECT id_serie FROM tb_series WHERE nome=p_nome);
ELSE
INSERT INTO tb_series
(nome,
id_status,
id_cliente,
id_fabricante,
id_tipo_equipamento,
id_modelo,
id_ano)
VALUES
(p_nome,
p_id_status,
p_id_cliente,
p_id_fabricante,
p_id_tipo_equipamento,
p_id_modelo,
p_id_ano);
SET p_mensagem='Valor inserido com sucesso';
SET p_id_serie=LAST_INSERT_ID();
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_serie(
IN p_id_serie INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_cliente INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_id_ano INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_series WHERE id_serie=p_id_serie))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_series SET 
nome = p_nome,
id_status = p_id_status,
id_cliente = p_id_cliente,
id_fabricante = p_id_fabricante,
id_tipo_equipamento = p_id_tipo_equipamento,
id_modelo = p_id_modelo,
id_ano = p_id_ano
WHERE id_serie=p_id_serie;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_serie(
IN p_id_serie INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_series WHERE id_serie=p_id_serie))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_series WHERE id_serie=p_id_serie;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;