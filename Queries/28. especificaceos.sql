
-- Queries da tabela de conjuntos
CREATE TABLE tb_especificacoes (
    id_especificacao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    id_conjunto INT NOT NULL,
    id_status INT NOT NULL,
	PRIMARY KEY (id_especificacao),
    FOREIGN KEY (id_conjunto) REFERENCES tb_conjuntos (id_conjunto),
    FOREIGN KEY (id_status) REFERENCES tb_status (id_status)
);

INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Buzina', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cinto de Segurança', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Extintor de Incêndio', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Iluminação de Serviço', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Luzes Indicativas', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Micro do Banco', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Micro do Homem Morto', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Micro Estacionamento', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Trava do banco', 1, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Verificação / Ajuste', 2, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Verificar Desgaste', 3, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Conectores', 4, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Contatos', 4, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Ponto do Power Lockout', 4, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Avaliação Rolamentos / Vedações', 5, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desmontagem', 5, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Montegem / Ajuste / Lubrificação', 5, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Avaliação Placas de Atrito', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Avaliação Rolamentos', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Corretor Lateral / Cilindro', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Corretor Lateral / Placas de Atrito', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desgaste dos Garfos', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desmontar Corretor Lateral', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Fadiga / Trincas / Empenos', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Funcionamento Corretor Lateral', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Limitadores Fim de Curso', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Lubrificação', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Pino de Trava dos Garfos', 6, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Apresentação Geral', 7, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Capacidade de Carga', 7, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Frota', 7, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Regra de "1 Metro"', 7, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Compartimento Bateria', 8, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Compartimento Motores', 8, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Limpeza Geral', 8, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Placas eletrônicas', 8, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Limpeza Geral', 9, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Lubrificação Básica', 9, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Segundo Plano de Lubrificação', 10, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Chave de Emergência', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Chave de Seta / Botoeiras', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Chave Liga/desliga', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Horímetro', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Interruptor de Buzina', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Marcador de Descarga Bateria', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Painel de Instrumentos', 11, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cabos / Terminais / Bombinas', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Coletor de Induzido', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Escovas / Porta Escovas', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Fusíveis / Porta Fusíveis', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Isolação', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Retentores', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Rolamentos', 12, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Ajustar Correntes', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Analisar Correntes', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Fadiga / Trincas / Deformação', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Folgas', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Inspeção Visual Geral', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mangueiras: Desgaste / Vazamentos', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Polias / Roldanas', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Rolamentos / Calços / Placas Atrito', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Testar Funcionamento', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Verificar Folgas / Placas Atrito', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Verificar Rolamentos', 13, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Acionamento Sensores', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Avaliação', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desmontagem', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Folgas', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Inspeção Visual Geral', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Limpeza Interna', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Lubrificação / Ajustes', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Pinos / Rótulas / Rolamentos', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Rolamentos / Perfis', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Testar Funcionamento', 14, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Avarias nas Rodas / Pneus', 15, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desgate dos Pneus', 15, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Folgas de Rolamentos', 15, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Reaperto Parafusos e Marcação', 15, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Inspeção Visual Geral', 16, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Testar Funcionamento', 16, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Checar Nível de Fluídos', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindro Mestre', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros Auxiliares / Pinças', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Desmontagem / Avaliação', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Discos de Freio', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Freio de Estacionamento / Ajustar', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Freio Magnético / Ajustar', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Limpeza Interna', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Montagem / Ajustes', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Nível de Fluídos', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Pastilhas / Lonas / Ajustar', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Pedais', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Testar Funcionamento', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Troca do Fluído', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Tubulações / Vazamentos', 17, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Amortecedores', 18, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mancais', 18, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Molas', 18, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindro / Vazamentos', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Correntes / Corôas / Cremalheira', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mangas de Eixo / Graxeiros', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mangueiras e Conexões', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Motores Elétricos / Hidráulicos', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Orbitrol, Coluna de Direção', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Rolamento Flange', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Rótulas / Terminais / Graxeiros', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Timão de Comando', 19, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Contatores / Relés', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Controladores', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Oxidação de Conexões', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Parâmetros do Controlador', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Placas Eletrônicas', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Reaperto de Conexões', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Sensores / Atuadores', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Verificação Cabos/Chicotes', 20, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Bomba hidráulica', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindro Deslocador', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros de Elevação', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros de Inclinação', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros Retrak', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Comandos de Válvulas', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Conexões / Reaperto', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mangueiras', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Nível de Óleo', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Ruído Bomba', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Válvulas', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Vazamentos', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Medição de Pressão / Ajustes', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Reaperto Conexões / Marcação', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Troca de Filtros', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Troca Óleos', 21, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Checagem de Limalhas', 22, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Folgas / Ruídos', 22, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Nível de Óleo', 22, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Reaperto / Marcação', 22, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Troca Óleo', 22, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Acessórios Adicionais', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros do Mastro', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros Inclinação', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Cilindros Retrak', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Comando Hidráulico', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Mangueiras / Conexões', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Motores', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Tanque', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Transmissão', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Válvulas', 23, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Fixação / Marcação', 24, 1);
INSERT INTO tb_especificacoes (nome, id_conjunto, id_status) VALUES ('Outro', 25, 1);

DELIMITER $$
CREATE PROCEDURE sp_inserir_especificacao(
IN p_nome VARCHAR(60),
IN p_id_conjunto INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(EXISTS(SELECT * FROM tb_especificacoes WHERE nome=p_nome)) THEN
SET p_mensagem='Valor já existe';
ELSE
INSERT INTO tb_especificacoes 
(nome,
id_conjunto,
id_status) 
VALUES 
(p_nome,
p_id_conjunto,
p_id_status);
SET p_mensagem='Valor inserido com sucesso';
END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_editar_especificacao(
IN p_id_especificacao INT,
IN p_nome VARCHAR(60),
IN p_id_conjunto INT,
IN p_id_status INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_especificacoes WHERE id_especificacao=p_id_especificacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
UPDATE tb_especificacoes SET 
nome = p_nome,
id_conjunto = p_id_conjunto,
id_status = p_id_status
WHERE id_especificacao=p_id_especificacao;
SET p_mensagem='Valor editado com sucesso';
END IF;
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE sp_excluir_especificacao(
IN p_id_especificacao INT,
OUT p_mensagem VARCHAR(255))
BEGIN
IF(NOT(EXISTS(SELECT * FROM tb_especificacoes WHERE id_especificacao=p_id_especificacao))) THEN
SET p_mensagem='Valor não existe';
ELSE
DELETE FROM tb_especificacoes
WHERE id_especificacao=p_id_especificacao;
SET p_mensagem='Valor excluído com sucesso';
END IF;
END$$
DELIMITER ;