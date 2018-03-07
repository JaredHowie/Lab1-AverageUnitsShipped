Public Class frmAverageUnitsShipped
    Private dayNumber As Integer = 1
    Private allUnitsShipped(7) As Integer
    Private averageShipped As Double = 0.0


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clesr all text boxes as well as resets all form level variables
        tbAllUnitsShipped.Clear()
        tbAverageUnitsShipped.Clear()
        txtDay.Clear()
        dayNumber = 1
        tbUnitsShipped.Clear()
        txtDay.Text() = "Day"
        dayNumber = 1
        txtDayNumber.Text() = dayNumber.ToString
        btnEnter.Enabled() = True
        tbUnitsShipped.Enabled() = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form when the exit button is clicked
        Close()


    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Create the variables needed
        Dim userInput As String = tbUnitsShipped.Text()
        Dim validUserInput As Integer = 0
        Dim sumUnitsShipped As Integer = 0
        'if we have not finished puting numbers in for the week
        If dayNumber <= 7 Then
            txtDayNumber.Text() = dayNumber.ToString
            'if the text entered is a whole number
            If Integer.TryParse(userInput, validUserInput) Then
                'if the number entered is within the range
                If validUserInput < 1000 And validUserInput > 0 Then
                    'display the number in the textbox on a new line
                    tbAllUnitsShipped.Text() = tbAllUnitsShipped.Text() + tbUnitsShipped.Text() + vbNewLine
                    'put the valid number in the area 
                    allUnitsShipped(dayNumber - 1) = validUserInput
                    tbUnitsShipped.Select()
                    'move the day forward
                    dayNumber = dayNumber + 1

                Else
                    'warn the user that the number they entred is not in the range
                    MessageBox.Show("The number entered must be between 0 and 1000 inclusive")
                    tbUnitsShipped.Select()
                End If
            Else
                'warn the user that they did not enter a whole number
                MessageBox.Show("You must enter a whole number!")
                tbUnitsShipped.Select()
            End If
        Else
            'disable the enter button
            btnEnter.Enabled() = False
            'disable the text box where the user entres the data
            tbUnitsShipped.Enabled() = False
            'loop through the array and add the sum of all the days up
            For counter As Integer = 0 To 6
                sumUnitsShipped = sumUnitsShipped + allUnitsShipped(counter)
            Next
            'find the average using the calculated sum
            averageShipped = sumUnitsShipped / 7
            'round the calculated average to 2 decimal places
            averageShipped = Math.Round(averageShipped, 2)
            'display the calculated average to the user
            tbAverageUnitsShipped.Text() = "Average per day: " + averageShipped.ToString
        End If




    End Sub

    Private Sub txtDay_TextChanged(sender As Object, e As EventArgs) Handles txtDay.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDayNumber.TextChanged

    End Sub

    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDayNumber.Text() = dayNumber.ToString
    End Sub
End Class
