'Program Name;   Latte Selection
'Developer; City Hussen
'Date; 06/25/2022
'Purpose; This application displays two letter flavours (PumpkinSpice   
'and mocha).The user can select a latte flavour.

Public Class frmLatteSelection

    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        'This code is executed when the user clicks the pumpkin Spice button.It displays the
        'pumpkin picture ,hides the mocha picture and enables the select latte button.
        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'This code is executed when the user clicks the select button .It disables the
        'pumpkin spice button ,the select button and the mocha button.It hides the
        'instruction label1,displays the confirmation label1,and enables the Exit window button.

        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        'This code is executed when the user clicks the Mocha button.It displays the
        'mocha picture,hides the pumpkin picture, and enables the select button.

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks the Exit window button
        'It closes the window and terminates the program execution.
        Close()
    End Sub
End Class
