Imports System.Windows.Forms

Public Class frmHost


  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    Dim ip As System.Net.IPAddress = Nothing
    If Not System.Net.IPAddress.TryParse(CtlIP1.Text, ip) Then
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
