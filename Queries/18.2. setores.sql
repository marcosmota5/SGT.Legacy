
-- Queries da tabela de setores
CREATE TABLE tb_setores (
    id_setor INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    prazo_adicional INT NOT NULL,
    id_status INT NOT NULL,
	PRIMARY KEY (id_setor),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
);

INSERT INTO tb_setores (nome, prazo_adicional, id_status) VALUES ('Peças', 6, 1);
INSERT INTO tb_setores (nome, prazo_adicional, id_status) VALUES ('Pós vendas', 15, 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_setor(
IN p_nome VARCHAR(60),
IN p_prazo_adicional INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_setores WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_setores 
(nome,
prazo_adicional,
id_status) 
VALUES 
(p_nome,
p_prazo_adicional,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_setor(
IN p_id_setor INT,
IN p_nome VARCHAR(60),
IN p_prazo_adicional INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_setores WHERE id_setor=p_id_setor))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_setores SET 
nome = p_nome,
prazo_adicional = p_prazo_adicional,
id_status = p_id_status
WHERE id_setor=p_id_setor;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE sp_excluir_setor(
IN p_id_setor INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_setores WHERE id_setor=p_id_setor))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_setores
WHERE id_setor=p_id_setor;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;