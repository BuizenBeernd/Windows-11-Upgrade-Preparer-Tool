<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserChoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserChoice))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnNext = New DevComponents.DotNetBar.ButtonX()
        Me.cB_Configure = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblApplicationSubtitle = New DevComponents.DotNetBar.LabelX()
        Me.lblApplicationTitle = New DevComponents.DotNetBar.LabelX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cB_Restore = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.btnNext)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(43, 493)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(723, 28)
        Me.Panel6.TabIndex = 37
        '
        'btnNext
        '
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNext.AntiAlias = True
        Me.btnNext.BackColor = System.Drawing.SystemColors.Control
        Me.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(615, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(108, 28)
        Me.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        '
        'cB_Configure
        '
        Me.cB_Configure.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cB_Configure.BackgroundStyle.Class = ""
        Me.cB_Configure.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cB_Configure.Checked = True
        Me.cB_Configure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cB_Configure.CheckValue = "Y"
        Me.cB_Configure.Dock = System.Windows.Forms.DockStyle.Top
        Me.cB_Configure.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!)
        Me.cB_Configure.Location = New System.Drawing.Point(43, 143)
        Me.cB_Configure.Name = "cB_Configure"
        Me.cB_Configure.Size = New System.Drawing.Size(723, 31)
        Me.cB_Configure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cB_Configure.TabIndex = 38
        Me.cB_Configure.Text = "Configure my computer for Windows 11."
        Me.cB_Configure.TextColor = System.Drawing.Color.Gainsboro
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(43, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(723, 47)
        Me.Panel5.TabIndex = 35
        '
        'lblApplicationSubtitle
        '
        Me.lblApplicationSubtitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblApplicationSubtitle.BackgroundStyle.Class = ""
        Me.lblApplicationSubtitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblApplicationSubtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblApplicationSubtitle.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!)
        Me.lblApplicationSubtitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblApplicationSubtitle.Location = New System.Drawing.Point(43, 73)
        Me.lblApplicationSubtitle.Name = "lblApplicationSubtitle"
        Me.lblApplicationSubtitle.Size = New System.Drawing.Size(723, 23)
        Me.lblApplicationSubtitle.TabIndex = 34
        Me.lblApplicationSubtitle.Text = "Please select from one of the available options to continue."
        '
        'lblApplicationTitle
        '
        Me.lblApplicationTitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblApplicationTitle.BackgroundStyle.Class = ""
        Me.lblApplicationTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblApplicationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblApplicationTitle.Font = New System.Drawing.Font("Microsoft Yi Baiti", 36.0!)
        Me.lblApplicationTitle.ForeColor = System.Drawing.Color.White
        Me.lblApplicationTitle.Location = New System.Drawing.Point(43, 30)
        Me.lblApplicationTitle.Name = "lblApplicationTitle"
        Me.lblApplicationTitle.Size = New System.Drawing.Size(723, 43)
        Me.lblApplicationTitle.TabIndex = 33
        Me.lblApplicationTitle.Text = "What do you want to do?"
        Me.lblApplicationTitle.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(43, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 30)
        Me.Panel3.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(766, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(43, 521)
        Me.Panel2.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(43, 521)
        Me.Panel1.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 521)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(809, 30)
        Me.Panel4.TabIndex = 36
        '
        'cB_Restore
        '
        Me.cB_Restore.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cB_Restore.BackgroundStyle.Class = ""
        Me.cB_Restore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cB_Restore.Dock = System.Windows.Forms.DockStyle.Top
        Me.cB_Restore.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!)
        Me.cB_Restore.Location = New System.Drawing.Point(43, 174)
        Me.cB_Restore.Name = "cB_Restore"
        Me.cB_Restore.Size = New System.Drawing.Size(723, 31)
        Me.cB_Restore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cB_Restore.TabIndex = 39
        Me.cB_Restore.Text = "Restore the original state of Windows 10."
        Me.cB_Restore.TextColor = System.Drawing.Color.Gainsboro
        '
        'frmUserChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 551)
        Me.Controls.Add(Me.cB_Restore)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.cB_Configure)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lblApplicationSubtitle)
        Me.Controls.Add(Me.lblApplicationTitle)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 11 Upgrade Preparer Tool"
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Private WithEvents btnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cB_Configure As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblApplicationSubtitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblApplicationTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cB_Restore As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
