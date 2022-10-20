
-- Queries da tabela de status de aprovação
CREATE TABLE tb_status_aprovacao(
    id_status_aprovacao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_status_aprovacao),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_status_aprovacao (nome, id_status) VALUES ('Aprovado', 1);
INSERT INTO tb_status_aprovacao (nome, id_status) VALUES ('Aprovado parcialmente', 1);
INSERT INTO tb_status_aprovacao (nome, id_status) VALUES ('Em análise', 1);
INSERT INTO tb_status_aprovacao (nome, id_status) VALUES ('Não aprovado', 1);
INSERT INTO tb_status_aprovacao (nome, id_status) VALUES ('Cancelado', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_status_aprovacao(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_status_aprovacao WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_status_aprovacao
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
CREATE PROCEDURE sp_editar_status_aprovacao(
IN p_id_status_aprovacao INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_status_aprovacao WHERE id_status_aprovacao=p_id_status_aprovacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_status_aprovacao SET 
nome = p_nome,
id_status = p_id_status
WHERE id_status_aprovacao=p_id_status_aprovacao;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_status_aprovacao(
IN p_id_status_aprovacao INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_status_aprovacao WHERE id_status_aprovacao=p_id_status_aprovacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_status_aprovacao 
WHERE id_status_aprovacao=p_id_status_aprovacao;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;