Public Class btnAdd
    Sub dgv_styleRow()
        For i As Integer = 0 To OMSys_OrdersV2DBDataGridView.RowCount - 1
            If i Mod 2 = 0 Then
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersV2DB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        dgv_styleRow()
    End Sub
    Private Sub OMSys_OrdersDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OMSys_OrdersV2DBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)
    End Sub



    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs)
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        Me.OMSys_OrdersV2DBBindingSource.RemoveFilter()
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub

    Private Sub OMSys_OrdersV2DBDataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles OMSys_OrdersV2DBDataGridView.DataSourceChanged
        dgv_styleRow()
    End Sub

    Private Sub btnAddOrder1_Click_1(sender As Object, e As EventArgs) Handles btnAddOrder1.Click
        OMSys_OrdersV2DBBindingSource.AddNew()
        dgv_styleRow()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_ProductName.Text = "" Or txt_Quantity.Text = "" Or
            txt_TotalPrice.Text = "" Or txt_Address.Text = "" Or txt_ContactNumber.Text = "" Or cmb_Status.Text = "" Then

            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Order saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class