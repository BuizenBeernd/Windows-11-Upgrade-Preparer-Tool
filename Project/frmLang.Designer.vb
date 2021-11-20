<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblApplicationTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblApplicationSubtitle = New DevComponents.DotNetBar.LabelX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnNext = New DevComponents.DotNetBar.ButtonX()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblLanguage = New DevComponents.DotNetBar.LabelX()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbLanguage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(43, 551)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(766, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(43, 551)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(43, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 30)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(43, 521)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(723, 30)
        Me.Panel4.TabIndex = 3
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
        Me.lblApplicationTitle.TabIndex = 4
        Me.lblApplicationTitle.Text = "Select your language to continue"
        Me.lblApplicationTitle.TextLineAlignment = System.Drawing.StringAlignment.Far
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
        Me.lblApplicationSubtitle.TabIndex = 5
        Me.lblApplicationSubtitle.Text = "Please select from one of the available options to continue."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(43, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(723, 47)
        Me.Panel5.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.btnNext)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(43, 493)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(723, 28)
        Me.Panel6.TabIndex = 7
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.lblLanguage)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(43, 143)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(113, 350)
        Me.Panel7.TabIndex = 8
        '
        'lblLanguage
        '
        '
        '
        '
        Me.lblLanguage.BackgroundStyle.Class = ""
        Me.lblLanguage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLanguage.ForeColor = System.Drawing.Color.White
        Me.lblLanguage.Location = New System.Drawing.Point(0, 0)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(113, 20)
        Me.lblLanguage.TabIndex = 0
        Me.lblLanguage.Text = "Language"
        Me.lblLanguage.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(500, 143)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(266, 350)
        Me.Panel8.TabIndex = 9
        '
        'cbLanguage
        '
        Me.cbLanguage.DisplayMember = "Text"
        Me.cbLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLanguage.Enabled = False
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.ItemHeight = 14
        Me.cbLanguage.Location = New System.Drawing.Point(156, 143)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(344, 20)
        Me.cbLanguage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbLanguage.TabIndex = 10
        Me.cbLanguage.Text = "English"
        '
        'frmLang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 551)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lblApplicationSubtitle)
        Me.Controls.Add(Me.lblApplicationTitle)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 11 Upgrade Preparer Tool"
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblApplicationTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblApplicationSubtitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Private WithEvents btnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblLanguage As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbLanguage As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
