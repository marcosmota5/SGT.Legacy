-- Queries de criação da tabela de versões

CREATE TABLE tb_versoes (
    id_versao INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    data_lancamento DATETIME NOT NULL,
    e_critica TINYINT(1) NOT NULL,
	PRIMARY KEY (id_versao)
);

CREATE TABLE tb_registro_alteracoes (
    id_registro_alteracao INT NOT NULL AUTO_INCREMENT,
    id_versao INT NOT NULL,
    descricao TEXT NOT NULL,
	PRIMARY KEY (id_registro_alteracao),
    FOREIGN KEY (id_versao) REFERENCES tb_versoes (id_versao)
);

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.0', '2021-02-13 11:21:00', 1);

INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (1, 'Lançamento da ferramenta');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.1', '2021-02-14 23:46:00', 1);

INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Corrigido erro que não permitia usúários administradores editar outros usuários');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada opção de alterar o texto da proposta em PDF');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada validação na importação de cotações da Kion de modo a exibir apenas e-mails que contenham o arquivo em Excel');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Corrigido problema em que não era possível alterar a data máxima no filtro de importação de cotações');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionado nome do fornecedor no formulário de importação de cotações');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada opção de exibir/ocultar o NCM das peças na visualização da proposta em PDF');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alterados todos os campos de definição de login do usuário de modo a remover acentos e outros caracteres');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alterado o nome da opção Inserir frete para Definir frete');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionadas dicas em diversos campos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada opção de definir um termo para todos os clientes');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada mensagem de confirmação de recuperação de senha para caso o usuário clique sem querer');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Corrigido campo Termo na tela de gerenciamento de clientes que estava exibindo Padrão para todos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alteradas as dimensões da tela de início e propostas de modo a ficar totalmente visível em monitores menores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alterado gráfico Quantidade de propostas por cliente para Top 10 clientes por propostas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alterados gráficos de top 5 itens de modo a desconsiderar os itens não identificados da carga de dados históricos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionado filtro de usuários na tela inicial');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Adicionada opção de cancelar edição/revisão da proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Removido temporariamente o botão de exclusão de proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (2, 'Alterado opção de visualização da proposta em PDF para só mostrar opções de exibição de códigos caso a proposta possua peças');


INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.2', '2021-02-15 23:42:00', 1);

INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Corrigido limite de caracteres em todos os campos de texto do sistema');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Corrigido erro em que não era possível atualizar o estoque quando a planilha de estoque estava aberta em outro computador');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Alteradas novamente as dimensões da tela de início de modo a ficar totalmente visível em monitores menores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Alterado o layout da tela inicial de modo que os indicadores se adequem melhor às novas dimensões');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Adicionado filtro de usuário na pesquisa básica');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Adicionada coluna Usuário na tabela da pesquisa básica e avançada');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Alterado o instalador de modo a substituir automaticamente as versões anteriores já instaladas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (3, 'Corrigido problema em que ao selecionar o fabricante Still sem uma série informada o campo Ano ficava sempre definido como 1980');


INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.3', '2021-02-18 00:19:00', 1);

INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Alterado e-mail do sistema para um do domínio euroliftempilhadeiras.com.br');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Corrigido problema em que ao definir um termo para o cliente era sempre definido como o padrão');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Adicionado campo Setor para os usuários');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Corrigido problema em que os comentários da proposta não eram carregados');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Corrigido problema que permitia que itens fossem editados ou excluídos mesmo sem editar a proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Alterada a forma de salvar termos, agora isto é feito diretamente na proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Adicionado filtro de setores na pesquisa básica, avançada e na tela inicial');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Adicionado limite de resultados o qual pode ser definido nas opções');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Corrigido problema em que ao editar uma proposta e inserir um novo item, ao salvar essa proposta o item era duplicado');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (4, 'Corrigido problema em que sempre ao atualizar o prazo a coluna de usuário de inserção do item era movida para a direita');


INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.4', '2021-02-18 15:10:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Removido limite de caracteres do campo Cabeçalho nos termos da proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Adicionada verificação de novas versões do sistema e atualização automática');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Alterado o registro de alterações de modo a exibir em tempo real as modificações');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Corrigido erro que acontecia ao confirmar o carregamento de um termo com uma das caixas de seleção vazia');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Corrigido erro que impossibilitava a alteração do perfil do usuário');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Alterado o tamanho e removidas as casas decimais do rótulos do gráfico de faturamento mensal');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (5, 'Adicionada opção de carregar termos da proposta de termos gerais cadastrados');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.5', '2021-02-19 00:29:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionada tratativa para peças com prazo do fornecedor contendo um asterisco');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionada barra de progresso no momento da importação de peças');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionada barra de progresso no momento da atualização do prazo das peças');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Corrigido problema em que ao revisar uma proposta o código da revisão era retornado errado');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Corrigido problema em que ao revisar uma proposta, cancelar a revisão e depois editar a mesma proposta o código era mantido como o código de revisão');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionado filtro para considerar ou não propostas revisadas nas pesquisas e indicadores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Corrigido problema em que o horímetro não era carregado ao abrir uma proposta existente');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionado campo Ordem de serviço na proposta, pesquisa avançada e proposta em PDF');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionado campos de detalhes de aprovação (apenas visuais) na proposta em PDF');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionada opção de abrir a proposta clicando com o botão direito na pesquisa padrão e avançada');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Adicionada opção de abrir diretamente a proposta em PDF clicando com o botão direito na pesquisa padrão e avançada');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (6, 'Corrigido problema em que o instalador não permitia continuar por conta de um delay para fechar o sistema');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.6', '2021-02-22 00:12:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Corrigido problema em que tornava possível carregar termos antes de editar a proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Alterada a forma de exibição dos campos de carregamento de termos na proposta ao exibir uma proposta existente');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Corrigido problema em que ao imprimir diretamente a proposta eram geradas páginas em branco contendo apenas cabeçalho e rodapé');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Adicionada opção de alterar os contatos através de um formulário próprio, disponível na opção Parâmetros');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Adicionado bloqueio na exclusão de parâmetros e usuários de modo a não permitir a exclusão de itens que existam em outras tabelas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (7, 'Corrigido problema que não permitia a exclusão de usuários');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.7', '2021-02-23 22:14:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Alterada verificação de versões de modo a identificar versões críticas intermediárias');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Efetuada nova alteração de modo a tentar corrigir problema em que ao imprimir propostas eram impressas páginas em branco indefinidamente em alguns computadores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Corrigido problema em que a seleção de parâmetros por meio do teclado não era reconhecida');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Alterado cabeçalho da tabela e rótulo de nome em todos os parâmetros para refletir o parâmetro selecionado');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Adicionada opção de inserir/alterar fornecedores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Adicionada opção de inserir/alterar fabricantes');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Adicionada opção de inserir/alterar tipos de equipamentos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (8, 'Adicionada opção de inserir/alterar modelos');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.8', '2021-02-25 00:33:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (9, 'Alterado o formulário de informação de nova versão disponível de modo a mostrar as alterações efetuadas e corrigir problemas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (9, 'Adicionada opção de inserir/alterar famílias');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (9, 'Adicionada opção de inserir/alterar anos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (9, 'Adicionada opção de inserir/alterar séries');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (9, 'Corrigido problema em que era possível clicar em que era possível excluir um parâmetro não permitido, o que gerava um erro');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.0.9', '2021-02-28 23:33:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Corrigido erro que acontecia ao tentar inserir/editar um contato com os campos de telefone e/ou e-mail em branco');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de inserir/alterar empresas - Disponível apenas para o login de administrador principal');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de inserir/alterar filiais - Disponível apenas para o login de administrador principal');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de inserir/alterar setores - Disponível apenas para o login de administrador principal');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Movida a opção do prazo adicional de peças para o formulário de setores');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Alterado o comportamento do texto informado na adição/edição de itens de modo a refletir o tipo de item selecionado');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Corrigido problema no qual era retornado um erro na proposta em PDF nos itens que não possuem NCM');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Alterado alinhamento vertical dos itens da proposta em PDF');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de exibir/ocultar os códigos diretamente na visualização da proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de inserir/alterar conjuntos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de inserir/alterar especificações');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de definir conjuntos/especificações de peças na proposta clicando com o botão direito no campo em questão ou através da opção de inserir/editar peça');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção de exibir/ocultar os conjuntos das peças na visualização da proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Corrigido erro que acontecia ao abrir a edição de perfil quando não havia emails em cópia ou texto padrão cadastrado');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Adicionada opção pesquisar propostas por conjunto ou especificação através da pesquisa avançada');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (10, 'Correções de bugs visuais');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.0', '2021-03-04 23:36:00', 0);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Corrigido problema em que ao editar o item o campo de prazo inicial era preenchido com o prazo final');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Adicionadas mensagens de lembrete ao alterar a quantidade de peças na proposta');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Alterado o gráfico Quantidade por motivo da aprovação para Quantidade não aprovada por motivo');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Alterada a classificação de data de todos os gráficos e filtros do início de Data de inserção para Data de envio');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Adicionado filtro de modo a mostrar nos gráficos do início apenas propostas enviadas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Alterada a opção de definição de frete de modo a considerar apenas o tipo de item Peça');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Adicionada opção de definir o desconto final na adição/edição de itens também para serviços e deslocamentos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Adicionada opção de definir o desconto de custo (apenas para peças) e final para todos os itens');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Corrigido problema no qual, ao salvar uma proposta sem série mas com dados do equipamento, esses dados não eram carregados posteriormente');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Alterados diversos textos de modo a exibir dados mais coerentes');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (11, 'Correções de bugs visuais');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.1', '2021-04-09 00:16:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (12, 'Alterados os tamanhos dos controles na tela de edição de termos');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (12, 'Removida a opção de definir o termo na adição/edição de clientes');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (12, 'Adicionada opção de associar termos à setores e clientes');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (12, 'Alterada a forma de carregamento de termos para adequar ao novo modo');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (12, 'Habilitada a opção de exclusão de propostas para o administrador principal');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.2', '2021-05-03 22:33:00', 0);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (13, 'Ajustada a opção de carga de dados para o formato atual de propostas e itens de propostas');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (13, 'Habilitada a opção de carga de dados para o administrador principal');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (13, 'Adicionada senha adicional para a carga de dados por ser uma função crítica');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.3', '2021-05-27 23:49:00', 0);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (14, 'Removida a opção de envio de notificação');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (14, 'Adicionada a opção de registro de requisições');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (14, 'Adicionados ícones nas opções da página inicial');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.4', '2021-07-07 20:45:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Corrigido erro que acontecia ao tentar importar cotações da TVH por conta de mudança na estrutura');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Corrigido erro que acontecia ao importar cotações da TVH com apenas 1 peça');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Desabilitado temporariamente o redimensionamento automático dos controles da tela inicial');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Adicionada opção de visualizar o comentário da requisição ao clicar duas vezes sobre o item');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Alterada a forma de seleção da pasta de estoque de modo a corrigir o problema de seleção de pastas de rede');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (15, 'Corrigido problema no envio de e-mail de requisições');

INSERT INTO tb_versoes (nome, data_lancamento, e_critica) VALUES ('1.0.1.5', '2021-07-11 17:19:00', 1);
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (16, 'Alterada a forma de importação de cotações da Kion e TVH de modo a considerar o nome das colunas ao invés da posição');
INSERT INTO tb_registro_alteracoes (id_versao, descricao) VALUES (16, 'Adicionada opção de edição do nome das colunas de importação para caso ocorra alterações  - Disponível apenas para o login de administrador principal');
