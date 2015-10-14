Public Class OptionsUI

  Private NowAdding As Boolean

  Public Overrides Sub LoadData(ByVal config As String)
    If config Is Nothing Then Exit Sub 'new instance
    Dim cfg = clConfig.Load(config)
    txtName.Text = cfg.Domain.ToString
    ttl1.Value = cfg.TTL
    For Each itm In cfg.Items
      lstHosts.Items.Add(itm.Weight.ToString).SubItems.Add(itm.IP.ToString)
    Next
  End Sub

  Public Overrides Function ValidateData() As Boolean
    If txtName.Text.Trim.Length = 0 Then
      MessageBox.Show("Host name is empty", "Weighted Round Robin", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    Dim d As JHSoftware.SimpleDNS.Plugin.DomainName
    If Not JHSoftware.SimpleDNS.Plugin.DomainName.TryParse(txtName.Text.Trim, d) Then
      MessageBox.Show("Invalid host name", "Weighted Round Robin", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    If lstHosts.Items.Count = 0 Then
      MessageBox.Show("Weight/IP address list is empty", "Weighted Round Robin", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    Return True
  End Function

  Public Overrides Function SaveData() As String
    Dim cfg As New clConfig
    cfg.Domain = JHSoftware.SimpleDNS.Plugin.DomainName.Parse(txtName.Text.Trim)
    cfg.TTL = ttl1.Value
    For Each itm As ListViewItem In lstHosts.Items
      cfg.Items.Add(New clConfig.WRRItem With {.Weight = Integer.Parse(itm.Text), .IP = JHSoftware.SimpleDNS.Plugin.IPAddress.Parse(itm.SubItems(1).Text)})
    Next
    Return cfg.Save
  End Function

  Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Dim frm As New frmHost
    frm.ctrlIP = GetIPCtrl.Invoke(True, True)
    AddHandler frm.FormClosing, AddressOf SubFormClosing
    NowAdding = True
    frm.ShowDialog()
  End Sub

  Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    If lstHosts.SelectedIndices.Count = 0 Then Exit Sub
    Dim frm As New frmHost
    frm.ctrlIP = GetIPCtrl.Invoke(True, True)
    AddHandler frm.FormClosing, AddressOf SubFormClosing
    frm.numWeight.Value = Integer.Parse(lstHosts.SelectedItems(0).Text)
    frm.ctrlIP.Text = lstHosts.SelectedItems(0).SubItems(1).Text
    NowAdding = False
    frm.ShowDialog()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    If lstHosts.SelectedIndices.Count = 0 Then Exit Sub
    lstHosts.Items.RemoveAt(lstHosts.SelectedIndices(0))
  End Sub

  Sub SubFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
    Dim frm = DirectCast(sender, frmHost)
    If frm.DialogResult <> DialogResult.OK Then Exit Sub
    Dim ip = System.Net.IPAddress.Parse(frm.ctrlIP.Text)
    For i = 0 To lstHosts.Items.Count - 1
      If Not NowAdding AndAlso i = lstHosts.SelectedIndices(0) Then Continue For
      If System.Net.IPAddress.Parse(lstHosts.Items(i).SubItems(1).Text).Equals(ip) Then
        MessageBox.Show("IP address is already in the list", "Weighted Round Robin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Cancel = True
        Exit Sub
      End If
    Next
    Dim lvi As ListViewItem
    If NowAdding Then
      lvi = lstHosts.Items.Add(CInt(frm.numWeight.Value).ToString)
      lvi.SubItems.Add(ip.ToString)
      lvi.Selected = True
    Else
      lvi = lstHosts.SelectedItems(0)
      lvi.Text = CInt(frm.numWeight.Value).ToString
      lvi.SubItems(1).Text = ip.ToString
    End If
  End Sub

  Private Sub lstHosts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstHosts.DoubleClick
    btnEdit_Click(Nothing, Nothing)
  End Sub

  Private Sub lstHosts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHosts.SelectedIndexChanged
    btnEdit.Enabled = (lstHosts.SelectedIndices.Count > 0)
    btnRemove.Enabled = (lstHosts.SelectedIndices.Count > 0)
  End Sub

End Class
