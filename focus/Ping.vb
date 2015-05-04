Imports System.Windows.Forms

Public Class Ping

    Private ok As Boolean

    Sub New(text As String, Optional type As MsgBoxStyle = MsgBoxStyle.OkOnly, Optional t As String = "focus")

        ' This call is required by the designer.
        InitializeComponent()

        msgtext.Text = text
        title.Text = t
        Select Case type
            Case MsgBoxStyle.YesNo
                cancel.Visible = False
                msgbox_buttons.SetColumn(yes, 1)
                msgbox_buttons.SetColumn(no, 2)
            Case MsgBoxStyle.OkOnly
                no.Text = "OK"
                cancel.Visible = False
                msgbox_buttons.SetColumnSpan(no, 3)
                yes.Visible = False
                ok = True
        End Select

        fadeTimer.Start()
    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click
        If Not ok Then
            Me.DialogResult = System.Windows.Forms.DialogResult.No
        End If
        Me.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub ping_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles title.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub ping_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles title.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub ping_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles title.MouseUp
        drag = False
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
            If Me.Opacity < 1 Then
                Me.Opacity = Math.Min(Me.Opacity + 1 / g_animSpeed, 1)
            Else
                fadeTimer.Stop()
            End If
    End Sub




End Class
