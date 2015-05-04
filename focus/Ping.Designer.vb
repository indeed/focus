<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ping
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
        Me.components = New System.ComponentModel.Container()
        Me.msgbox_buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.cancel = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.Button()
        Me.yes = New System.Windows.Forms.Button()
        Me.msgtext = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.fadeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.msgbox_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'msgbox_buttons
        '
        Me.msgbox_buttons.AccessibleDescription = "menu_settings_color"
        Me.msgbox_buttons.ColumnCount = 3
        Me.msgbox_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.msgbox_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.msgbox_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.msgbox_buttons.Controls.Add(Me.cancel, 0, 0)
        Me.msgbox_buttons.Controls.Add(Me.no, 0, 0)
        Me.msgbox_buttons.Controls.Add(Me.yes, 0, 0)
        Me.msgbox_buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.msgbox_buttons.Location = New System.Drawing.Point(1, 103)
        Me.msgbox_buttons.Margin = New System.Windows.Forms.Padding(0)
        Me.msgbox_buttons.Name = "msgbox_buttons"
        Me.msgbox_buttons.RowCount = 1
        Me.msgbox_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.msgbox_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.msgbox_buttons.Size = New System.Drawing.Size(270, 32)
        Me.msgbox_buttons.TabIndex = 6
        '
        'cancel
        '
        Me.cancel.AccessibleDescription = "menu_settings_color"
        Me.cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cancel.Location = New System.Drawing.Point(180, 0)
        Me.cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(90, 32)
        Me.cancel.TabIndex = 32
        Me.cancel.Text = "Cancel"
        Me.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cancel.UseVisualStyleBackColor = True
        '
        'no
        '
        Me.no.AccessibleDescription = "menu_settings_color"
        Me.no.Dock = System.Windows.Forms.DockStyle.Fill
        Me.no.FlatAppearance.BorderSize = 0
        Me.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.no.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.no.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.no.Location = New System.Drawing.Point(90, 0)
        Me.no.Margin = New System.Windows.Forms.Padding(0)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(90, 32)
        Me.no.TabIndex = 31
        Me.no.Text = "No"
        Me.no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.no.UseVisualStyleBackColor = True
        '
        'yes
        '
        Me.yes.AccessibleDescription = "menu_settings_color"
        Me.yes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.yes.FlatAppearance.BorderSize = 0
        Me.yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yes.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yes.Location = New System.Drawing.Point(0, 0)
        Me.yes.Margin = New System.Windows.Forms.Padding(0)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(90, 32)
        Me.yes.TabIndex = 29
        Me.yes.Text = "Yes"
        Me.yes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.yes.UseVisualStyleBackColor = True
        '
        'msgtext
        '
        Me.msgtext.AccessibleDescription = "menu_settings_color"
        Me.msgtext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msgtext.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgtext.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.msgtext.Location = New System.Drawing.Point(1, 24)
        Me.msgtext.Name = "msgtext"
        Me.msgtext.Size = New System.Drawing.Size(270, 79)
        Me.msgtext.TabIndex = 8
        Me.msgtext.Text = "focus"
        Me.msgtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'title
        '
        Me.title.AccessibleDescription = "menu_settings_color"
        Me.title.AccessibleName = "inverted"
        Me.title.Dock = System.Windows.Forms.DockStyle.Top
        Me.title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.title.Location = New System.Drawing.Point(1, 1)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(270, 23)
        Me.title.TabIndex = 7
        Me.title.Text = "focus"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fadeTimer
        '
        Me.fadeTimer.Interval = 30
        '
        'Ping
        '
        Me.AccessibleDescription = "menu_color"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 136)
        Me.Controls.Add(Me.msgtext)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.msgbox_buttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ping"
        Me.Opacity = 0.0R
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.msgbox_buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msgbox_buttons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.Button
    Friend WithEvents yes As System.Windows.Forms.Button
    Friend WithEvents msgtext As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents fadeTimer As System.Windows.Forms.Timer

End Class
