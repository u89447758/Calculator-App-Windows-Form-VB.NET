Public Class Form1


    Dim firstNumber As Double
    Dim currentOperator As String
    Dim isNewOperation As Boolean = False

    Private Sub NumberClick(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDecimal.Click


        Dim btn As Button = CType(sender, Button)



        If isNewOperation Then
            txtDisplay.Text = ""
            isNewOperation = False
        End If

        If btn.Text = "." AndAlso txtDisplay.Text.Contains(".") Then
            Exit Sub
        End If

        txtDisplay.Text += btn.Text
    End Sub

    Private Sub OperatorClick(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        If Not Double.TryParse(txtDisplay.Text, firstNumber) Then
            MessageBox.Show("Invalid input!")
            Return
        End If

        Dim btn As Button = CType(sender, Button)
        firstNumber = CDbl(txtDisplay.Text)
        currentOperator = btn.Text
        isNewOperation = True
    End Sub


    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        If Not Double.TryParse(txtDisplay.Text, firstNumber) Then
            MessageBox.Show("Invalid input!")
            Return
        End If

        Dim secondNumber As Double = CDbl(txtDisplay.Text)
        Dim result As Double

        Select Case currentOperator
            Case "+"
                result = firstNumber + secondNumber
            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber
            Case "/"
                If secondNumber = 0 Then
                    MessageBox.Show("Cannot divide by zero!")
                    Return
                End If
                result = firstNumber / secondNumber
        End Select

        txtDisplay.Text = result.ToString()
        isNewOperation = True
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
        firstNumber = 0
        currentOperator = ""
        isNewOperation = False
    End Sub


End Class
