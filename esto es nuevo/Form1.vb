Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim edad As Integer = 19
        Dim anos As Date = "03-05-1999"
        Dim nombre As String = "andres "
        MsgBox(nombre.ToString + ("Edad: ") + edad.ToString + ("  Fecha de nacimiento:  ") + anos.ToString)







    End Sub
End Class
