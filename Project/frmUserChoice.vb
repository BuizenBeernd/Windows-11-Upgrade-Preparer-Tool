Public Class frmUserChoice
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If cB_Configure.Checked = True Then
            frmConfReady.Show()
            Me.Close()
        ElseIf cB_Restore.Checked = True Then
            Try
                'Disable the TPM bypass key
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                        "BypassTPMCheck", "0")
                'Disable the RAM bypass key
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                        "BypassRAMCheck", "0")
                'Disable the Secure Boot bypass key
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup",
                       "BypassSecureBootCheck", "0")
                'Disable the Secure Boot bypass key
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup",
                       "AllowUpgradesWithUnsupportedTPMOrCPU", "0")

                frmFinished.lblApplicationTitle.Text = "Modifications are removed."
                frmFinished.lblApplicationSubtitle.Text = "Your Windows is restored to its original state."
                frmFinished.cB_StartWin11Install.Visible = False
                frmFinished.lblNotification.Visible = False
                frmFinished.Show()
                Me.Close()

            Catch ex As Exception
                frmFailed.Show()
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub cB_Configure_CheckedChanged(sender As Object, e As EventArgs) Handles cB_Configure.CheckedChanged
        If cB_Configure.Checked = True Then
            cB_Restore.Checked = False
        End If
    End Sub

    Private Sub cB_Restore_CheckedChanged(sender As Object, e As EventArgs) Handles cB_Restore.CheckedChanged
        If cB_Restore.Checked = True Then
            cB_Configure.Checked = False
        End If
    End Sub
End Class