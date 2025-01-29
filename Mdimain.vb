Public Class Mdimain


    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Add_user.Show()
    End Sub

    Private Sub RemoveUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveUserToolStripMenuItem.Click
        Remove_user.Show()
    End Sub

    Private Sub ShowUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowUsersToolStripMenuItem.Click
        User_list_view.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Change_PassCode.Show()
    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        Add_new_emp.Show()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEmployeeToolStripMenuItem.Click
        Update_emp.Show()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        Delete_emp.Show()
    End Sub

    Private Sub ViewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeToolStripMenuItem.Click
        view_emp.show()
    End Sub

    Private Sub AddNewCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCategoryToolStripMenuItem.Click
        Category_Details.Show()
    End Sub

    Private Sub AddNewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStockToolStripMenuItem.Click
        Stock.Show()
    End Sub

    Private Sub ViewStockListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockListToolStripMenuItem.Click
        View_stock.Show()
    End Sub

    Private Sub StcokReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StcokReportToolStripMenuItem.Click
        Stock_Report.Show()
    End Sub

    Private Sub PurchaseEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseEntryToolStripMenuItem.Click
        purchase.Show()
    End Sub

    Private Sub SalesEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesEntryToolStripMenuItem.Click
        Sales.Show()
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        Purchasereport.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        Sales_report.Show()
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        Employee_Report.Show()
    End Sub
End Class