
-- Queries da tabela de usuários
CREATE TABLE tb_usuarios (
    id_usuario INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    sexo VARCHAR(30) NOT NULL,
    cpf VARCHAR(30) NOT NULL,
    telefone VARCHAR(30),
    email VARCHAR(60) NOT NULL,
    login VARCHAR(30) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    id_status INT NOT NULL,
    id_filial INT NOT NULL,
    id_perfil INT NOT NULL,
    data_cadastro DATETIME NOT NULL,
    data_ultima_alteracao_senha DATETIME,
    data_ultima_alteracao_login DATETIME,
    data_ultima_alteracao_email DATETIME,
    imagem LONGBLOB,
    texto_resposta_email TEXT,
    emails_copia TEXT,
    PRIMARY KEY (id_usuario),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
    FOREIGN KEY (id_filial) REFERENCES tb_filiais (id_filial),
    FOREIGN KEY (id_perfil) REFERENCES tb_perfis (id_perfil)
);

INSERT INTO tb_usuarios (nome, sexo, cpf, telefone, email, login, senha, id_status, id_filial, id_perfil, texto_resposta_email, emails_copia, data_cadastro, data_ultima_alteracao_senha) VALUES ('Administrador', 'M', '99999999999', '', 'sgt@euroliftempilhadeiras.com.br', 'admin', SHA1('admin'), 1, 1, 1, 'Conforme vossa solicitação, envio a proposta referente à(s) peça(s) e/ou serviço(s) solicitado(s). Aguardo vossa análise e aprovação.', '', NOW(), NOW());

DELIMITER $$
CREATE PROCEDURE sp_inserir_usuario(
IN p_nome VARCHAR(60),
IN p_sexo VARCHAR(30),
IN p_cpf VARCHAR(30),
IN p_telefone VARCHAR(30),
IN p_email VARCHAR(60),
IN p_login VARCHAR(30),
IN p_senha VARCHAR(255),
IN p_id_status INT,
IN p_id_filial INT,
IN p_id_perfil INT,
IN p_data_cadastro DATETIME,
IN p_imagem LONGBLOB,
IN p_texto_resposta_email TEXT,
IN p_emails_copia TEXT,
OUT p_id_usuario INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE login=p_login)) THEN
SET p_mensagem='Valor já existe 1';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE login=p_login);
ELSE
IF(EXISTS(SELECT * FROM tb_usuarios WHERE cpf=p_cpf)) THEN
SET p_mensagem='Valor já existe 2';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE cpf=p_cpf);
ELSE
IF(EXISTS(SELECT * FROM tb_usuarios WHERE email=p_email)) THEN
SET p_mensagem='Valor já existe 3';
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE email=p_email);
ELSE
INSERT INTO tb_usuarios 
(nome,
sexo,
cpf,
telefone,
email,
login,
senha,
id_status,
id_filial,
id_perfil,
data_cadastro,
data_ultima_alteracao_senha,
imagem,
texto_resposta_email,
emails_copia) 
VALUES 
(p_nome,
p_sexo,
p_cpf,
p_telefone,
p_email,
p_login,
SHA1(p_senha),
p_id_status,
p_id_filial,
p_id_perfil,
p_data_cadastro,
p_data_cadastro,
p_imagem,
p_texto_resposta_email,
p_emails_copia);
SET p_id_usuario = LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
END IF;
END IF;
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_usuario(
IN p_id_usuario INT,
IN p_nome VARCHAR(60),
IN p_sexo VARCHAR(30),
IN p_cpf VARCHAR(30),
IN p_telefone VARCHAR(30),
IN p_email VARCHAR(60),
IN p_login VARCHAR(30),
IN p_id_status INT,
IN p_id_filial INT,
IN p_id_perfil INT,
IN p_data_ultima_alteracao_login DATETIME,
IN p_data_ultima_alteracao_email DATETIME,
IN p_imagem LONGBLOB,
IN p_texto_resposta_email TEXT,
IN p_emails_copia TEXT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_usuarios SET 
nome = p_nome,
sexo = p_sexo,
cpf = p_cpf,
telefone = p_telefone,
email = p_email,
login = p_login,
id_status = p_id_status,
id_filial = p_id_filial,
id_perfil = p_id_perfil,
data_ultima_alteracao_login = p_data_ultima_alteracao_login,
data_ultima_alteracao_email = p_data_ultima_alteracao_email,
imagem = p_imagem,
texto_resposta_email = p_texto_resposta_email,
emails_copia = p_emails_copia
WHERE id_usuario=p_id_usuario;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_valida_senha(
IN p_id_usuario INT,
IN p_senha VARCHAR(255),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario)) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario AND senha=SHA1(p_senha))) THEN
SET p_mensagem='Senha correta';
ELSE
SET p_mensagem='Senha errada';
END IF;
ELSE
SET p_mensagem='Usuario nao encontrado';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_altera_senha(
IN p_id_usuario INT,
IN p_senha VARCHAR(255),
IN p_data_ultima_alteracao_senha DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_usuarios SET 
senha = SHA1(p_senha),
data_ultima_alteracao_senha = p_data_ultima_alteracao_senha
WHERE id_usuario=p_id_usuario;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_usuario(
IN p_id_usuario INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_usuarios
WHERE id_usuario=p_id_usuario;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;



DELIMITER $$
CREATE PROCEDURE sp_efetua_login(
IN p_login VARCHAR(30),
IN p_email VARCHAR(60),
IN p_senha VARCHAR(255),
OUT p_id_usuario INT,
OUT p_mensagem VARCHAR(255),
OUT po_login VARCHAR(30),
OUT po_email VARCHAR(60),
OUT p_nome VARCHAR(60),
OUT p_id_perfil INT,
OUT p_nome_perfil VARCHAR(60),
OUT p_id_filial INT,
OUT p_nome_filial VARCHAR(60),
OUT p_id_pais INT,
OUT p_nome_pais VARCHAR(60),
OUT p_id_estado INT,
OUT p_nome_estado VARCHAR(60),
OUT p_id_cidade INT,
OUT p_nome_cidade VARCHAR(60),
OUT p_imagem LONGBLOB,
OUT p_data_ultima_alteracao_senha DATETIME,
OUT p_texto_resposta_email TEXT,
OUT p_emails_copia TEXT)
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE login=p_login OR email=p_email)) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE (login=p_login OR email=p_email) AND senha=SHA1(p_senha))) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE (login=p_login OR email=p_email) AND id_status=1)) THEN
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_mensagem='Logado com sucesso';
SET p_nome=(SELECT nome FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_login=(SELECT login FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_email=(SELECT email FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_id_perfil=(SELECT id_perfil FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_nome_perfil=(SELECT pf.nome FROM tb_usuarios as us INNER JOIN tb_perfis as pf ON us.id_perfil = pf.id_perfil WHERE login=p_login OR email=p_email);
SET p_id_filial=(SELECT id_filial FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_nome_filial=(SELECT fl.nome FROM tb_usuarios as us INNER JOIN tb_filiais as fl ON us.id_filial = fl.id_filial WHERE login=p_login OR email=p_email);
SET p_id_pais=(SELECT pa.id_pais FROM tb_filiais as fl INNER JOIN tb_paises as pa ON fl.id_pais = pa.id_pais WHERE id_filial=p_id_filial);
SET p_nome_pais=(SELECT pa.nome FROM tb_filiais as fl INNER JOIN tb_paises as pa ON fl.id_pais = pa.id_pais WHERE id_filial=p_id_filial);
SET p_id_estado=(SELECT es.id_estado FROM tb_filiais as fl INNER JOIN tb_estados as es ON fl.id_estado = es.id_estado WHERE id_filial=p_id_filial);
SET p_nome_estado=(SELECT es.nome FROM tb_filiais as fl INNER JOIN tb_estados as es ON fl.id_estado = es.id_estado WHERE id_filial=p_id_filial);
SET p_id_cidade=(SELECT ci.id_cidade FROM tb_filiais as fl INNER JOIN tb_cidades as ci ON fl.id_cidade = ci.id_cidade WHERE id_filial=p_id_filial);
SET p_nome_cidade=(SELECT ci.nome FROM tb_filiais as fl INNER JOIN tb_cidades as ci ON fl.id_cidade = ci.id_cidade WHERE id_filial=p_id_filial);
SET p_imagem=(SELECT imagem FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_data_ultima_alteracao_senha=(SELECT data_ultima_alteracao_senha FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_texto_resposta_email=(SELECT texto_resposta_email FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_emails_copia=(SELECT emails_copia FROM tb_usuarios WHERE login=p_login OR email=p_email);
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Valor inativo';
END IF;
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Senha inválida';
END IF;
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_id_perfil=0;
SET p_nome_perfil='';
SET p_id_filial=0;
SET p_nome_filial='';
SET p_id_pais=0;
SET p_nome_pais='';
SET p_id_estado=0;
SET p_nome_estado='';
SET p_id_cidade=0;
SET p_nome_cidade='';
SET p_imagem=NULL;
SET p_data_ultima_alteracao_senha=NOW();
SET p_texto_resposta_email='';
SET p_emails_copia='';
SET p_mensagem='Login e/ou e-mail não existe';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_retorna_email(
IN p_login VARCHAR(30),
IN p_email VARCHAR(60),
OUT p_id_usuario INT,
OUT p_mensagem VARCHAR(255),
OUT po_login VARCHAR(30),
OUT po_email VARCHAR(60),
OUT p_nome VARCHAR(60))
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE login=p_login OR email=p_email)) THEN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE (login=p_login OR email=p_email) AND id_status=1)) THEN
SET p_id_usuario=(SELECT id_usuario FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET p_mensagem='Retornado com sucesso';
SET p_nome=(SELECT nome FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_login=(SELECT login FROM tb_usuarios WHERE login=p_login OR email=p_email);
SET po_email=(SELECT email FROM tb_usuarios WHERE login=p_login OR email=p_email);
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_mensagem='Valor inativo';
END IF;
ELSE
SET p_id_usuario=0;
SET p_nome='';
SET po_login='';
SET po_email='';
SET p_mensagem='Login e/ou e-mail não existe';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_retorna_login(
IN p_id_usuario INT,
OUT p_login VARCHAR(30))
BEGIN
IF(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario)) THEN
SET p_login=(SELECT login FROM tb_usuarios WHERE id_usuario=p_id_usuario);
ELSE
SET p_login='';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_altera_texto_padrao_email_copia(
IN p_id_usuario INT,
IN p_texto_resposta_email TEXT,
IN p_emails_copia TEXT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_usuarios WHERE id_usuario=p_id_usuario))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_usuarios SET 
texto_resposta_email = p_texto_resposta_email,
emails_copia = p_emails_copia
WHERE id_usuario=p_id_usuario;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

