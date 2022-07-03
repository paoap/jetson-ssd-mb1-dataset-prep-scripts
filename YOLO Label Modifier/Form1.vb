Imports System.IO
Public Class frmMain
    Dim strFolder As String
    Dim blnModify, blnCheck As Boolean
    Dim MyCounter As Integer

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        ListBox1.Items.Clear()
        If FolderBrowserDialog1.ShowDialog() Then
            strFolder = FolderBrowserDialog1.SelectedPath()
            lblFolder.Text = strFolder

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(strFolder)
                If InStr(foundFile, ".txt") <> 0 Then
                    ListBox1.Items.Add(foundFile)
                End If
            Next

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        txtOrig.Clear()
        txtModified.Clear()
        Dim currentFile() As String = File.ReadAllLines(ListBox1.Text)

        For Each r In currentFile
            txtOrig.Text &= r & vbCrLf
        Next

        If blnModify = True Then
            For Each r In currentFile
                Try
                    Dim myLength As Byte = InStr(r, " ")
                    If InStrRev(r, txtLF.Text, myLength) = 1 Then

                        r = r.Remove(0, myLength - 1)
                        r = txtR.Text & r
                    End If
                Catch ex As Exception
                    'Nothing
                Finally
                    txtModified.Text &= r & Environment.NewLine
                End Try
            Next

        ElseIf blnCheck = True Then

            For Each r In currentFile
                Try
                    Dim myLength As Byte = InStr(r, " ")
                    If InStrRev(r, txtLF.Text, myLength) = 1 Then
                        myCounter += 1
                    End If
                Catch ex As Exception
                    'Nothing
                Finally

                End Try
            Next

        End If


    End Sub

    Private Sub btnLabels_Click(sender As Object, e As EventArgs) Handles btnLabels.Click

        blnCheck = True
        MyCounter = 0
        For i As Integer = 0 To ListBox1.Items.Count() - 1
            ListBox1.SelectedIndex = i
        Next
        blnCheck = False
        MsgBox(txtLF.Text & " = " & MyCounter)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        Dim myAnswer As MsgBoxResult = MsgBox("Modify all of the files?", MsgBoxStyle.YesNo, vbQuestion)
        If myAnswer = MsgBoxResult.Yes Then
            blnModify = True
            For i As Integer = 0 To ListBox1.Items.Count() - 1
                ListBox1.SelectedIndex = i
                My.Computer.FileSystem.WriteAllText(ListBox1.Text, txtModified.Text, False, New System.Text.UTF8Encoding)
            Next
            blnModify = False
        End If

    End Sub
End Class
