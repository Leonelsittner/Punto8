Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Frase, B As String
        Dim C, A, Contador, F As Integer
        Frase = txtFrase.Text
        C = Frase.Length
        Dim Vfrase(C) As String
        Contador = 0
        B = ","
        A = 0
        For F = 1 To C
            Vfrase(F) = Frase.Substring(A, 1)
            If Vfrase(F) = B Then
                Contador = Contador + 1
            End If
            A = A + 1

        Next
    End Sub
End Class
