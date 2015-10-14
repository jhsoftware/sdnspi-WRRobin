Imports JHSoftware.SimpleDNS.Plugin

Public Class WRRobin
  Implements IGetHostPlugIn

  Dim myConfig As clConfig

#Region "events"
  Public Event LogLine(ByVal text As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LogLine
  Public Event AsyncError(ByVal ex As System.Exception) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.AsyncError
  Public Event SaveConfig(ByVal config As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveConfig
#End Region

#Region "not implemented"
  Public Sub LookupReverse(ByVal req As IDNSRequest, ByRef resultName As JHSoftware.SimpleDNS.Plugin.DomainName, ByRef resultTTL As Integer) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.LookupReverse
    Throw New NotSupportedException
  End Sub

  Public Sub LookupTXT(ByVal req As IDNSRequest, ByRef resultText As String, ByRef resultTTL As Integer) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.LookupTXT
    Throw New NotSupportedException
  End Sub

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
  End Sub

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Sub StartService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
  End Sub

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

#Region "other methods"

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    With GetPlugInTypeInfo
      .Name = "Weighted Round Robin"
      .Description = "Serves IP addresses round robin from a weighted list"
      .InfoURL = "http://www.simpledns.com/plugin-wrrobin"
      .ConfigFile = False
      .MultiThreaded = False
    End With
  End Function

  Public Sub Lookup(ByVal req As IDNSRequest, ByRef resultIP As IPAddress, ByRef resultTTL As Integer) Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.Lookup
    resultIP = myConfig.HitMe(If(CUShort(req.QType) = 1, 4, 6))
    resultTTL = myConfig.TTL
  End Sub

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    REM do not compare host names - two instances with different ACLs should be able to use same host name
    Return False
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String, ByRef maxThreads As Integer) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    myConfig = clConfig.Load(config)
  End Sub

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetOptionsUI
    Return New OptionsUI
  End Function

  Public Function GetDNSAskAbout() As DNSAskAboutGH Implements JHSoftware.SimpleDNS.Plugin.IGetHostPlugIn.GetDNSAskAbout
    GetDNSAskAbout = New DNSAskAboutGH
    With GetDNSAskAbout
      .Domain = myConfig.Domain
      .ForwardIPv4 = True
      .ForwardIPv6 = True
    End With
  End Function

#End Region

End Class
