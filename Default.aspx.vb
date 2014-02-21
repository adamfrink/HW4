
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub CALCULATE_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'get user inputs
        Dim hourlyWage = Val(hourlywageTextBox.Text)
        Dim hoursWorked = Val(hrsWorkedTextBox.Text)
        Dim ptax = Val(ptaxTextBox.Text)
        Dim atax = Val(ataxTextBox.Text)

        'Declare variables
        Dim grossPay As Decimal
        Dim taxablePay As Decimal
        Dim postTaxPay As Decimal
        Dim netPay As Decimal

        'Perform calculations

        ' compute gross pay
        grossPay = hourlyWage * hoursWorked

        'compute taxable pay
        taxablePay = grossPay - ptax

        'compute post tax pay
        If grossPay < 500 Then
            postTaxPay = taxablePay - (taxablePay * 0.18)
        Else
            postTaxPay = taxablePay - (taxablePay * 0.22)
        End If

        'compute net pay
        netPay = postTaxPay - atax

        'display net pay
        netpayLabel.Text = "$" & netPay

    End Sub

    Protected Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clear TextBoxes and Label
        hourlywageTextBox.Text = " "
        hrsWorkedTextBox.Text = " "
        ptaxTextBox.Text = " "
        ataxTextBox.Text = " "
        netpayLabel.Text = " "
    End Sub

    Protected Sub hourlywageTextBox_TextChanged(sender As Object, e As EventArgs) Handles hourlywageTextBox.TextChanged

    End Sub

    Protected Sub ptaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles ptaxTextBox.TextChanged

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
