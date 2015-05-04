<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class focus
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(focus))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 0.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 100.0R)
        Me.timer_anim = New System.Windows.Forms.Timer(Me.components)
        Me.pomodoro_strip = New System.Windows.Forms.Panel()
        Me.pomodoro_fill = New System.Windows.Forms.Panel()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.panel_content = New System.Windows.Forms.Panel()
        Me.panel_stats = New System.Windows.Forms.Panel()
        Me.stats_main = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chart_progress = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.stats_group_time = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.stats_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stats_group_progress = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.stats_progress = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stats_divider = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.stats_title = New System.Windows.Forms.Label()
        Me.stats_back = New System.Windows.Forms.Button()
        Me.panel_settings = New System.Windows.Forms.Panel()
        Me.settings_main = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.settings_cancel = New System.Windows.Forms.Button()
        Me.settings_ok = New System.Windows.Forms.Button()
        Me.settings_table = New System.Windows.Forms.TableLayoutPanel()
        Me.settings_group_other = New System.Windows.Forms.GroupBox()
        Me.settings_startfullscreen = New System.Windows.Forms.CheckBox()
        Me.settings_group_pom = New System.Windows.Forms.GroupBox()
        Me.settings_pom_table = New System.Windows.Forms.TableLayoutPanel()
        Me.settings_pomtime_break = New System.Windows.Forms.NumericUpDown()
        Me.settings_pomtime = New System.Windows.Forms.NumericUpDown()
        Me.settings_label_pomtimebreak = New System.Windows.Forms.Label()
        Me.settings_label_pomtime = New System.Windows.Forms.Label()
        Me.settings_pom_startup = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.settings_changefont = New System.Windows.Forms.Button()
        Me.settings_divider = New System.Windows.Forms.Panel()
        Me.settings_panel_top = New System.Windows.Forms.Panel()
        Me.settings_title = New System.Windows.Forms.Label()
        Me.settings_back = New System.Windows.Forms.Button()
        Me.panel_writer_info = New System.Windows.Forms.Panel()
        Me.label_time = New System.Windows.Forms.Label()
        Me.label_wordcount = New System.Windows.Forms.Label()
        Me.label_output = New System.Windows.Forms.Label()
        Me.panel_write = New System.Windows.Forms.Panel()
        Me.text_writer = New System.Windows.Forms.RichTextBox()
        Me.panel_searchreplace = New System.Windows.Forms.Panel()
        Me.button_replaceall = New System.Windows.Forms.Button()
        Me.button_replace = New System.Windows.Forms.Button()
        Me.findreplace_replace = New System.Windows.Forms.TextBox()
        Me.button_find = New System.Windows.Forms.Button()
        Me.findreplace_find = New System.Windows.Forms.TextBox()
        Me.searchreplace_close = New System.Windows.Forms.Button()
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.panel_menu_main = New System.Windows.Forms.Panel()
        Me.panel_menu_flow = New System.Windows.Forms.Panel()
        Me.button_stats = New System.Windows.Forms.Button()
        Me.menu_expand_themes = New System.Windows.Forms.Panel()
        Me.table_theme = New System.Windows.Forms.TableLayoutPanel()
        Me.button_theme_slate = New System.Windows.Forms.Button()
        Me.button_theme_khaki = New System.Windows.Forms.Button()
        Me.button_theme_light = New System.Windows.Forms.Button()
        Me.button_theme = New System.Windows.Forms.Button()
        Me.menu_expand_pomodoro = New System.Windows.Forms.Panel()
        Me.button_pomEnable = New System.Windows.Forms.Button()
        Me.panel_menu_divider2 = New System.Windows.Forms.Panel()
        Me.button_settings = New System.Windows.Forms.Button()
        Me.button_pomodoro = New System.Windows.Forms.Button()
        Me.menu_expand_file = New System.Windows.Forms.Panel()
        Me.button_print = New System.Windows.Forms.Button()
        Me.button_save = New System.Windows.Forms.Button()
        Me.button_open = New System.Windows.Forms.Button()
        Me.button_new = New System.Windows.Forms.Button()
        Me.button_file = New System.Windows.Forms.Button()
        Me.panel_menu_divider3 = New System.Windows.Forms.Panel()
        Me.button_close = New System.Windows.Forms.Button()
        Me.panel_menu_divider = New System.Windows.Forms.Panel()
        Me.panel_menu_pomodoro = New System.Windows.Forms.Panel()
        Me.chart_pomodoro = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pomodoro_status = New System.Windows.Forms.Label()
        Me.contextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThesaurusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.timer_main = New System.Windows.Forms.Timer(Me.components)
        Me.printdialog = New System.Windows.Forms.PrintDialog()
        Me.editorfontdialog = New System.Windows.Forms.FontDialog()
        Me.pomodoro_strip.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.panel_content.SuspendLayout()
        Me.panel_stats.SuspendLayout()
        Me.stats_main.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chart_progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stats_group_time.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.stats_group_progress.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panel_settings.SuspendLayout()
        Me.settings_main.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.settings_table.SuspendLayout()
        Me.settings_group_other.SuspendLayout()
        Me.settings_group_pom.SuspendLayout()
        Me.settings_pom_table.SuspendLayout()
        CType(Me.settings_pomtime_break, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings_pomtime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.settings_panel_top.SuspendLayout()
        Me.panel_writer_info.SuspendLayout()
        Me.panel_write.SuspendLayout()
        Me.panel_searchreplace.SuspendLayout()
        Me.panel_menu.SuspendLayout()
        Me.panel_menu_main.SuspendLayout()
        Me.panel_menu_flow.SuspendLayout()
        Me.menu_expand_themes.SuspendLayout()
        Me.table_theme.SuspendLayout()
        Me.menu_expand_pomodoro.SuspendLayout()
        Me.menu_expand_file.SuspendLayout()
        Me.panel_menu_pomodoro.SuspendLayout()
        CType(Me.chart_pomodoro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer_anim
        '
        Me.timer_anim.Interval = 30
        '
        'pomodoro_strip
        '
        Me.pomodoro_strip.AccessibleDescription = ""
        Me.pomodoro_strip.BackColor = System.Drawing.Color.LightGray
        Me.pomodoro_strip.Controls.Add(Me.pomodoro_fill)
        Me.pomodoro_strip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pomodoro_strip.Location = New System.Drawing.Point(0, 770)
        Me.pomodoro_strip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pomodoro_strip.Name = "pomodoro_strip"
        Me.pomodoro_strip.Size = New System.Drawing.Size(1211, 5)
        Me.pomodoro_strip.TabIndex = 10
        '
        'pomodoro_fill
        '
        Me.pomodoro_fill.AccessibleDescription = ""
        Me.pomodoro_fill.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pomodoro_fill.Dock = System.Windows.Forms.DockStyle.Left
        Me.pomodoro_fill.Location = New System.Drawing.Point(0, 0)
        Me.pomodoro_fill.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pomodoro_fill.Name = "pomodoro_fill"
        Me.pomodoro_fill.Size = New System.Drawing.Size(0, 5)
        Me.pomodoro_fill.TabIndex = 10
        '
        'panel_main
        '
        Me.panel_main.AccessibleDescription = "background_color"
        Me.panel_main.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel_main.Controls.Add(Me.panel_content)
        Me.panel_main.Controls.Add(Me.panel_searchreplace)
        Me.panel_main.Controls.Add(Me.panel_menu)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(0, 0)
        Me.panel_main.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(1211, 770)
        Me.panel_main.TabIndex = 11
        '
        'panel_content
        '
        Me.panel_content.AccessibleDescription = "background_color"
        Me.panel_content.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel_content.Controls.Add(Me.panel_stats)
        Me.panel_content.Controls.Add(Me.panel_settings)
        Me.panel_content.Controls.Add(Me.panel_writer_info)
        Me.panel_content.Controls.Add(Me.panel_write)
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(224, 0)
        Me.panel_content.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Padding = New System.Windows.Forms.Padding(85, 0, 85, 0)
        Me.panel_content.Size = New System.Drawing.Size(987, 770)
        Me.panel_content.TabIndex = 10
        '
        'panel_stats
        '
        Me.panel_stats.AccessibleDescription = "menu_settings_color"
        Me.panel_stats.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_stats.Controls.Add(Me.stats_main)
        Me.panel_stats.Controls.Add(Me.stats_divider)
        Me.panel_stats.Controls.Add(Me.Panel4)
        Me.panel_stats.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_stats.Location = New System.Drawing.Point(7, 65)
        Me.panel_stats.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_stats.Name = "panel_stats"
        Me.panel_stats.Size = New System.Drawing.Size(43, 39)
        Me.panel_stats.TabIndex = 26
        '
        'stats_main
        '
        Me.stats_main.AccessibleDescription = "menu_settings_color"
        Me.stats_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.stats_main.Controls.Add(Me.TableLayoutPanel3)
        Me.stats_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stats_main.Location = New System.Drawing.Point(0, 49)
        Me.stats_main.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stats_main.Name = "stats_main"
        Me.stats_main.Padding = New System.Windows.Forms.Padding(43, 39, 43, 39)
        Me.stats_main.Size = New System.Drawing.Size(43, 0)
        Me.stats_main.TabIndex = 24
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.stats_group_time, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.stats_group_progress, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(43, 39)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(0, 0)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chart_progress)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 288)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.GroupBox2.Size = New System.Drawing.Size(1, 240)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progress Chart"
        '
        'chart_progress
        '
        Me.chart_progress.AccessibleDescription = "menu_settings_color"
        Me.chart_progress.BorderSkin.BorderColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.AxisX.Title = "TIME"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.AxisY.Title = "WORDS/MIN"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.SystemColors.WindowFrame
        ChartArea1.Name = "MainArea"
        Me.chart_progress.ChartAreas.Add(ChartArea1)
        Me.chart_progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart_progress.IsSoftShadows = False
        Me.chart_progress.Location = New System.Drawing.Point(11, 32)
        Me.chart_progress.Margin = New System.Windows.Forms.Padding(0)
        Me.chart_progress.Name = "chart_progress"
        Series1.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Series1.BorderWidth = 3
        Series1.ChartArea = "MainArea"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelForeColor = System.Drawing.SystemColors.WindowFrame
        Series1.MarkerBorderColor = System.Drawing.Color.Transparent
        Series1.MarkerBorderWidth = 0
        Series1.Name = "Data"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Me.chart_progress.Series.Add(Series1)
        Me.chart_progress.Size = New System.Drawing.Size(0, 198)
        Me.chart_progress.TabIndex = 2
        '
        'stats_group_time
        '
        Me.stats_group_time.AutoSize = True
        Me.stats_group_time.Controls.Add(Me.TableLayoutPanel5)
        Me.stats_group_time.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stats_group_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stats_group_time.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_group_time.Location = New System.Drawing.Point(4, 146)
        Me.stats_group_time.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stats_group_time.Name = "stats_group_time"
        Me.stats_group_time.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.stats_group_time.Size = New System.Drawing.Size(1, 134)
        Me.stats_group_time.TabIndex = 25
        Me.stats_group_time.TabStop = False
        Me.stats_group_time.Text = "Productivity"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.stats_time, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(11, 32)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(0, 92)
        Me.TableLayoutPanel5.TabIndex = 41
        '
        'stats_time
        '
        Me.stats_time.AccessibleDescription = ""
        Me.stats_time.AutoSize = True
        Me.stats_time.BackColor = System.Drawing.Color.Transparent
        Me.stats_time.Dock = System.Windows.Forms.DockStyle.Top
        Me.stats_time.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_time.Location = New System.Drawing.Point(4, 0)
        Me.stats_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stats_time.Name = "stats_time"
        Me.stats_time.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.stats_time.Size = New System.Drawing.Size(1, 92)
        Me.stats_time.TabIndex = 44
        Me.stats_time.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.stats_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label1.Size = New System.Drawing.Size(1, 92)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Words per minute" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Words per pomodoro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time spent working" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pomodoros spent working" & _
    ""
        '
        'stats_group_progress
        '
        Me.stats_group_progress.AutoSize = True
        Me.stats_group_progress.Controls.Add(Me.TableLayoutPanel4)
        Me.stats_group_progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stats_group_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stats_group_progress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_group_progress.Location = New System.Drawing.Point(4, 4)
        Me.stats_group_progress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stats_group_progress.Name = "stats_group_progress"
        Me.stats_group_progress.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.stats_group_progress.Size = New System.Drawing.Size(1, 134)
        Me.stats_group_progress.TabIndex = 24
        Me.stats_group_progress.TabStop = False
        Me.stats_group_progress.Text = "Progress"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.stats_progress, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(11, 32)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(0, 92)
        Me.TableLayoutPanel4.TabIndex = 40
        '
        'stats_progress
        '
        Me.stats_progress.AccessibleDescription = ""
        Me.stats_progress.AutoSize = True
        Me.stats_progress.BackColor = System.Drawing.Color.Transparent
        Me.stats_progress.Dock = System.Windows.Forms.DockStyle.Top
        Me.stats_progress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_progress.Location = New System.Drawing.Point(4, 0)
        Me.stats_progress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stats_progress.Name = "stats_progress"
        Me.stats_progress.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.stats_progress.Size = New System.Drawing.Size(1, 92)
        Me.stats_progress.TabIndex = 41
        Me.stats_progress.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.stats_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = ""
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label3.Size = New System.Drawing.Size(1, 92)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Total Words" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Sentences" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Pages" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'stats_divider
        '
        Me.stats_divider.AccessibleDescription = "text_color"
        Me.stats_divider.BackColor = System.Drawing.Color.LightGray
        Me.stats_divider.Dock = System.Windows.Forms.DockStyle.Top
        Me.stats_divider.Location = New System.Drawing.Point(0, 44)
        Me.stats_divider.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stats_divider.Name = "stats_divider"
        Me.stats_divider.Size = New System.Drawing.Size(43, 5)
        Me.stats_divider.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.AccessibleDescription = "menu_settings_color"
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.stats_title)
        Me.Panel4.Controls.Add(Me.stats_back)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(43, 44)
        Me.Panel4.TabIndex = 22
        '
        'stats_title
        '
        Me.stats_title.AccessibleDescription = "background_color"
        Me.stats_title.BackColor = System.Drawing.Color.Transparent
        Me.stats_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stats_title.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_title.Location = New System.Drawing.Point(48, 0)
        Me.stats_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stats_title.Name = "stats_title"
        Me.stats_title.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.stats_title.Size = New System.Drawing.Size(0, 44)
        Me.stats_title.TabIndex = 22
        Me.stats_title.Text = "S T A T I S T I C S"
        Me.stats_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stats_back
        '
        Me.stats_back.AccessibleDescription = "background_color"
        Me.stats_back.Dock = System.Windows.Forms.DockStyle.Left
        Me.stats_back.FlatAppearance.BorderSize = 0
        Me.stats_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stats_back.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats_back.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stats_back.Image = Global.focus.My.Resources.Resources.back
        Me.stats_back.Location = New System.Drawing.Point(0, 0)
        Me.stats_back.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.stats_back.Name = "stats_back"
        Me.stats_back.Size = New System.Drawing.Size(48, 44)
        Me.stats_back.TabIndex = 21
        Me.stats_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stats_back.UseVisualStyleBackColor = True
        '
        'panel_settings
        '
        Me.panel_settings.AccessibleDescription = "menu_settings_color"
        Me.panel_settings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_settings.Controls.Add(Me.settings_main)
        Me.panel_settings.Controls.Add(Me.settings_divider)
        Me.panel_settings.Controls.Add(Me.settings_panel_top)
        Me.panel_settings.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_settings.Location = New System.Drawing.Point(8, 7)
        Me.panel_settings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_settings.Name = "panel_settings"
        Me.panel_settings.Size = New System.Drawing.Size(43, 39)
        Me.panel_settings.TabIndex = 4
        '
        'settings_main
        '
        Me.settings_main.AccessibleDescription = "menu_settings_color"
        Me.settings_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.settings_main.Controls.Add(Me.TableLayoutPanel1)
        Me.settings_main.Controls.Add(Me.settings_table)
        Me.settings_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_main.Location = New System.Drawing.Point(0, 49)
        Me.settings_main.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_main.Name = "settings_main"
        Me.settings_main.Padding = New System.Windows.Forms.Padding(43, 39, 43, 39)
        Me.settings_main.Size = New System.Drawing.Size(43, 0)
        Me.settings_main.TabIndex = 24
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.settings_cancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.settings_ok, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 421)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(0, 39)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'settings_cancel
        '
        Me.settings_cancel.AccessibleDescription = "background_color"
        Me.settings_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_cancel.FlatAppearance.BorderSize = 0
        Me.settings_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_cancel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.settings_cancel.Location = New System.Drawing.Point(5, 0)
        Me.settings_cancel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.settings_cancel.Name = "settings_cancel"
        Me.settings_cancel.Size = New System.Drawing.Size(1, 39)
        Me.settings_cancel.TabIndex = 39
        Me.settings_cancel.Text = "CANCEL"
        Me.settings_cancel.UseVisualStyleBackColor = True
        '
        'settings_ok
        '
        Me.settings_ok.AccessibleDescription = "background_color"
        Me.settings_ok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_ok.FlatAppearance.BorderSize = 0
        Me.settings_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_ok.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_ok.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.settings_ok.Location = New System.Drawing.Point(5, 0)
        Me.settings_ok.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.settings_ok.Name = "settings_ok"
        Me.settings_ok.Size = New System.Drawing.Size(1, 39)
        Me.settings_ok.TabIndex = 38
        Me.settings_ok.Text = "OK"
        Me.settings_ok.UseVisualStyleBackColor = True
        '
        'settings_table
        '
        Me.settings_table.AutoSize = True
        Me.settings_table.ColumnCount = 1
        Me.settings_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.settings_table.Controls.Add(Me.settings_group_other, 0, 4)
        Me.settings_table.Controls.Add(Me.settings_group_pom, 0, 2)
        Me.settings_table.Controls.Add(Me.GroupBox1, 0, 1)
        Me.settings_table.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_table.Location = New System.Drawing.Point(43, 39)
        Me.settings_table.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_table.Name = "settings_table"
        Me.settings_table.RowCount = 5
        Me.settings_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_table.Size = New System.Drawing.Size(0, 382)
        Me.settings_table.TabIndex = 1
        '
        'settings_group_other
        '
        Me.settings_group_other.AutoSize = True
        Me.settings_group_other.Controls.Add(Me.settings_startfullscreen)
        Me.settings_group_other.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_group_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_group_other.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_group_other.Location = New System.Drawing.Point(4, 297)
        Me.settings_group_other.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_group_other.Name = "settings_group_other"
        Me.settings_group_other.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_group_other.Size = New System.Drawing.Size(1, 81)
        Me.settings_group_other.TabIndex = 26
        Me.settings_group_other.TabStop = False
        Me.settings_group_other.Text = "Other"
        '
        'settings_startfullscreen
        '
        Me.settings_startfullscreen.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_startfullscreen.Location = New System.Drawing.Point(11, 32)
        Me.settings_startfullscreen.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_startfullscreen.Name = "settings_startfullscreen"
        Me.settings_startfullscreen.Padding = New System.Windows.Forms.Padding(21, 0, 21, 0)
        Me.settings_startfullscreen.Size = New System.Drawing.Size(0, 39)
        Me.settings_startfullscreen.TabIndex = 1
        Me.settings_startfullscreen.Text = "Start fullscreen"
        Me.settings_startfullscreen.UseVisualStyleBackColor = True
        '
        'settings_group_pom
        '
        Me.settings_group_pom.AutoSize = True
        Me.settings_group_pom.Controls.Add(Me.settings_pom_table)
        Me.settings_group_pom.Controls.Add(Me.settings_pom_startup)
        Me.settings_group_pom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_group_pom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_group_pom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_group_pom.Location = New System.Drawing.Point(4, 98)
        Me.settings_group_pom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_group_pom.Name = "settings_group_pom"
        Me.settings_group_pom.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_group_pom.Size = New System.Drawing.Size(1, 191)
        Me.settings_group_pom.TabIndex = 25
        Me.settings_group_pom.TabStop = False
        Me.settings_group_pom.Text = "Pomodoro Settings"
        '
        'settings_pom_table
        '
        Me.settings_pom_table.AutoSize = True
        Me.settings_pom_table.ColumnCount = 2
        Me.settings_pom_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.settings_pom_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.settings_pom_table.Controls.Add(Me.settings_pomtime_break, 1, 1)
        Me.settings_pom_table.Controls.Add(Me.settings_pomtime, 1, 0)
        Me.settings_pom_table.Controls.Add(Me.settings_label_pomtimebreak, 0, 1)
        Me.settings_pom_table.Controls.Add(Me.settings_label_pomtime, 0, 0)
        Me.settings_pom_table.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_pom_table.Location = New System.Drawing.Point(11, 71)
        Me.settings_pom_table.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_pom_table.Name = "settings_pom_table"
        Me.settings_pom_table.RowCount = 2
        Me.settings_pom_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_pom_table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.settings_pom_table.Size = New System.Drawing.Size(0, 110)
        Me.settings_pom_table.TabIndex = 5
        '
        'settings_pomtime_break
        '
        Me.settings_pomtime_break.BackColor = System.Drawing.Color.White
        Me.settings_pomtime_break.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.settings_pomtime_break.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_pomtime_break.Location = New System.Drawing.Point(175, 65)
        Me.settings_pomtime_break.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_pomtime_break.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.settings_pomtime_break.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.settings_pomtime_break.Name = "settings_pomtime_break"
        Me.settings_pomtime_break.Size = New System.Drawing.Size(1, 29)
        Me.settings_pomtime_break.TabIndex = 27
        Me.settings_pomtime_break.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.settings_pomtime_break.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'settings_pomtime
        '
        Me.settings_pomtime.BackColor = System.Drawing.Color.White
        Me.settings_pomtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.settings_pomtime.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_pomtime.Location = New System.Drawing.Point(175, 10)
        Me.settings_pomtime.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_pomtime.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.settings_pomtime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.settings_pomtime.Name = "settings_pomtime"
        Me.settings_pomtime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.settings_pomtime.Size = New System.Drawing.Size(1, 29)
        Me.settings_pomtime.TabIndex = 26
        Me.settings_pomtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.settings_pomtime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'settings_label_pomtimebreak
        '
        Me.settings_label_pomtimebreak.AccessibleDescription = ""
        Me.settings_label_pomtimebreak.BackColor = System.Drawing.Color.Transparent
        Me.settings_label_pomtimebreak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_label_pomtimebreak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_label_pomtimebreak.Location = New System.Drawing.Point(0, 55)
        Me.settings_label_pomtimebreak.Margin = New System.Windows.Forms.Padding(0)
        Me.settings_label_pomtimebreak.Name = "settings_label_pomtimebreak"
        Me.settings_label_pomtimebreak.Size = New System.Drawing.Size(164, 55)
        Me.settings_label_pomtimebreak.TabIndex = 24
        Me.settings_label_pomtimebreak.Text = "Break (Minutes)"
        Me.settings_label_pomtimebreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'settings_label_pomtime
        '
        Me.settings_label_pomtime.AccessibleDescription = ""
        Me.settings_label_pomtime.BackColor = System.Drawing.Color.Transparent
        Me.settings_label_pomtime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_label_pomtime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_label_pomtime.Location = New System.Drawing.Point(0, 0)
        Me.settings_label_pomtime.Margin = New System.Windows.Forms.Padding(0)
        Me.settings_label_pomtime.Name = "settings_label_pomtime"
        Me.settings_label_pomtime.Size = New System.Drawing.Size(164, 55)
        Me.settings_label_pomtime.TabIndex = 23
        Me.settings_label_pomtime.Text = "Work (Minutes)"
        Me.settings_label_pomtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'settings_pom_startup
        '
        Me.settings_pom_startup.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_pom_startup.Location = New System.Drawing.Point(11, 32)
        Me.settings_pom_startup.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.settings_pom_startup.Name = "settings_pom_startup"
        Me.settings_pom_startup.Padding = New System.Windows.Forms.Padding(21, 0, 21, 0)
        Me.settings_pom_startup.Size = New System.Drawing.Size(0, 39)
        Me.settings_pom_startup.TabIndex = 1
        Me.settings_pom_startup.Text = "Enabled on startup"
        Me.settings_pom_startup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.settings_changefont)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(1, 86)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editor Font"
        '
        'settings_changefont
        '
        Me.settings_changefont.AccessibleDescription = "menu_settings_color"
        Me.settings_changefont.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_changefont.FlatAppearance.BorderSize = 0
        Me.settings_changefont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_changefont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_changefont.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.settings_changefont.Image = Global.focus.My.Resources.Resources.themes
        Me.settings_changefont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_changefont.Location = New System.Drawing.Point(11, 32)
        Me.settings_changefont.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.settings_changefont.Name = "settings_changefont"
        Me.settings_changefont.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.settings_changefont.Size = New System.Drawing.Size(0, 44)
        Me.settings_changefont.TabIndex = 36
        Me.settings_changefont.Text = "    Change editor font"
        Me.settings_changefont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_changefont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.settings_changefont.UseVisualStyleBackColor = True
        '
        'settings_divider
        '
        Me.settings_divider.AccessibleDescription = "text_color"
        Me.settings_divider.BackColor = System.Drawing.Color.LightGray
        Me.settings_divider.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_divider.Location = New System.Drawing.Point(0, 44)
        Me.settings_divider.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_divider.Name = "settings_divider"
        Me.settings_divider.Size = New System.Drawing.Size(43, 5)
        Me.settings_divider.TabIndex = 23
        '
        'settings_panel_top
        '
        Me.settings_panel_top.AccessibleDescription = "menu_settings_color"
        Me.settings_panel_top.BackColor = System.Drawing.Color.WhiteSmoke
        Me.settings_panel_top.Controls.Add(Me.settings_title)
        Me.settings_panel_top.Controls.Add(Me.settings_back)
        Me.settings_panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_panel_top.Location = New System.Drawing.Point(0, 0)
        Me.settings_panel_top.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settings_panel_top.Name = "settings_panel_top"
        Me.settings_panel_top.Size = New System.Drawing.Size(43, 44)
        Me.settings_panel_top.TabIndex = 22
        '
        'settings_title
        '
        Me.settings_title.AccessibleDescription = "background_color"
        Me.settings_title.BackColor = System.Drawing.Color.Transparent
        Me.settings_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_title.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_title.Location = New System.Drawing.Point(48, 0)
        Me.settings_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.settings_title.Name = "settings_title"
        Me.settings_title.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.settings_title.Size = New System.Drawing.Size(0, 44)
        Me.settings_title.TabIndex = 22
        Me.settings_title.Text = "F O C U S   S E T T I N G S"
        Me.settings_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'settings_back
        '
        Me.settings_back.AccessibleDescription = "background_color"
        Me.settings_back.Dock = System.Windows.Forms.DockStyle.Left
        Me.settings_back.FlatAppearance.BorderSize = 0
        Me.settings_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_back.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_back.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.settings_back.Image = Global.focus.My.Resources.Resources.back
        Me.settings_back.Location = New System.Drawing.Point(0, 0)
        Me.settings_back.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.settings_back.Name = "settings_back"
        Me.settings_back.Size = New System.Drawing.Size(48, 44)
        Me.settings_back.TabIndex = 21
        Me.settings_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_back.UseVisualStyleBackColor = True
        '
        'panel_writer_info
        '
        Me.panel_writer_info.AccessibleDescription = "editor_color"
        Me.panel_writer_info.BackColor = System.Drawing.SystemColors.Control
        Me.panel_writer_info.Controls.Add(Me.label_time)
        Me.panel_writer_info.Controls.Add(Me.label_wordcount)
        Me.panel_writer_info.Controls.Add(Me.label_output)
        Me.panel_writer_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_writer_info.Location = New System.Drawing.Point(85, 750)
        Me.panel_writer_info.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_writer_info.Name = "panel_writer_info"
        Me.panel_writer_info.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.panel_writer_info.Size = New System.Drawing.Size(817, 20)
        Me.panel_writer_info.TabIndex = 6
        '
        'label_time
        '
        Me.label_time.AccessibleDescription = ""
        Me.label_time.AccessibleName = "editor_text"
        Me.label_time.BackColor = System.Drawing.Color.Transparent
        Me.label_time.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_time.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_time.ForeColor = System.Drawing.Color.Gray
        Me.label_time.Location = New System.Drawing.Point(224, 0)
        Me.label_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_time.Name = "label_time"
        Me.label_time.Size = New System.Drawing.Size(369, 20)
        Me.label_time.TabIndex = 8
        Me.label_time.Text = "15:51"
        Me.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_wordcount
        '
        Me.label_wordcount.AccessibleDescription = ""
        Me.label_wordcount.AccessibleName = "editor_text"
        Me.label_wordcount.BackColor = System.Drawing.Color.Transparent
        Me.label_wordcount.Dock = System.Windows.Forms.DockStyle.Right
        Me.label_wordcount.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_wordcount.ForeColor = System.Drawing.Color.DimGray
        Me.label_wordcount.Location = New System.Drawing.Point(593, 0)
        Me.label_wordcount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_wordcount.Name = "label_wordcount"
        Me.label_wordcount.Size = New System.Drawing.Size(213, 20)
        Me.label_wordcount.TabIndex = 7
        Me.label_wordcount.Text = "0 words"
        Me.label_wordcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label_output
        '
        Me.label_output.AccessibleDescription = ""
        Me.label_output.AccessibleName = "editor_text"
        Me.label_output.BackColor = System.Drawing.Color.Transparent
        Me.label_output.Dock = System.Windows.Forms.DockStyle.Left
        Me.label_output.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_output.ForeColor = System.Drawing.Color.Gray
        Me.label_output.Location = New System.Drawing.Point(11, 0)
        Me.label_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_output.Name = "label_output"
        Me.label_output.Size = New System.Drawing.Size(213, 20)
        Me.label_output.TabIndex = 6
        Me.label_output.Text = "ready"
        Me.label_output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_write
        '
        Me.panel_write.AccessibleDescription = "editor_color"
        Me.panel_write.BackColor = System.Drawing.SystemColors.Control
        Me.panel_write.Controls.Add(Me.text_writer)
        Me.panel_write.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panel_write.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_write.Location = New System.Drawing.Point(85, 0)
        Me.panel_write.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_write.Name = "panel_write"
        Me.panel_write.Padding = New System.Windows.Forms.Padding(85, 44, 85, 44)
        Me.panel_write.Size = New System.Drawing.Size(817, 770)
        Me.panel_write.TabIndex = 2
        '
        'text_writer
        '
        Me.text_writer.AcceptsTab = True
        Me.text_writer.AccessibleDescription = "editor_color"
        Me.text_writer.BackColor = System.Drawing.SystemColors.Control
        Me.text_writer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text_writer.DetectUrls = False
        Me.text_writer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_writer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_writer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_writer.Location = New System.Drawing.Point(85, 44)
        Me.text_writer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.text_writer.Name = "text_writer"
        Me.text_writer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.text_writer.Size = New System.Drawing.Size(647, 682)
        Me.text_writer.TabIndex = 3
        Me.text_writer.Text = ""
        '
        'panel_searchreplace
        '
        Me.panel_searchreplace.AccessibleDescription = "menu_settings_color"
        Me.panel_searchreplace.BackColor = System.Drawing.SystemColors.Control
        Me.panel_searchreplace.Controls.Add(Me.button_replaceall)
        Me.panel_searchreplace.Controls.Add(Me.button_replace)
        Me.panel_searchreplace.Controls.Add(Me.findreplace_replace)
        Me.panel_searchreplace.Controls.Add(Me.button_find)
        Me.panel_searchreplace.Controls.Add(Me.findreplace_find)
        Me.panel_searchreplace.Controls.Add(Me.searchreplace_close)
        Me.panel_searchreplace.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_searchreplace.Location = New System.Drawing.Point(224, 0)
        Me.panel_searchreplace.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_searchreplace.MaximumSize = New System.Drawing.Size(0, 36)
        Me.panel_searchreplace.Name = "panel_searchreplace"
        Me.panel_searchreplace.Padding = New System.Windows.Forms.Padding(24, 4, 8, 4)
        Me.panel_searchreplace.Size = New System.Drawing.Size(987, 0)
        Me.panel_searchreplace.TabIndex = 9
        '
        'button_replaceall
        '
        Me.button_replaceall.AccessibleDescription = "menu_settings_color"
        Me.button_replaceall.Dock = System.Windows.Forms.DockStyle.Left
        Me.button_replaceall.FlatAppearance.BorderSize = 0
        Me.button_replaceall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_replaceall.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_replaceall.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_replaceall.Image = CType(resources.GetObject("button_replaceall.Image"), System.Drawing.Image)
        Me.button_replaceall.Location = New System.Drawing.Point(426, 4)
        Me.button_replaceall.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_replaceall.Name = "button_replaceall"
        Me.button_replaceall.Size = New System.Drawing.Size(28, 0)
        Me.button_replaceall.TabIndex = 24
        Me.button_replaceall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button_replaceall.UseVisualStyleBackColor = True
        '
        'button_replace
        '
        Me.button_replace.AccessibleDescription = "menu_settings_color"
        Me.button_replace.Dock = System.Windows.Forms.DockStyle.Left
        Me.button_replace.FlatAppearance.BorderSize = 0
        Me.button_replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_replace.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_replace.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_replace.Image = CType(resources.GetObject("button_replace.Image"), System.Drawing.Image)
        Me.button_replace.Location = New System.Drawing.Point(398, 4)
        Me.button_replace.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_replace.Name = "button_replace"
        Me.button_replace.Size = New System.Drawing.Size(28, 0)
        Me.button_replace.TabIndex = 23
        Me.button_replace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button_replace.UseVisualStyleBackColor = True
        '
        'findreplace_replace
        '
        Me.findreplace_replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.findreplace_replace.Dock = System.Windows.Forms.DockStyle.Left
        Me.findreplace_replace.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findreplace_replace.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.findreplace_replace.Location = New System.Drawing.Point(239, 4)
        Me.findreplace_replace.Margin = New System.Windows.Forms.Padding(0)
        Me.findreplace_replace.Name = "findreplace_replace"
        Me.findreplace_replace.Size = New System.Drawing.Size(159, 27)
        Me.findreplace_replace.TabIndex = 22
        Me.findreplace_replace.Tag = "replace string..."
        Me.findreplace_replace.Text = "replace string..."
        '
        'button_find
        '
        Me.button_find.AccessibleDescription = "menu_settings_color"
        Me.button_find.Dock = System.Windows.Forms.DockStyle.Left
        Me.button_find.FlatAppearance.BorderSize = 0
        Me.button_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_find.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_find.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_find.Image = Global.focus.My.Resources.Resources.search
        Me.button_find.Location = New System.Drawing.Point(211, 4)
        Me.button_find.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_find.Name = "button_find"
        Me.button_find.Size = New System.Drawing.Size(28, 0)
        Me.button_find.TabIndex = 21
        Me.button_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button_find.UseVisualStyleBackColor = True
        '
        'findreplace_find
        '
        Me.findreplace_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.findreplace_find.Dock = System.Windows.Forms.DockStyle.Left
        Me.findreplace_find.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findreplace_find.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.findreplace_find.Location = New System.Drawing.Point(52, 4)
        Me.findreplace_find.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.findreplace_find.Name = "findreplace_find"
        Me.findreplace_find.Size = New System.Drawing.Size(159, 27)
        Me.findreplace_find.TabIndex = 5
        Me.findreplace_find.Tag = "find string..."
        Me.findreplace_find.Text = "find string..."
        '
        'searchreplace_close
        '
        Me.searchreplace_close.AccessibleDescription = "menu_settings_color"
        Me.searchreplace_close.Dock = System.Windows.Forms.DockStyle.Left
        Me.searchreplace_close.FlatAppearance.BorderSize = 0
        Me.searchreplace_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchreplace_close.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchreplace_close.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.searchreplace_close.Image = Global.focus.My.Resources.Resources.back
        Me.searchreplace_close.Location = New System.Drawing.Point(24, 4)
        Me.searchreplace_close.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.searchreplace_close.Name = "searchreplace_close"
        Me.searchreplace_close.Size = New System.Drawing.Size(28, 0)
        Me.searchreplace_close.TabIndex = 25
        Me.searchreplace_close.UseVisualStyleBackColor = True
        '
        'panel_menu
        '
        Me.panel_menu.AccessibleDescription = "menu_color"
        Me.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu.Controls.Add(Me.panel_menu_main)
        Me.panel_menu.Controls.Add(Me.panel_menu_divider)
        Me.panel_menu.Controls.Add(Me.panel_menu_pomodoro)
        Me.panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_menu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.panel_menu.Size = New System.Drawing.Size(224, 770)
        Me.panel_menu.TabIndex = 7
        '
        'panel_menu_main
        '
        Me.panel_menu_main.AccessibleDescription = "menu_settings_color"
        Me.panel_menu_main.AutoScroll = True
        Me.panel_menu_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu_main.Controls.Add(Me.panel_menu_flow)
        Me.panel_menu_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_menu_main.Location = New System.Drawing.Point(0, 225)
        Me.panel_menu_main.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_menu_main.Name = "panel_menu_main"
        Me.panel_menu_main.Size = New System.Drawing.Size(223, 545)
        Me.panel_menu_main.TabIndex = 8
        '
        'panel_menu_flow
        '
        Me.panel_menu_flow.AutoScroll = True
        Me.panel_menu_flow.Controls.Add(Me.button_stats)
        Me.panel_menu_flow.Controls.Add(Me.menu_expand_themes)
        Me.panel_menu_flow.Controls.Add(Me.button_theme)
        Me.panel_menu_flow.Controls.Add(Me.menu_expand_pomodoro)
        Me.panel_menu_flow.Controls.Add(Me.panel_menu_divider2)
        Me.panel_menu_flow.Controls.Add(Me.button_settings)
        Me.panel_menu_flow.Controls.Add(Me.button_pomodoro)
        Me.panel_menu_flow.Controls.Add(Me.menu_expand_file)
        Me.panel_menu_flow.Controls.Add(Me.button_file)
        Me.panel_menu_flow.Controls.Add(Me.panel_menu_divider3)
        Me.panel_menu_flow.Controls.Add(Me.button_close)
        Me.panel_menu_flow.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_menu_flow.Location = New System.Drawing.Point(-1, 0)
        Me.panel_menu_flow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_menu_flow.Name = "panel_menu_flow"
        Me.panel_menu_flow.Size = New System.Drawing.Size(224, 545)
        Me.panel_menu_flow.TabIndex = 9
        '
        'button_stats
        '
        Me.button_stats.AccessibleDescription = "menu_settings_color"
        Me.button_stats.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_stats.FlatAppearance.BorderSize = 0
        Me.button_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_stats.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_stats.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_stats.Image = Global.focus.My.Resources.Resources.stats
        Me.button_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_stats.Location = New System.Drawing.Point(0, 132)
        Me.button_stats.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_stats.Name = "button_stats"
        Me.button_stats.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_stats.Size = New System.Drawing.Size(224, 44)
        Me.button_stats.TabIndex = 35
        Me.button_stats.Text = "    Statistics"
        Me.button_stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_stats.UseVisualStyleBackColor = True
        '
        'menu_expand_themes
        '
        Me.menu_expand_themes.AccessibleDescription = "menu_color"
        Me.menu_expand_themes.Controls.Add(Me.table_theme)
        Me.menu_expand_themes.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_expand_themes.Location = New System.Drawing.Point(0, 132)
        Me.menu_expand_themes.Margin = New System.Windows.Forms.Padding(0)
        Me.menu_expand_themes.MaximumSize = New System.Drawing.Size(0, 44)
        Me.menu_expand_themes.Name = "menu_expand_themes"
        Me.menu_expand_themes.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.menu_expand_themes.Size = New System.Drawing.Size(224, 0)
        Me.menu_expand_themes.TabIndex = 34
        '
        'table_theme
        '
        Me.table_theme.ColumnCount = 3
        Me.table_theme.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_theme.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_theme.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_theme.Controls.Add(Me.button_theme_slate, 0, 0)
        Me.table_theme.Controls.Add(Me.button_theme_khaki, 0, 0)
        Me.table_theme.Controls.Add(Me.button_theme_light, 0, 0)
        Me.table_theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_theme.Location = New System.Drawing.Point(0, 1)
        Me.table_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.table_theme.Name = "table_theme"
        Me.table_theme.RowCount = 1
        Me.table_theme.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_theme.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.table_theme.Size = New System.Drawing.Size(224, 0)
        Me.table_theme.TabIndex = 1
        '
        'button_theme_slate
        '
        Me.button_theme_slate.AccessibleDescription = ""
        Me.button_theme_slate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.button_theme_slate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_theme_slate.FlatAppearance.BorderSize = 0
        Me.button_theme_slate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_theme_slate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_theme_slate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.button_theme_slate.Location = New System.Drawing.Point(148, 0)
        Me.button_theme_slate.Margin = New System.Windows.Forms.Padding(0)
        Me.button_theme_slate.Name = "button_theme_slate"
        Me.button_theme_slate.Size = New System.Drawing.Size(76, 1)
        Me.button_theme_slate.TabIndex = 12
        Me.button_theme_slate.UseVisualStyleBackColor = False
        '
        'button_theme_khaki
        '
        Me.button_theme_khaki.AccessibleDescription = ""
        Me.button_theme_khaki.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.button_theme_khaki.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_theme_khaki.FlatAppearance.BorderSize = 0
        Me.button_theme_khaki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_theme_khaki.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_theme_khaki.ForeColor = System.Drawing.Color.SaddleBrown
        Me.button_theme_khaki.Location = New System.Drawing.Point(74, 0)
        Me.button_theme_khaki.Margin = New System.Windows.Forms.Padding(0)
        Me.button_theme_khaki.Name = "button_theme_khaki"
        Me.button_theme_khaki.Size = New System.Drawing.Size(74, 1)
        Me.button_theme_khaki.TabIndex = 11
        Me.button_theme_khaki.UseVisualStyleBackColor = False
        '
        'button_theme_light
        '
        Me.button_theme_light.AccessibleDescription = ""
        Me.button_theme_light.BackColor = System.Drawing.SystemColors.Control
        Me.button_theme_light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_theme_light.FlatAppearance.BorderSize = 0
        Me.button_theme_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_theme_light.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_theme_light.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_theme_light.Location = New System.Drawing.Point(0, 0)
        Me.button_theme_light.Margin = New System.Windows.Forms.Padding(0)
        Me.button_theme_light.Name = "button_theme_light"
        Me.button_theme_light.Size = New System.Drawing.Size(74, 1)
        Me.button_theme_light.TabIndex = 10
        Me.button_theme_light.UseVisualStyleBackColor = False
        '
        'button_theme
        '
        Me.button_theme.AccessibleDescription = "menu_settings_color"
        Me.button_theme.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_theme.FlatAppearance.BorderSize = 0
        Me.button_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_theme.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_theme.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_theme.Image = Global.focus.My.Resources.Resources.theme
        Me.button_theme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_theme.Location = New System.Drawing.Point(0, 88)
        Me.button_theme.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_theme.Name = "button_theme"
        Me.button_theme.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_theme.Size = New System.Drawing.Size(224, 44)
        Me.button_theme.TabIndex = 33
        Me.button_theme.Text = "    Theme"
        Me.button_theme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_theme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_theme.UseVisualStyleBackColor = True
        '
        'menu_expand_pomodoro
        '
        Me.menu_expand_pomodoro.AccessibleDescription = "menu_color"
        Me.menu_expand_pomodoro.Controls.Add(Me.button_pomEnable)
        Me.menu_expand_pomodoro.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_expand_pomodoro.Location = New System.Drawing.Point(0, 88)
        Me.menu_expand_pomodoro.Margin = New System.Windows.Forms.Padding(0)
        Me.menu_expand_pomodoro.MaximumSize = New System.Drawing.Size(0, 44)
        Me.menu_expand_pomodoro.Name = "menu_expand_pomodoro"
        Me.menu_expand_pomodoro.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.menu_expand_pomodoro.Size = New System.Drawing.Size(224, 0)
        Me.menu_expand_pomodoro.TabIndex = 32
        '
        'button_pomEnable
        '
        Me.button_pomEnable.AccessibleDescription = "menu_settings_color"
        Me.button_pomEnable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_pomEnable.FlatAppearance.BorderSize = 0
        Me.button_pomEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_pomEnable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_pomEnable.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_pomEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_pomEnable.Location = New System.Drawing.Point(0, 1)
        Me.button_pomEnable.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_pomEnable.Name = "button_pomEnable"
        Me.button_pomEnable.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_pomEnable.Size = New System.Drawing.Size(224, 0)
        Me.button_pomEnable.TabIndex = 34
        Me.button_pomEnable.Text = "Start Pomodoro"
        Me.button_pomEnable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_pomEnable.UseVisualStyleBackColor = True
        '
        'panel_menu_divider2
        '
        Me.panel_menu_divider2.AccessibleDescription = "menu_color"
        Me.panel_menu_divider2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu_divider2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_menu_divider2.Location = New System.Drawing.Point(0, 467)
        Me.panel_menu_divider2.Margin = New System.Windows.Forms.Padding(11, 10, 11, 0)
        Me.panel_menu_divider2.Name = "panel_menu_divider2"
        Me.panel_menu_divider2.Size = New System.Drawing.Size(224, 1)
        Me.panel_menu_divider2.TabIndex = 29
        '
        'button_settings
        '
        Me.button_settings.AccessibleDescription = "menu_settings_color"
        Me.button_settings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.button_settings.FlatAppearance.BorderSize = 0
        Me.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_settings.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_settings.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_settings.Image = Global.focus.My.Resources.Resources.settings
        Me.button_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_settings.Location = New System.Drawing.Point(0, 468)
        Me.button_settings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button_settings.Name = "button_settings"
        Me.button_settings.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_settings.Size = New System.Drawing.Size(224, 44)
        Me.button_settings.TabIndex = 28
        Me.button_settings.Text = "    Settings"
        Me.button_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_settings.UseVisualStyleBackColor = True
        '
        'button_pomodoro
        '
        Me.button_pomodoro.AccessibleDescription = "menu_settings_color"
        Me.button_pomodoro.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_pomodoro.FlatAppearance.BorderSize = 0
        Me.button_pomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_pomodoro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_pomodoro.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_pomodoro.Image = Global.focus.My.Resources.Resources.pom
        Me.button_pomodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_pomodoro.Location = New System.Drawing.Point(0, 44)
        Me.button_pomodoro.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_pomodoro.Name = "button_pomodoro"
        Me.button_pomodoro.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_pomodoro.Size = New System.Drawing.Size(224, 44)
        Me.button_pomodoro.TabIndex = 21
        Me.button_pomodoro.Text = "    Pomodoro"
        Me.button_pomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_pomodoro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_pomodoro.UseVisualStyleBackColor = True
        '
        'menu_expand_file
        '
        Me.menu_expand_file.AccessibleDescription = "menu_color"
        Me.menu_expand_file.Controls.Add(Me.button_print)
        Me.menu_expand_file.Controls.Add(Me.button_save)
        Me.menu_expand_file.Controls.Add(Me.button_open)
        Me.menu_expand_file.Controls.Add(Me.button_new)
        Me.menu_expand_file.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_expand_file.Location = New System.Drawing.Point(0, 44)
        Me.menu_expand_file.Margin = New System.Windows.Forms.Padding(0)
        Me.menu_expand_file.MaximumSize = New System.Drawing.Size(0, 121)
        Me.menu_expand_file.Name = "menu_expand_file"
        Me.menu_expand_file.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.menu_expand_file.Size = New System.Drawing.Size(224, 0)
        Me.menu_expand_file.TabIndex = 13
        '
        'button_print
        '
        Me.button_print.AccessibleDescription = "menu_settings_color"
        Me.button_print.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_print.FlatAppearance.BorderSize = 0
        Me.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_print.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_print.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_print.Location = New System.Drawing.Point(0, 91)
        Me.button_print.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_print.Name = "button_print"
        Me.button_print.Size = New System.Drawing.Size(224, 30)
        Me.button_print.TabIndex = 10
        Me.button_print.Text = "Print"
        Me.button_print.UseVisualStyleBackColor = True
        '
        'button_save
        '
        Me.button_save.AccessibleDescription = "menu_settings_color"
        Me.button_save.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_save.FlatAppearance.BorderSize = 0
        Me.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_save.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_save.Location = New System.Drawing.Point(0, 61)
        Me.button_save.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(224, 30)
        Me.button_save.TabIndex = 7
        Me.button_save.Text = "Save"
        Me.button_save.UseVisualStyleBackColor = True
        '
        'button_open
        '
        Me.button_open.AccessibleDescription = "menu_settings_color"
        Me.button_open.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_open.FlatAppearance.BorderSize = 0
        Me.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_open.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_open.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_open.Location = New System.Drawing.Point(0, 31)
        Me.button_open.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_open.Name = "button_open"
        Me.button_open.Size = New System.Drawing.Size(224, 30)
        Me.button_open.TabIndex = 8
        Me.button_open.Text = "Open"
        Me.button_open.UseVisualStyleBackColor = True
        '
        'button_new
        '
        Me.button_new.AccessibleDescription = "menu_settings_color"
        Me.button_new.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_new.FlatAppearance.BorderSize = 0
        Me.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_new.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_new.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_new.Location = New System.Drawing.Point(0, 1)
        Me.button_new.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_new.Name = "button_new"
        Me.button_new.Size = New System.Drawing.Size(224, 30)
        Me.button_new.TabIndex = 9
        Me.button_new.Text = "New"
        Me.button_new.UseVisualStyleBackColor = True
        '
        'button_file
        '
        Me.button_file.AccessibleDescription = "menu_settings_color"
        Me.button_file.Dock = System.Windows.Forms.DockStyle.Top
        Me.button_file.FlatAppearance.BorderSize = 0
        Me.button_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_file.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_file.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_file.Image = Global.focus.My.Resources.Resources.file
        Me.button_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_file.Location = New System.Drawing.Point(0, 0)
        Me.button_file.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.button_file.Name = "button_file"
        Me.button_file.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.button_file.Size = New System.Drawing.Size(224, 44)
        Me.button_file.TabIndex = 20
        Me.button_file.Text = "    File"
        Me.button_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_file.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_file.UseVisualStyleBackColor = True
        '
        'panel_menu_divider3
        '
        Me.panel_menu_divider3.AccessibleDescription = "menu_color"
        Me.panel_menu_divider3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu_divider3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_menu_divider3.Location = New System.Drawing.Point(0, 512)
        Me.panel_menu_divider3.Margin = New System.Windows.Forms.Padding(11, 10, 11, 0)
        Me.panel_menu_divider3.Name = "panel_menu_divider3"
        Me.panel_menu_divider3.Size = New System.Drawing.Size(224, 1)
        Me.panel_menu_divider3.TabIndex = 31
        '
        'button_close
        '
        Me.button_close.AccessibleDescription = "menu_settings_color"
        Me.button_close.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.button_close.FlatAppearance.BorderSize = 0
        Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_close.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.button_close.Image = CType(resources.GetObject("button_close.Image"), System.Drawing.Image)
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.Location = New System.Drawing.Point(0, 513)
        Me.button_close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button_close.Name = "button_close"
        Me.button_close.Padding = New System.Windows.Forms.Padding(11, 0, 0, 5)
        Me.button_close.Size = New System.Drawing.Size(224, 32)
        Me.button_close.TabIndex = 30
        Me.button_close.Text = "    Exit"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_close.UseVisualStyleBackColor = True
        '
        'panel_menu_divider
        '
        Me.panel_menu_divider.AccessibleDescription = "menu_color"
        Me.panel_menu_divider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu_divider.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_menu_divider.Location = New System.Drawing.Point(0, 224)
        Me.panel_menu_divider.Margin = New System.Windows.Forms.Padding(11, 10, 11, 0)
        Me.panel_menu_divider.Name = "panel_menu_divider"
        Me.panel_menu_divider.Size = New System.Drawing.Size(223, 1)
        Me.panel_menu_divider.TabIndex = 7
        '
        'panel_menu_pomodoro
        '
        Me.panel_menu_pomodoro.AccessibleDescription = "menu_settings_color"
        Me.panel_menu_pomodoro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_menu_pomodoro.Controls.Add(Me.chart_pomodoro)
        Me.panel_menu_pomodoro.Controls.Add(Me.pomodoro_status)
        Me.panel_menu_pomodoro.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_menu_pomodoro.Enabled = False
        Me.panel_menu_pomodoro.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu_pomodoro.Margin = New System.Windows.Forms.Padding(11, 10, 11, 0)
        Me.panel_menu_pomodoro.Name = "panel_menu_pomodoro"
        Me.panel_menu_pomodoro.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.panel_menu_pomodoro.Size = New System.Drawing.Size(223, 224)
        Me.panel_menu_pomodoro.TabIndex = 4
        '
        'chart_pomodoro
        '
        Me.chart_pomodoro.AccessibleDescription = "menu_settings_color"
        Me.chart_pomodoro.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "MainArea"
        Me.chart_pomodoro.ChartAreas.Add(ChartArea2)
        Me.chart_pomodoro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart_pomodoro.Location = New System.Drawing.Point(5, 5)
        Me.chart_pomodoro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chart_pomodoro.Name = "chart_pomodoro"
        Series2.ChartArea = "MainArea"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.CustomProperties = "DoughnutRadius=25, PieStartAngle=270"
        Series2.Name = "PomodoroTime"
        DataPoint1.Color = System.Drawing.SystemColors.WindowFrame
        DataPoint2.Color = System.Drawing.Color.LightGray
        Series2.Points.Add(DataPoint1)
        Series2.Points.Add(DataPoint2)
        Me.chart_pomodoro.Series.Add(Series2)
        Me.chart_pomodoro.Size = New System.Drawing.Size(213, 177)
        Me.chart_pomodoro.TabIndex = 10
        '
        'pomodoro_status
        '
        Me.pomodoro_status.BackColor = System.Drawing.Color.Transparent
        Me.pomodoro_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pomodoro_status.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pomodoro_status.Location = New System.Drawing.Point(5, 182)
        Me.pomodoro_status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pomodoro_status.Name = "pomodoro_status"
        Me.pomodoro_status.Size = New System.Drawing.Size(213, 37)
        Me.pomodoro_status.TabIndex = 9
        Me.pomodoro_status.Text = "DISABLED"
        Me.pomodoro_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contextmenu
        '
        Me.contextmenu.AccessibleDescription = "editor_color"
        Me.contextmenu.BackColor = System.Drawing.SystemColors.Control
        Me.contextmenu.DropShadowEnabled = False
        Me.contextmenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator1, Me.ThesaurusToolStripMenuItem, Me.FindToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripMenuFullscreen})
        Me.contextmenu.Name = "contextmenu"
        Me.contextmenu.Size = New System.Drawing.Size(242, 262)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.focus.My.Resources.Resources.undo
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.UndoToolStripMenuItem.Text = "Undo"
        Me.UndoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.focus.My.Resources.Resources.redo
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.focus.My.Resources.Resources.copy
        Me.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.focus.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.focus.My.Resources.Resources.paste
        Me.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'ThesaurusToolStripMenuItem
        '
        Me.ThesaurusToolStripMenuItem.Image = Global.focus.My.Resources.Resources.thesaurus
        Me.ThesaurusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ThesaurusToolStripMenuItem.Name = "ThesaurusToolStripMenuItem"
        Me.ThesaurusToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.ThesaurusToolStripMenuItem.Text = "Thesaurus"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = Global.focus.My.Resources.Resources.search
        Me.FindToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.FindToolStripMenuItem.Text = "Find and Replace"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.focus.My.Resources.Resources.selectall
        Me.SelectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(238, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.focus.My.Resources.Resources.print
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(238, 6)
        '
        'ToolStripMenuFullscreen
        '
        Me.ToolStripMenuFullscreen.Image = Global.focus.My.Resources.Resources.fullscreen
        Me.ToolStripMenuFullscreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuFullscreen.Name = "ToolStripMenuFullscreen"
        Me.ToolStripMenuFullscreen.ShortcutKeyDisplayString = "F11"
        Me.ToolStripMenuFullscreen.Size = New System.Drawing.Size(241, 24)
        Me.ToolStripMenuFullscreen.Text = "Toggle Fullscreen"
        '
        'timer_main
        '
        Me.timer_main.Interval = 1000
        '
        'printdialog
        '
        Me.printdialog.UseEXDialog = True
        '
        'editorfontdialog
        '
        Me.editorfontdialog.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorfontdialog.ShowEffects = False
        '
        'focus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 775)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.pomodoro_strip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(845, 577)
        Me.Name = "focus"
        Me.Text = "focus"
        Me.pomodoro_strip.ResumeLayout(False)
        Me.panel_main.ResumeLayout(False)
        Me.panel_content.ResumeLayout(False)
        Me.panel_stats.ResumeLayout(False)
        Me.stats_main.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chart_progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stats_group_time.ResumeLayout(False)
        Me.stats_group_time.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.stats_group_progress.ResumeLayout(False)
        Me.stats_group_progress.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.panel_settings.ResumeLayout(False)
        Me.settings_main.ResumeLayout(False)
        Me.settings_main.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.settings_table.ResumeLayout(False)
        Me.settings_table.PerformLayout()
        Me.settings_group_other.ResumeLayout(False)
        Me.settings_group_pom.ResumeLayout(False)
        Me.settings_group_pom.PerformLayout()
        Me.settings_pom_table.ResumeLayout(False)
        CType(Me.settings_pomtime_break, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings_pomtime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.settings_panel_top.ResumeLayout(False)
        Me.panel_writer_info.ResumeLayout(False)
        Me.panel_write.ResumeLayout(False)
        Me.panel_searchreplace.ResumeLayout(False)
        Me.panel_searchreplace.PerformLayout()
        Me.panel_menu.ResumeLayout(False)
        Me.panel_menu_main.ResumeLayout(False)
        Me.panel_menu_flow.ResumeLayout(False)
        Me.menu_expand_themes.ResumeLayout(False)
        Me.table_theme.ResumeLayout(False)
        Me.menu_expand_pomodoro.ResumeLayout(False)
        Me.menu_expand_file.ResumeLayout(False)
        Me.panel_menu_pomodoro.ResumeLayout(False)
        CType(Me.chart_pomodoro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timer_anim As System.Windows.Forms.Timer
    Friend WithEvents pomodoro_strip As System.Windows.Forms.Panel
    Friend WithEvents pomodoro_fill As System.Windows.Forms.Panel
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents panel_menu As System.Windows.Forms.Panel
    Friend WithEvents panel_menu_main As System.Windows.Forms.Panel
    Friend WithEvents panel_menu_divider As System.Windows.Forms.Panel
    Friend WithEvents panel_menu_pomodoro As System.Windows.Forms.Panel
    Friend WithEvents contextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThesaurusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panel_menu_flow As System.Windows.Forms.Panel
    Friend WithEvents menu_expand_file As System.Windows.Forms.Panel
    Friend WithEvents button_save As System.Windows.Forms.Button
    Friend WithEvents button_open As System.Windows.Forms.Button
    Friend WithEvents button_new As System.Windows.Forms.Button
    Friend WithEvents button_pomodoro As System.Windows.Forms.Button
    Friend WithEvents button_file As System.Windows.Forms.Button
    Friend WithEvents timer_main As System.Windows.Forms.Timer
    Friend WithEvents panel_menu_divider2 As System.Windows.Forms.Panel
    Friend WithEvents button_settings As System.Windows.Forms.Button
    Friend WithEvents printdialog As System.Windows.Forms.PrintDialog
    Friend WithEvents panel_menu_divider3 As System.Windows.Forms.Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents panel_content As System.Windows.Forms.Panel
    Friend WithEvents panel_writer_info As System.Windows.Forms.Panel
    Friend WithEvents label_time As System.Windows.Forms.Label
    Friend WithEvents label_wordcount As System.Windows.Forms.Label
    Friend WithEvents label_output As System.Windows.Forms.Label
    Friend WithEvents panel_write As System.Windows.Forms.Panel
    Friend WithEvents panel_searchreplace As System.Windows.Forms.Panel
    Friend WithEvents findreplace_find As System.Windows.Forms.TextBox
    Friend WithEvents button_find As System.Windows.Forms.Button
    Friend WithEvents button_replaceall As System.Windows.Forms.Button
    Friend WithEvents button_replace As System.Windows.Forms.Button
    Friend WithEvents findreplace_replace As System.Windows.Forms.TextBox
    Friend WithEvents searchreplace_close As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuFullscreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents button_print As System.Windows.Forms.Button
    Friend WithEvents chart_pomodoro As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents pomodoro_status As System.Windows.Forms.Label
    Friend WithEvents button_stats As System.Windows.Forms.Button
    Friend WithEvents menu_expand_themes As System.Windows.Forms.Panel
    Friend WithEvents table_theme As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents button_theme_slate As System.Windows.Forms.Button
    Friend WithEvents button_theme_khaki As System.Windows.Forms.Button
    Friend WithEvents button_theme_light As System.Windows.Forms.Button
    Friend WithEvents button_theme As System.Windows.Forms.Button
    Friend WithEvents menu_expand_pomodoro As System.Windows.Forms.Panel
    Friend WithEvents button_pomEnable As System.Windows.Forms.Button
    Friend WithEvents text_writer As System.Windows.Forms.RichTextBox
    Friend WithEvents panel_settings As System.Windows.Forms.Panel
    Friend WithEvents settings_main As System.Windows.Forms.Panel
    Friend WithEvents settings_table As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents settings_divider As System.Windows.Forms.Panel
    Friend WithEvents settings_panel_top As System.Windows.Forms.Panel
    Friend WithEvents settings_title As System.Windows.Forms.Label
    Friend WithEvents settings_back As System.Windows.Forms.Button
    Friend WithEvents settings_group_pom As System.Windows.Forms.GroupBox
    Friend WithEvents settings_pom_startup As System.Windows.Forms.CheckBox
    Friend WithEvents settings_pom_table As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents settings_pomtime_break As System.Windows.Forms.NumericUpDown
    Friend WithEvents settings_pomtime As System.Windows.Forms.NumericUpDown
    Friend WithEvents settings_label_pomtimebreak As System.Windows.Forms.Label
    Friend WithEvents settings_label_pomtime As System.Windows.Forms.Label
    Friend WithEvents settings_group_other As System.Windows.Forms.GroupBox
    Friend WithEvents settings_startfullscreen As System.Windows.Forms.CheckBox
    Friend WithEvents settings_changefont As System.Windows.Forms.Button
    Friend WithEvents editorfontdialog As System.Windows.Forms.FontDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents settings_cancel As System.Windows.Forms.Button
    Friend WithEvents settings_ok As System.Windows.Forms.Button
    Friend WithEvents panel_stats As System.Windows.Forms.Panel
    Friend WithEvents stats_main As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents stats_group_time As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents stats_time As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stats_group_progress As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents stats_progress As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stats_divider As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents stats_title As System.Windows.Forms.Label
    Friend WithEvents stats_back As System.Windows.Forms.Button
    Friend WithEvents chart_progress As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
