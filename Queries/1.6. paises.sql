
-- Queries da tabela de países
CREATE TABLE tb_paises(
    id_pais INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
    PRIMARY KEY (id_pais),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
INSERT INTO tb_paises (nome, id_status) VALUES ('Afeganistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Albânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Argélia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Andorra', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Angola', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Antígua e Barbuda', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Argentina', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Armênia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Austrália', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Áustria', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Azerbaijão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bahamas', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bahrein', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bangladesh', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Barbados', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bielorrússia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bélgica', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Belize', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Benin', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bermudas', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Butão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bolívia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bósnia e Herzegovina', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Botsuana', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Brasil', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Brunei', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Bulgária', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Burkina Faso', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Burundi', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Camboja', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Camarões', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Canadá', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Cabo Verde', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('República Centro-Africana', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Chade', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Chile', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('China', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Colômbia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Comores', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('República do Congo', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Costa do Marfim', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Costa Rica', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Croácia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Cuba', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Chipre', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('República Checa', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('República Democrática do Congo', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Dinamarca', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Djibouti', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Dominica', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('República Dominicana', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Equador', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Egito', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('El Salvador', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Inglaterra', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guiné Equatorial', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Eritreia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Estônia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Etiópia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Fiji', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Finlândia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('França', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guiana Francesa', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Gabão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Gâmbia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Geórgia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Alemanha', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Gana', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Grécia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Granada', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guatemala', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guiné', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guiné-Bissau', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Guiana', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Haiti', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Honduras', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Hungria', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Islândia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Índia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Indonésia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Iraque', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Irlanda', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Israel', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Itália', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Jamaica', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Japão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Jordânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Cazaquistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Quênia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Kiribati', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Kuwait', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Quirguistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Laos', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Letônia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Líbano', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Lesoto', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Libéria', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Líbia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Liechtenstein', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Lituânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Luxemburgo', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Macedônia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Madagáscar', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Malawi', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Malásia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Maldivas', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Mali', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Malta', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Ilhas Marshall', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Mauritânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Maurícia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('México', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Micronésia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Moldávia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Mônaco', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Mongólia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Marrocos', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Moçambique', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Myanmar', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Namíbia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Nauru', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Nepal', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Países Baixos', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Nova Zelândia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Nicarágua', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Niger', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Nigéria', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Coreia do Norte', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Noruega', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Omã', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Paquistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Palau', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Panamá', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Papua-Nova Guiné', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Paraguai', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Peru', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Filipinas', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Polônia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Portugal', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Porto Rico', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Catar', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Romênia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Rússia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Ruanda', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('São Cristóvão e Nevis', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Santa Lúcia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('São Vicente e Granadinas', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Samoa', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('San Marino', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('São Tomé e Príncipe', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Arábia Saudita', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Senegal', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Seychelles', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Serra Leoa', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Cingapura', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Eslováquia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Eslovênia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Ilhas Salomão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Somália', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('África do Sul', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Coreia do Sul', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Espanha', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Sri Lanka', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Sudão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Suriname', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Suazilândia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Suécia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Suíça', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Síria', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Taiwan', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tajiquistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tanzânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tailândia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Togo', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tonga', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Trinidad e Tobago', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tunísia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Turquia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Turquemenistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Tuvalu', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Uganda', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Ucrânia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Emirados Árabes Unidos', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Estados Unidos', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Uruguai', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Uzbequistão', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Vanuatu', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Vaticano', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Venezuela', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Vietname', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Irã', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Iêmen', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Zâmbia', 1);
INSERT INTO tb_paises (nome, id_status) VALUES ('Zimbabwe', 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_pais(
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_paises WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_paises
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
CREATE PROCEDURE sp_editar_pais(
IN p_id_pais INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_paises WHERE id_pais=p_id_pais))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_paises SET 
nome = p_nome,
id_status = p_id_status
WHERE id_pais=p_id_pais;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_pais(
IN p_id_pais INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_paises WHERE id_pais=p_id_pais))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_paises 
WHERE id_pais=p_id_pais;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;