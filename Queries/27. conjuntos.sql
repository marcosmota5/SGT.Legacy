
-- Queries da tabela de conjuntos
CREATE TABLE tb_conjuntos (
    id_conjunto INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
	PRIMARY KEY (id_conjunto),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
);

INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Acessórios', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Aferição de Velocidade', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Aterramento', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Conexão da Bateria', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Cubos de Roda', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Garfos / Porta Garfos', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Gerenciamento Visual', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Limpeza / Lavar', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Limpeza / Lubrificação', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Lubrificação Completa', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Medidores / Instrumentos', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Motores Elétricos', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Perfis dos Mastros', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Retrak / Bandeja Bateria', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Rodas e Pneus', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema de Direção', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema de Freios', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema de Suspensão', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema Direçâo', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema Elétrico', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema Hidráulico', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Sistema Transmissão', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Vazamentos', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Verificação de Contra Peso', 1);
INSERT INTO tb_conjuntos (nome, id_status) VALUES ('Outro', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_conjunto(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_conjuntos WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_conjuntos 
(nome,
id_status) 
VALUES 
(p_nome,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_conjunto(
IN p_id_conjunto INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_conjuntos WHERE id_conjunto=p_id_conjunto))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_conjuntos SET 
nome = p_nome,
id_status = p_id_status
WHERE id_conjunto=p_id_conjunto;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_conjunto(
IN p_id_conjunto INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_conjuntos WHERE id_conjunto=p_id_conjunto))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_conjuntos
WHERE id_conjunto=p_id_conjunto;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;