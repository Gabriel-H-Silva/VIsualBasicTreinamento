<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        PictureBox2 = New PictureBox()
        Btn_login = New Button()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(211, 452)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(252, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 31)
        Label1.TabIndex = 1
        Label1.Text = "Login Fliper 2024 Remake"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(18, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 32)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ControlLight
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(49, 101)
        txtPassword.Margin = New Padding(5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(288, 33)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ControlLight
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(49, 41)
        txtUsername.Margin = New Padding(5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(289, 33)
        txtUsername.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(18, 101)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 33)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Btn_login
        ' 
        Btn_login.ForeColor = Color.Black
        Btn_login.Location = New Point(142, 320)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(91, 43)
        Btn_login.TabIndex = 2
        Btn_login.Text = "Logar"
        Btn_login.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Btn_login)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(PictureBox1)
        Panel2.ForeColor = Color.DarkGray
        Panel2.Location = New Point(227, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(359, 368)
        Panel2.TabIndex = 7
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 450)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Login"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Panel2 As Panel
End Class
