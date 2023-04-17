Imports System.Diagnostics.Contracts

Public Class Form1
    Dim x As Contact()
    Dim i As Integer = 0
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click

        Dim x As Contact = New Contact()
        x.name_ = txtname.Text
        x.dateofbirth_ = dtpbirth.Value
        x.phone_ = txtphone.Text
        x.email_ = txtemail.Text
        PERSON.Items.Add(x)
    End Sub
End Class
