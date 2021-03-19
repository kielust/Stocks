Public Class frmMain
    Dim ManageOrder As New frmMainScreen
    Dim ManageStocks As New frmMainScreen2
    Dim LoginForm As New frmLogin
    Private Sub btnManageOrder_Click(sender As Object, e As EventArgs) Handles btnManageOrder.Click
        ManageOrder.Show()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        ManageStocks.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        ManageOrder.Close()
        ManageStocks.Close()
        Close()
    End Sub
End Class