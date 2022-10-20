Public Class Desconto

    Private Sub btn_Inserir_Click(sender As Object, e As EventArgs) Handles btn_Inserir.Click

        Dim PercentualDesconto As Decimal = DIVIDE(CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(nud_Percentual_Desconto.Value))), 100)

        For Each dtb_row As DataRow In dtbItens.Rows
            Select Case get_coluna_desconto
                Case "desconto_inicial_item"
                    If CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtb_row("id_tipo_item"))) = 1 Then
                        dtb_row("desconto_inicial_item") = PercentualDesconto
                    End If
                Case "desconto_final_item"
                    If get_id_tipo_item_desconto > 0 Then
                        If CONVERT_TO_INTEGER(CONVERT_TO_STRING(dtb_row("id_tipo_item"))) = get_id_tipo_item_desconto Then
                            dtb_row("desconto_final_item") = PercentualDesconto
                        End If
                    Else
                        dtb_row("desconto_final_item") = PercentualDesconto
                    End If

            End Select
        Next

        Me.Close()

    End Sub

    Private Sub Desconto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nud_Percentual_Desconto.ResetText()
        'nud_Percentual_Desconto.Controls(0).Visible = False

        Select Case get_coluna_desconto
            Case "desconto_inicial_item"
                nud_Percentual_Desconto.Value = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Avg(desconto_inicial_item)", "id_tipo_item = 1")))) * 100
            Case "desconto_final_item"
                If get_id_tipo_item_desconto > 0 Then
                    nud_Percentual_Desconto.Value = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Avg(desconto_final_item)", "id_tipo_item = " & CONVERT_TO_STRING(get_id_tipo_item_desconto))))) * 100
                Else
                    nud_Percentual_Desconto.Value = CONVERT_TO_DECIMAL(Trim(CONVERT_TO_STRING(dtbItens.Compute("Avg(desconto_final_item)", "")))) * 100
                End If
        End Select


    End Sub

End Class