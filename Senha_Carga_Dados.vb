Public Class Senha_Carga_Dados

    Private Sub btn_Mostrar_Senha_Click(sender As Object, e As EventArgs) Handles btn_Mostrar_Senha.Click

        btn_Mostrar_Senha.Visible = False
        btn_Esconder_Senha.Visible = True
        txt_Senha.PasswordChar = ""

    End Sub

    Private Sub btn_Esconder_Senha_Click(sender As Object, e As EventArgs) Handles btn_Esconder_Senha.Click
        btn_Mostrar_Senha.Visible = True
        btn_Esconder_Senha.Visible = False
        txt_Senha.PasswordChar = "*"
    End Sub
    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click

        Dim form = New Carga_Dados

        If txt_Senha.Text <> "I3i&z6R=#wj0" Then
            MessageBox.Show(Me, "Senha incorreta", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Hide()
        Form.ShowDialog()

    End Sub
End Class