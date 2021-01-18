<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RightR = New System.Windows.Forms.PictureBox()
        Me.LeftR = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.serverchat = New System.Windows.Forms.RichTextBox()
        Me.serveronoff = New System.Windows.Forms.Label()
        Me.serverstat = New System.Windows.Forms.Label()
        Me.Stopserver = New System.Windows.Forms.Button()
        Me.iplist = New System.Windows.Forms.ListBox()
        Me.startserver = New System.Windows.Forms.Button()
        Me.ircchat = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DownR = New System.Windows.Forms.PictureBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UpR = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPORT = New System.Windows.Forms.TextBox()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RightR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DownR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(246, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(327, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(408, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Has Connection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(490, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FALSE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RightR)
        Me.GroupBox1.Controls.Add(Me.LeftR)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.serverchat)
        Me.GroupBox1.Controls.Add(Me.serveronoff)
        Me.GroupBox1.Controls.Add(Me.serverstat)
        Me.GroupBox1.Controls.Add(Me.Stopserver)
        Me.GroupBox1.Controls.Add(Me.iplist)
        Me.GroupBox1.Controls.Add(Me.startserver)
        Me.GroupBox1.Controls.Add(Me.ircchat)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(962, 350)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chat Room"
        '
        'RightR
        '
        Me.RightR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightR.Location = New System.Drawing.Point(959, -35)
        Me.RightR.Name = "RightR"
        Me.RightR.Size = New System.Drawing.Size(3, 451)
        Me.RightR.TabIndex = 18
        Me.RightR.TabStop = False
        '
        'LeftR
        '
        Me.LeftR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.LeftR.Location = New System.Drawing.Point(0, -58)
        Me.LeftR.Name = "LeftR"
        Me.LeftR.Size = New System.Drawing.Size(3, 474)
        Me.LeftR.TabIndex = 17
        Me.LeftR.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(863, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "IP List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Server Chat"
        '
        'serverchat
        '
        Me.serverchat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.serverchat.BackColor = System.Drawing.SystemColors.InfoText
        Me.serverchat.ForeColor = System.Drawing.Color.Lime
        Me.serverchat.Location = New System.Drawing.Point(536, 48)
        Me.serverchat.Name = "serverchat"
        Me.serverchat.Size = New System.Drawing.Size(258, 296)
        Me.serverchat.TabIndex = 12
        Me.serverchat.Text = ""
        '
        'serveronoff
        '
        Me.serveronoff.AutoSize = True
        Me.serveronoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serveronoff.Location = New System.Drawing.Point(580, 32)
        Me.serveronoff.Name = "serveronoff"
        Me.serveronoff.Size = New System.Drawing.Size(21, 13)
        Me.serveronoff.TabIndex = 11
        Me.serveronoff.Text = "Off"
        '
        'serverstat
        '
        Me.serverstat.AutoSize = True
        Me.serverstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serverstat.Location = New System.Drawing.Point(536, 32)
        Me.serverstat.Name = "serverstat"
        Me.serverstat.Size = New System.Drawing.Size(47, 13)
        Me.serverstat.TabIndex = 10
        Me.serverstat.Text = "Status:"
        '
        'Stopserver
        '
        Me.Stopserver.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Stopserver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Stopserver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Stopserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stopserver.Location = New System.Drawing.Point(663, 3)
        Me.Stopserver.Name = "Stopserver"
        Me.Stopserver.Size = New System.Drawing.Size(131, 26)
        Me.Stopserver.TabIndex = 9
        Me.Stopserver.Text = "Stop Server"
        Me.Stopserver.UseVisualStyleBackColor = False
        '
        'iplist
        '
        Me.iplist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.iplist.BackColor = System.Drawing.SystemColors.InfoText
        Me.iplist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.iplist.ForeColor = System.Drawing.Color.Lime
        Me.iplist.FormattingEnabled = True
        Me.iplist.Location = New System.Drawing.Point(800, 16)
        Me.iplist.Name = "iplist"
        Me.iplist.Size = New System.Drawing.Size(159, 329)
        Me.iplist.TabIndex = 6
        '
        'startserver
        '
        Me.startserver.BackColor = System.Drawing.SystemColors.ControlDark
        Me.startserver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startserver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
        Me.startserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startserver.Location = New System.Drawing.Point(536, 3)
        Me.startserver.Name = "startserver"
        Me.startserver.Size = New System.Drawing.Size(121, 26)
        Me.startserver.TabIndex = 8
        Me.startserver.Text = "Start Server"
        Me.startserver.UseVisualStyleBackColor = False
        '
        'ircchat
        '
        Me.ircchat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ircchat.BackColor = System.Drawing.SystemColors.InfoText
        Me.ircchat.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.ircchat.ForeColor = System.Drawing.Color.Lime
        Me.ircchat.Location = New System.Drawing.Point(3, 16)
        Me.ircchat.Name = "ircchat"
        Me.ircchat.Size = New System.Drawing.Size(527, 287)
        Me.ircchat.TabIndex = 1
        Me.ircchat.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DownR)
        Me.Panel2.Controls.Add(Me.RichTextBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 303)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(956, 44)
        Me.Panel2.TabIndex = 0
        '
        'DownR
        '
        Me.DownR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.DownR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownR.Location = New System.Drawing.Point(0, 41)
        Me.DownR.Name = "DownR"
        Me.DownR.Size = New System.Drawing.Size(956, 3)
        Me.DownR.TabIndex = 16
        Me.DownR.TabStop = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(527, 41)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = "/setuser "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxPORT)
        Me.Panel1.Controls.Add(Me.TextBoxIP)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 58)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.UpR)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(962, 23)
        Me.Panel3.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Roasting IRC Client"
        '
        'UpR
        '
        Me.UpR.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UpR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.UpR.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpR.Location = New System.Drawing.Point(0, 0)
        Me.UpR.Name = "UpR"
        Me.UpR.Size = New System.Drawing.Size(851, 3)
        Me.UpR.TabIndex = 16
        Me.UpR.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(851, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "🗕"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(887, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "🗖"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(924, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(663, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 19)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Host Your Own Server!"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(157, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IP:"
        '
        'TextBoxPORT
        '
        Me.TextBoxPORT.Location = New System.Drawing.Point(192, 31)
        Me.TextBoxPORT.Name = "TextBoxPORT"
        Me.TextBoxPORT.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxPORT.TabIndex = 5
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Location = New System.Drawing.Point(29, 31)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(126, 20)
        Me.TextBoxIP.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(962, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(530, 308)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IRC Client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RightR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DownR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ircchat As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPORT As TextBox
    Friend WithEvents serveronoff As Label
    Friend WithEvents serverstat As Label
    Friend WithEvents Stopserver As Button
    Friend WithEvents iplist As ListBox
    Friend WithEvents startserver As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents serverchat As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RightR As PictureBox
    Friend WithEvents LeftR As PictureBox
    Friend WithEvents DownR As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents UpR As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
