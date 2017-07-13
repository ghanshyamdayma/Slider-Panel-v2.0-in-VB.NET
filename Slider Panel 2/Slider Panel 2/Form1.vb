Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Do Until Panel1.Location.X = 0
            Panel1.Location = New Point(Panel1.Location.X + 1, 0)
            Me.Refresh()
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do Until Panel1.Location.X = -165
            Panel1.Location = New Point(Panel1.Location.X - 1, 0)
            Me.Refresh()
        Loop
    End Sub
End Class
