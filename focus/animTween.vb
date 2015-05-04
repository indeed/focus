Public Class animTween
    Inherits anim

    Public startPos As Point
    Public startSize As Size
    Public tweenX As Integer
    Public tweenY As Integer
    Public type As Integer 'translate = 0, resize = 1
    Private tween As Integer = 3

    Public Sub New(c As Control, s As Integer, tx As Integer, ty As Integer, t As Integer)
        control = c
        speed = s
        startPos = c.Location
        startSize = c.Size
        tweenX = tx
        tweenY = ty
        type = t
    End Sub

    Public Sub animate()
        If Not done Then
            Select Case type
                Case 0
                    Dim x As Integer = control.Location.X + tweenX / tween
                    Dim y As Integer = control.Location.Y + tweenY / tween
                    tween += 1
                    control.Location = New Point(x, y)
                    If (tweenX >= 0 AndAlso control.Location.X >= startPos.X + tweenX) Or (tweenX <= 0 AndAlso control.Location.X <= startPos.X + tweenX) Then
                        If (tweenY >= 0 AndAlso control.Location.Y >= startPos.Y + tweenY) Or (tweenY <= 0 AndAlso control.Location.Y <= startPos.Y + tweenY) Then
                            done = True
                            control.Location = New Point(startPos.X + tweenX, startPos.Y + tweenY)
                        End If
                    End If
                Case 1
                    Dim x As Integer = control.Width + tweenX / tween
                    Dim y As Integer = control.Height + tweenY / tween
                    tween += 1
                    control.Size = New Size(x, y)
                    If (tweenX >= 0 AndAlso control.Width >= startSize.Width + tweenX) Or (tweenX <= 0 AndAlso control.Width <= startSize.Width + tweenX) Then
                        If (tweenY >= 0 AndAlso control.Height >= startSize.Height + tweenY) Or (tweenY <= 0 AndAlso control.Height <= startSize.Height + tweenY) Then
                            done = True
                            control.Size = New Size(startSize.Width + tweenX, startSize.Height + tweenY)
                        End If
                    End If
            End Select
        End If
    End Sub

End Class
