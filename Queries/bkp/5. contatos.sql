
-- Queries da tabela de contato
CREATE TABLE tb_contatos(
    id_contato INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    telefone VARCHAR(60),
    email VARCHAR(60),
    id_pais INT NOT NULL,    
    id_estado INT NOT NULL,
	id_cidade INT NOT NULL,
    id_status INT NOT NULL,
	id_cliente INT NOT NULL,
    PRIMARY KEY (id_contato),
	FOREIGN KEY (id_pais) REFERENCES tb_paises (id_pais),
	FOREIGN KEY (id_estado) REFERENCES tb_estados (id_estado),
	FOREIGN KEY (id_cidade) REFERENCES tb_cidades (id_cidade),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
    FOREIGN KEY (id_cliente) REFERENCES tb_clientes (id_cliente)
    );

DELIMITER $$
CREATE PROCEDURE sp_inserir_contato(
IN p_nome VARCHAR(60),
IN p_telefone VARCHAR(60),
IN p_email VARCHAR(60),
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_id_status INT,
IN p_id_cliente INT,
OUT p_mensagem VARCHAR(255),
OUT p_id_contato INT)
BEGIN
IF(EXISTS(SELECT id_contato FROM tb_contatos WHERE id_cliente=p_id_cliente AND nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
SET p_id_contato=(SELECT id_contato FROM tb_contatos WHERE id_cliente=p_id_cliente AND nome=p_nome);
ELSE
INSERT INTO tb_contatos
(nome,
telefone,
email,
id_pais,
id_estado,
id_cidade,
id_status,
id_cliente)
VALUES
(p_nome,
p_telefone,
p_email,
p_id_pais,
p_id_estado,
p_id_cidade,
p_id_status,
p_id_cliente);
SET p_mensagem='Valor inserido com sucesso';
SET p_id_contato=LAST_INSERT_ID();
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_contato(
IN p_id_contato INT,
IN p_nome VARCHAR(60),
IN p_telefone VARCHAR(60),
IN p_email VARCHAR(60),
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_id_status INT,
IN p_id_cliente INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_contatos WHERE id_contato=p_id_contato))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_contatos SET 
nome = p_nome,
telefone = p_telefone,
email = p_email,
id_pais = p_id_pais,
id_estado = p_id_estado,
id_cidade = p_id_cidade,
id_status = p_id_status,
id_cliente = p_id_cliente
WHERE id_contato=p_id_contato;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_contato(
IN p_id_contato INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_contatos WHERE id_contato=p_id_contato))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_contatos WHERE id_contato=p_id_contato;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;
    
DELIMITER $$
CREATE PROCEDURE sp_retorna_dados_contato(
IN p_id_contato INT,
OUT p_nome VARCHAR(60),
OUT p_telefone VARCHAR(60),
OUT p_email VARCHAR(60),
OUT p_id_pais INT,
OUT p_id_estado INT,
OUT p_id_cidade INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_contatos WHERE id_contato=p_id_contato))) THEN
SET p_mensagem='Valor não existe';
ELSE
SET p_nome=(SELECT nome FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_telefone=(SELECT telefone FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_email=(SELECT email FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_id_pais=(SELECT id_pais FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_id_estado=(SELECT id_estado FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_id_cidade=(SELECT id_cidade FROM tb_contatos WHERE id_contato=p_id_contato);
SET p_mensagem='Valor existe';
END IF;
END$$
DELIMITER ;