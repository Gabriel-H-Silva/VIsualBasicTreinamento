Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Email As String
        'Verificador se o primeiro Nome foi escrito
        If Not String.IsNullOrEmpty(txtEmail.Text) Then
            Email = txtEmail.Text
        Else
            MsgBox("Insira o Email")
            Return
        End If

        Dim Senha As String
        'Verificador se o sobrenome foi escrito
        If Not String.IsNullOrEmpty(txtPassword.Text) Then
            Senha = txtPassword.Text
        Else
            MsgBox("Insira a Senha")
            Return
        End If


    End Sub
End Class