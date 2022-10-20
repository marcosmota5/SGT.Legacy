-- Queries da tabela de mapeamento de colunas para importação de cotações de fornecedores
CREATE TABLE tb_colunas_importacao_cotacoes(
    id_coluna_importacao_cotacao INT NOT NULL AUTO_INCREMENT,
    nome_coluna_sistema VARCHAR(255) NOT NULL,
    nome_coluna_sistema_formatado VARCHAR(255) NOT NULL,
	coluna_existe TINYINT(1) NOT NULL,
    nome_coluna_cotacao VARCHAR(255) NOT NULL,
    id_fornecedor INT NOT NULL,
    PRIMARY KEY (id_coluna_importacao_cotacao),
    FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores (id_fornecedor)
    );
    
-- Kion
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('codigo_item', 'Código', 1, 'Part number / Código', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('descricao_item', 'Descrição', 1, 'Description of Goods / Descrição das Mercadorias', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('quantidade_item', 'Quantidade', 1, 'Quantity / Quantidade', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('preco_unitario_inicial_item', 'Preço unitário inicial', 1, 'Unit Price /            Pr. Unit. ', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('percentual_ipi_item', '% IPI', 1, 'IPI / ISS', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('percentual_icms_item', '% ICMS', 1, 'ICMS', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('ncm_item', 'NCM', 1, 'NCM', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('mva_item', 'MVA', 1, '% MVA', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('valor_st_item', 'Valor ST', 1, 'ST Amount / Valor ST', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('valor_total_inicial_item', 'Preço total inicial', 1, ' Total Amount /     Valor Total', 1);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('prazo_inicial_item', 'Prazo inicial', 1, 'Delivery / Entrega', 1);

-- TVH
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('codigo_item', 'Código', 1, 'Código', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('descricao_item', 'Descrição', 1, 'Descrição', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('quantidade_item', 'Quantidade', 1, 'Qtd.', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('preco_unitario_inicial_item', 'Preço unitário inicial', 1, 'Vlr. Unitário', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('percentual_ipi_item', '% IPI', 1, '% IPI', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('percentual_icms_item', '% ICMS', 1, '% ICMS', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('ncm_item', 'NCM', 1, 'NCM', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('mva_item', 'MVA', 0, '', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('valor_st_item', 'Valor ST', 1, 'Vlr. ICMS ST', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('valor_total_inicial_item', 'Preço total inicial', 1, 'Vlr. Total', 2);
INSERT INTO tb_colunas_importacao_cotacoes (nome_coluna_sistema, nome_coluna_sistema_formatado, coluna_existe, nome_coluna_cotacao, id_fornecedor) VALUES ('prazo_inicial_item', 'Prazo inicial', 1, 'Prev. Entrega', 2);

DELIMITER $$
CREATE PROCEDURE sp_inserir_coluna_importacao_cotacao(
IN p_nome_coluna_sistema VARCHAR(255),
IN p_nome_coluna_sistema_formatado VARCHAR(255),
IN p_coluna_existe TINYINT(1),
IN p_nome_coluna_cotacao VARCHAR(255),
IN p_id_fornecedor INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_colunas_importacao_cotacoes WHERE nome_coluna_sistema=p_nome_coluna_sistema AND id_fornecedor=p_id_fornecedor)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_colunas_importacao_cotacoes
(nome_coluna_sistema,
nome_coluna_sistema_formatado,
coluna_existe,
nome_coluna_cotacao,
id_fornecedor)
VALUES
(p_nome_coluna_sistema,
p_nome_coluna_sistema_formatado,
p_coluna_existe,
p_nome_coluna_cotacao,
p_id_fornecedor);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_coluna_importacao_cotacao(
IN p_id_coluna_importacao_cotacao INT,
IN p_nome_coluna_sistema VARCHAR(255),
IN p_nome_coluna_sistema_formatado VARCHAR(255),
IN p_coluna_existe TINYINT(1),
IN p_nome_coluna_cotacao VARCHAR(255),
IN p_id_fornecedor INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_colunas_importacao_cotacoes WHERE id_coluna_importacao_cotacao=p_id_coluna_importacao_cotacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_colunas_importacao_cotacoes SET 
nome_coluna_sistema = p_nome_coluna_sistema,
nome_coluna_sistema_formatado = p_nome_coluna_sistema_formatado,
coluna_existe = p_coluna_existe,
nome_coluna_cotacao = p_nome_coluna_cotacao,
id_fornecedor = p_id_fornecedor
WHERE id_coluna_importacao_cotacao=p_id_coluna_importacao_cotacao;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_coluna_importacao_cotacao(
IN p_id_coluna_importacao_cotacao INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_colunas_importacao_cotacoes WHERE id_coluna_importacao_cotacao=p_id_coluna_importacao_cotacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_colunas_importacao_cotacoes WHERE id_coluna_importacao_cotacao=p_id_coluna_importacao_cotacao;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;