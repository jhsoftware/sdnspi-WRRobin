<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHost
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.CtlIP1 = New JHSoftware.SimpleDNS.ctlIP()
        Me.grpBox.SuspendLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(251, 127)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(332, 127)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'grpBox
        '
        Me.grpBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox.Controls.Add(Me.CtlIP1)
        Me.grpBox.Controls.Add(Me.lblIP)
        Me.grpBox.Controls.Add(Me.numWeight)
        Me.grpBox.Controls.Add(Me.lblWeight)
        Me.grpBox.Location = New System.Drawing.Point(12, 12)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Padding = New System.Windows.Forms.Padding(15)
        Me.grpBox.Size = New System.Drawing.Size(395, 109)
        Me.grpBox.TabIndex = 0
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Host"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(18, 67)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(60, 13)
        Me.lblIP.TabIndex = 2
        Me.lblIP.Text = "IP address:"
        '
        'numWeight
        '
        Me.numWeight.Location = New System.Drawing.Point(84, 26)
        Me.numWeight.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numWeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(51, 20)
        Me.numWeight.TabIndex = 1
        Me.numWeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(18, 28)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight:"
        '
        'CtlIP1
        '
        Me.CtlIP1.AutoSize = True
        Me.CtlIP1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlIP1.Location = New System.Drawing.Point(84, 63)
        Me.CtlIP1.Name = "CtlIP1"
        Me.CtlIP1.Size = New System.Drawing.Size(281, 22)
        Me.CtlIP1.TabIndex = 3
        Me.CtlIP1.Value = Nothing
        '
        'frmHost
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(419, 162)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHost"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Host"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents numWeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents CtlIP1 As ctlIP
End Class
