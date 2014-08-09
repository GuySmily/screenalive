Imports System.Runtime.InteropServices
Imports Microsoft.Win32         'for system events
'Imports IWshRuntimeLibrary

Public Class Main

  Private Const SPI_SETSCREENSAVETIMEOUT As Int32 = 15
  Private blnInitializing As Boolean = True

  'This function queries or sets system-wide parameters, and updates the user profile during the process.
  <DllImport("user32", EntryPoint:="SystemParametersInfo", CharSet:=CharSet.Auto, SetLastError:=True)> _
  Private Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
  End Function

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
    'Minimize on startup
    Me.WindowState = FormWindowState.Minimized
    PowerManagement.DisablePowerSaving()

    blnInitializing = False
  End Sub

  Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    PowerManagement.EnablePowerSaving()
  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    'Sets the screen saver time-out value to the 
    'value of the uiParam parameter. This value is the amount of time, 
    'in seconds, that the system must remain idle before the screen saver activates. 
    'So, if you set it 30, it will suspend the screensaver & Power Off features for 30 minutes

    'SystemParametersInfo(SPI_SETSCREENSAVETIMEOUT, 30, 0, 0)

  End Sub

End Class


Public Class PowerManagement
  'Source: http://msdn.microsoft.com/en-us/library/windows/desktop/aa373208%28v=vs.85%29.aspx
  '        http://www.vbforums.com/showthread.php?725077-Ensure-quot-Sleep-quot-is-disabled

  Private Sub New()
  End Sub

  Public Shared Function DisablePowerSaving() As EXECUTION_STATE
    Return NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED _
                                                 Or EXECUTION_STATE.ES_DISPLAY_REQUIRED _
                                                 Or EXECUTION_STATE.ES_CONTINUOUS)
  End Function

  Public Shared Function EnablePowerSaving() As EXECUTION_STATE
    Return NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
  End Function

  Private Class NativeMethods
    Friend Declare Function SetThreadExecutionState Lib "kernel32" (ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE
  End Class

  <Flags()>
  Public Enum EXECUTION_STATE As Integer
    ES_CONTINUOUS = &H80000000
    ES_USER_PRESENT = &H4
    ES_DISPLAY_REQUIRED = &H2
    ES_SYSTEM_REQUIRED = &H1
  End Enum
End Class




