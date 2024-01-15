Imports Google.Protobuf.WellKnownTypes
Imports WinFormsApp1.Accounts

Public Class Login


    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Dim Account As New Account.EventReceiver
        Dim UserId As Integer

        Dim Username As String
        'Verificador se o primeiro Nome foi escrito
        If Not String.IsNullOrEmpty(txtUsername.Text) Then
            Username = txtUsername.Text
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

        UserId = Account.LoginUser(Username, Senha)
        If UserId > 0 Then
            Me.Hide()
            Menu.Show()
            Menu.Menu_Load(UserId)
        End If
    End Sub
End Class