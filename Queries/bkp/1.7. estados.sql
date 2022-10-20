
-- Queries da tabela de estados
CREATE TABLE tb_estados(
    id_estado INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_status INT NOT NULL,
	id_pais INT NOT NULL,
    PRIMARY KEY (id_estado),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status),
	FOREIGN KEY (id_pais) REFERENCES tb_paises (id_pais)
    );
    
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AF', 1, 1);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AL', 1, 2);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DZ', 1, 3);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AD', 1, 4);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AO', 1, 5);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AG', 1, 6);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AR', 1, 7);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AM', 1, 8);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AU', 1, 9);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AT', 1, 10);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AZ', 1, 11);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BS', 1, 12);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BH', 1, 13);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BD', 1, 14);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BB', 1, 15);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BY', 1, 16);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BE', 1, 17);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BZ', 1, 18);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BJ', 1, 19);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BM', 1, 20);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BT', 1, 21);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BO', 1, 22);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BA', 1, 23);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BW', 1, 24);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AC', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AL', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AM', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AP', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BA', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CE', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DF', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ES', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GO', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MA', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MG', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MS', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MT', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PA', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PB', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PE', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PI', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PR', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RJ', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RN', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RO', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RR', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RS', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SC', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SE', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SP', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TO', 1, 25);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BN', 1, 26);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BG', 1, 27);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BF', 1, 28);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('BI', 1, 29);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KH', 1, 30);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CM', 1, 31);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CA', 1, 32);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CV', 1, 33);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CF', 1, 34);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TD', 1, 35);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CL', 1, 36);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CN', 1, 37);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CO', 1, 38);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KM', 1, 39);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CG', 1, 40);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CI', 1, 41);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CR', 1, 42);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('HR', 1, 43);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CU', 1, 44);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CY', 1, 45);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CZ', 1, 46);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CD', 1, 47);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DK', 1, 48);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DJ', 1, 49);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DM', 1, 50);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DO', 1, 51);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('EC', 1, 52);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('EG', 1, 53);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SV', 1, 54);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GB', 1, 55);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GQ', 1, 56);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ER', 1, 57);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('EE', 1, 58);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ET', 1, 59);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('FJ', 1, 60);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('FI', 1, 61);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('FR', 1, 62);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GF', 1, 63);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GA', 1, 64);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GM', 1, 65);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GE', 1, 66);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('DE', 1, 67);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GH', 1, 68);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GR', 1, 69);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GD', 1, 70);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GT', 1, 71);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GN', 1, 72);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GW', 1, 73);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('GY', 1, 74);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('HT', 1, 75);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('HN', 1, 76);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('HU', 1, 77);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IS', 1, 78);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IN', 1, 79);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ID', 1, 80);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IQ', 1, 81);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IE', 1, 82);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IL', 1, 83);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IT', 1, 84);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('JM', 1, 85);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('JP', 1, 86);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('JO', 1, 87);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KZ', 1, 88);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KE', 1, 89);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KI', 1, 90);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KW', 1, 91);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KG', 1, 92);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LA', 1, 93);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LV', 1, 94);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LB', 1, 95);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LS', 1, 96);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LR', 1, 97);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LY', 1, 98);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LI', 1, 99);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LT', 1, 100);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LU', 1, 101);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MK', 1, 102);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MG', 1, 103);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MW', 1, 104);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MY', 1, 105);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MV', 1, 106);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ML', 1, 107);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MT', 1, 108);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MH', 1, 109);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MR', 1, 110);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MU', 1, 111);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MX', 1, 112);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('FM', 1, 113);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MD', 1, 114);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MC', 1, 115);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MN', 1, 116);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MA', 1, 117);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MZ', 1, 118);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('MM', 1, 119);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NA', 1, 120);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NR', 1, 121);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NP', 1, 122);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NL', 1, 123);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NZ', 1, 124);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NI', 1, 125);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NE', 1, 126);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NG', 1, 127);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KP', 1, 128);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('NO', 1, 129);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('OM', 1, 130);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PK', 1, 131);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PW', 1, 132);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PA', 1, 133);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PG', 1, 134);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PY', 1, 135);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PE', 1, 136);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PH', 1, 137);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PL', 1, 138);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PT', 1, 139);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('PR', 1, 140);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('QA', 1, 141);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RO', 1, 142);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RU', 1, 143);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('RW', 1, 144);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KN', 1, 145);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LC', 1, 146);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('VC', 1, 147);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('WS', 1, 148);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SM', 1, 149);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ST', 1, 150);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SA', 1, 151);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SN', 1, 152);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SC', 1, 153);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SL', 1, 154);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SG', 1, 155);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SK', 1, 156);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SI', 1, 157);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SB', 1, 158);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SO', 1, 159);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ZA', 1, 160);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('KR', 1, 161);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ES', 1, 162);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('LK', 1, 163);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SD', 1, 164);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SR', 1, 165);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SZ', 1, 166);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SE', 1, 167);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('CH', 1, 168);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('SY', 1, 169);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TW', 1, 170);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TJ', 1, 171);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TZ', 1, 172);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TH', 1, 173);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TG', 1, 174);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TO', 1, 175);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TT', 1, 176);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TN', 1, 177);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TR', 1, 178);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TM', 1, 179);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('TV', 1, 180);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('UG', 1, 181);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('UA', 1, 182);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('AE', 1, 183);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('US', 1, 184);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('UY', 1, 185);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('UZ', 1, 186);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('VU', 1, 187);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('VA', 1, 188);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('VE', 1, 189);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('VN', 1, 190);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('IR', 1, 191);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('YE', 1, 192);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ZM', 1, 193);
INSERT INTO tb_estados (nome, id_status, id_pais) VALUES ('ZW', 1, 194);

DELIMITER $$
CREATE PROCEDURE sp_inserir_estado(
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_pais INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_estados WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_estados
(nome,
id_status,
id_pais)
VALUES
(p_nome,
p_id_status,
p_id_pais);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_estado(
IN p_id_estado INT,
IN p_nome VARCHAR(60),
IN p_id_status INT,
IN p_id_pais INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_estados WHERE id_estado=p_id_estado))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_estados SET 
nome = p_nome,
id_status = p_id_status,
id_pais = p_id_pais
WHERE id_estado=p_id_estado;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_estado(
IN p_id_estado INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_estados WHERE id_estado=p_id_estado))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_estados 
WHERE id_estado=p_id_estado;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;