
-- Queries da tabela de prioridades
CREATE TABLE tb_prioridades(
    id_prioridade INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_prioridade),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_prioridades (nome, id_status) VALUES ('Baixa', 1);
INSERT INTO tb_prioridades (nome, id_status) VALUES ('Média', 1);
INSERT INTO tb_prioridades (nome, id_status) VALUES ('Alta', 1);
INSERT INTO tb_prioridades (nome, id_status) VALUES ('Não se aplica', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_prioridade(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_prioridades WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_prioridades
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
CREATE PROCEDURE sp_editar_prioridade(
IN p_id_prioridade INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_prioridades WHERE id_prioridade=p_id_prioridade))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_prioridades SET 
nome = p_nome,
id_status = p_id_status
WHERE id_prioridade=p_id_prioridade;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_prioridade(
IN p_id_prioridade INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_prioridades WHERE id_prioridade=p_id_prioridade))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_prioridades WHERE id_prioridade=p_id_prioridade;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;