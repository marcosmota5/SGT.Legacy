
-- Queries da tabela de perfis
CREATE TABLE tb_perfis(
    id_perfil INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_perfil),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_perfis (nome, id_status) VALUES ('Administrador', 1);
INSERT INTO tb_perfis (nome, id_status) VALUES ('Comum', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_perfil(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_perfis WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_perfis
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
CREATE PROCEDURE sp_editar_perfil(
IN p_id_perfil INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_perfis WHERE id_perfil=p_id_perfil))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_perfis SET 
nome = p_nome,
id_status = p_id_status
WHERE id_perfil=p_id_perfil;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_perfil(
IN p_id_perfil INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_perfis WHERE id_perfil=p_id_perfil))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_perfis WHERE id_perfil=p_id_perfil;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;