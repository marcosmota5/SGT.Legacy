Public Class Comentario_Manifestacao
    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click

        Dim dtb_row As DataRow

        If txt_Comentario.Text = "" Then
            MessageBox.Show(Me, "O campo do comentário não pode ficar vazio", "Campos obrigatórios não prenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        dtb_row = dtbComenatarios.NewRow
        dtb_row("id_comentario_registro_manifestacao") = 0
        dtb_row("id_registro_manifestacao") = get_id_registro_manifestacao
        dtb_row("data_insercao") = Now
        dtb_row("comentario") = txt_Comentario.Text
        dtb_row("nome_pessoa_insercao") = get_nome_usuario
        dtb_row("email_pessoa_insercao") = get_email_usuario

        dtbComenatarios.Rows.Add(dtb_row)

        Me.Close()

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class