
-- Queries da tabela de fabricantes
CREATE TABLE tb_fabricantes(
    id_fabricante INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_fabricante),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );

INSERT INTO tb_fabricantes (nome, id_status) VALUES ('Linde', 1);
INSERT INTO tb_fabricantes (nome, id_status) VALUES ('Still', 1);
INSERT INTO tb_fabricantes (nome, id_status) VALUES ('Hyster', 1);
INSERT INTO tb_fabricantes (nome, id_status) VALUES ('Yale', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_fabricante(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_fabricantes WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_fabricantes
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
CREATE PROCEDURE sp_editar_fabricante(
IN p_id_fabricante INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_fabricantes WHERE id_fabricante=p_id_fabricante))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_fabricantes SET 
nome = p_nome,
id_status = p_id_status
WHERE id_fabricante=p_id_fabricante;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_fabricante(
IN p_id_fabricante INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_fabricantes WHERE id_fabricante=p_id_fabricante))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_fabricantes WHERE id_fabricante=p_id_fabricante;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;