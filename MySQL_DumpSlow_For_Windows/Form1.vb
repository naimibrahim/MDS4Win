Imports System.IO

Public Class Form1
    Dim desc, sortBy, abstract, subLockTime As String


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectSQLDUmpFile.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.CheckPathExists = True) Then
            txtSQLDumpFile.Text = OpenFileDialog1.FileName
            txtFilePath.Text = OpenFileDialog1.FileName.ToString() & "_analysis_output.txt"
        Else
            MessageBox.Show("Wrong file")
        End If

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If (OpenFileDialog1.CheckPathExists = True) And Integer.TryParse(txtNumTopSlowQuery.Text, 0) Then
            TextBox1.Text = "Analyzing...Please wait.."
            txtSQLDumpFile.Text = OpenFileDialog1.FileName
            Dim p As New Process
            AnalyzeOption()
            p.StartInfo.FileName = System.Environment.CurrentDirectory & "\library\perl\bin\" & "perl.exe"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.Arguments = "mysqldumpslow.pl -t " & Convert.ToInt16(txtNumTopSlowQuery.Text) & subLockTime & desc & sortBy & abstract & " """ & OpenFileDialog1.FileName & """"
            p.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory & "\library\perl\bin\"
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.CreateNoWindow = True
            AddHandler p.OutputDataReceived, AddressOf p_OutputDataReceived
            p.Start()
            TextBox1.Text = ""
            p.BeginOutputReadLine()



        Else
            MessageBox.Show("Wrong file")
        End If

    End Sub
    Public Sub AnalyzeOption()
        If cmbDescending.Text = "Ascending" Then
            desc = " -r "
        Else
            desc = " "
        End If

        If cmbSortBy.Text = "Query time" Then
            sortBy = " -s t "
        ElseIf cmbSortBy.Text = "Lock time" Then
            sortBy = " -s l "
        ElseIf cmbSortBy.Text = "Average lock time" Then
            sortBy = " -s al "
        ElseIf cmbSortBy.Text = "Rows sent" Then
            sortBy = " -s r "
        ElseIf cmbSortBy.Text = "Average rows sent" Then
            sortBy = " -s ar "
        ElseIf cmbSortBy.Text = "Count" Then
            sortBy = " -s c "
        Else
            sortBy = " -s at "
        End If

        If cmbAbstracs.Text = "Do not abstract all numbers to N and strings to 'S'" Then
            abstract = " -a "
        Else
            abstract = ""
        End If

        If cmbSubLockTime.Text = "Do not subtract lock time from total time" Then
            subLockTime = " -l"
        Else
            subLockTime = ""
        End If
    End Sub
    Public Sub p_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        UpdateTextBox(e.Data)
    End Sub

    Delegate Sub SetTextCallback([text] As String)
    Private Sub UpdateTextBox(ByVal text As String)
        If Me.TextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf UpdateTextBox)
            Me.Invoke(d, New Object() {text})
        Else
            If TextBox1.Text = Nothing Then TextBox1.Text = text Else TextBox1.AppendText(vbNewLine & text)
        End If
    End Sub

    Private Sub btnSaveResult_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveResult.Click
        Try
            My.Computer.FileSystem.WriteAllText(txtFilePath.Text & ".txt", TextBox1.Text, False)
            MessageBox.Show("MySQL DumpSlow Analysis has been saved to " & txtFilePath.Text & ".txt")
        Catch ex As Exception
            MessageBox.Show("File Path : " & txtFilePath.Text & "---" & ex.Message)
        End Try

    End Sub



    Private Sub btnFilePath_Click(sender As System.Object, e As System.EventArgs) Handles btnFilePath.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.CheckPathExists = True Then
            txtFilePath.Text = SaveFileDialog1.FileName.ToString()
        End If
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        SplashScreen1.Show()
    End Sub
End Class
