Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 As String
        Dim text2 As String
        Dim text3 As String
        Dim text4 As String

        text1 = "visual"
        text2 = "basic"
        text3 = "2022"
        text4 = text1 & text2 & text3

        MsgBox(text4)
    End Sub
End Class
