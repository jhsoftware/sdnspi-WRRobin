Imports System.Threading.Tasks
Imports JHSoftware.SimpleDNS
Imports JHSoftware.SimpleDNS.Plugin

Public Class WRRobin
  Implements ILookupHost
  Implements IOptionsUI

  Dim myConfig As clConfig

  Public Property Host As IHost Implements IPlugInBase.Host

#Region "not implemented"

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
  End Sub

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

#Region "other methods"

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetTypeInfo
    With GetPlugInTypeInfo
      .Name = "Weighted Round Robin"
      .Description = "Serves IP addresses round robin from a weighted list"
      .InfoURL = "https://simpledns.plus/plugin-wrrobin"
    End With
  End Function

  Public Function LookupHost(name As DomName, ipv6 As Boolean, req As IRequestContext) As Task(Of LookupResult(Of SdnsIP)) Implements ILookupHost.LookupHost
    If name <> myConfig.Domain Then Return Task.FromResult(Of LookupResult(Of SdnsIP))(Nothing)
    Return Task.FromResult(New LookupResult(Of SdnsIP) With {.Value = myConfig.HitMe(If(ipv6, 6, 4)), .TTL = myConfig.TTL})
  End Function


  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    REM do not compare host names - two instances with different ACLs should be able to use same host name
    Return False
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    myConfig = clConfig.Load(config)
  End Sub

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IOptionsUI.GetOptionsUI
    Return New OptionsUI
  End Function

  Public Function StartService() As Task Implements IPlugInBase.StartService
    Return Task.CompletedTask
  End Function

#End Region

End Class
