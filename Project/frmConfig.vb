Imports Microsoft.Win32

Public Class frmConfig
    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim increment As Integer = 0

        Try
            'Create the TPM bypass key
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                    "BypassTPMCheck", "1")
            increment = increment + 25
            If increment > pB.Maximum Then
                increment = pB.Maximum
            End If
            pB.Value = increment
            lblProgressPercentage.Text = "25%"

            'Create the RAM bypass key
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                    "BypassRAMCheck", "1")
            increment = increment + 25
            If increment > pB.Maximum Then
                increment = pB.Maximum
            End If
            pB.Value = increment
            lblProgressPercentage.Text = "25%"

            'Create the Secure Boot bypass key
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                   "BypassSecureBootCheck", "1")
            increment = increment + 25
            If increment > pB.Maximum Then
                increment = pB.Maximum
            End If
            pB.Value = increment
            lblProgressPercentage.Text = "25%"

            'Create the Secure Boot bypass key
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup",
                   "AllowUpgradesWithUnsupportedTPMOrCPU", "1")
            increment = increment + 25
            If increment > pB.Maximum Then
                increment = pB.Maximum
            End If
            pB.Value = increment

            If increment = 100 Then
                frmFinished.Show()
                Me.Close()
            End If
        Catch ex As Exception
            pB.Value = 0
            frmFailed.Show()
            Me.Close()
        End Try
    End Sub
End Class