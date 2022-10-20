
-- Queries da tabela de tipos de equipamento
CREATE TABLE tb_tipos_equipamento(
    id_tipo_equipamento INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_tipo_equipamento),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );

INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Empilhadeira a combustão', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Empilhadeira contrabalançada elétrica', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Empilhadeira patolada', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Empilhadeira selecionadora', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Empilhadeira retrátil', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Transpaleteira', 1);
INSERT INTO tb_tipos_equipamento (nome, id_status) VALUES ('Rebocador', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_tipo_equipamento(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_tipos_equipamento WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_tipos_equipamento
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
CREATE PROCEDURE sp_editar_tipo_equipamento(
IN p_id_tipo_equipamento INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_tipos_equipamento WHERE id_tipo_equipamento=p_id_tipo_equipamento))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_tipos_equipamento SET 
nome = p_nome,
id_status = p_id_status
WHERE id_tipo_equipamento=p_id_tipo_equipamento;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_tipo_equipamento(
IN p_id_tipo_equipamento INT,
IN p_nome VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_tipos_equipamento WHERE id_tipo_equipamento=p_id_tipo_equipamento))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_tipos_equipamento WHERE id_tipo_equipamento=p_id_tipo_equipamento;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;