Public Module globals

    Public g_PageWidth As Integer = 960
    Public g_PagePadding As Padding = New Padding(64, 36, 64, 36)
    Public g_WindowSize As Size = New Size(800, 640)
    Public g_MenuTriggerWidth As Integer = 32
    Public g_MenuDrawerWidth As Integer = 148
    Public g_animSpeed As Integer = 12 'inversely fast
    Public g_Theme As Dictionary(Of String, Color) = theme_Light
    Public g_StartFullscreen As Boolean = True
    Public g_ThesaurusAPICall As String = "http://words.bighugelabs.com/api/2/dd1424cf5448d8d8337a022276e6d77b/"
    Public g_Font As Font = New Font("Courier New", 12)
    Public g_PomodoroTime As Integer = 10
    Public g_pomodoroBreakTime As Integer = 5
    Public g_pomodoroEnabledDefault As Boolean = False

End Module
