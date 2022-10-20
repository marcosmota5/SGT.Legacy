
-- Queries da tabela de anos
CREATE TABLE tb_anos(
    id_ano INT NOT NULL AUTO_INCREMENT,
    id_status INT NOT NULL,
	id_fabricante INT NOT NULL,
    posicao_inicio_caracteres INT NOT NULL,
    caracteres VARCHAR(10) NOT NULL,
    ano INT NOT NULL,
    PRIMARY KEY (id_ano),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
    FOREIGN KEY (id_fabricante) REFERENCES tb_fabricantes (id_fabricante)
    );
    
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '0', 1980);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '1', 1981);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '2', 1982);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '3', 1983);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '4', 1984);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '5', 1985);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '6', 1986);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '7', 1987);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '8', 1988);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, '9', 1989);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'A', 1990);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'B', 1991);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'C', 1992);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'D', 1993);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'E', 1994);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'F', 1995);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'G', 1996);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'H', 1997);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'J', 1998);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'K', 1999);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'L', 2000);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'M', 2001);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'N', 2002);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'P', 2003);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'R', 2004);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'S', 2005);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'T', 2006);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'U', 2007);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'W', 2008);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'Z', 2009);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'A', 2010);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'B', 2011);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'C', 2012);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'D', 2013);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'E', 2014);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'F', 2015);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'G', 2016);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'H', 2017);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'J', 2018);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'K', 2019);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'L', 2020);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'M', 2021);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'N', 2022);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'P', 2023);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'R', 2024);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'S', 2025);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'T', 2026);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'U', 2027);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'V', 2028);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'W', 2029);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'X', 2030);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'Y', 2031);
INSERT INTO tb_anos (id_status, id_fabricante, posicao_inicio_caracteres, caracteres, ano) VALUES (1, 2, 7, 'Z', 2032);

DELIMITER $$
CREATE PROCEDURE sp_inserir_ano(
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_posicao_inicio_caracteres INT,
IN p_caracteres VARCHAR(10),
IN p_ano INT,
OUT p_mensagem VARCHAR(255))
BEGIN
INSERT INTO tb_anos
(id_status,
id_fabricante,
posicao_inicio_caracteres,
caracteres,
ano)
VALUES
(p_id_status,
p_id_fabricante,
p_posicao_inicio_caracteres,
p_caracteres,
p_ano);
SET p_mensagem='Valor inserido com sucesso';
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_ano(
IN p_id_ano INT,
IN p_id_status INT,
IN p_id_fabricante INT,
IN p_posicao_inicio_caracteres INT,
IN p_caracteres VARCHAR(10),
IN p_ano INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_anos WHERE id_ano=p_id_ano))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_anos SET 
id_status = p_id_status,
id_fabricante = p_id_fabricante,
posicao_inicio_caracteres = p_posicao_inicio_caracteres,
caracteres = p_caracteres,
ano = p_ano
WHERE id_ano=p_id_ano;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_ano(
IN p_id_ano INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_anos WHERE id_ano=p_id_ano))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_anos WHERE id_ano=p_id_ano;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;