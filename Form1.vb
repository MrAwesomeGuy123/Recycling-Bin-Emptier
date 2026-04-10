Public Class Form1

    Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hwnd As Long, ByVal pszRootPath As String, ByVal dwFlags As Long) As Long
    Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Long

    Const SHERB_NOCONFIRMATION = &H1
    Const SHERB_NOPROGRESSUI = &H2
    Const SHERB_NOSOUND = &H4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            SHEmptyRecycleBin(0, Nothing, SHERB_NOCONFIRMATION Or SHERB_NOPROGRESSUI Or SHERB_NOSOUND)
            SHUpdateRecycleBinIcon()
            MessageBox.Show("Recycle Bin emptied!")
        Catch ex As Exception
            MessageBox.Show("How did you manage to error this, idiot.")
        End Try
    End Sub
End Class
