Imports System.IO
Public Class frmEditor
    Public writefile As StreamWriter
    Public readfile As StreamReader
    Dim result As DialogResult

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        result = SaveFileDialog1.ShowDialog
        If result = DialogResult.OK Then
            writefile = New StreamWriter(SaveFileDialog1.FileName, False)
            writefile.Write(rtbEditor.Text)
            writefile.Close()
            rtbEditor.Text = ""
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        result = OpenFileDialog1.ShowDialog
        If result = DialogResult.OK Then
            readfile = New StreamReader(OpenFileDialog1.FileName)
            rtbEditor.Text = readfile.ReadToEnd()
            readfile.Close()
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class