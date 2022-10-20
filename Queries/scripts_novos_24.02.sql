
DROP PROCEDURE IF EXISTS sp_inserir_familia;

DELIMITER $$
CREATE PROCEDURE sp_inserir_familia(
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_familia VARCHAR(10),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=p_familia)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_familias
(id_status,
id_fabricante,
id_tipo_equipamento,
id_modelo,
familia)
VALUES
(p_id_status,
p_id_fabricante,
p_id_tipo_equipamento,
p_id_modelo,
p_familia);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;