<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Btn_New = New Button()
        Btn_Exit = New Button()
        Panel1 = New Panel()
        Btn_lucker = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btn_New
        ' 
        Btn_New.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_New.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Btn_New.Cursor = Cursors.Hand
        Btn_New.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_New.ForeColor = SystemColors.InfoText
        Btn_New.Image = CType(resources.GetObject("Btn_New.Image"), Image)
        Btn_New.Location = New Point(6, 3)
        Btn_New.Name = "Btn_New"
        Btn_New.Size = New Size(109, 95)
        Btn_New.TabIndex = 4
        Btn_New.Text = "Cadastrar Usuario"
        Btn_New.TextAlign = ContentAlignment.BottomCenter
        Btn_New.TextImageRelation = TextImageRelation.ImageAboveText
        Btn_New.UseVisualStyleBackColor = True
        ' 
        ' Btn_Exit
        ' 
        Btn_Exit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Btn_Exit.ForeColor = SystemColors.InfoText
        Btn_Exit.Image = CType(resources.GetObject("Btn_Exit.Image"), Image)
        Btn_Exit.Location = New Point(6, 400)
        Btn_Exit.Name = "Btn_Exit"
        Btn_Exit.Size = New Size(109, 91)
        Btn_Exit.TabIndex = 4
        Btn_Exit.Text = "Fechar"
        Btn_Exit.TextAlign = ContentAlignment.BottomCenter
        Btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Btn_lucker)
        Panel1.Controls.Add(Btn_Exit)
        Panel1.Controls.Add(Btn_New)
        Panel1.Location = New Point(2, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(125, 496)
        Panel1.TabIndex = 0
        ' 
        ' Btn_lucker
        ' 
        Btn_lucker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_lucker.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Btn_lucker.Cursor = Cursors.Hand
        Btn_lucker.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_lucker.ForeColor = SystemColors.InfoText
        Btn_lucker.Image = CType(resources.GetObject("Btn_lucker.Image"), Image)
        Btn_lucker.Location = New Point(6, 299)
        Btn_lucker.Name = "Btn_lucker"
        Btn_lucker.Size = New Size(109, 95)
        Btn_lucker.TabIndex = 5
        Btn_lucker.Text = "Cassino"
        Btn_lucker.TextAlign = ContentAlignment.BottomCenter
        Btn_lucker.TextImageRelation = TextImageRelation.ImageAboveText
        Btn_lucker.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(130, 520)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        Text = "Menu"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Public Property Btn_newUser As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_New As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_lucker As Button
End Class
