Public Class Form1

    Private password As String

    Private rd As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Clear()

        For i = 0 To 100
            password = ""
            For x = 0 To CInt(TextBox1.Text) - 1

                Dim capitalize = rd.Next(2)
                If capitalize = 0 Then
                    password = password & GetIt(rd.Next(10))
                Else
                    password = password & GetIt(rd.Next(10)).ToUpper

                End If

            Next
            ComboBox1.Items.Add(password)


        Next
    End Sub

    Private Function GetIt(ByVal number As Integer) As String

        Select Case number
            Case 0
                Return "a"
            Case 1
                Return "b"
            Case 2
                Return "c"
            Case 3
                Return "d"
            Case 4
                Return "e"
            Case 5
                Return "f"
            Case 6
                Return "g"
            Case 7
                Return "h"
            Case 8
                Return "i"
            Case 9
                Return "j"
        End Select

        Return ""

    End Function

End Class
