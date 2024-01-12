
Public Class CadastroUsuario
    Private Sub CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        Dim FirstName As String
        'Verificador se o primeiro Nome foi escrito
        If Not String.IsNullOrEmpty(txtFirstName.Text) Then
            FirstName = txtFirstName.Text
        Else
            MsgBox("Insira o Nome")
            Return
        End If

        Dim LastName As String
        'Verificador se o sobrenome foi escrito
        If Not String.IsNullOrEmpty(txtLastName.Text) Then
            LastName = txtLastName.Text
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


        SaveNewUser(FirstName, LastName, GenderName, Email, Birth, UserType)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Close()
        Menu.Show()
    End Sub

End Class