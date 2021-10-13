<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsUI
  Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtName = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnAdd = New System.Windows.Forms.Button
    Me.btnEdit = New System.Windows.Forms.Button
    Me.btnRemove = New System.Windows.Forms.Button
    Me.lstHosts = New System.Windows.Forms.ListView
    Me.colWeight = New System.Windows.Forms.ColumnHeader
    Me.colIP = New System.Windows.Forms.ColumnHeader
    Me.ttl1 = New ctlTTL
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(-3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(61, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Host name:"
    '
    'txtName
    '
    Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtName.Location = New System.Drawing.Point(0, 16)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(354, 20)
    Me.txtName.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(-3, 194)
    Me.Label3.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(159, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Host record TTL (Time To Live):"
    '
    'btnAdd
    '
    Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAdd.Location = New System.Drawing.Point(289, 54)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(65, 21)
    Me.btnAdd.TabIndex = 3
    Me.btnAdd.Text = "Add..."
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'btnEdit
    '
    Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnEdit.Enabled = False
    Me.btnEdit.Location = New System.Drawing.Point(289, 81)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(65, 21)
    Me.btnEdit.TabIndex = 4
    Me.btnEdit.Text = "Edit..."
    Me.btnEdit.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRemove.Enabled = False
    Me.btnRemove.Location = New System.Drawing.Point(289, 108)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(65, 21)
    Me.btnRemove.TabIndex = 5
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'lstHosts
    '
    Me.lstHosts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstHosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colWeight, Me.colIP})
    Me.lstHosts.FullRowSelect = True
    Me.lstHosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lstHosts.HideSelection = False
    Me.lstHosts.Location = New System.Drawing.Point(0, 54)
    Me.lstHosts.MultiSelect = False
    Me.lstHosts.Name = "lstHosts"
    Me.lstHosts.ShowGroups = False
    Me.lstHosts.Size = New System.Drawing.Size(283, 122)
    Me.lstHosts.TabIndex = 2
    Me.lstHosts.UseCompatibleStateImageBehavior = False
    Me.lstHosts.View = System.Windows.Forms.View.Details
    '
    'colWeight
    '
    Me.colWeight.Text = "Weight"
    Me.colWeight.Width = 50
    '
    'colIP
    '
    Me.colIP.Text = "IP address"
    Me.colIP.Width = 200
    '
    'ttl1
    '
    Me.ttl1.AutoSize = True
    Me.ttl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttl1.BackColor = System.Drawing.Color.Transparent
    Me.ttl1.Location = New System.Drawing.Point(0, 210)
    Me.ttl1.Name = "ttl1"
    Me.ttl1.ReadOnly = False
    Me.ttl1.Size = New System.Drawing.Size(156, 21)
    Me.ttl1.TabIndex = 7
    Me.ttl1.Value = 300
    '
    'OptionsUI
    '
    Me.Controls.Add(Me.lstHosts)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.btnEdit)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.ttl1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.Label1)
    Me.Name = "OptionsUI"
    Me.Size = New System.Drawing.Size(354, 240)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents ttl1 As ctlTTL
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents lstHosts As System.Windows.Forms.ListView
  Friend WithEvents colWeight As System.Windows.Forms.ColumnHeader
  Friend WithEvents colIP As System.Windows.Forms.ColumnHeader

End Class
