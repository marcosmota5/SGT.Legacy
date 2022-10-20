
-- Queries da tabela de filiais
CREATE TABLE tb_filiais(
    id_filial INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_empresa INT NOT NULL,
	id_pais INT NOT NULL,    
    id_estado INT NOT NULL,
	id_cidade INT NOT NULL,
    endereco TEXT NOT NULL,
    CEP VARCHAR(10) NOT NULL,
    telefone_geral VARCHAR(30),
    telefone_pecas VARCHAR(30),
    telefone_servicos VARCHAR(30),
    email_geral VARCHAR(60),
    email_pecas VARCHAR(60),
    email_servicos VARCHAR(60), 
    id_status INT NOT NULL,
    PRIMARY KEY (id_filial),
    FOREIGN KEY (id_empresa) REFERENCES tb_empresas (id_empresa),
	FOREIGN KEY (id_pais) REFERENCES tb_paises (id_pais),
	FOREIGN KEY (id_estado) REFERENCES tb_estados (id_estado),
	FOREIGN KEY (id_cidade) REFERENCES tb_cidades (id_cidade),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_filiais (nome, id_empresa, id_pais, id_estado, id_cidade, endereco, CEP, id_status, telefone_geral, telefone_pecas, telefone_servicos, email_geral, email_pecas, email_servicos)
 VALUES ('Matriz', 1, 25, 29, 296, 'Avenida Jorge Amado, S/N. Ao lado do Detran. Em frente ao Hospital Geral', '42800605', 1, '7141111691', '71997315450', '71991040814', 'suportevendas@euroliftempilhadeiras.com.br', 'patricia.pecas@euroliftempilhadeiras.com.br', 'robson.posvendas@euroliftempilhadeiras.com.br');

DELIMITER $$
CREATE PROCEDURE sp_inserir_filial(
IN p_nome VARCHAR(60),
IN p_id_empresa INT,
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_endereco TEXT,
IN p_CEP VARCHAR(10),
IN p_telefone_geral VARCHAR(30),
IN p_telefone_pecas VARCHAR(30),
IN p_telefone_servicos VARCHAR(30),
IN p_email_geral VARCHAR(60),
IN p_email_pecas VARCHAR(60),
IN p_email_servicos VARCHAR(60), 
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_filiais WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_filiais
(nome,
id_empresa,
id_pais,
id_estado,
id_cidade,
endereco,
CEP,
telefone_geral,
telefone_pecas,
telefone_servicos,
email_geral,
email_pecas,
email_servicos,
id_status)
VALUES
(p_nome,
p_id_empresa,
p_id_pais,
p_id_estado,
p_id_cidade,
p_endereco,
p_CEP,
p_telefone_geral,
p_telefone_pecas,
p_telefone_servicos,
p_email_geral,
p_email_pecas,
p_email_servicos,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_filial(
IN p_id_filial INT,
IN p_id_empresa INT,
IN p_nome VARCHAR(60),
IN p_id_pais INT,
IN p_id_estado INT,
IN p_id_cidade INT,
IN p_endereco TEXT,
IN p_CEP VARCHAR(10),
IN p_telefone_geral VARCHAR(30),
IN p_telefone_pecas VARCHAR(30),
IN p_telefone_servicos VARCHAR(30),
IN p_email_geral VARCHAR(60),
IN p_email_pecas VARCHAR(60),
IN p_email_servicos VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_filiais WHERE id_filial=p_id_filial))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_filiais SET 
nome = p_nome,
id_empresa = p_id_empresa,
id_pais = p_id_pais,
id_estado = p_id_estado,
id_cidade = p_id_cidade,
endereco = p_endereco,
CEP = p_CEP,
telefone_geral = p_telefone_geral,
telefone_pecas = p_telefone_pecas,
telefone_servicos = p_telefone_servicos,
email_geral = p_email_geral,
email_pecas = p_email_pecas,
email_servicos = p_email_servicos,
id_status = p_id_status
WHERE id_filial=p_id_filial;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_filial(
IN p_id_filial INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_filiais WHERE id_filial=p_id_filial))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_filiais WHERE id_filial=p_id_filial;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_retorna_dados_filial(
IN p_id_filial INT,
OUT p_id_empresa INT,
OUT p_id_pais INT,
OUT p_id_estado INT,
OUT p_id_cidade INT,
OUT p_endereco TEXT,
OUT p_CEP VARCHAR(10),
OUT p_telefone_geral VARCHAR(30),
OUT p_telefone_pecas VARCHAR(30),
OUT p_telefone_servicos VARCHAR(30),
OUT p_email_geral VARCHAR(60),
OUT p_email_pecas VARCHAR(60),
OUT p_email_servicos VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_filiais WHERE id_filial=p_id_filial))) THEN
SET p_mensagem='Valor não existe';
ELSE
SET p_id_empresa=(SELECT id_empresa FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_id_pais=(SELECT id_pais FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_id_estado=(SELECT id_estado FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_id_cidade=(SELECT id_cidade FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_endereco=(SELECT endereco FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_CEP=(SELECT CEP FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_telefone_geral=(SELECT telefone_geral FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_telefone_pecas=(SELECT telefone_pecas FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_telefone_servicos=(SELECT telefone_servicos FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_email_geral=(SELECT email_geral FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_email_pecas=(SELECT email_pecas FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_email_servicos=(SELECT email_servicos FROM tb_filiais WHERE id_filial=p_id_filial);
SET p_mensagem='Valor existe';
END IF;
END$$
DELIMITER ;