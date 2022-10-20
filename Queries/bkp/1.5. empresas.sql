
-- Queries da tabela de empresas
CREATE TABLE tb_empresas(
    id_empresa INT NOT NULL AUTO_INCREMENT,
    CNPJ VARCHAR(60) NOT NULL,
    razao_social VARCHAR(255) NOT NULL,
    nome_fantasia VARCHAR(255) NOT NULL,
	site VARCHAR(255),
    id_status INT NOT NULL,
	PRIMARY KEY (id_empresa),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
	);
    
INSERT INTO tb_empresas (CNPJ, razao_social, nome_fantasia, site, id_status) VALUES ('08669068000170', 'EUROLIFT COMERCIO SERVICOS IMPORTACAO E EXPORTACAO DE MAQUINAS LTDA', 'EUROLIFT EMPILHADEIRAS', 'http://www.euroliftempilhadeiras.com.br', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_empresa(
IN p_CNPJ VARCHAR(60),
IN p_razao_social VARCHAR(255),
IN p_nome_fantasia VARCHAR(255),
IN p_site VARCHAR(255),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_empresas WHERE CNPJ=p_CNPJ)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_empresas
(CNPJ,
razao_social,
nome_fantasia,
site,
id_status)
VALUES
(p_CNPJ,
p_razao_social,
p_nome_fantasia,
p_site,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_empresa(
IN p_id_empresa INT,
IN p_CNPJ VARCHAR(60),
IN p_razao_social VARCHAR(255),
IN p_nome_fantasia VARCHAR(255),
IN p_site VARCHAR(255),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_empresas WHERE id_empresa=p_id_empresa))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_empresas SET 
CNPJ=p_CNPJ,
razao_social=p_razao_social,
nome_fantasia=p_nome_fantasia,
site=p_site,
id_status=p_id_status
WHERE id_empresa=p_id_empresa;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_empresa(
IN p_id_empresa INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_empresas WHERE id_empresa=p_id_empresa))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_empresas WHERE id_empresa=p_id_empresa;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;