
CREATE TABLE tb_tipos_manifestacoes (
    id_tipo_manifestacao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
	PRIMARY KEY (id_tipo_manifestacao)
);

INSERT INTO tb_tipos_manifestacoes (nome) VALUES ('Correção');
INSERT INTO tb_tipos_manifestacoes (nome) VALUES ('Adição');
INSERT INTO tb_tipos_manifestacoes (nome) VALUES ('Alteração');
INSERT INTO tb_tipos_manifestacoes (nome) VALUES ('Remoção');
INSERT INTO tb_tipos_manifestacoes (nome) VALUES ('Outro');

CREATE TABLE tb_prioridades_manifestacoes (
    id_prioridade_manifestacao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
	PRIMARY KEY (id_prioridade_manifestacao)
);

INSERT INTO tb_prioridades_manifestacoes (nome) VALUES ('Baixa');
INSERT INTO tb_prioridades_manifestacoes (nome) VALUES ('Média');
INSERT INTO tb_prioridades_manifestacoes (nome) VALUES ('Alta');
INSERT INTO tb_prioridades_manifestacoes (nome) VALUES ('Urgente');

CREATE TABLE tb_status_manifestacoes (
    id_status_manifestacao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
	PRIMARY KEY (id_status_manifestacao)
);

INSERT INTO tb_status_manifestacoes (nome) VALUES ('Aberto');
INSERT INTO tb_status_manifestacoes (nome) VALUES ('Em análise');
INSERT INTO tb_status_manifestacoes (nome) VALUES ('Em andamento');
INSERT INTO tb_status_manifestacoes (nome) VALUES ('Fechado');
INSERT INTO tb_status_manifestacoes (nome) VALUES ('Cancelado');

CREATE TABLE tb_registro_manifestacoes (
    id_registro_manifestacao INT NOT NULL AUTO_INCREMENT,
    descricao_abertura VARCHAR(255) NOT NULL,
    data_abertura DATETIME NOT NULL,
	nome_pessoa_abertura VARCHAR(60),
    email_pessoa_abertura VARCHAR(60),
	descricao_fechamento VARCHAR(255),
    data_fechamento DATETIME,
	nome_pessoa_fechamento VARCHAR(60),
    email_pessoa_fechamento VARCHAR(60),
    id_tipo_manifestacao INT,
    id_prioridade_manifestacao INT,
    id_status_manifestacao INT,
	PRIMARY KEY (id_registro_manifestacao),
	FOREIGN KEY (id_tipo_manifestacao) REFERENCES tb_tipos_manifestacoes (id_tipo_manifestacao), 
	FOREIGN KEY (id_prioridade_manifestacao) REFERENCES tb_prioridades_manifestacoes (id_prioridade_manifestacao), 
	FOREIGN KEY (id_status_manifestacao) REFERENCES tb_status_manifestacoes (id_status_manifestacao)
);

CREATE TABLE tb_historico_manifestacoes (
    id_historico_manifestacao INT NOT NULL AUTO_INCREMENT,
    id_registro_manifestacao INT NOT NULL,
	data_alteracao DATETIME NOT NULL,
    descricao_alteracao TEXT NOT NULL,
	nome_pessoa_alteracao VARCHAR(60),
    email_pessoa_alteracao VARCHAR(60),
	PRIMARY KEY (id_historico_manifestacao),
    FOREIGN KEY (id_registro_manifestacao) REFERENCES tb_registro_manifestacoes (id_registro_manifestacao)
);

CREATE TABLE tb_comentarios_registro_manifestacoes (
    id_comentario_registro_manifestacao INT NOT NULL AUTO_INCREMENT,
    id_registro_manifestacao INT NOT NULL,
	data_insercao DATETIME NOT NULL,
    comentario TEXT NOT NULL,
    nome_pessoa_insercao VARCHAR(60),
    email_pessoa_insercao VARCHAR(60),
	PRIMARY KEY (id_comentario_registro_manifestacao),
    FOREIGN KEY (id_registro_manifestacao) REFERENCES tb_registro_manifestacoes (id_registro_manifestacao)
);

CREATE TABLE tb_imagens_registro_manifestacoes (
    id_imagem_registro_manifestacao INT NOT NULL AUTO_INCREMENT,
    id_registro_manifestacao INT NOT NULL,
	data_insercao DATETIME NOT NULL,
	miniatura LONGBLOB,
    imagem LONGBLOB,
    tamanho_imagem INT,
    nome_pessoa_insercao VARCHAR(60),
    email_pessoa_insercao VARCHAR(60),
	PRIMARY KEY (id_imagem_registro_manifestacao),
    FOREIGN KEY (id_registro_manifestacao) REFERENCES tb_registro_manifestacoes (id_registro_manifestacao)
);

CREATE TABLE tb_enderecos_mac_desenvolvedores (
    id_endereco_mac_desenvolvedor INT NOT NULL AUTO_INCREMENT,
    endereco_mac_desenvolvedor VARCHAR(60),
	PRIMARY KEY (id_endereco_mac_desenvolvedor)
);

DELIMITER $$
CREATE PROCEDURE sp_inserir_manifestacao(
IN p_descricao_abertura VARCHAR(255),
IN p_nome_pessoa_abertura VARCHAR(60),
IN p_email_pessoa_abertura VARCHAR(60),
IN p_id_tipo_manifestacao INT,
IN p_id_prioridade_manifestacao INT,
IN p_id_status_manifestacao INT,
OUT p_id_registro_manifestacao INT,
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
INSERT INTO tb_registro_manifestacoes 
(descricao_abertura,
data_abertura,
nome_pessoa_abertura,
email_pessoa_abertura,
id_tipo_manifestacao,
id_prioridade_manifestacao,
id_status_manifestacao) 
VALUES 
(p_descricao_abertura,
hora_atual,
p_nome_pessoa_abertura,
p_email_pessoa_abertura,
p_id_tipo_manifestacao,
p_id_prioridade_manifestacao,
p_id_status_manifestacao);
SET p_id_registro_manifestacao=LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
INSERT INTO tb_historico_manifestacoes
(id_registro_manifestacao,
data_alteracao,
descricao_alteracao,
nome_pessoa_alteracao,
email_pessoa_alteracao)
VALUES
(p_id_registro_manifestacao,
hora_atual,
'Manifestação criada',
p_nome_pessoa_abertura,
p_email_pessoa_abertura);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_manifestacao(
p_id_registro_manifestacao INT,
p_nome_pessoa_alteracao VARCHAR(60),
p_email_pessoa_alteracao VARCHAR(60),
p_descricao_fechamento VARCHAR(255),
p_id_tipo_manifestacao INT,
p_id_prioridade_manifestacao INT,
p_id_status_manifestacao INT,
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
DECLARE old_id_tipo_manifestacao INT;
DECLARE old_id_prioridade_manifestacao INT;
DECLARE old_id_status_manifestacao INT;
DECLARE atualiza_status BOOL;

IF(NOT(EXISTS(SELECT * FROM tb_registro_manifestacoes WHERE id_registro_manifestacao=p_id_registro_manifestacao))) THEN
	SET p_mensagem='Valor não existe';
ELSE
	SET old_id_tipo_manifestacao = (SELECT id_tipo_manifestacao FROM tb_registro_manifestacoes WHERE id_registro_manifestacao=p_id_registro_manifestacao);
    SET old_id_prioridade_manifestacao = (SELECT id_prioridade_manifestacao FROM tb_registro_manifestacoes WHERE id_registro_manifestacao=p_id_registro_manifestacao);
    SET old_id_status_manifestacao = (SELECT id_status_manifestacao FROM tb_registro_manifestacoes WHERE id_registro_manifestacao=p_id_registro_manifestacao);
    
    IF(old_id_status_manifestacao <> 4 AND p_id_status_manifestacao = 4) THEN
		UPDATE tb_registro_manifestacoes SET 
		id_tipo_manifestacao = p_id_tipo_manifestacao,
		id_prioridade_manifestacao = p_id_prioridade_manifestacao,
		id_status_manifestacao = p_id_status_manifestacao,
        descricao_fechamento = p_descricao_fechamento,
        data_fechamento = hora_atual,
        nome_pessoa_fechamento = p_nome_pessoa_alteracao,
        email_pessoa_fechamento = p_email_pessoa_alteracao
		WHERE id_registro_manifestacao=p_id_registro_manifestacao;
        
        INSERT INTO tb_historico_manifestacoes
		(id_registro_manifestacao,
		data_alteracao,
		descricao_alteracao,
		nome_pessoa_alteracao,
		email_pessoa_alteracao)
		VALUES
		(p_id_registro_manifestacao,
		hora_atual,
		'Requisição fechada',
		p_nome_pessoa_alteracao,
		p_email_pessoa_alteracao);
        
        SET atualiza_status = FALSE;
        
	ELSE
        
		IF(old_id_status_manifestacao = 4 AND p_id_status_manifestacao <> 4) THEN
			
			UPDATE tb_registro_manifestacoes SET 
			id_tipo_manifestacao = p_id_tipo_manifestacao,
			id_prioridade_manifestacao = p_id_prioridade_manifestacao,
			id_status_manifestacao = p_id_status_manifestacao,
            descricao_fechamento = p_descricao_fechamento,
			data_fechamento = NULL,
			nome_pessoa_fechamento = NULL,
			email_pessoa_fechamento = NULL
			WHERE id_registro_manifestacao=p_id_registro_manifestacao;
			
			SET atualiza_status = FALSE;
        
            INSERT INTO tb_historico_manifestacoes
			(id_registro_manifestacao,
			data_alteracao,
			descricao_alteracao,
			nome_pessoa_alteracao,
			email_pessoa_alteracao)
			VALUES
			(p_id_registro_manifestacao,
			hora_atual,
			'Requisição reaberta',
			p_nome_pessoa_alteracao,
			p_email_pessoa_alteracao);

        ELSE
        
			UPDATE tb_registro_manifestacoes SET 
			id_tipo_manifestacao = p_id_tipo_manifestacao,
			id_prioridade_manifestacao = p_id_prioridade_manifestacao,
			id_status_manifestacao = p_id_status_manifestacao
			WHERE id_registro_manifestacao=p_id_registro_manifestacao;
			
			SET atualiza_status = TRUE;

        END IF;
    END IF;
    
    SET p_mensagem='Valor editado com sucesso';
    
    IF(p_mensagem='Valor editado com sucesso') THEN
		IF(old_id_tipo_manifestacao <> p_id_tipo_manifestacao) THEN
			INSERT INTO tb_historico_manifestacoes
			(id_registro_manifestacao,
			data_alteracao,
			descricao_alteracao,
			nome_pessoa_alteracao,
			email_pessoa_alteracao)
			VALUES
			(p_id_registro_manifestacao,
			hora_atual,
			CONCAT('Tipo da manifestação alterada. De: ', 
			(SELECT nome FROM tb_tipos_manifestacoes WHERE id_tipo_manifestacao = old_id_tipo_manifestacao),
			'. Para: ',
			(SELECT nome FROM tb_tipos_manifestacoes WHERE id_tipo_manifestacao = p_id_tipo_manifestacao)),
			p_nome_pessoa_alteracao,
			p_email_pessoa_alteracao);
		END IF;
		IF(old_id_prioridade_manifestacao <> p_id_prioridade_manifestacao) THEN
			INSERT INTO tb_historico_manifestacoes
			(id_registro_manifestacao,
			data_alteracao,
			descricao_alteracao,
			nome_pessoa_alteracao,
			email_pessoa_alteracao)
			VALUES
			(p_id_registro_manifestacao,
			hora_atual,
			CONCAT('Prioridade da manifestação alterada. De: ', 
			(SELECT nome FROM tb_prioridades_manifestacoes WHERE id_prioridade_manifestacao = old_id_prioridade_manifestacao),
			'. Para: ',
			(SELECT nome FROM tb_prioridades_manifestacoes WHERE id_prioridade_manifestacao = p_id_prioridade_manifestacao)),
			p_nome_pessoa_alteracao,
			p_email_pessoa_alteracao);
		END IF;
        IF atualiza_status = TRUE THEN
			IF(old_id_status_manifestacao <> p_id_status_manifestacao) THEN
				INSERT INTO tb_historico_manifestacoes
				(id_registro_manifestacao,
				data_alteracao,
				descricao_alteracao,
				nome_pessoa_alteracao,
				email_pessoa_alteracao)
				VALUES
				(p_id_registro_manifestacao,
				hora_atual,
				CONCAT('Status da manifestação alterado. De: ', 
				(SELECT nome FROM tb_status_manifestacoes WHERE id_status_manifestacao = old_id_status_manifestacao),
				'. Para: ',
				(SELECT nome FROM tb_status_manifestacoes WHERE id_status_manifestacao = p_id_status_manifestacao)),
				p_nome_pessoa_alteracao,
				p_email_pessoa_alteracao);
			END IF;
		END IF;
	END IF;
END IF;

END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_inserir_comentario_manifestacao (
IN p_id_registro_manifestacao INT,
-- IN p_data_insercao DATETIME,
IN p_comentario TEXT,
IN p_nome_pessoa_insercao VARCHAR(60),
IN p_email_pessoa_insercao VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
INSERT INTO tb_comentarios_registro_manifestacoes 
(id_registro_manifestacao,
data_insercao,
comentario,
nome_pessoa_insercao,
email_pessoa_insercao) 
VALUES 
(p_id_registro_manifestacao,
hora_atual,
p_comentario,
p_nome_pessoa_insercao,
p_email_pessoa_insercao);
SET p_mensagem='Valor inserido com sucesso';
INSERT INTO tb_historico_manifestacoes
(id_registro_manifestacao,
data_alteracao,
descricao_alteracao,
nome_pessoa_alteracao,
email_pessoa_alteracao)
VALUES
(p_id_registro_manifestacao,
hora_atual,
'Comentário adicionado',
p_nome_pessoa_insercao,
p_email_pessoa_insercao);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_comentario_manifestacao (
IN p_id_comentario_registro_manifestacao INT,
IN p_id_registro_manifestacao INT,
IN p_nome_pessoa_insercao VARCHAR(60),
IN p_email_pessoa_insercao VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
IF(NOT(EXISTS(SELECT * FROM tb_comentarios_registro_manifestacoes WHERE id_comentario_registro_manifestacao=p_id_comentario_registro_manifestacao))) THEN
	SET p_mensagem='Valor não existe';
ELSE
	DELETE FROM tb_comentarios_registro_manifestacoes
	WHERE id_comentario_registro_manifestacao=p_id_comentario_registro_manifestacao;
	SET p_mensagem='Valor excluído com sucesso';
    INSERT INTO tb_historico_manifestacoes
	(id_registro_manifestacao,
	data_alteracao,
	descricao_alteracao,
	nome_pessoa_alteracao,
	email_pessoa_alteracao)
	VALUES
	(p_id_registro_manifestacao,
	hora_atual,
	'Comentário excluído',
	p_nome_pessoa_insercao,
	p_email_pessoa_insercao);
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_inserir_imagem_manifestacao (
IN p_id_registro_manifestacao INT,
-- IN p_data_insercao DATETIME,
IN p_imagem LONGBLOB,
IN p_tamanho_imagem INT,
IN p_nome_pessoa_insercao VARCHAR(60),
IN p_email_pessoa_insercao VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
INSERT INTO tb_imagens_registro_manifestacoes 
(id_registro_manifestacao,
data_insercao,
imagem,
tamanho_imagem,
nome_pessoa_insercao,
email_pessoa_insercao) 
VALUES 
(p_id_registro_manifestacao,
hora_atual,
p_imagem,
p_tamanho_imagem,
p_nome_pessoa_insercao,
p_email_pessoa_insercao);
SET p_mensagem='Valor inserido com sucesso';
INSERT INTO tb_historico_manifestacoes
(id_registro_manifestacao,
data_alteracao,
descricao_alteracao,
nome_pessoa_alteracao,
email_pessoa_alteracao)
VALUES
(p_id_registro_manifestacao,
hora_atual,
'Imagem adicionada',
p_nome_pessoa_insercao,
p_email_pessoa_insercao);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_imagem_manifestacao (
IN p_id_imagem_registro_manifestacao INT,
IN p_id_registro_manifestacao INT,
IN p_nome_pessoa_insercao VARCHAR(60),
IN p_email_pessoa_insercao VARCHAR(60),
OUT p_mensagem VARCHAR(255))
BEGIN
DECLARE hora_atual DATETIME DEFAULT NOW();
IF(NOT(EXISTS(SELECT * FROM tb_imagens_registro_manifestacoes WHERE id_imagem_registro_manifestacao=p_id_imagem_registro_manifestacao))) THEN
	SET p_mensagem='Valor não existe';
ELSE
	DELETE FROM tb_imagens_registro_manifestacoes
	WHERE id_imagem_registro_manifestacao=p_id_imagem_registro_manifestacao;
	SET p_mensagem='Valor excluído com sucesso';
    INSERT INTO tb_historico_manifestacoes
	(id_registro_manifestacao,
	data_alteracao,
	descricao_alteracao,
	nome_pessoa_alteracao,
	email_pessoa_alteracao)
	VALUES
	(p_id_registro_manifestacao,
	hora_atual,
	'Imagem excluída',
	p_nome_pessoa_insercao,
	p_email_pessoa_insercao);
END IF;
END$$
DELIMITER ;
