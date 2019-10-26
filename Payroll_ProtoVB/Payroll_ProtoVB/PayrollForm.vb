Public Class PayrollForm

    'load form
    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_540GroupProjectDataSet.EmployeeFuture' table. You can move, or remove it, as needed.
        Me.EmployeeFutureTableAdapter.Fill(Me._540GroupProjectDataSet.EmployeeFuture)
        'TODO: This line of code loads data into the '_540GroupProjectDataSet.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me._540GroupProjectDataSet.EmployeePast)

    End Sub

    'menue
    Private Sub MenueStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menueStrip.ItemClicked

    End Sub

    'menue buttons'
    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click

    End Sub

    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click

    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click

    End Sub
    'end of menue buttons'

    'menue button separators'
    Private Sub ToolStripSeparator1_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub ToolStripSeparator2_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStripSeparator3_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator3.Click

    End Sub

    Private Sub ToolStripSeparator4_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator4.Click

    End Sub

    Private Sub ToolStripSeparator5_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator5.Click

    End Sub

    Private Sub ToolStripSeparator6_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator6.Click

    End Sub
    'end of menue button separators'

    'employee search operations'
    'label
    Private Sub PayrollFormEmployeeSearchLabel_Click(sender As Object, e As EventArgs) Handles payrollFormEmployeeSearchLabel.Click

    End Sub

    'textbox
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    'button
    Private Sub PayrollFormSearch_Click(sender As Object, e As EventArgs) Handles PayrollFormSearch.Click

    End Sub
    'end search operations'

    'previous payments tab data grid
    Private Sub PayrollDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayrollDataGridViewPast.CellContentClick

    End Sub

    'present and expected paydates data grid
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayrollDataGridViewFuture.CellContentClick

    End Sub

    'paystub groupbox- contains formatting for paystub layout
    Private Sub PayStubGroupBox_Enter(sender As Object, e As EventArgs)

    End Sub

    'paystub labels'
    'date printed
    Private Sub DatePrintLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'pay to order
    Private Sub PayToOrderLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'pay to order- employee name
    Private Sub PayToOrderEmployeeNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'pay to order- numerical payment amount
    Private Sub PayNumLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'pay to order- string format of payment amount
    Private Sub PayStrLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'currency base
    Private Sub DOLLARSLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'memo for pay period
    Private Sub Memeo_Click(sender As Object, e As EventArgs)

    End Sub

    'pay period
    Private Sub PayPeriodLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateDashLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SignatureLabel_Click(sender As Object, e As EventArgs)

    End Sub
    'end of labels'

    'masked texts boxes for paystub'
    'compnay name
    Private Sub CompanyNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    'company address
    Private Sub CompanyAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    'bank name
    Private Sub BankNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    'bank address
    Private Sub BankAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    'reference number
    Private Sub RefNumMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub EmpNameTxtBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PayNumMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub PayStrMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub EmpNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub EmpAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub AccountNumberTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub
    'end of Masked Text Boxes'

    'date components'
    'date on which the paystub will be printed
    Private Sub PrntDatePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    'start date for pay period
    Private Sub StrtPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    'end date for pay period
    Private Sub EndPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    'end of date components'

    'print paystub'
    'button'
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles payStubViewBTN.Click

    End Sub

    'printDocument'
    Private Sub PrintDocumentPaystub_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentPaystub.PrintPage

    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged

    End Sub

    Private Sub PastPayTab_Click(sender As Object, e As EventArgs) Handles PastPayTab.Click

    End Sub

    Private Sub FuturePayTab_Click(sender As Object, e As EventArgs) Handles FuturePayTab.Click

    End Sub

    Private Sub PayStubGroupBox_Enter_1(sender As Object, e As EventArgs)

    End Sub
    'end of printing components'
End Class