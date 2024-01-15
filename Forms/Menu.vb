Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports WinFormsApp1.Accounts
Imports WinFormsApp1.Gender_Enum
Public Class UserLogged
    Public Property Id As Integer
    Public Property Username As String
    Public Property Name As String
    Public Property GenderId As Integer
    Public Property Email As String
    Public Property Birth As String
    Public Property UserTypeId As Integer
    Public Property Password As String
    Public Property Failed As Boolean
End Class
Public Class Menu
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        End
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        Me.Enabled = False
        CadastroUsuario.Show()
    End Sub

    Private Sub Btn_luckers_Click(sender As Object, e As EventArgs) Handles Btn_lucker.Click
        Me.Enabled = False
        Cassino.Show()
    End Sub

    Public Sub Menu_Load(Id)
        Dim Account As New Account.EventReceiver

    End Sub
End Class