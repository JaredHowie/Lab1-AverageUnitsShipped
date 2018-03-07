<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.tbUnitsShipped = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.tbAllUnitsShipped = New System.Windows.Forms.TextBox()
        Me.tbAverageUnitsShipped = New System.Windows.Forms.TextBox()
        Me.txtDayNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleName = "btnEnter"
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(13, 218)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(104, 218)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.Location = New System.Drawing.Point(195, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AccessibleName = "lblUnits"
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(43, 23)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units:"
        '
        'tbUnitsShipped
        '
        Me.tbUnitsShipped.AccessibleName = "tbUnitsShipped"
        Me.tbUnitsShipped.Location = New System.Drawing.Point(104, 23)
        Me.tbUnitsShipped.Name = "tbUnitsShipped"
        Me.tbUnitsShipped.Size = New System.Drawing.Size(75, 22)
        Me.tbUnitsShipped.TabIndex = 1
        '
        'txtDay
        '
        Me.txtDay.AccessibleName = "txtDay"
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDay.Enabled = False
        Me.txtDay.Location = New System.Drawing.Point(185, 23)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(35, 15)
        Me.txtDay.TabIndex = 0
        Me.txtDay.Text = "Day "
        '
        'tbAllUnitsShipped
        '
        Me.tbAllUnitsShipped.AccessibleName = "txtAllUnitsShipped"
        Me.tbAllUnitsShipped.Enabled = False
        Me.tbAllUnitsShipped.Location = New System.Drawing.Point(46, 51)
        Me.tbAllUnitsShipped.MaximumSize = New System.Drawing.Size(4, 200)
        Me.tbAllUnitsShipped.MinimumSize = New System.Drawing.Size(192, 130)
        Me.tbAllUnitsShipped.Multiline = True
        Me.tbAllUnitsShipped.Name = "tbAllUnitsShipped"
        Me.tbAllUnitsShipped.Size = New System.Drawing.Size(192, 133)
        Me.tbAllUnitsShipped.TabIndex = 6
        '
        'tbAverageUnitsShipped
        '
        Me.tbAverageUnitsShipped.AccessibleName = "tbAverageUnitsShipped"
        Me.tbAverageUnitsShipped.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbAverageUnitsShipped.Enabled = False
        Me.tbAverageUnitsShipped.Location = New System.Drawing.Point(46, 190)
        Me.tbAverageUnitsShipped.Name = "tbAverageUnitsShipped"
        Me.tbAverageUnitsShipped.Size = New System.Drawing.Size(192, 22)
        Me.tbAverageUnitsShipped.TabIndex = 7
        '
        'txtDayNumber
        '
        Me.txtDayNumber.AccessibleName = "txtDayNumber"
        Me.txtDayNumber.BackColor = System.Drawing.SystemColors.Control
        Me.txtDayNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDayNumber.Location = New System.Drawing.Point(220, 23)
        Me.txtDayNumber.Name = "txtDayNumber"
        Me.txtDayNumber.Size = New System.Drawing.Size(18, 15)
        Me.txtDayNumber.TabIndex = 8
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AccessibleName = "frmAverageUnitsShipped"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.txtDayNumber)
        Me.Controls.Add(Me.tbAverageUnitsShipped)
        Me.Controls.Add(Me.tbAllUnitsShipped)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.tbUnitsShipped)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents tbUnitsShipped As TextBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents tbAllUnitsShipped As TextBox
    Friend WithEvents tbAverageUnitsShipped As TextBox
    Friend WithEvents txtDayNumber As TextBox
End Class
