Public Class Cassino

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        If (Label1.Text = "7") And (Label2.Text = "7") And (Label3.Text = "7") Then
            Label5.Text = CStr(Int(Label5.Text + 1000))
            Beep()
        ElseIf (Label1.Text = "2") And (Label2.Text = "5") And (Label3.Text = "7") Then
            Label5.Text = CStr(Int(Label5.Text + 350))
            Beep()
        ElseIf (Label1.Text = "6") And (Label2.Text = "6") And (Label3.Text = "6") Then
            Label5.Text = CStr(Int(Label5.Text + 666))
            Beep()
        End If
        Label5.Text = CStr(Int(Label5.Text - 2))

        If (Label5.Text <= Int(2)) Then
            Label5.Text = "se fudeu"
            Button3.Visible = True
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = CStr(Int(25))
        Button3.Visible = False
        Button1.Enabled = True

    End Sub
End Class
