
-- Queries da tabela de status
CREATE TABLE tb_status(
    id_status INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    PRIMARY KEY (id_status)
    );

INSERT INTO tb_status (nome) VALUES ('Ativo');
INSERT INTO tb_status (nome) VALUES ('Inativo');

DELIMITER $$
CREATE PROCEDURE sp_inserir_status(
IN p_nome VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_status WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_status
(nome)
VALUES
(p_nome);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_status(
IN p_id_status INT,
IN p_nome VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_status WHERE id_status=p_id_status))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_status SET 
nome = p_nome
WHERE id_status=p_id_status;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_status(
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_status WHERE id_status=p_id_status))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_status WHERE id_status=p_id_status;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;