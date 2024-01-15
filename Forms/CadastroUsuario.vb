
Imports MySql.Data.MySqlClient
Imports WinFormsApp1.Accounts

Public Class CadastroUsuario
    Private Sub CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim Account As New Account.EventReceiver
        Dim Saved As Boolean
        Try
            Dim Username As String
            'Verificador se o primeiro Nome foi escrito
            If Not String.IsNullOrEmpty(txtUsername.Text) Then
                Username = txtUsername.Text
            Else
                MsgBox("Insira o Nome")
                Return
            End If

            Dim Name As String
            'Verificador se o sobrenome foi escrito
            If Not String.IsNullOrEmpty(txtName.Text) Then
                Name = txtName.Text
            Else
                MsgBox("Insira o Sobrenome")
                Return
            End If

            Dim GenderName As String
            'Verificador se o Genero foi escrito
            If Not String.IsNullOrEmpty(CbGender.Text) Then
                GenderName = CbGender.Text
            Else
                MsgBox("Insira o Genero")
                Return
            End If

            Dim Email As String
            'Verificador se o email foi escrito
            If Not String.IsNullOrEmpty(txtEmail.Text) Then
                Email = txtEmail.Text + "@fliper.com"
            Else
                MsgBox("Insira o Email")
                Return
            End If

            Dim Birth As String
            'Verificador se a data de nascimento foi escrito
            If Not String.IsNullOrEmpty(dtBirth.Value) Then
                Birth = dtBirth.Value
            Else
                MsgBox("Insira o Genero")
                Return
            End If

            Dim UserType As String
            'Verificador se o Tipo de usuario foi escrito
            If Not String.IsNullOrEmpty(CbSelectPerm.Text) Then
                UserType = CbSelectPerm.Text
            Else
                MsgBox("Insira o tipo de Usuario")
                Return
            End If

            Dim Password As String
            'Verificador se a Senha foi escrito
            If Not String.IsNullOrEmpty(CbSelectPerm.Text) Then
                Password = txtInputPassword.Text
            Else
                MsgBox("Insira a Senha")
                Return
            End If

            Dim ConfirmPassword As String
            'Verificador se confirma Senha foi escrito
            If Not String.IsNullOrEmpty(CbSelectPerm.Text) Then
                ConfirmPassword = txtInputConfirmPassword.Text
            Else
                MsgBox("Confirme a Senha")
                Return
            End If

            If Password <> ConfirmPassword Then
                MsgBox("As senhas não são iguais!")
                Return
            End If

            Saved = Account.SaveNewUser(Username,
                Name,
                GenderName,
                Email,
                Birth,
                UserType,
                Password)

            If Saved = True Then
                txtUsername.Text = ""
                txtName.Text = ""
                CbGender.Text = ""
                txtEmail.Text = ""
                CbSelectPerm.Text = ""
                txtInputPassword.Text = ""
                txtInputConfirmPassword.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Close()
        Menu.Show()
    End Sub

End Class