
-- Queries da tabela de suporte para os termos
CREATE TABLE tb_termos_suporte(
    id_termo INT NOT NULL, 
    id_cliente INT, 
	id_setor INT, 
    id_status INT NOT NULL,
	FOREIGN KEY (id_termo) REFERENCES tb_termos (id_termo),
	FOREIGN KEY (id_cliente) REFERENCES tb_clientes (id_cliente),
	FOREIGN KEY (id_setor) REFERENCES tb_setores (id_setor),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
DELIMITER $$
CREATE PROCEDURE sp_inserir_termo_suporte(
IN p_id_termo INT,
IN p_id_cliente INT,
IN p_id_setor INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
INSERT INTO tb_termos_suporte
(id_termo,
id_cliente,
id_setor,
id_status)
VALUES
(p_id_termo,
p_id_cliente,
p_id_setor,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END$$
DELIMITER ;

-- Não é necessário um procedimento de edição visto que sempre será removido tudo e adicionado
/* DELIMITER $$
CREATE PROCEDURE sp_editar_termo_suporte(
IN p_id_termo_suporte INT,
IN p_id_termo INT,
IN p_id_cliente INT,
IN p_id_setor INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_termos_suporte WHERE id_termo_suporte=p_id_termo_suporte))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_termos_suporte SET 
id_termo = p_id_termo,
id_cliente = p_id_cliente,
id_setor = p_id_setor,
id_status = p_id_status
WHERE id_termo_suporte=p_id_termo_suporte;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ; */

DELIMITER $$
CREATE PROCEDURE sp_excluir_termo_suporte(
IN p_id_termo INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_termos_suporte WHERE id_termo=p_id_termo))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_termos_suporte WHERE id_termo=p_id_termo;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;