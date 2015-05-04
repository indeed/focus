Imports focus.globals
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Runtime.InteropServices

Public Class focus

    Private _menuOpen As Boolean
    Private _menuTrigger As Panel
    Private _fullScreen As Boolean
    Private _windowRect As Rectangle
    Private _fileName As String = "Untitled Document"

    Private _animsDone As Boolean = True
    Private _tweenObjects As New List(Of anim)
    Private _animsPendingRemoval As New List(Of anim)
    Private _pomodoroTime As Integer
    Private _pomodoro As Boolean
    Private _pomodoroBreak As Boolean

    Private _findIndex As Integer

    Private _overlay As PictureBox
    Private _time As Integer

    Private _data As New List(Of Tuple(Of DateTime, Double))
    Private _timecap As Integer = 36000



    Private Sub update_stats_chart(sender As Object, e As EventArgs) Handles timer_main.Tick

        If _data.Count > _timecap Then
            For i As Integer = 1 To _data.Count - _timecap
                _data.Remove(_data(0))
            Next
        End If

        _data.Add(New Tuple(Of DateTime, Double)(DateTime.Now, Math.Round(wordCount(text_writer.Text) / ((_time + 1) / 60), 2)))
        chart_progress.Series(0).Points.Clear()

        For Each Point As Tuple(Of DateTime, Double) In _data
            Dim p As DataPoint = New DataPoint
            p.YValues(0) = Point.Item2
            p.XValue = Point.Item1.ToOADate()
            chart_progress.Series(0).Points.Add(p)
        Next

        chart_progress.Refresh()
    End Sub

    Public WriteOnly Property darken
        Set(value)
            If Me.WindowState <> FormWindowState.Minimized Then
                If value Then
                    Dim Bmp = New Bitmap(Bounds.Size.Width, Bounds.Size.Height)
                    'Me.DrawToBitmap(Bmp, New Rectangle(Point.Empty, Bounds.Size))
                    Using g = Graphics.FromImage(Bmp)
                        Dim Brush As New SolidBrush(Color.FromArgb(125, Color.Black))
                        g.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Bmp.Size)
                        g.FillRectangle(Brush, New Rectangle(Point.Empty, Bmp.Size))
                    End Using
                    _overlay = New PictureBox
                    Me.Controls.Add(_overlay)
                    _overlay.Visible = True
                    _overlay.Size = Bounds.Size
                    _overlay.Location = Bounds.Location - PointToScreen(Point.Empty)

                    _overlay.Image = Bmp
                    _overlay.BringToFront()

                Else
                        If _overlay IsNot Nothing Then
                            Me.Controls.Remove(_overlay)
                            _overlay.Dispose()
                        End If
                End If
            End If
        End Set
    End Property

    Private Function msg(text As String, Optional options As MsgBoxStyle = MsgBoxStyle.OkOnly, Optional title As String = "focus")
        Try
            darken = True
            Dim ping As Ping = New Ping(text, options, title)
            setTheme(ping, g_Theme)
            If Me.WindowState = FormWindowState.Minimized Then
                ping.StartPosition = FormStartPosition.CenterScreen
            End If
            timer_main.Stop()
            Return ping.ShowDialog()
        Finally
            darken = False
            timer_main.Start()
        End Try
    End Function

    Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Select Case My.Settings.Theme
            Case 0
                g_Theme = theme_Light
            Case 1
                g_Theme = theme_Khaki
            Case 2
                g_Theme = theme_Slate
        End Select
        g_PomodoroTime = My.Settings.PomodoroTime
        g_pomodoroBreakTime = My.Settings.PomodoroBreakTime
        g_pomodoroEnabledDefault = My.Settings.PomodoroEnabledDefault
        g_StartFullscreen = My.Settings.StartFullscreen
        g_Font = My.Settings.Font
    End Sub

    Private Sub focus_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Shortcuts
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
            If _fullScreen Then
                toggleFullscreen()
                writeOut("windowed")
            ElseIf e.KeyCode = Keys.F11 Then
                toggleFullscreen()
                writeOut("fullscreen")
            End If
        ElseIf e.KeyCode = Keys.P And e.Modifiers = Keys.Control Then
            PrintToolStripMenuItem_Click(PrintToolStripMenuItem, Nothing)
        ElseIf e.KeyCode = Keys.S And e.Modifiers = Keys.Control Then
            button_save_Click(button_save, Nothing)
        ElseIf e.KeyCode = Keys.O And e.Modifiers = Keys.Control Then
            button_open_Click(button_open, Nothing)
        ElseIf e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
            button_new_Click(button_new, Nothing)
        ElseIf e.KeyCode = Keys.F And e.Modifiers = Keys.Control Then
            toggleSubMenu(panel_searchreplace)
        End If
    End Sub

    Private Sub startPomodoro()
        _pomodoroTime = g_PomodoroTime
        _pomodoro = True
        _pomodoroBreak = False
        pomodoro_status.Text = "WORK"
        panel_menu_pomodoro.Enabled = True
        writeOut("pomodoro start")
    End Sub

    Private Sub stopPomodoro()
        _pomodoroTime = 0
        _pomodoro = False
        _pomodoroBreak = False
        pomodoro_status.Text = "DISABLED"
        panel_menu_pomodoro.Enabled = False
        writeOut("pomodoro stop")
    End Sub

    Private Sub toggleFullscreen()
        If Not _fullScreen Then
            _fullScreen = True
            If Me.WindowState <> FormWindowState.Maximized Then
                _windowRect = New Rectangle(Me.Location, Me.Size)
            End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'Me.TopMost = True
            Me.Size = Screen.PrimaryScreen.Bounds.Size
            Me.Location = Screen.PrimaryScreen.Bounds.Location
        Else
            _fullScreen = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            'Me.TopMost = False
            Me.Size = _windowRect.Size
            Me.Location = _windowRect.Location
        End If
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub setTheme(c As Control, theme As Dictionary(Of String, Color))
        Try
            c.ForeColor = theme("text_color")
        Finally
        End Try
        Try
            c.BackColor = theme(c.AccessibleDescription)
            If c.GetType() = GetType(Button) Or c.GetType() = GetType(Label) Then
                If Not c.AccessibleName = "inverted" Then
                    c.ForeColor = theme("text_color")
                Else
                    c.BackColor = theme("text_color")
                    c.ForeColor = theme(c.AccessibleDescription)
                End If
            End If
        Catch
        End Try
        For Each j As Control In c.Controls
            setTheme(j, theme)
        Next
        g_Theme = theme
        Select Case theme.GetHashCode()
            Case theme_Light.GetHashCode()
                My.Settings.Theme = 0
            Case theme_Khaki.GetHashCode()
                My.Settings.Theme = 1
            Case theme_Slate.GetHashCode()
                My.Settings.Theme = 2
        End Select
        'text_writer.Select(1, 1)
        resetSelection()
        'text_writer.SelectionColor = theme("editor_color")
        text_writer.ForeColor = theme("text_color")
        'contextmenu.BackColor = theme("editor_color")
        Dim series As Series = chart_pomodoro.Series(0)
        If Not _pomodoroBreak Then
            series.Points(1).Color = theme("menu_color")
            series.Points(0).Color = theme("text_color")
            pomodoro_strip.BackColor = theme("editor_color")
            pomodoro_fill.BackColor = theme("text_color")
        Else
            series.Points(0).Color = theme("menu_color")
            series.Points(1).Color = theme("text_color")
            pomodoro_fill.BackColor = theme("editor_color")
            pomodoro_strip.BackColor = theme("text_color")
        End If
    End Sub

    Private Sub focus_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim g As Graphics = Me.CreateGraphics()
        g_MenuDrawerWidth = g_MenuDrawerWidth * (g.DpiX / 72)
        g.Dispose()
        panel_write.Padding = g_PagePadding
        panel_menu.Width = 0
        Me.Size = g_WindowSize
        timer_anim.Start()
        timer_main.Start()
        setTheme(Me, g_Theme)
        _windowRect = New Rectangle(Me.Location, Me.Size)
        If g_StartFullscreen Then
            toggleFullscreen()
        End If
        panel_menu_pomodoro.Height = g_MenuDrawerWidth
        text_writer.ContextMenuStrip = contextmenu
        panel_menu_flow.Width = g_MenuDrawerWidth
        text_writer.Font = g_Font
        Me.Text = _fileName
        If g_pomodoroEnabledDefault Then
            startPomodoro()
        End If
        panel_main.Controls.Add(panel_settings)
        panel_settings.Width = 0
        panel_settings.Enabled = False
        panel_settings.Dock = DockStyle.Right
        panel_settings.BringToFront()

        panel_main.Controls.Add(panel_stats)
        panel_stats.Width = 0
        panel_stats.Enabled = False
        panel_stats.Dock = DockStyle.Right
        panel_stats.BringToFront()

        load_settings()
    End Sub

    Private Sub tweenMove(c As Control, speed As Integer, tweenX As Integer, tweenY As Integer)
        If _animsDone Then
            _animsDone = False
            Dim anim As animTween = New animTween(c, speed, tweenX, tweenY, 0)
            _tweenObjects.Add(anim)
        End If
    End Sub

    Private Sub tweenSize(c As Control, speed As Integer, tweenX As Integer, tweenY As Integer)
        If _animsDone Then
            _animsDone = False
            Dim anim As animTween = New animTween(c, speed, tweenX, tweenY, 1)
            _tweenObjects.Add(anim)

        End If
    End Sub

    Private Sub timer_anim_Tick(sender As Object, e As EventArgs) Handles timer_anim.Tick
        If _tweenObjects.Count > 0 Then
            For Each t As animTween In _tweenObjects
                If t.done Then
                    _animsPendingRemoval.Add(t)
                Else
                    t.animate()
                End If
            Next
        Else
            _animsDone = True
        End If
        For Each a As anim In _animsPendingRemoval
            If a.GetType() = GetType(animTween) Then
                _tweenObjects.Remove(a)
                a.Dispose()
            End If
        Next
        _animsPendingRemoval.Clear()
    End Sub

    Private Sub writeOut(o As String)
        label_output.Text = o
    End Sub

    Private Sub form_mouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, panel_content.MouseMove, panel_write.MouseMove, text_writer.MouseMove
        If Not _menuOpen Then
            If Windows.Forms.Cursor.Position.X - Me.Location.X <= g_MenuTriggerWidth Then
                If _animsDone Then
                    _menuOpen = True
                    tweenSize(panel_menu, g_animSpeed, g_MenuDrawerWidth, 0)
                End If
            End If
        ElseIf Windows.Forms.Cursor.Position.X - Me.Location.X > g_MenuDrawerWidth Then
            If _animsDone Then
                tweenSize(panel_menu, g_animSpeed, -g_MenuDrawerWidth, 0)
                _menuOpen = False
            End If
        End If
    End Sub

    Private Sub focus_Resize(sender As Object, e As EventArgs) Handles Me.Resize, panel_content.Resize
        panel_menu.Height = Me.Height
        If panel_content.Width >= g_PageWidth Then
            Dim dynpadding As Integer = (panel_content.Width - g_PageWidth) / 2
            panel_content.Padding = New Padding(dynpadding, 0, dynpadding, 0)
        Else
            panel_content.Padding = New Padding(0, 0, 0, 0)
        End If
        If Me.WindowState = FormWindowState.Maximized Then
            _fullScreen = False
            toggleFullscreen()
        End If
        If panel_settings.Enabled = True Then
            panel_settings.Width = panel_content.Width
        End If
        If panel_stats.Enabled = True Then
            panel_stats.Width = panel_content.Width
        End If
    End Sub

#Region "Menu Buttons"

    Private Sub toggleSubMenu(subpanel As Control)
        If subpanel.Height >= subpanel.MaximumSize.Height Then
            tweenSize(subpanel, g_animSpeed, 0, -subpanel.MaximumSize.Height)
        Else
            tweenSize(subpanel, g_animSpeed, 0, subpanel.MaximumSize.Height)
        End If
    End Sub

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub

    Private Sub hideOtherSubMenus(exclude As Object)
        Dim others As List(Of Control) = New List(Of Control) From {menu_expand_file, menu_expand_pomodoro, menu_expand_themes}
        others.Remove(exclude)
        For Each s As Control In others
            If s.Height > 0 Then
                _animsDone = True
                toggleSubMenu(s)
            End If
        Next
    End Sub

    Private Sub button_theme_Click(sender As Object, e As EventArgs) Handles button_theme.Click
        toggleSubMenu(menu_expand_themes)
        hideOtherSubMenus(menu_expand_themes)
    End Sub

    Private Sub button_file_Click(sender As Object, e As EventArgs) Handles button_file.Click
        toggleSubMenu(menu_expand_file)
        hideOtherSubMenus(menu_expand_file)
    End Sub

    Private Sub button_stats_Click(sender As Object, e As EventArgs, Optional a As Boolean = True) Handles button_stats.Click
        If _animsDone Then
            If Not panel_stats.Enabled Then
                panel_stats.Enabled = True
                panel_stats.Width = 0
                tweenSize(panel_stats, g_animSpeed, panel_content.Width, 0)
                panel_stats.Dock = DockStyle.Right
            Else
                panel_stats.Enabled = False
                panel_stats.Width = panel_content.Width
                tweenSize(panel_stats, g_animSpeed, -panel_content.Width, 0)
                panel_stats.Dock = DockStyle.Left
            End If
            If panel_settings.Enabled = True AndAlso a Then
                _animsDone = True
                button_settings_Click(Nothing, Nothing, False)
            End If
        End If
    End Sub

    Private Sub button_pomodoro_Click(sender As Object, e As EventArgs) Handles button_pomodoro.Click
        toggleSubMenu(menu_expand_pomodoro)
        hideOtherSubMenus(menu_expand_pomodoro)
    End Sub

    Private Sub button_open_Click(sender As Object, e As EventArgs) Handles button_open.Click
        Dim openfile As New OpenFileDialog()
        openfile.DefaultExt = "*.txt"
        openfile.Filter = "Plain Text Files|*.txt|Rich Text Files|*.rtf|Word Documents|*.docx|All Files|*.*"
        If (openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (openfile.FileName.Length > 0) Then
            text_writer.LoadFile(openfile.FileName, RichTextBoxStreamType.PlainText)
            _fileName = openfile.FileName
            writeOut("open " & Path.GetFileNameWithoutExtension(_fileName))
        End If
    End Sub

    Private Sub button_save_Click(sender As Object, e As EventArgs) Handles button_save.Click
        Dim saveFile As New SaveFileDialog()
        saveFile.FileName = _fileName
        saveFile.DefaultExt = "*.txt"
        saveFile.Filter = "Plain Text Files|*.txt|Rich Text Files|*.rtf|Word Documents|*.docx|All Files|*.*"
        If Not File.Exists(_fileName) Then
            If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso saveFile.FileName.Length > 0 Then
                text_writer.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText)
                _fileName = saveFile.FileName
            End If
        Else
            text_writer.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText)
            _fileName = saveFile.FileName
        End If
        writeOut("saved " & LCase(DateTime.Now.ToShortTimeString()))
    End Sub

    Private Sub button_new_Click(sender As Object, e As EventArgs) Handles button_new.Click
        If promptSave() Then
            text_writer.Clear()
            _fileName = "Untitled Document"
        End If
        writeOut("new file")
    End Sub

#Region "Themer"
    Private Sub button_theme_khaki_Click(sender As Object, e As EventArgs) Handles button_theme_khaki.Click
        g_Theme = theme_Khaki
        setTheme(Me, g_Theme)
    End Sub

    Private Sub button_theme_light_Click(sender As Object, e As EventArgs) Handles button_theme_light.Click
        g_Theme = theme_Light
        setTheme(Me, g_Theme)
    End Sub

    Private Sub button_theme_slate_Click(sender As Object, e As EventArgs) Handles button_theme_slate.Click
        g_Theme = theme_Slate
        setTheme(Me, g_Theme)
    End Sub

    Private Sub button_theme_khaki_paint(sender As Object, e As PaintEventArgs)
        sender.width = g_MenuDrawerWidth / menu_expand_themes.Controls.Count
    End Sub
#End Region
#End Region

    Private Function wordCount(value As String) As Integer
        Dim collection As MatchCollection = Regex.Matches(value, "\S+")
        Return collection.Count
    End Function

    Private Sub text_writer_TextChanged(sender As Object, e As EventArgs) Handles text_writer.TextChanged
        label_wordcount.Text = wordCount(text_writer.Text) & " words"
        If Len(text_writer.Text) > 0 Then
            writeOut("typing...")
        End If
        'resetSelection()
    End Sub

    <DllImport("user32.dll", EntryPoint:="FlashWindow")> _
    Public Shared Function FlashWindow(ByVal hwnd As Integer, ByVal bInvert As Integer) As Integer
    End Function

    Private Sub timer_main_Tick(sender As Object, e As EventArgs) Handles timer_main.Tick
        label_time.Text = LCase(DateTime.Now.ToShortTimeString())
        Me.Text = _fileName
        If label_output.Text = "typing..." Then
            writeOut("ready")
        End If
        Dim series As Series = chart_pomodoro.Series(0)
        If _pomodoro Then
            If _pomodoroTime > 0 Then
                _pomodoroTime -= 1
            Else
                Me.TopMost = True
                Me.TopMost = False
                If Not _pomodoroBreak Then
                    _pomodoroBreak = True
                    _pomodoroTime = g_pomodoroBreakTime
                    setTheme(panel_menu, g_Theme)
                    pomodoro_status.Text = "BREAK"
                    My.Computer.Audio.Play(My.Resources.chime, AudioPlayMode.Background)
                    FlashWindow(Me.Handle, 1)
                    msg("Break time!")
                Else
                    _pomodoroBreak = False
                    _pomodoroTime = g_PomodoroTime
                    setTheme(panel_menu, g_Theme)
                    pomodoro_status.Text = "WORK"
                    My.Computer.Audio.Play(My.Resources.chime, AudioPlayMode.Background)
                    FlashWindow(Me.Handle, 1)
                    msg("Back to work!")
                End If

            End If
            series.Points(1).YValues(0) = _pomodoroTime
            series.Points(0).YValues(0) = g_PomodoroTime - _pomodoroTime
            chart_pomodoro.Refresh()
            pomodoro_fill.Width = pomodoro_strip.Width * (g_PomodoroTime - _pomodoroTime) / g_PomodoroTime
        End If
        updatestats()
        _time += 1
        wordCount(text_writer.Text)
    End Sub

    Private Sub updatestats()
        stats_progress.Text = wordCount(text_writer.Text) & vbLf & text_writer.Text.ToCharArray().Count() & vbLf & text_writer.Text.Split(New [Char]() {"."c, "?"c, "!"c}).Count() - 1 & vbLf & Math.Ceiling(wordCount(text_writer.Text) / 450)
        stats_time.Text = Math.Round(wordCount(text_writer.Text) / ((_time + 1) / 60), 2) & vbLf & Math.Round(wordCount(text_writer.Text) / ((_time + 1) / g_PomodoroTime), 2) & vbLf & TimeSpan.FromSeconds(_time).ToString() & vbLf & Math.Round(_time / g_PomodoroTime, 2)
    End Sub

    Function promptSave()
        Dim prompt As MsgBoxResult = msg("Do you want to save changes to " & _fileName & "?", MsgBoxStyle.YesNoCancel)
        If prompt = MsgBoxResult.Yes Then
            button_save_Click(Nothing, Nothing)
            Return True
        ElseIf prompt = MsgBoxResult.No Then
            Return True
        End If
        Return False
    End Function

    Private Sub focus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not promptSave() Then
            e.Cancel = True
        End If
        My.Settings.Save()
    End Sub

#Region "Context Menu"
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        text_writer.Undo()
        writeOut("undo action")
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        text_writer.Redo()
        writeOut("redo action")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        text_writer.Copy()
        writeOut("copy selection")
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        text_writer.Cut()
        writeOut("cut selection")
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        text_writer.Paste()
        writeOut("paste selection")
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        text_writer.SelectAll()
        writeOut("select all")
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click, button_print.Click
        Dim doc As New TextPrint(text_writer.Text)
        doc.Font = g_Font
        printdialog.AllowSomePages = True
        printdialog.ShowHelp = True
        printdialog.Document = doc
        Dim result As DialogResult = printdialog.ShowDialog()
        If (result = DialogResult.OK) Then
            doc.Print()
        End If
    End Sub

    Private Sub ToolStripMenuFullscreen_Click(sender As Object, e As EventArgs) Handles ToolStripMenuFullscreen.Click
        toggleFullscreen()
    End Sub

#Region "Thesaurus"

    Private Sub ThesaurusToolStripMenuItem_Hover(sender As Object, e As EventArgs) Handles ThesaurusToolStripMenuItem.MouseEnter
        sender.DropDownItems.Clear()
        Try
            Dim client As WebClient = New WebClient()
            Dim reply As String = CStr(client.DownloadString(g_ThesaurusAPICall & text_writer.SelectedText & "/"))
            Dim synonyms() As String = reply.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
            For Each syn As String In synonyms
                Dim formatted() As String = syn.Split("|".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries)
                Dim item As ToolStripMenuItem = New ToolStripMenuItem(formatted(2))
                item.ShortcutKeyDisplayString = formatted(0) & " | " & formatted(1)
                sender.DropDownItems.Add(item)
            Next
            For Each item As ToolStripMenuItem In sender.DropDownItems
                AddHandler item.Click, AddressOf ThesaurusWordClick
            Next
        Catch ex As Net.WebException
            sender.DropDownItems.Add("No synonyms found")
        End Try
    End Sub

    Private Sub ThesaurusWordClick(sender As Object, e As EventArgs)
        ThesaurusToolStripMenuItem.DropDownItems.Clear()
        text_writer.SelectedText = sender.Text
        writeOut("replace word")
    End Sub

#End Region
#End Region

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        If panel_searchreplace.Height = 0 Then
            toggleSubMenu(panel_searchreplace)
        End If
    End Sub

    Private Sub button_replaceall_Click(sender As Object, e As EventArgs) Handles button_replaceall.Click
        writeOut((text_writer.Text.Length - text_writer.Text.Replace(findreplace_find.Text, String.Empty).Length) / findreplace_find.Text.Length & " words replaced")
        text_writer.Text = text_writer.Text.Replace(findreplace_find.Text, findreplace_replace.Text)
        resetSelection()
    End Sub

    Private Sub searchreplace_close_Click(sender As Object, e As EventArgs) Handles searchreplace_close.Click
        toggleSubMenu(panel_searchreplace)
    End Sub

    Private Sub findreplace_focus(sender As Object, e As EventArgs) Handles findreplace_find.GotFocus, findreplace_replace.GotFocus
        If sender.text = sender.tag Then
            sender.text = ""
        End If
    End Sub

    Private Sub button_find_Click(sender As Object, e As EventArgs) Handles button_find.Click
        Dim found As Boolean
        writeOut((text_writer.Text.Length - text_writer.Text.Replace(findreplace_find.Text, String.Empty).Length) / findreplace_find.Text.Length & " occurences")

        Dim matches As MatchCollection = Regex.Matches(text_writer.Text, findreplace_find.Text)

        For Each match As Match In matches
            If match.Index >= _findIndex Then
                found = True
                findreplace_find_TextChanged(findreplace_find, Nothing)
                _findIndex = match.Index + 1
                text_writer.Select(match.Index, match.Length)
                text_writer.SelectionBackColor = Color.Yellow
                text_writer.SelectionColor = g_Theme("text_color")
                Exit For
            End If
        Next
        If Not found Then
            _findIndex = 0
        End If
    End Sub

    Private Sub resetSelection()
        text_writer.SelectAll()
        text_writer.SelectionColor = g_Theme("text_color")
        text_writer.SelectionBackColor = g_Theme("editor_color")
        text_writer.DeselectAll()
    End Sub

    Private Sub findreplace_find_TextChanged(sender As Object, e As EventArgs) Handles findreplace_find.TextChanged
        resetSelection()
        If panel_searchreplace.Height > 0 Then
            If sender.text.length > 0 Then
                Dim matches As MatchCollection = Regex.Matches(text_writer.Text, findreplace_find.Text)

                For Each match As Match In matches
                    text_writer.Select(match.Index, match.Length)
                    text_writer.SelectionBackColor = g_Theme("text_color")
                    text_writer.SelectionColor = g_Theme("editor_color")
                Next

                writeOut((text_writer.Text.Length - text_writer.Text.Replace(findreplace_find.Text, String.Empty).Length) / findreplace_find.Text.Length & " occurences")
            End If
        End If
    End Sub

    Private Sub button_replace_Click(sender As Object, e As EventArgs) Handles button_replace.Click
        Dim replacetext As String = findreplace_replace.Text

        If text_writer.SelectedText.Length <= 0 Then
            Exit Sub
        End If

        Dim s As String = findreplace_find.Text

        Dim nextPos As Integer
        If _findIndex > 0 Then
            nextPos = _findIndex - 1
        Else
            Exit Sub
        End If

        text_writer.SelectionStart = nextPos
        text_writer.SelectionLength = s.Length
        text_writer.SelectedText = replacetext
        'nextPos = text_writer.Text.IndexOf(s, nextPos + 1)

        findreplace_find_TextChanged(findreplace_find, Nothing)
        button_find_Click(Nothing, Nothing)
        writeOut("replace word")
    End Sub

    Private Sub chart_pomodoro_tick(sender As Object, e As PaintEventArgs) Handles chart_pomodoro.Paint
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center
        Dim t As DateTime = New DateTime(TimeSpan.FromSeconds(_pomodoroTime).Ticks)
        e.Graphics.DrawString(t.ToString(("mm:ss")), New Font("Segoe UI", 16), New SolidBrush(g_Theme("text_color")), New Point(chart_pomodoro.Width / 2, chart_pomodoro.Height / 2), stringFormat)
    End Sub

    Private Sub button_pomEnable_Click(sender As Object, e As EventArgs) Handles button_pomEnable.Click
        If Not _pomodoro Then
            startPomodoro()
            sender.text = "Stop Pomodoro"
        Else
            If msg("Are you sure you're done?", vbYesNo) = MsgBoxResult.Yes Then
                stopPomodoro()
                sender.text = "Start Pomodoro"
            End If
        End If
    End Sub

    Private Sub button_settings_Click(sender As Object, e As EventArgs, Optional a As Boolean = True) Handles button_settings.Click
        If _animsDone Then
            If Not panel_settings.Enabled Then
                panel_settings.Enabled = True
                panel_settings.Width = 0
                tweenSize(panel_settings, g_animSpeed, panel_content.Width, 0)
                panel_settings.Dock = DockStyle.Right

            Else
                panel_settings.Enabled = False
                panel_settings.Width = panel_content.Width
                tweenSize(panel_settings, g_animSpeed, -panel_content.Width, 0)
                panel_settings.Dock = DockStyle.Left
            End If
            If panel_stats.Enabled = True AndAlso a Then
                _animsDone = True
                button_stats_Click(Nothing, Nothing, False)
            End If
        End If
        load_settings()
    End Sub

    Private Sub settings_back_Click(sender As Object, e As EventArgs) Handles settings_back.Click
        button_settings_Click(Nothing, Nothing)
    End Sub

    Private Sub load_settings()
        settings_startfullscreen.Checked = g_StartFullscreen
        settings_pom_startup.Checked = g_pomodoroEnabledDefault
        settings_pomtime.Value = Math.Ceiling(g_PomodoroTime / 60)
        settings_pomtime_break.Value = Math.Ceiling(g_pomodoroBreakTime / 60)
        text_writer.Font = g_Font
    End Sub

    Private Sub settings_ok_Click(sender As Object, e As EventArgs) Handles settings_ok.Click
        Dim restartpom As Boolean
        If _pomodoro AndAlso (settings_pomtime.Value <> g_PomodoroTime Or settings_pomtime_break.Value <> g_pomodoroBreakTime) Then
            If msg("You changed your pomodoro settings. Would you like to restart the timer?", MsgBoxStyle.YesNo, "timer changed") = DialogResult.Yes Then
                restartpom = True
            End If
        End If
        g_PomodoroTime = settings_pomtime.Value * 60
        My.Settings.PomodoroTime = g_PomodoroTime
        My.Settings.Font = g_Font
        g_StartFullscreen = settings_startfullscreen.Checked
        My.Settings.StartFullscreen = g_StartFullscreen
        g_pomodoroEnabledDefault = settings_pom_startup.Checked
        My.Settings.PomodoroEnabledDefault = g_pomodoroEnabledDefault
        g_pomodoroBreakTime = settings_pomtime_break.Value * 60
        My.Settings.PomodoroBreakTime = g_pomodoroBreakTime
        writeOut("settings changed")
        button_settings_Click(Nothing, Nothing)
        If restartpom Then
            stopPomodoro()
            startPomodoro()
        End If
    End Sub

    Private Sub settings_changefont_Click(sender As Object, e As EventArgs) Handles settings_changefont.Click
        editorfontdialog.Font = g_Font
        If editorfontdialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            g_Font = editorfontdialog.Font
            text_writer.Font = editorfontdialog.Font
        End If
    End Sub

    Private Sub settings_cancel_Click(sender As Object, e As EventArgs) Handles settings_cancel.Click
        button_settings_Click(Nothing, Nothing)

    End Sub

    Private Sub stats_back_Click(sender As Object, e As EventArgs) Handles stats_back.Click
        button_stats_Click(Nothing, Nothing)
    End Sub

    Private Sub text_writer_contentsResized(sender As Object, e As ContentsResizedEventArgs) Handles text_writer.ContentsResized
        text_writer.Height = e.NewRectangle.Height + 12
    End Sub

    Private Sub panel_write_click(sender As Object, e As MouseEventArgs) Handles panel_write.Click
        text_writer.Focus()

    End Sub

End Class
