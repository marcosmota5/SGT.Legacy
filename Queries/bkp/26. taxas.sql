
-- Queries da tabela de taxas
CREATE TABLE tb_taxas(
    id_taxa INT NOT NULL AUTO_INCREMENT,
    data_inicio DATETIME NOT NULL,
    data_fim DATETIME,
    nome TEXT,
    percentual_aliquota_externa_icms_item_nacional DECIMAL(20,10),
	percentual_aliquota_externa_icms_item_importado DECIMAL(20,10),
	percentual_mva_item_nacional DECIMAL(20, 10),
	percentual_mva_item_importado DECIMAL(20, 10),
	percentual_aliquota_interna_icms_item_nacional DECIMAL(20, 10),
	percentual_aliquota_interna_icms_item_importado DECIMAL(20, 10),
	impostos_federais_item_nacional DECIMAL(20, 10),
	impostos_federais_item_importado DECIMAL(20, 10),
	rateio_despesa_fixa_item_nacional DECIMAL(20, 10),
	rateio_despesa_fixa_item_importado DECIMAL(20, 10),
	percentual_lucro_necessario_item_revenda_st_nacional DECIMAL(20, 10),
	percentual_lucro_necessario_item_outros_nacional DECIMAL(20, 10),
	percentual_lucro_necessario_item_revenda_st_importado DECIMAL(20, 10),
	percentual_lucro_necessario_item_outros_importado DECIMAL(20, 10),
	percentual_acrescimo_item_nacional DECIMAL(20,10),
	percentual_acrescimo_item_importado DECIMAL(20,10),
    PRIMARY KEY (id_taxa)
    );

INSERT INTO tb_taxas
(data_inicio,
nome,
percentual_aliquota_externa_icms_item_nacional,
percentual_aliquota_externa_icms_item_importado,
percentual_mva_item_nacional,
percentual_mva_item_importado,
percentual_aliquota_interna_icms_item_nacional,
percentual_aliquota_interna_icms_item_importado,
impostos_federais_item_nacional,
impostos_federais_item_importado,
rateio_despesa_fixa_item_nacional,
rateio_despesa_fixa_item_importado,
percentual_lucro_necessario_item_revenda_st_nacional,
percentual_lucro_necessario_item_outros_nacional,
percentual_lucro_necessario_item_revenda_st_importado,
percentual_lucro_necessario_item_outros_importado,
percentual_acrescimo_item_nacional,
percentual_acrescimo_item_importado)
VALUES
(NOW(),
'Taxa padrão',
0.07,
0.04,
0.9482,
1.0111,
0.18,
0.18,
0.08,
0.08,
0.10,
0.10,
0.195,
0.173,
0.195,
0.173,
0,
0);

DELIMITER $$
CREATE PROCEDURE sp_inserir_taxa(
IN p_data_inicio DATETIME,
IN p_nome TEXT,
IN p_percentual_aliquota_externa_icms_item_nacional DECIMAL(20,10),
IN p_percentual_aliquota_externa_icms_item_importado DECIMAL(20,10),
IN p_percentual_mva_item_nacional DECIMAL(20, 10),
IN p_percentual_mva_item_importado DECIMAL(20, 10),
IN p_percentual_aliquota_interna_icms_item_nacional DECIMAL(20, 10),
IN p_percentual_aliquota_interna_icms_item_importado DECIMAL(20, 10),
IN p_impostos_federais_item_nacional DECIMAL(20, 10),
IN p_impostos_federais_item_importado DECIMAL(20, 10),
IN p_rateio_despesa_fixa_item_nacional DECIMAL(20, 10),
IN p_rateio_despesa_fixa_item_importado DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item_revenda_st_nacional DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item_outros_nacional DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item_revenda_st_importado DECIMAL(20, 10),
IN p_percentual_lucro_necessario_item_outros_importado DECIMAL(20, 10),
IN p_percentual_acrescimo_item_nacional DECIMAL(20,10),
IN p_percentual_acrescimo_item_importado DECIMAL(20,10),
OUT p_id_taxa INT,
OUT p_mensagem VARCHAR(255))
BEGIN
INSERT INTO tb_taxas
(data_inicio,
nome,
percentual_aliquota_externa_icms_item_nacional,
percentual_aliquota_externa_icms_item_importado,
percentual_mva_item_nacional,
percentual_mva_item_importado,
percentual_aliquota_interna_icms_item_nacional,
percentual_aliquota_interna_icms_item_importado,
impostos_federais_item_nacional,
impostos_federais_item_importado,
rateio_despesa_fixa_item_nacional,
rateio_despesa_fixa_item_importado,
percentual_lucro_necessario_item_revenda_st_nacional,
percentual_lucro_necessario_item_outros_nacional,
percentual_lucro_necessario_item_revenda_st_importado,
percentual_lucro_necessario_item_outros_importado,
percentual_acrescimo_item_nacional,
percentual_acrescimo_item_importado)
VALUES
(p_data_inicio,
p_nome,
p_percentual_aliquota_externa_icms_item_nacional,
p_percentual_aliquota_externa_icms_item_importado,
p_percentual_mva_item_nacional,
p_percentual_mva_item_importado,
p_percentual_aliquota_interna_icms_item_nacional,
p_percentual_aliquota_interna_icms_item_importado,
p_impostos_federais_item_nacional,
p_impostos_federais_item_importado,
p_rateio_despesa_fixa_item_nacional,
p_rateio_despesa_fixa_item_importado,
p_percentual_lucro_necessario_item_revenda_st_nacional,
p_percentual_lucro_necessario_item_outros_nacional,
p_percentual_lucro_necessario_item_revenda_st_importado,
p_percentual_lucro_necessario_item_outros_importado,
p_percentual_acrescimo_item_nacional,
p_percentual_acrescimo_item_importado);
SET p_id_taxa=LAST_INSERT_ID();
SET p_mensagem='Valor inserido com sucesso';
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_taxa(
IN p_id_taxa INT,
IN p_nome TEXT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_taxas WHERE id_taxa=p_id_taxa))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_taxas SET 
nome = p_nome
WHERE id_taxa=p_id_taxa;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_taxa(
IN p_id_taxa INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_taxas WHERE id_taxa=p_id_taxa))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_taxas WHERE id_taxa=p_id_taxa;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_taxa_data_fim(
IN p_id_taxa INT,
IN p_data_fim DATETIME,
OUT p_mensagem VARCHAR(255))
BEGIN
UPDATE tb_taxas SET 
data_fim = p_data_fim
WHERE id_taxa <> p_id_taxa AND data_fim IS NULL;
SET p_mensagem='Valor editado com sucesso';
END$$
DELIMITER ;