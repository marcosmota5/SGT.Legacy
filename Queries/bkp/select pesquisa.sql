SELECT itpr.id_item_proposta AS ID_Item_Proposta, itpr.id_proposta AS ID_Proposta, prop.codigo_proposta AS Codigo_Proposta, prop.data_solicitacao AS Data_Solicitacao, clie.nome AS Nome_Cliente, cont.nome AS Nome_Contato, prop.data_envio AS Data_Envio
FROM tb_itens_propostas AS itpr
INNER JOIN tb_usuarios AS itpr_usua_ins ON itpr.id_usuario=itpr_usua_ins.id_usuario
INNER JOIN tb_status AS itpr_stat ON itpr.id_status=itpr_stat.id_status
INNER JOIN tb_status_aprovacao AS stap ON itpr.id_status_aprovacao=stap.id_status_aprovacao
INNER JOIN tb_justificativas_aprovacao AS juap ON itpr.id_justificativa_aprovacao=juap.id_justificativa_aprovacao
INNER JOIN tb_tipos_item AS tiit ON itpr.id_tipo_item=tiit.id_tipo_item
INNER JOIN tb_fornecedores AS forn ON itpr.id_fornecedor=forn.id_fornecedor
INNER JOIN tb_tipos_substituicao_tributaria AS tstr ON itpr.id_tipo_substituicao_tributaria_item=tstr.id_tipo_substituicao_tributaria
INNER JOIN tb_origens AS orig ON itpr.id_origem_item=orig.id_origem
INNER JOIN tb_propostas AS prop ON itpr.id_proposta=prop.id_proposta
INNER JOIN tb_filiais AS fili ON prop.id_filial=fili.id_filial
INNER JOIN tb_clientes AS clie ON prop.id_cliente=clie.id_cliente
INNER JOIN tb_contatos AS cont ON prop.id_contato=cont.id_contato
INNER JOIN tb_prioridades AS prio ON prop.id_prioridade=prio.id_prioridade
INNER JOIN tb_fabricantes AS fabr ON prop.id_fabricante=fabr.id_fabricante
INNER JOIN tb_tipos_equipamento AS tieq ON prop.id_tipo_equipamento=tieq.id_tipo_equipamento
INNER JOIN tb_modelos AS mode ON prop.id_modelo=mode.id_modelo
INNER JOIN tb_anos AS ano ON prop.id_ano=ano.id_ano
INNER JOIN tb_series AS seri ON prop.id_serie=seri.id_serie