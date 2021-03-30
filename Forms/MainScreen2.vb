Public Class frmMainScreen2
    Dim yes As Boolean = False

    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
    End Sub

    Private Sub OMSysStocksDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OMSysStocksDBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        date_added.Checked = False
        OMSysStocksDBBindingSource.AddNew()
        cmb_Size.SelectedIndex = -1
    End Sub
    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSysStocksDBBindingSource.RemoveCurrent()
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
            Catch ex As Exception

            End Try

        End If

        OMSysStocksDBBindingSource.MoveLast()

    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click


        If txt_StockName.Text = "" Or txt_Stock.Text = "" Or cmb_Size.Text = "" Or txt_Color.Text = "" Or txt_SellingPrice.Text = "" Or txt_OriginalPrice.Text = "" Then
            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Product saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'MessageBox.Show("Database error, the application will restart to save the changes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Application.Restart()
                ' Puwede yung code above pero pwede rin to, ikaw mamili kung ano mas maganda pag nag e-error
                Me.Refresh()
            End Try
        End If

    End Sub

    Private Sub Date_AddedDateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        yes = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
        Me.OMSysStocksDBBindingSource.RemoveFilter()
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged

    End Sub


End Class