Public Class Inserir_Frete
    Private Sub btn_Inserir_Click(sender As Object, e As EventArgs) Handles btn_Inserir.Click

        Dim TotalFrete As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(nud_Valor_Frete.Value)))
        Dim QuantidadeTotalItens As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(quantidade_item)", "id_tipo_item = 1"))))
        Dim ValorUnitarioItens As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(preco_unitario_inicial_item)", "id_tipo_item = 1"))))
        Dim ValorTotalItens As Decimal = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(valor_total_inicial_item)", "id_tipo_item = 1"))))

        For Each dtb_row As DataRow In dtbItens.Rows
            If CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtb_row("id_tipo_item"))) = 1 Then
                Select Case get_tipo_inserir_frete
                    Case 1
                        dtb_row("frete_unitario_item") = DIVIDE(TotalFrete, CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Select("id_tipo_item = 1").Count))))
                    Case 2
                        dtb_row("frete_unitario_item") = TotalFrete * DIVIDE(CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtb_row("preco_unitario_inicial_item")))), ValorUnitarioItens)
                    Case 3
                        dtb_row("frete_unitario_item") = TotalFrete * DIVIDE(CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtb_row("quantidade_item")))), QuantidadeTotalItens)
                    Case 4
                        dtb_row("frete_unitario_item") = TotalFrete * DIVIDE(CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtb_row("valor_total_inicial_item")))), ValorTotalItens)
                End Select
            End If
        Next

        Me.Close()

    End Sub

    Private Sub Inserir_Frete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nud_Valor_Frete.ResetText()
        'nud_Valor_Frete.Controls(0).Visible = False

        nud_Valor_Frete.Value = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Sum(frete_unitario_item)", "id_tipo_item = 1"))))
    End Sub
End Class