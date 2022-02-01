Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        If a > b Then
            If a > c Then
                TextBox4.Text = a
            Else
                TextBox4.Text = c
            End If

        Else

            If b > c Then
                TextBox4.Text = b
            Else
                TextBox4.Text = c
            End If

        End If

    End Sub
End Class
