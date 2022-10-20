CREATE TABLE tb_senhas_usuarios (
    id_senha_usuario INT NOT NULL AUTO_INCREMENT,
    id_usuario INT NOT NULL,
    senha VARCHAR(255) NOT NULL,
    data_definicao DATETIME NOT NULL,
    PRIMARY KEY (id_senha_usuario),
    FOREIGN KEY (id_usuario) REFERENCES tb_usuarios (id_usuario)
);

INSERT INTO tb_senhas_usuarios (id_usuario, senha, data_definicao) VALUES (1, SHA1('admin'), NOW());

DELIMITER $$
CREATE PROCEDURE sp_inserir_senha_usuario(
IN p_id_usuario INT,
IN p_senha VARCHAR(255),
IN p_data_definicao DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_senhas_usuarios WHERE id_usuario=p_id_usuario AND senha=SHA1(p_senha))) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_senhas_usuarios 
(id_usuario,
senha,
data_definicao) 
VALUES 
(p_id_usuario,
SHA1(p_senha),
p_data_definicao);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_valida_historico_senha(
IN p_id_usuario INT,
IN p_senha VARCHAR(255),
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_senhas_usuarios WHERE id_usuario=p_id_usuario AND senha=SHA1(p_senha) ORDER BY data_definicao DESC LIMIT 5)) THEN
SET p_mensagem='Senha existe';
ELSE
SET p_mensagem='Senha não existe';
END IF;
END$$
DELIMITER ;