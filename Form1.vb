Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tenfile As String
        tenfile = Txttenfile.Text
        Dim noidung = Txtnoidung.Text
        Dim sw As System.IO.StreamWriter
        If Rd1.Checked Then
            sw = New IO.StreamWriter(IO.File.Open("D:\\" & tenfile, IO.FileMode.OpenOrCreate))
            sw.Write(noidung)
        Else
            sw = New IO.StreamWriter(IO.File.Open("D:\\" & tenfile, IO.FileMode.Append))
            sw.WriteLine(noidung)
            sw.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class
