Public Class Form1
    Private Sub OMSys_OrdersDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMSys_OrdersDBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMSys_OrdersDBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersDB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersDB)

    End Sub
End Class