
-- Queries da tabela de modelos
CREATE TABLE tb_modelos(
    id_modelo INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
	id_fabricante INT NOT NULL,
	id_tipo_equipamento INT NOT NULL,
    PRIMARY KEY (id_modelo),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
    FOREIGN KEY (id_fabricante) REFERENCES tb_fabricantes (id_fabricante),
    FOREIGN KEY (id_tipo_equipamento) REFERENCES tb_tipos_equipamento (id_tipo_equipamento)
    );
    
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H160D LINHA 354', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H20T LINHA 350', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H25T LINHA 351', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H25T LINHA 392', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H30T LINHA 351', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H35T LINHA 393', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H40D LINHA 394', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H40T LINHA 394', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H45T LINHA 352', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H50T LINHA 394', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H70D LINHA 353', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('H70D LINHA 396', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('HT25T LINHA 1283', 1, 1, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('E16 LINHA 335', 1, 1, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('E20P LINHA 335', 1, 1, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('E30 LINHA 387', 1, 1, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('L12 LINHA 99', 1, 1, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('L14 LINHA 91', 1, 1, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('L16 LINHA 101', 1, 1, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('L16 LINHA 91', 1, 1, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R17 LINHA 100', 1, 1, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R17 LINHA 94', 1, 1, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R17 LINHA 95', 1, 1, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R20 LINHA 100', 1, 1, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R20 LINHA 95', 1, 1, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EWR ACTIVE', 1, 1, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('T20 LINHA 90', 1, 1, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('T20SP LINHA 131', 1, 1, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('BR20', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('CLX 25', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('CLX 30', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('CLX K25', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R70-16T', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R70-20T', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RC44-25C K21', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RC44-25C K25', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RC44-30', 1, 2, 1);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R20-20', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R20-20P', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R50-16', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-16', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-20', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-25', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-30', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-45', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R60-50', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX20-20', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX20-20P', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX50-15/16', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX50-15/16 BR', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX60-25', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX60-30', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX60-40', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('RX60-50', 1, 2, 2);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGV 14', 1, 2, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGV 16', 1, 2, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EJC-EGV', 1, 2, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EXV 12', 1, 2, 3);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('CX-T 40', 1, 2, 7);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('R06-06', 1, 2, 7);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('ETV-FM', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FM 14', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FME I', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FME II', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FMX 17', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FMX 20', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FMX 25', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FMX NG', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('FV-X 16', 1, 2, 5);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EJE-KMS20', 1, 2, 4);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EK 12', 1, 2, 4);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('KMSX 27', 1, 2, 4);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGU 16-S', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGU 18', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGU 20', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EGU 20C', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('EJE-ER20', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('ERE-EGU 20', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('ERX 27', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('ERX MECANICA', 1, 2, 6);
INSERT INTO tb_modelos (nome, id_status, id_fabricante, id_tipo_equipamento) VALUES ('SU20', 1, 2, 6);

DELIMITER $$
CREATE PROCEDURE sp_inserir_modelo(
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_modelos WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_modelos
(nome,
id_status,
id_fabricante,
id_tipo_equipamento)
VALUES
(p_nome,
p_id_status,
p_id_fabricante,
p_id_tipo_equipamento);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_modelo(
IN p_id_modelo INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_modelos WHERE id_modelo=p_id_modelo))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_modelos SET 
nome = p_nome,
id_status = p_id_status,
id_fabricante = p_id_fabricante,
id_tipo_equipamento = p_id_tipo_equipamento
WHERE id_modelo=p_id_modelo;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_modelo(
IN p_id_modelo INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_modelos WHERE id_modelo=p_id_modelo))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_modelos WHERE id_modelo=p_id_modelo;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;