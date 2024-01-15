<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroUsuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designerff   
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroUsuario))
        btn_Save = New Button()
        txtEmail = New TextBox()
        Label_Email = New Label()
        Panel1 = New Panel()
        Titulo = New Label()
        Btn_back = New Button()
        Label_Username = New Label()
        txtUsername = New TextBox()
        Label_dtBirth = New Label()
        Label_Name = New Label()
        txtName = New TextBox()
        TextBox5 = New TextBox()
        dtBirth = New DateTimePicker()
        CbGender = New ComboBox()
        Label_Gender = New Label()
        CbSelectPerm = New ComboBox()
        Label1 = New Label()
        Label_password = New Label()
        txtInputPassword = New TextBox()
        Label_confirmPassword = New Label()
        txtInputConfirmPassword = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_Save
        ' 
        btn_Save.Location = New Point(556, 261)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(90, 36)
        btn_Save.TabIndex = 0
        btn_Save.Text = "Salvar"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(30, 148)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(291, 23)
        txtEmail.TabIndex = 1
        ' 
        ' Label_Email
        ' 
        Label_Email.AutoSize = True
        Label_Email.Location = New Point(30, 130)
        Label_Email.Name = "Label_Email"
        Label_Email.Size = New Size(39, 15)
        Label_Email.TabIndex = 3
        Label_Email.Text = "Email:"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Titulo)
        Panel1.Controls.Add(Btn_back)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 63)
        Panel1.TabIndex = 5
        ' 
        ' Titulo
        ' 
        Titulo.AutoSize = True
        Titulo.Location = New Point(166, 14)
        Titulo.Name = "Titulo"
        Titulo.Size = New Size(113, 15)
        Titulo.TabIndex = 1
        Titulo.Text = "Cadastro de Usuario"
        ' 
        ' Btn_back
        ' 
        Btn_back.Image = CType(resources.GetObject("Btn_back.Image"), Image)
        Btn_back.Location = New Point(5, 8)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(50, 50)
        Btn_back.TabIndex = 0
        Btn_back.UseVisualStyleBackColor = True
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Location = New Point(30, 84)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(50, 15)
        Label_Username.TabIndex = 7
        Label_Username.Text = "Usuario:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(30, 102)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(153, 23)
        txtUsername.TabIndex = 6
        ' 
        ' Label_dtBirth
        ' 
        Label_dtBirth.AutoSize = True
        Label_dtBirth.Location = New Point(445, 130)
        Label_dtBirth.Name = "Label_dtBirth"
        Label_dtBirth.Size = New Size(115, 15)
        Label_dtBirth.TabIndex = 9
        Label_dtBirth.Text = "Data de nascimento:"
        ' 
        ' Label_Name
        ' 
        Label_Name.AutoSize = True
        Label_Name.Location = New Point(189, 84)
        Label_Name.Name = "Label_Name"
        Label_Name.Size = New Size(43, 15)
        Label_Name.TabIndex = 11
        Label_Name.Text = "Nome:"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(189, 102)
        txtName.Name = "txtName"
        txtName.Size = New Size(326, 23)
        txtName.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Enabled = False
        TextBox5.Location = New Point(327, 148)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(112, 23)
        TextBox5.TabIndex = 12
        TextBox5.Text = "@fliper.com"
        ' 
        ' dtBirth
        ' 
        dtBirth.Format = DateTimePickerFormat.Short
        dtBirth.Location = New Point(445, 148)
        dtBirth.Name = "dtBirth"
        dtBirth.Size = New Size(173, 23)
        dtBirth.TabIndex = 13
        ' 
        ' CbGender
        ' 
        CbGender.DropDownStyle = ComboBoxStyle.DropDownList
        CbGender.FormattingEnabled = True
        CbGender.Items.AddRange(New Object() {"Masculino", "Feminino"})
        CbGender.Location = New Point(521, 101)
        CbGender.Name = "CbGender"
        CbGender.Size = New Size(97, 23)
        CbGender.TabIndex = 14
        CbGender.Tag = ""
        ' 
        ' Label_Gender
        ' 
        Label_Gender.AutoSize = True
        Label_Gender.Location = New Point(521, 83)
        Label_Gender.Name = "Label_Gender"
        Label_Gender.Size = New Size(48, 15)
        Label_Gender.TabIndex = 15
        Label_Gender.Text = "Gênero:"
        ' 
        ' CbSelectPerm
        ' 
        CbSelectPerm.FormattingEnabled = True
        CbSelectPerm.Items.AddRange(New Object() {"Administrador", "Usuario"})
        CbSelectPerm.Location = New Point(465, 197)
        CbSelectPerm.Name = "CbSelectPerm"
        CbSelectPerm.Size = New Size(153, 23)
        CbSelectPerm.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(465, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 17
        Label1.Text = "Tipo de Usuario"
        ' 
        ' Label_password
        ' 
        Label_password.AutoSize = True
        Label_password.Location = New Point(30, 180)
        Label_password.Name = "Label_password"
        Label_password.Size = New Size(42, 15)
        Label_password.TabIndex = 19
        Label_password.Text = "Senha:"
        ' 
        ' txtInputPassword
        ' 
        txtInputPassword.BorderStyle = BorderStyle.FixedSingle
        txtInputPassword.Location = New Point(30, 198)
        txtInputPassword.Name = "txtInputPassword"
        txtInputPassword.Size = New Size(212, 23)
        txtInputPassword.TabIndex = 18
        ' 
        ' Label_confirmPassword
        ' 
        Label_confirmPassword.AutoSize = True
        Label_confirmPassword.Location = New Point(248, 179)
        Label_confirmPassword.Name = "Label_confirmPassword"
        Label_confirmPassword.Size = New Size(104, 15)
        Label_confirmPassword.TabIndex = 21
        Label_confirmPassword.Text = "Confirme a Senha:"
        ' 
        ' txtInputConfirmPassword
        ' 
        txtInputConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtInputConfirmPassword.Location = New Point(248, 197)
        txtInputConfirmPassword.Name = "txtInputConfirmPassword"
        txtInputConfirmPassword.Size = New Size(211, 23)
        txtInputConfirmPassword.TabIndex = 20
        ' 
        ' CadastroUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 307)
        Controls.Add(Label_confirmPassword)
        Controls.Add(txtInputConfirmPassword)
        Controls.Add(Label_password)
        Controls.Add(txtInputPassword)
        Controls.Add(Label1)
        Controls.Add(CbSelectPerm)
        Controls.Add(Label_Gender)
        Controls.Add(CbGender)
        Controls.Add(dtBirth)
        Controls.Add(TextBox5)
        Controls.Add(Label_Name)
        Controls.Add(txtName)
        Controls.Add(Label_dtBirth)
        Controls.Add(Label_Username)
        Controls.Add(txtUsername)
        Controls.Add(Panel1)
        Controls.Add(Label_Email)
        Controls.Add(txtEmail)
        Controls.Add(btn_Save)
        FormBorderStyle = FormBorderStyle.None
        Name = "CadastroUsuario"
        Text = "CadastroUsuario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Titulo As Label
    Friend WithEvents Btn_back As Button
    Friend WithEvents Label_Username As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label_dtBirth As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents dtBirth As DateTimePicker
    Friend WithEvents CbGender As ComboBox
    Friend WithEvents Label_Gender As Label
    Friend WithEvents CbSelectPerm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_password As Label
    Friend WithEvents txtInputPassword As TextBox
    Friend WithEvents Label_confirmPassword As Label
    Friend WithEvents txtInputConfirmPassword As TextBox
End Class
