Public Class Form1
    Private Sub btnConverttoKM_Click(sender As Object, e As EventArgs) Handles btnConverttoKM.Click
        Dim Miles As Decimal
        Dim KM As Decimal

        Miles = txtMiles.Text

        KM = Miles * 1.609

        txtKM.Text = KM



    End Sub

    Private Sub btnConverttoMiles_Click(sender As Object, e As EventArgs) Handles btnConverttoMiles.Click
        Dim Miles As Decimal
        Dim KM As Decimal

        KM = txtKM.Text

        Miles = KM / 1.609

        txtMiles.Text = Miles
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetText()
        txtMiles.ResetText()
        txtKM.ResetText()
    End Sub
End Class
