Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        MsgBox(MsgBoxStyle.ApplicationModal.RetryCancel)



        Dim edad As Integer = 19
        Dim anos As Date = "03-05-1999"
        Dim nombre As String = "andres "
        MsgBox(nombre.ToString + ("Edad: ") + edad.ToString + ("  Fecha de nacimiento:  ") + anos.ToString)







    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnigualomenor.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles texto1.TextChanged

    End Sub
End Class
