Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim mainScreen As New frmMain

        If txtUsername.Text <> "1" Then
            MessageBox.Show("Incorrect username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text <> "1" Then
            MessageBox.Show("Incorrect password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Hide() 'should be Close()
            mainScreen.Show()
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
