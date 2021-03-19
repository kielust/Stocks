Public Class ForgotPass
    Public userPass2 As String
    Private Sub btnEnterKey_Click(sender As Object, e As EventArgs) Handles btnEnterKey.Click
        If txtMasterKey.Text = "10aKNLjJgl26" Then

            panelResetPass.Visible = True
        Else
            MessageBox.Show("Incorrect master key. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnSubmitNewPass_Click(sender As Object, e As EventArgs) Handles btnSubmitNewPass.Click
        If txtNewPass.Text = txtConfirmPass.Text Then
            userPass2 = txtConfirmPass.Text
            'frmLogin.userPass = userPass2
            My.Settings.Password = userPass2
            My.Settings.Save()
            Dim okay As DialogResult = MessageBox.Show("New password created successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If okay = DialogResult.OK Then
                Close()
            End If
        Else
            MessageBox.Show("Passwords do not match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class