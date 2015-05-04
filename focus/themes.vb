Public Module themes

    Public theme_Light As New Dictionary(Of String, Color) From {
        {"editor_color", SystemColors.Control},
        {"background_color", SystemColors.ControlLight},
        {"text_color", SystemColors.WindowFrame},
        {"menu_settings_color", Color.WhiteSmoke},
        {"menu_color", Color.Gainsboro}}

    Public theme_Dark As New Dictionary(Of String, Color) From {
        {"editor_color", Color.FromArgb(255, 25, 25, 25)},
        {"background_color", Color.FromArgb(255, 15, 15, 15)},
        {"text_color", Color.WhiteSmoke},
        {"menu_color", Color.FromArgb(255, 25, 25, 25)}}

    Public theme_Terminal As New Dictionary(Of String, Color) From {
        {"editor_color", Color.FromArgb(255, 5, 5, 5)},
        {"background_color", Color.FromArgb(255, 10, 10, 10)},
        {"text_color", Color.FromArgb(0, 245, 25)},
        {"menu_color", Color.FromArgb(255, 25, 25, 25)}}

    Public theme_Slate As New Dictionary(Of String, Color) From {
        {"editor_color", Color.FromArgb(255, 224, 238, 238)},
        {"background_color", Color.FromArgb(255, 204, 218, 218)},
        {"text_color", Color.FromArgb(47, 79, 79)},
        {"menu_settings_color", Color.FromArgb(255, 224, 238, 238)},
        {"menu_color", Color.FromArgb(255, 180, 205, 205)}}

    Public theme_Khaki As New Dictionary(Of String, Color) From {
        {"editor_color", Color.FromArgb(255, 210, 200, 185)},
        {"background_color", Color.FromArgb(255, 190, 180, 165)},
        {"text_color", Color.FromArgb(65, 60, 50)},
        {"menu_settings_color", Color.FromArgb(255, 230, 220, 205)},
        {"menu_color", Color.FromArgb(255, 190, 180, 165)}}


End Module
