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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtExeList = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtExeList
        '
        Me.txtExeList.Location = New System.Drawing.Point(12, 12)
        Me.txtExeList.Multiline = True
        Me.txtExeList.Name = "txtExeList"
        Me.txtExeList.ReadOnly = True
        Me.txtExeList.Size = New System.Drawing.Size(220, 238)
        Me.txtExeList.TabIndex = 1
        Me.txtExeList.Text = "EXEold'da varolan programlar:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 253)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(43, 13)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtExeList)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "MEGA-Test01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtExeList As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As Label
End Class
