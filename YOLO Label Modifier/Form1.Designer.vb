<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtOrig = New System.Windows.Forms.TextBox()
        Me.txtModified = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLF = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnLabels = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(27, 27)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(86, 26)
        Me.btnOpenFolder.TabIndex = 0
        Me.btnOpenFolder.Text = "Open Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(138, 30)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(122, 19)
        Me.lblFolder.TabIndex = 1
        Me.lblFolder.Text = "No folder selected."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(32, 133)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(289, 308)
        Me.ListBox1.TabIndex = 2
        '
        'txtOrig
        '
        Me.txtOrig.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtOrig.Location = New System.Drawing.Point(337, 133)
        Me.txtOrig.Multiline = True
        Me.txtOrig.Name = "txtOrig"
        Me.txtOrig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrig.Size = New System.Drawing.Size(341, 308)
        Me.txtOrig.TabIndex = 3
        '
        'txtModified
        '
        Me.txtModified.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtModified.Location = New System.Drawing.Point(694, 133)
        Me.txtModified.Multiline = True
        Me.txtModified.Name = "txtModified"
        Me.txtModified.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtModified.Size = New System.Drawing.Size(341, 308)
        Me.txtModified.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File List:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(337, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Original Text:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(694, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Modified Text:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Look for:"
        '
        'txtLF
        '
        Me.txtLF.Location = New System.Drawing.Point(99, 68)
        Me.txtLF.Name = "txtLF"
        Me.txtLF.Size = New System.Drawing.Size(66, 26)
        Me.txtLF.TabIndex = 9
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(286, 67)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(66, 26)
        Me.txtR.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(188, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Replacement:"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(384, 67)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(146, 26)
        Me.btnModify.TabIndex = 12
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnLabels
        '
        Me.btnLabels.Location = New System.Drawing.Point(556, 68)
        Me.btnLabels.Name = "btnLabels"
        Me.btnLabels.Size = New System.Drawing.Size(139, 26)
        Me.btnLabels.TabIndex = 13
        Me.btnLabels.Text = "Count Labels"
        Me.btnLabels.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1105, 489)
        Me.Controls.Add(Me.btnLabels)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtModified)
        Me.Controls.Add(Me.txtOrig)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblFolder)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Name = "frmMain"
        Me.Text = "YOLO Label Modifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents lblFolder As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtOrig As TextBox
    Friend WithEvents txtModified As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLF As TextBox
    Friend WithEvents txtR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents btnLabels As Button
End Class
