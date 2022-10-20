
DROP PROCEDURE IF EXISTS sp_inserir_setor;

DELIMITER $$
CREATE PROCEDURE sp_inserir_setor(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_setores WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_setores 
(nome,
id_status) 
VALUES 
(p_nome,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

ALTER TABLE tb_filiais ADD prazo_adicional INT NOT NULL AFTER email_servicos;
UPDATE tb_filiais SET prazo_adicional = 6 WHERE id_filial > 0;

DROP PROCEDURE IF EXISTS sp_inserir_filial;
DROP PROCEDURE IF EXISTS sp_editar_filial;

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
IN p_prazo_adicional INT,
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
prazo_adicional,
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
p_prazo_adicional,
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
IN p_prazo_adicional INT,
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
prazo_adicional = p_prazo_adicional,
id_status = p_id_status
WHERE id_filial=p_id_filial;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;