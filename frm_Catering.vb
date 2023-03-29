'Author: Logan Furlong
'Program: Catering
'Purpose: Calculates the cost of the order including discounts of loyalty points
Option Strict On
Option Explicit On


Public Class frm_Catering

    'When Calculate button is clicked performs calculation to get total cost after discounts from loyalty points
    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        'Checks if there is a numeric value in the input box and returns an error if there is a null value
        'in the input box or characters (other than numerical values were input)
        If IsNumeric(txt_Points.Text) Then
            intPoints = Convert.ToInt32(txt_Points.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."

            'Platter Radio button checks
            If rad_Cheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf rad_Wraps.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf rad_Veggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf rad_Sausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf rad_Fruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            'Payment selection radio button checks
            If rad_Prepay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf rad_Pickup.Checked Then
                strPay = " with Pay upon Pickup"
            End If

            'Calculation begins here for the discount
            intPoints = Convert.ToInt32(intPoints / 10I)

            decPoints = (intPoints * cdecDiscount) / 100

            If decPoints > 1 Then
                decPoints = 1
            End If

            decFinal = decCost * (1 - decPoints)

            lbl_Display.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints

        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btn_Clear.PerformClick()
        End If


    End Sub
    Private Sub frm_Catering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On load of the form all default objects are selected
        Me.btn_Clear.PerformClick()

    End Sub

    'Sets form to the default state
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click, MyBase.Load

        txt_Points.Text = ""
        txt_Points.Focus()
        lbl_Display.Text = ""
        rad_Cheese.Checked = True
        rad_Wraps.Checked = False
        rad_Veggie.Checked = False
        rad_Sausage.Checked = False
        rad_Fruit.Checked = False
        rad_Prepay.Checked = True
        rad_Pickup.Checked = False

    End Sub


End Class
