Public Class Form1
    ' Program: Race Results
    ' Programmer: Douglas Enos
    ' Date: May 23, 2016
    ' This program accepts three names and three times and calculates the race results
    ' 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear the text boxes and labels
        txtRunnerOneName.Clear()
        txtRunnerOneTime.Clear()

        txtRunnerTwoName.Clear()
        txtRunnerTwoTime.Clear()

        txtRunnerThreeName.Clear()
        txtRunnerThreeTime.Clear()

        lblFirstPlace.Text = String.Empty
        lblSecondPlace.Text = String.Empty
        lblThirdPlace.Text = String.Empty

        txtRunnerOneName.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim intTimeOne As Integer               ' this initially hold the first runner's time, eventually the fastest time
        Dim intTimeTwo As Integer               ' this will initially hold the second runner's time, eventually the second fastest time
        Dim intTimeThree As Integer             ' this will initially hold the third runner's time, eventually the third fasted time.
        Dim intSwap As Integer                  ' temporary swap variable for runner time.

        Dim strFirstPlace As String             ' This initially hold the first runner's name and eventually the fastest runner's name
        Dim strSecondPlace As String            ' initally the second runner name from form, eventually second fastest runner
        Dim strThirdPlace As String             ' initially the third runner name from form, eventually third fastest runner
        Dim strSwap As String                   ' temporary swap variable for runner names.

        ' load strings from txtboxes
        ' we are not validating the names. that would be inconceivable!

        strFirstPlace = txtRunnerOneName.Text
        strSecondPlace = txtRunnerTwoName.Text
        strThirdPlace = txtRunnerThreeName.Text

        ' get times and validate them
        ' swap values as necessary to get order correct.
        ' we don't know arrays yet so we cannot do a proper bubble sort but we don't need it 
        ' because there are only three times
        ' if the times are tied, nothing happens
        If Integer.TryParse(txtRunnerOneTime.Text, intTimeOne) Then
            If Integer.TryParse(txtRunnerTwoTime.Text, intTimeTwo) Then
                If Integer.TryParse(txtRunnerThreeTime.Text, intTimeThree) Then
                    If intTimeOne > intTimeTwo Then
                        ' swap the times if needed
                        intSwap = intTimeOne
                        intTimeOne = intTimeTwo
                        intTimeTwo = intSwap
                        ' swap the names
                        strSwap = strFirstPlace
                        strFirstPlace = strSecondPlace
                        strSecondPlace = strSwap
                    End If
                    If intTimeOne > intTimeThree Then
                        intSwap = intTimeOne
                        intTimeOne = intTimeThree
                        intTimeThree = intSwap

                        strSwap = strFirstPlace
                        strFirstPlace = strThirdPlace
                        strThirdPlace = strSwap
                    End If
                    If intTimeTwo > intTimeThree Then
                        intSwap = intTimeTwo
                        intTimeTwo = intTimeThree
                        intTimeThree = intSwap

                        strSwap = strSecondPlace
                        strSecondPlace = strThirdPlace
                        strThirdPlace = strSwap
                    End If
                    '
                    ' load the results into the labels for display
                    ' The times are swapped about to order our names. would be easier with an array
                    ' 
                    lblFirstPlace.Text = strFirstPlace
                    lblSecondPlace.Text = strSecondPlace
                    lblThirdPlace.Text = strThirdPlace
                Else
                    MessageBox.Show("The third runner's time must be an integer")
                End If
            Else
                MessageBox.Show("The second runner's time must be an integer.")
            End If
        Else
            MessageBox.Show("The first runner's time must be an integer")
        End If
    End Sub
End Class
