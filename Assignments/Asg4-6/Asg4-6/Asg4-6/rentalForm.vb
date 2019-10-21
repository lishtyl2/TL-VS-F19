'Tyler Lish
'RCET0265
'asg4-6
'Rental Form
'https://github.com/lishtyl2/TL-VS-F19/tree/master/Assignments

Option Strict On
Option Explicit On
Public Class rentalForm

    Dim cost As Double = 0
    Dim miles As Double
    Dim milesTotal As Double
    Dim milesCharge As Double
    Dim days As Integer
    Dim daysTotal As Double
    Dim daysCharge As Double
    Dim discounts As Double
    Dim amountDue As Double
    Dim customers As Double
    Dim validateValues As Boolean
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.YesNo) _
            = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearAllFields()
    End Sub
    Private Sub ClearAllFields()
        nameTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipCodeTextBox.Clear()
        beginOdometerTextBox.Clear()
        endOdometerTextBox.Clear()
        daysTextBox.Clear()
        clearSelected()
    End Sub
    Private Sub checkForDiscounts()
        Dim discountMultiplier As Double = 0
        Dim howMuchDiscount As Double = 0

        If aaaCheckBox.Checked Then
            discountMultiplier += 0.05
        End If
        If seniorCheckBox.Checked Then
            discountMultiplier += 0.03
        End If
        howMuchDiscount = discountMultiplier * cost
        discounts += howMuchDiscount
        discountLabel.Text = howMuchDiscount.ToString("C")
        cost = (1 - discountMultiplier) * cost

    End Sub
    Private Sub CheckTextBoxes()
        Dim popUp As String
        Dim validateZipCode As Boolean = True

        popUp = ""
        validateValues = False
        Try
            days = Integer.Parse(daysTextBox.Text)
            If days > 45 Or days < 1 Then
                MessageBox.Show("Please enter a valid number of days, 0-45")
                daysTextBox.Select()
            End If
        Catch ex As Exception
        End Try
        Try
            miles = Double.Parse(endOdometerTextBox.Text) - Double.Parse(beginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid odometer values")
            beginOdometerTextBox.Select()
        End Try

        Try
            Integer.Parse(zipCodeTextBox.Text)
        Catch ex As Exception
            validateZipCode = False
        End Try

        If zipCodeTextBox.Text.Length() <> 5 Or validateZipCode = False Then
            popUp = "Please enter the correct zip code." & vbNewLine & popUp
            zipCodeTextBox.Select()
        End If

        If stateTextBox.Text.Length() < 2 Then
            popUp = "Please enter the state abbreviation."
            stateTextBox.Select()
        End If

        If cityTextBox.Text.Length() = 0 Then
            popUp = "Please enter your city." & vbNewLine & popUp
            cityTextBox.Select()
        End If

        If addressTextBox.Text.Length() = 0 Then
            popUp = "Please enter the address." & vbNewLine & popUp
            addressTextBox.Select()
        End If

        If nameTextBox.Text.Length() = 0 Then
            popUp = "Please enter the customer name." & vbNewLine & popUp
            nameTextBox.Select()
        End If

        If popUp <> "" Then
            MessageBox.Show(popUp)
        Else validateValues = True

        End If
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim chargeForDays As Integer
        Dim costLocal As Double
        CheckTextBoxes()

        If validateValues Then
            If miles > 0 Then

            Else
                MessageBox.Show("Please enter a valid odometer reading, ending odometer reading must be greater than the beginning reading.")
                beginOdometerTextBox.Select()
            End If
            If kilometersRadioButton.Checked = True Then
                miles *= 0.62
            End If

            milesDrivenLabel.Text = Convert.ToString(miles)
            milesTotal += miles

            If miles >= 201 And miles <= 500 Then
                cost = (miles - 200) * 0.12
            ElseIf miles > 500 Then
                cost = (miles - 500) * 0.1 + (300 * 0.12)
            End If

            milesCharge += cost
            mileChargeLabel.Text = cost.ToString("C")
            chargeForDays = days * 15
            daysTotal += days
            daysCharge += chargeForDays
            costLocal = cost + chargeForDays
            cost = costLocal
            dayChargeLabel.Text = chargeForDays.ToString("C")
            checkForDiscounts()
            amountDue += cost
            customers += 1
            youOweLabel.Text = cost.ToString("C")
        End If
        calculateSelected()
    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        Dim summaryTotal As String
        summaryTotal = "Distance Driven = " & milesTotal & vbNewLine &
            "Mileage Charge = " & milesCharge.ToString("C") & vbNewLine &
            "Total Days Rented = " & daysTotal & vbNewLine &
            "Total Day Charge = " & daysCharge.ToString("C") & vbNewLine &
            "Total Discounts = " & discounts.ToString("C") & vbNewLine &
            "Total Paid = " & amountDue.ToString("C") & vbNewLine &
            "Customers = " & customers
        MessageBox.Show(summaryTotal)
    End Sub
    Private Sub clearSelected()
        milesDrivenLabel.ForeColor = Color.Black
        mileChargeLabel.ForeColor = Color.Black
        dayChargeLabel.ForeColor = Color.Black
        discountLabel.ForeColor = Color.Black
        youOweLabel.ForeColor = Color.Black
    End Sub
    Private Sub calculateSelected()
        milesDrivenLabel.ForeColor = Color.White
        mileChargeLabel.ForeColor = Color.White
        dayChargeLabel.ForeColor = Color.White
        discountLabel.ForeColor = Color.White
        youOweLabel.ForeColor = Color.White
    End Sub
End Class
