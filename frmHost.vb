Imports System.Windows.Forms

Public Class frmHost

  Friend WithEvents ctrlIP As Windows.Forms.Control

  Private Sub frmHost_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

  End Sub

  Private Sub frmItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    grpBox.Controls.Add(ctrlIP)
    ctrlIP.Location = txtDummy.Location
    ctrlIP.TabIndex = lblIP.TabIndex + 1
  End Sub

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    Dim ip As System.Net.IPAddress
    If Not System.Net.IPAddress.TryParse(ctrlIP.Text, ip) Then
      MessageBox.Show("Invalid IP address", "Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

End Class
