
-- Queries da tabela de termos
CREATE TABLE tb_termos(
    id_termo INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL, 
    observacoes TEXT,
    prazo_entrega TEXT,
    condicao_pagamento TEXT,
    garantia TEXT,
    validade TEXT,
    id_status INT NOT NULL,
    PRIMARY KEY (id_termo),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
    );
    
    INSERT INTO tb_termos (nome, observacoes, prazo_entrega, condicao_pagamento, garantia, validade, id_status) VALUES ('Padrão', 'Somos Serviço autorizado LINDE/STILL onde trabalhamos rigorosamente seguindo as normas e recomendações do fabricante, dispomos de todo o ferramental necessário para correta realização dos serviços, só utilizamos produtos de primeira linha que atendem e/ou superam os especificados pela fabricante. Prestamos serviços que visam atender as Normas Regulamentadoras NR11 e NR12.
Necessário ponto de energia 220V e área de lavagem com esgoto.', 'Nosso prazo de entrega considera as condições normais de fluxo no Brasil. Devido a pandemia do Covid-19 PODE OCORRER O AUMENTO DO PRAZO DE ENTREGA em virtude de Ações Governamentais, Parada de transportadora, companhias aéreas, Aeroportos ou outros que possam interferir neste fluxo.
Peças: Obedecendo os prazos informados item a item acima, mediante a disponibilidade de estoque na data da apresentação da proposta, podendo ser alterado até a data da efetiva confirmação do pedido.
Serviços: Agendamento segundo disponibilidade de mão de obra para execução dos serviços, melhor data possível a ser definida entre as partes mediante a confirmação do pedido.', 'Para Peças e Serviços: 20 dias do faturamento.', 'Garantia de 90 dias para peças e serviços fornecidos pela EUROLIFT;Condições: 1 - Garantia válida se as peças forem aplicadas pela Rede de Serviços Autorizados Linde STILL, norma da Fábrica; 2 - Peças e Serviços posto na EUROLIFT, não incluso deslocamentos e fretes; 3 - Não se caracteriza garantia desgaste natural de peças e serviços fornecidos; 4 - Obrigatório cumprimento do plano de manutenção preventiva conforme normas da Fábrica; 5 - Garantia compreende falha de fabricação de peças e componentes e/ou erro de execução dos serviços fornecidos.', '05 dias, exceto modificação do Fabricante no período.', 1);
    
DELIMITER $$
CREATE PROCEDURE sp_inserir_termo(
IN p_nome VARCHAR(60),
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_termos WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_termos
(nome,
observacoes,
prazo_entrega,
condicao_pagamento,
garantia,
validade,
id_status)
VALUES
(p_nome,
p_observacoes,
p_prazo_entrega,
p_condicao_pagamento,
p_garantia,
p_validade,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_termo(
IN p_id_termo INT,
IN p_nome VARCHAR(60),
IN p_observacoes TEXT,
IN p_prazo_entrega TEXT,
IN p_condicao_pagamento TEXT,
IN p_garantia TEXT,
IN p_validade TEXT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_termos WHERE id_termo=p_id_termo))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_termos SET 
nome = p_nome,
observacoes = p_observacoes,
prazo_entrega = p_prazo_entrega,
condicao_pagamento = p_condicao_pagamento,
garantia = p_garantia,
validade = p_validade,
id_status = p_id_status
WHERE id_termo=p_id_termo;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_excluir_termo(
IN p_id_termo INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_termos WHERE id_termo=p_id_termo))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_termos WHERE id_termo=p_id_termo;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;