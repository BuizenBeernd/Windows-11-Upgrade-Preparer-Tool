Public Class frmConfReady

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            Dim Bypass_TPM = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SYSTEM\Setup", "BypassTPMCheck", Nothing)
            Dim Bypass_RAM = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SYSTEM\Setup", "BypassRAMCheck", Nothing)
            Dim Bypass_SB = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SYSTEM\Setup", "BypassSecureBootCheck", Nothing)
            Dim AllowUpgrades = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup", "AllowUpgradesWithUnsupportedTPMOrCPU", Nothing)

            If Bypass_TPM = "1" And Bypass_SB = "1" And Bypass_RAM = "1" And AllowUpgrades = "1" Then
                frmAlreadyConfigurated.Show()
                Me.Close()
            Else
                frmConfig.Show()
                Me.Close()
            End If
        Catch ex As Exception
            frmFailed.Show()
            Me.Close()
        End Try
    End Sub
End Class