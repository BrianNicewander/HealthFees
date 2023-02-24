Public Class HealthFees
    'Project Health Fees
    'Application for Gym calculations.
    'Programmed by Brian Nicewander
    'Date last modified 2/26/19

    'Declare variables for input.
    Dim intMonths As Integer     'Number of months
    Dim decDiscount As Decimal    'To hold the disount

    'Variables for output
    Dim decMT As Decimal          'Base Monthly Fee
    Dim decGT As Decimal          'Total Membership Fee
    Dim decDT As Decimal          'Discount total
    Dim decTax As Decimal         'Tax total
    Dim decSub As Decimal         'Sub total

    'Constants for base fees
    Const decADULT_FEE As Decimal = 40
    Const decCHILD_FEE As Decimal = 20
    Const decSTUDENT_FEE As Decimal = 20
    Const decSENIOR_FEE As Decimal = 35

    'Constants for additional fees
    Const decYOGA_FEE As Decimal = 10
    Const decKARATE_FEE As Decimal = 20
    Const decTRAINER_FEE As Decimal = 30

    'Tax Constant
    Const decTAX_RATE As Decimal = CDec(0.083)

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculates the total of the input and the disscount and show the output in a lables

        'Get the number of months
        If Integer.TryParse(txtMonths.Text, intMonths) Then
            'Validate the number of months
            If intMonths >= 1 And intMonths <= 24 Then
                'Determine the base monthly fee.
                If radAdult.Checked = True Then
                    decMT = decADULT_FEE
                ElseIf radChild.Checked = True Then
                    decMT = decCHILD_FEE
                ElseIf radStudent.Checked = True Then
                    decMT = decSTUDENT_FEE
                ElseIf radSenior.Checked = True Then
                    decMT = decSENIOR_FEE
                End If

                'Look for additional services
                If chkYoga.Checked = True Then
                    decMT += decYOGA_FEE
                End If

                If chkkarate.Checked = True Then
                    decMT += decKARATE_FEE
                End If

                If chkTrainer.Checked = True Then
                    decMT += decTRAINER_FEE
                End If

                'Calculate the subtotal.
                decSub = decMT * intMonths

                'Calculating the Decimal
                If Decimal.TryParse(txtDiscount.Text, decDiscount) Then
                    If decDiscount >= 0 And decDiscount <= 100 Then
                        decDT = decSub * (decDiscount * CDec(0.01))
                    Else
                        MessageBox.Show("Please enter a number 1-100 in the Discount Field!")
                        txtDiscount.Focus()
                        Exit Sub
                    End If
                ElseIf txtDiscount.Text = String.Empty Then
                    decDiscount = 0
                Else
                    MessageBox.Show("Please enter a valid number in the Discount box!")
                    txtDiscount.Focus()
                    Exit Sub
                End If

                'Calculate the tax
                decTax = (decSub - decDT) * decTAX_RATE

                'Calculate the Grand
                decGT = decSub + decTax - decDT

                'Display the fees
                lblMT2.Text = decMT.ToString("")
                lblContract2.Text = decSub.ToString("C")
                lblDiscount2.Text = decDT.ToString("C")
                lblTax2.Text = decTax.ToString("C")
                lblGT2.Text = decGT.ToString("C")
            Else
                'Error: Months is outside the range 1-24.
                MessageBox.Show("Months must be in the range 1-24.")
                txtMonths.Focus()
                Exit Sub
            End If
        Else
            'Error: Value entered for months is not a interger.
            MessageBox.Show("Months must be an integer")
            txtMonths.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the values, boxes, label, and time

        'Reset the Adult radio button.
        radAdult.Checked = True

        'clear check boxes.
        chkYoga.Checked = False
        chkkarate.Checked = False
        chkTrainer.Checked = False

        'Clear text box for number of months
        txtMonths.Clear()
        txtDiscount.Clear()

        'Clear the fee labels.
        lblMT2.Text = String.Empty
        lblGT2.Text = String.Empty
        lblContract2.Text = String.Empty
        lblTax2.Text = String.Empty
        lblDiscount2.Text = String.Empty

        'Reset Variables
        decDT = 0
        decGT = 0
        decSub = 0
        decMT = 0
        decTax = 0
        decDiscount = 0
        intMonths = 0

        'Reset the time and date
        lblTime.Text = Now.ToString("D") & " " & Now.ToString("T")

        'Give txtMonths the fucus
        txtMonths.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub

    Private Sub HealthFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show the current time and date when you open the form
        lblTime.Text = Now.ToString("D") & " " & Now.ToString("T")
    End Sub
End Class
