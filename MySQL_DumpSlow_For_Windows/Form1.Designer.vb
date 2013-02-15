<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectSQLDUmpFile = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtSQLDumpFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSaveResult = New System.Windows.Forms.Button()
        Me.txtNumTopSlowQuery = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDescending = New System.Windows.Forms.ComboBox()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.cmbAbstracs = New System.Windows.Forms.ComboBox()
        Me.cmbSubLockTime = New System.Windows.Forms.ComboBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnFilePath = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectSQLDUmpFile
        '
        Me.btnSelectSQLDUmpFile.Location = New System.Drawing.Point(24, 81)
        Me.btnSelectSQLDUmpFile.Name = "btnSelectSQLDUmpFile"
        Me.btnSelectSQLDUmpFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectSQLDUmpFile.TabIndex = 0
        Me.btnSelectSQLDUmpFile.Text = "Select File"
        Me.btnSelectSQLDUmpFile.UseVisualStyleBackColor = True
        '
        'txtSQLDumpFile
        '
        Me.txtSQLDumpFile.Enabled = False
        Me.txtSQLDumpFile.Location = New System.Drawing.Point(24, 55)
        Me.txtSQLDumpFile.Name = "txtSQLDumpFile"
        Me.txtSQLDumpFile.Size = New System.Drawing.Size(294, 20)
        Me.txtSQLDumpFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select MySQL slow dump file"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Analyze Query"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(324, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(295, 253)
        Me.TextBox1.TabIndex = 4
        '
        'btnSaveResult
        '
        Me.btnSaveResult.Location = New System.Drawing.Point(543, 330)
        Me.btnSaveResult.Name = "btnSaveResult"
        Me.btnSaveResult.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveResult.TabIndex = 5
        Me.btnSaveResult.Text = "Save Result"
        Me.btnSaveResult.UseVisualStyleBackColor = True
        '
        'txtNumTopSlowQuery
        '
        Me.txtNumTopSlowQuery.Location = New System.Drawing.Point(157, 140)
        Me.txtNumTopSlowQuery.Name = "txtNumTopSlowQuery"
        Me.txtNumTopSlowQuery.Size = New System.Drawing.Size(22, 20)
        Me.txtNumTopSlowQuery.TabIndex = 6
        Me.txtNumTopSlowQuery.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of top slow query"
        '
        'cmbDescending
        '
        Me.cmbDescending.DisplayMember = "Descending,Ascending"
        Me.cmbDescending.FormattingEnabled = True
        Me.cmbDescending.Items.AddRange(New Object() {"Descending", "Ascending"})
        Me.cmbDescending.Location = New System.Drawing.Point(27, 243)
        Me.cmbDescending.Name = "cmbDescending"
        Me.cmbDescending.Size = New System.Drawing.Size(272, 21)
        Me.cmbDescending.TabIndex = 8
        Me.cmbDescending.Text = "Descending"
        '
        'cmbSortBy
        '
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Items.AddRange(New Object() {"Query time", "Average query time", "Lock time", "Average lock time", "Rows sent", "Average rows sent", "Count"})
        Me.cmbSortBy.Location = New System.Drawing.Point(27, 216)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(272, 21)
        Me.cmbSortBy.TabIndex = 9
        Me.cmbSortBy.Text = "Average query time"
        '
        'cmbAbstracs
        '
        Me.cmbAbstracs.FormattingEnabled = True
        Me.cmbAbstracs.Items.AddRange(New Object() {"Abstract numbers", "Do not abstract all numbers to N and strings to 'S'"})
        Me.cmbAbstracs.Location = New System.Drawing.Point(27, 189)
        Me.cmbAbstracs.Name = "cmbAbstracs"
        Me.cmbAbstracs.Size = New System.Drawing.Size(272, 21)
        Me.cmbAbstracs.TabIndex = 10
        Me.cmbAbstracs.Text = "Abstract numbers and string"
        '
        'cmbSubLockTime
        '
        Me.cmbSubLockTime.FormattingEnabled = True
        Me.cmbSubLockTime.Items.AddRange(New Object() {"Subtract lock time from total time", "Do not subtract lock time from total time"})
        Me.cmbSubLockTime.Location = New System.Drawing.Point(27, 162)
        Me.cmbSubLockTime.Name = "cmbSubLockTime"
        Me.cmbSubLockTime.Size = New System.Drawing.Size(272, 21)
        Me.cmbSubLockTime.TabIndex = 11
        Me.cmbSubLockTime.Text = "Subtract lock time from total time"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(325, 303)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(260, 20)
        Me.txtFilePath.TabIndex = 12
        '
        'btnFilePath
        '
        Me.btnFilePath.Location = New System.Drawing.Point(591, 303)
        Me.btnFilePath.Name = "btnFilePath"
        Me.btnFilePath.Size = New System.Drawing.Size(28, 21)
        Me.btnFilePath.TabIndex = 13
        Me.btnFilePath.Text = "..."
        Me.btnFilePath.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "*make sure that your filename don't have any whitespace"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(630, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 358)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFilePath)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.cmbSubLockTime)
        Me.Controls.Add(Me.cmbAbstracs)
        Me.Controls.Add(Me.cmbSortBy)
        Me.Controls.Add(Me.cmbDescending)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumTopSlowQuery)
        Me.Controls.Add(Me.btnSaveResult)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSQLDumpFile)
        Me.Controls.Add(Me.btnSelectSQLDUmpFile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MySQL DumpSlow for Windows"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelectSQLDUmpFile As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtSQLDumpFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveResult As System.Windows.Forms.Button
    Friend WithEvents txtNumTopSlowQuery As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDescending As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAbstracs As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubLockTime As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnFilePath As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
