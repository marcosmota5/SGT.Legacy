
-- Queries da tabela de tipos de substituição tributária
CREATE TABLE tb_tipos_substituicao_tributaria(
    id_tipo_substituicao_tributaria INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_tipo_substituicao_tributaria),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_tipos_substituicao_tributaria (nome, id_status) VALUES ('Revenda ST', 1);
INSERT INTO tb_tipos_substituicao_tributaria (nome, id_status) VALUES ('Revenda sem ST', 1);
INSERT INTO tb_tipos_substituicao_tributaria (nome, id_status) VALUES ('Revenda direta', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_tipo_substituicao_tributaria(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_tipos_substituicao_tributaria WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_tipos_substituicao_tributaria
(nome,
id_status)
VALUES
(p_nome,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_tipo_substituicao_tributaria(
IN p_id_tipo_substituicao_tributaria INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_tipos_substituicao_tributaria WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_tipos_substituicao_tributaria SET 
nome = p_nome,
id_status = p_id_status
WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_tipo_substituicao_tributaria(
IN p_id_tipo_substituicao_tributaria INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_tipos_substituicao_tributaria WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_tipos_substituicao_tributaria WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_retorna_tipo_substituicao_tributaria(
IN p_id_tipo_substituicao_tributaria INT,
OUT p_nome VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT nome FROM tb_tipos_substituicao_tributaria WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria))) THEN
SET p_nome="";
SET p_mensagem='Valor não existe';
ELSE
SET p_nome=(SELECT nome FROM tb_tipos_substituicao_tributaria WHERE id_tipo_substituicao_tributaria=p_id_tipo_substituicao_tributaria);
SET p_mensagem='Valor retornado com sucesso';
END IF;
END$$
DELIMITER ;