Public Class Menu
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        End
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        Me.Hide()
        CadastroUsuario.Show()
    End Sub

    Private Sub Btn_luckers_Click(sender As Object, e As EventArgs) Handles Btn_lucker.Click
        Me.Hide()
        Cassino.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class