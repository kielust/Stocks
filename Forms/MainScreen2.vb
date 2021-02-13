﻿Public Class frmMainScreen2
    Dim temp As String
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
        temp = DateTime.Now
        OMSysStocksDBBindingSource.AddNew()

    End Sub



    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSysStocksDBBindingSource.RemoveCurrent()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click

        If yes = False Then
            Date_AddedDateTimePicker.Value = temp
        End If



        If IDTextBox.Text = "" Or Material_NameTextBox.Text = "" Or StockTextBox.Text = "" Or Selling_PriceTextBox.Text = "" Or Unit_PriceTextBox.Text = "" Then
            MessageBox.Show("Please fill the textfields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Data Saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub Date_AddedDateTimePicker_MouseEnter(sender As Object, e As EventArgs) Handles Date_AddedDateTimePicker.MouseEnter
        yes = True
    End Sub
End Class