Imports JHSoftware.SimpleDNS.Plugin

Friend Class clConfig
  Public Domain As DomainName
  Public TTL As Integer
  Public Items As New List(Of WRRItem)

  Friend Class WRRItem
    Friend IP As IPAddress
    Friend Weight As Integer
    Friend Hits As Integer
  End Class

  Public Function HitMe(ByVal IPVersion As Integer) As IPAddress
    Dim load, MinLoad As Double
    Dim m As Integer = -1
    For i = 0 To Items.Count - 1
      With Items(i)
        If .IP.ipversion <> IPVersion Then Continue For
        load = .Hits / .Weight
        If m = -1 OrElse load < MinLoad Then
          MinLoad = load
          m = i
        End If
      End With
    Next
    If m = -1 Then Return Nothing
    With Items(m)
      .Hits += 1
      Return .IP
    End With
  End Function

  Shared Function Load(ByVal config As String) As clConfig
    Dim sa = PipeDecode(config)
    Dim rv As New clConfig
    rv.Domain = JHSoftware.SimpleDNS.Plugin.DomainName.Parse(sa(1))
    rv.TTL = Integer.Parse(sa(2))
    For i = 3 To sa.Length - 1 Step 2
      rv.Items.Add(New WRRItem With {.Weight = Integer.Parse(sa(i)), .IP = IPAddress.Parse(sa(i + 1))})
    Next
    Return rv
  End Function

  Friend Function Save() As String
    Dim sb As New System.Text.StringBuilder
    sb.Append("1") 'version
    sb.Append("|" & PipeEncode(Domain.ToString))
    sb.Append("|" & TTL.ToString)
    For Each itm In Items
      sb.Append("|" & itm.Weight.ToString)
      sb.Append("|" & itm.IP.ToString)
    Next
    Return sb.ToString
  End Function

End Class

