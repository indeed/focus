Public Class Splash

    Private Sub Splash_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawImage(My.Resources.splash, 0, 0, Me.Width, Me.Height)
    End Sub
End Class
