Public Class FrmDemoCalculator
    Dim number_1 As Integer
    Dim number_2 As Integer
    Dim sign As String
    Dim surname As String
    Dim name As String
    Dim age As Integer


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmDemoCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            tbxLine_2.Text += "0"
        End If


    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            tbxLine_2.Text += "."
            btnPoint.Enabled = False

        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        tbxLine_2.Text += "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        tbxLine_2.Text += "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        tbxLine_2.Text += "3"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        tbxLine_2.Text += "4"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        tbxLine_2.Text += "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        tbxLine_2.Text += "6"
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        tbxLine_2.Text += "7"
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        tbxLine_2.Text += "8"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        tbxLine_2.Text += "9"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tbxLine_2.Text = ""
        btnPoint.Enabled = True
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        tbxLine_2.Text = ""
        tbxLine_1.Text = ""
        btnPoint.Enabled = True
        btnDivision.Enabled = True
        btnMultiply.Enabled = True
        btnMinus.Enabled = True
        btnPlus.Enabled = True
        btnEqual.Enabled = True


    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            number_1 = Val(tbxLine_2.Text)
            tbxLine_1.Text = tbxLine_2.Text
            tbxLine_1.Text += "/"
            sign = "/"
            tbxLine_2.Text = ""
            btnDivision.Enabled = False
            btnMultiply.Enabled = False
            btnMinus.Enabled = False
            btnPlus.Enabled = False
            btnPoint.Enabled = True



        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            number_1 = Val(tbxLine_2.Text)
            tbxLine_1.Text = tbxLine_2.Text
            tbxLine_1.Text += "*"
            sign = "*"
            tbxLine_2.Text = ""
            btnDivision.Enabled = False
            btnMultiply.Enabled = False
            btnMinus.Enabled = False
            btnPlus.Enabled = False
            btnPoint.Enabled = True



        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            number_1 = Val(tbxLine_2.Text)
            tbxLine_1.Text = tbxLine_2.Text
            tbxLine_1.Text += "-"
            sign = "-"
            tbxLine_2.Text = ""
            btnDivision.Enabled = False
            btnMultiply.Enabled = False
            btnMinus.Enabled = False
            btnPlus.Enabled = False
            btnPoint.Enabled = True



        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If tbxLine_2.Text = "" Then
            Return
        Else
            number_1 = Val(tbxLine_2.Text)
            tbxLine_1.Text = tbxLine_2.Text
            tbxLine_1.Text += "+"
            sign = "+"
            tbxLine_2.Text = ""
            btnDivision.Enabled = False
            btnMultiply.Enabled = False
            btnMinus.Enabled = False
            btnPlus.Enabled = False
            btnPoint.Enabled = True



        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If tbxLine_2.Text = "" And tbxLine_1.Text = "" Then
            Return
        Else
            number_2 = Val(tbxLine_2.Text)
            tbxLine_1.Text = tbxLine_2.Text
            tbxLine_2.Text = ""
            btnEqual.Enabled = False

            Select Case sign
                Case "+"
                    tbxLine_2.Text = Val(number_1 + number_2)
                Case "-"
                    tbxLine_2.Text = Val(number_1 - number_2)
                Case "/"
                    tbxLine_2.Text = Val(number_1 / number_2)
                Case "*"
                    tbxLine_2.Text = Val(number_1 * number_2)
            End Select



        End If

    End Sub

    Sub Main()
        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        Console.Write("Enter your surname: ")
        surname = Console.ReadLine()
        Console.Write("Enter your age: ")
        age = Console.ReadLine()

        If age > 24 Then
            Console.Write("Congratulation you qualify for Exemption")
        Else
            Console.Write("Sorry you don't qualify for Exemption")

        End If


    End Sub



End Class
