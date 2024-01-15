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
        Button1 = New Button()
        Panel_Infinit = New Panel()
        txtUsername_Title = New Label()
        Panel3 = New Panel()
        Panel2 = New Panel()
        txtSaldo = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel_Infinit.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btn_New
        ' 
        resources.ApplyResources(Btn_New, "Btn_New")
        Btn_New.Cursor = Cursors.Hand
        Btn_New.ForeColor = SystemColors.InfoText
        Btn_New.Name = "Btn_New"
        Btn_New.UseVisualStyleBackColor = True
        ' 
        ' Btn_Exit
        ' 
        resources.ApplyResources(Btn_Exit, "Btn_Exit")
        Btn_Exit.ForeColor = SystemColors.InfoText
        Btn_Exit.Name = "Btn_Exit"
        Btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Btn_lucker)
        Panel1.Controls.Add(Btn_Exit)
        Panel1.Controls.Add(Btn_New)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' Btn_lucker
        ' 
        resources.ApplyResources(Btn_lucker, "Btn_lucker")
        Btn_lucker.Cursor = Cursors.Hand
        Btn_lucker.ForeColor = SystemColors.InfoText
        Btn_lucker.Name = "Btn_lucker"
        Btn_lucker.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = SystemColors.InfoText
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel_Infinit
        ' 
        Panel_Infinit.BackColor = SystemColors.HotTrack
        Panel_Infinit.BorderStyle = BorderStyle.FixedSingle
        Panel_Infinit.Controls.Add(Panel2)
        Panel_Infinit.Controls.Add(Panel3)
        resources.ApplyResources(Panel_Infinit, "Panel_Infinit")
        Panel_Infinit.Name = "Panel_Infinit"
        ' 
        ' txtUsername_Title
        ' 
        resources.ApplyResources(txtUsername_Title, "txtUsername_Title")
        txtUsername_Title.Name = "txtUsername_Title"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.Controls.Add(txtUsername_Title)
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtSaldo)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' txtSaldo
        ' 
        resources.ApplyResources(txtSaldo, "txtSaldo")
        txtSaldo.Name = "txtSaldo"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Menu
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_Infinit)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        Panel1.ResumeLayout(False)
        Panel_Infinit.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Public Property Btn_newUser As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_New As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_lucker As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_Infinit As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSaldo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUsername_Title As Label
End Class
