
-- Queries da tabela de familias
CREATE TABLE tb_familias(
    id_familia INT NOT NULL AUTO_INCREMENT,
    id_status INT NOT NULL,
	id_fabricante INT NOT NULL,
	id_tipo_equipamento INT NOT NULL,
	id_modelo INT NOT NULL,
    familia VARCHAR(10) NOT NULL,
    PRIMARY KEY (id_familia),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
    FOREIGN KEY (id_fabricante) REFERENCES tb_fabricantes (id_fabricante),
	FOREIGN KEY (id_tipo_equipamento) REFERENCES tb_tipos_equipamento (id_tipo_equipamento),
	FOREIGN KEY (id_modelo) REFERENCES tb_modelos (id_modelo)
    );
    
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 29, '348350');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 30, 'BACLX25');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 31, 'BACLX30');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 32, '348112');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 7, 59, '711050');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 2, 14, '335');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 2, 15, '335');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 2, 16, '387');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 73, '710115');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 74, '340129');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 75, '710122');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 75, '340129');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 76, '348104');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 55, '710244');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 55, '340261');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 56, '340259');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 56, '340261');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 56, '340260');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 57, '99OUTRO');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 77, '99OUTRO');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 4, 70, '341032');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 4, 71, '612116');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 78, '99OUTRO');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 79, '340137');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 80, '340139');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 61, '341828');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 6, 26, '096');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 3, 58, '710253');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 62, '611855');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 63, '341831');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 64, '341832');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 65, '341833');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 65, '341834');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 66, '341834');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 67, '511801');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 68, '341930');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 5, 69, '331532');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 1, '354');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 2, '350');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 3, '351');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 4, '392');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 5, '351');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 6, '393');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 7, '394');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 8, '394');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 9, '352');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 10, '394');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 11, '353');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 12, '396');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 1, 13, '1283');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 4, 72, '341033');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 3, 17, '099');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 3, 18, '091');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 3, 19, '101');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 3, 20, '091');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 7, 60, '280606');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 7, 60, '348098');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 5, 21, '100');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 5, 22, '094');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 5, 23, '095');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 5, 24, '100');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 5, 25, '095');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 38, '512005');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 39, '512022');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 40, '515044');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 41, '516043');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 42, '516022');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 43, '516023');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 44, '516025');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 45, '516045');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 46, '516029');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 33, '517077');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 34, '517079');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 35, '348046');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 36, '348047');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 1, 37, '348044');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 47, '516215');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 48, '516216');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 49, '515055');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 49, '515066');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 50, '345100');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 51, '516321');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 52, '516323');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 53, '516327');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 2, 54, '516329');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 2, 6, 81, '611610');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 6, 27, '090');
INSERT INTO tb_familias (id_status, id_fabricante, id_tipo_equipamento, id_modelo, familia) VALUES (1, 1, 6, 28, '131');

DELIMITER $$
CREATE PROCEDURE sp_inserir_familia(
IN id_status INT,
IN id_fabricante INT,
IN id_tipo_equipamento INT,
IN id_modelo INT,
IN familia VARCHAR(10),
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

DELIMITER $$
CREATE PROCEDURE sp_editar_familia(
IN p_id_familia INT,
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_id_tipo_equipamento INT,
IN p_id_modelo INT,
IN p_familia VARCHAR(10),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_familias WHERE id_familia=p_id_familia))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_familias SET 
id_status = p_id_status,
id_fabricante = p_id_fabricante,
id_tipo_equipamento = p_id_tipo_equipamento,
id_modelo = p_id_modelo,
familia = p_familia
WHERE id_familia=p_id_familia;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_familia(
IN p_id_familia INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_familias WHERE id_familia=p_id_familia))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_familias WHERE id_familia=p_id_familia;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;

-- 340260D05102
-- 3412


DELIMITER $$
CREATE PROCEDURE sp_verifica_familia(
IN p_serie VARCHAR(60),
OUT p_familia VARCHAR(10),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=LEFT(p_serie, 7))) THEN
SET p_familia=(LEFT(p_serie, 7));
SET p_mensagem='Valor encontrado';
ELSE
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=LEFT(p_serie, 6))) THEN
SET p_familia=(LEFT(p_serie, 6));
SET p_mensagem='Valor encontrado';
ELSE
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=LEFT(p_serie, 5))) THEN
SET p_familia=(LEFT(p_serie, 5));
SET p_mensagem='Valor encontrado';
ELSE
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=LEFT(p_serie, 4))) THEN
SET p_familia=(LEFT(p_serie, 4));
SET p_mensagem='Valor encontrado';
ELSE
IF(EXISTS(SELECT * FROM tb_familias WHERE familia=LEFT(p_serie, 3))) THEN
SET p_familia=(LEFT(p_serie, 3));
SET p_mensagem='Valor encontrado';
ELSE
SET p_familia='';
SET p_mensagem='Valor não existe';
END IF;
END IF;
END IF;
END IF;
END IF;
END$$
DELIMITER ;
