Public Class PayrollForm

    'load form
    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub PayrollDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayrollDataGridView2.CellContentClick

    End Sub

    'present and expected paydates data grid
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'paystub groupbox- contains formatting for paystub layout
    Private Sub PayStubGroupBox_Enter(sender As Object, e As EventArgs) Handles PayStubGroupBox.Enter

    End Sub

    'paystub labels'
    'date printed
    Private Sub DatePrintLabel_Click(sender As Object, e As EventArgs) Handles datePrintLabel.Click

    End Sub

    'pay to order
    Private Sub PayToOrderLabel_Click(sender As Object, e As EventArgs) Handles payToOrderLabel.Click

    End Sub

    'pay to order- employee name
    Private Sub PayToOrderEmployeeNameLabel_Click(sender As Object, e As EventArgs) Handles payToOrderEmployeeNameLabel.Click

    End Sub

    'pay to order- numerical payment amount
    Private Sub PayNumLabel_Click(sender As Object, e As EventArgs) Handles payNumLabel.Click

    End Sub

    'pay to order- string format of payment amount
    Private Sub PayStrLabel_Click(sender As Object, e As EventArgs) Handles payStrLabel.Click

    End Sub

    'currency base
    Private Sub DOLLARSLabel_Click(sender As Object, e As EventArgs) Handles DOLLARSLabel.Click

    End Sub

    'memo for pay period
    Private Sub Memeo_Click(sender As Object, e As EventArgs) Handles memo.Click

    End Sub

    'pay period
    Private Sub PayPeriodLabel_Click(sender As Object, e As EventArgs) Handles payPeriodLabel.Click

    End Sub

    Private Sub DateDashLabel_Click(sender As Object, e As EventArgs) Handles dateDashLabel.Click

    End Sub

    Private Sub SignatureLabel_Click(sender As Object, e As EventArgs) Handles signatureLabel.Click

    End Sub
    'end of labels'

    'masked texts boxes for paystub'
    'compnay name
    Private Sub CompanyNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles companyNameMTxtBox.MaskInputRejected

    End Sub

    'company address
    Private Sub CompanyAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles companyAddyMTxtBox.MaskInputRejected

    End Sub

    'bank name
    Private Sub BankNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles bankNameMTxtBox.MaskInputRejected

    End Sub

    'bank address
    Private Sub BankAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles bankAddyMTxtBox.MaskInputRejected

    End Sub

    'reference number
    Private Sub RefNumMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles RefNumMTxtBox.MaskInputRejected

    End Sub

    Private Sub EmpNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles empNameTxtBox.TextChanged

    End Sub

    Private Sub PayNumMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles payNumMTxtBox.MaskInputRejected

    End Sub

    Private Sub PayStrMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles payStrMTxtBox.MaskInputRejected

    End Sub

    Private Sub EmpNameMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles empNameMTxtBox.MaskInputRejected

    End Sub

    Private Sub EmpAddyMTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles empAddyMTxtBox.MaskInputRejected

    End Sub

    Private Sub AccountNumberTxtBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles accountNumberTxtBox.MaskInputRejected

    End Sub
    'end of Masked Text Boxes'

    'date components'
    'date on which the paystub will be printed
    Private Sub PrntDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles prntDatePicker.ValueChanged

    End Sub

    'start date for pay period
    Private Sub StrtPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles strtPayPeriodDatePicker.ValueChanged

    End Sub

    'end date for pay period
    Private Sub EndPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles endPayPeriodDatePicker.ValueChanged

    End Sub
    'end of date components'

    'print paystub'
    'button'
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles printButton.Click

    End Sub

    'printDocument'
    Private Sub PrintDocumentPaystub_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentPaystub.PrintPage

    End Sub
    'end of printing components'
End Class