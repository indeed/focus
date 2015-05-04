Public Class TextPrint
    Inherits Printing.PrintDocument
    Private fntPrintFont As Font
    Private strText As String
    Public Sub New(ByVal Text As String)
        MyBase.New()
        strText = Text
    End Sub
    Public Property Text() As String
        Get
            Return strText
        End Get
        Set(ByVal Value As String)
            strText = Value
        End Set
    End Property
    Protected Overrides Sub OnBeginPrint(ByVal ev _
                                As Printing.PrintEventArgs)
        MyBase.OnBeginPrint(ev)
        If fntPrintFont Is Nothing Then
            fntPrintFont = New Font("Times New Roman", 12)
        End If
    End Sub
    Public Property Font() As Font
        Get
            Return fntPrintFont
        End Get
        Set(ByVal Value As Font)
            fntPrintFont = Value
        End Set
    End Property
    Protected Overrides Sub OnPrintPage(ByVal ev _
       As Printing.PrintPageEventArgs)
        MyBase.OnPrintPage(ev)
        Static intCurrentChar As Integer
        Dim intPrintAreaHeight, intPrintAreaWidth, _
            intMarginLeft, intMarginTop As Integer
        With MyBase.DefaultPageSettings
            intPrintAreaHeight = .PaperSize.Height - _
                               .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - _
                              .Margins.Left - .Margins.Right
            intMarginLeft = .Margins.Left
            intMarginTop = .Margins.Top
        End With
        If MyBase.DefaultPageSettings.Landscape Then
            Dim intTemp As Integer
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If
        Dim intLineCount As Int32 = _
                CInt(intPrintAreaHeight / Font.Height)
        Dim rectPrintingArea As New RectangleF(intMarginLeft, _
            intMarginTop, intPrintAreaWidth, intPrintAreaHeight)
        Dim objSF As New StringFormat(StringFormatFlags.LineLimit)
        Dim intLinesFilled, intCharsFitted As Int32
        ev.Graphics.MeasureString(Mid(strText, _
                    UpgradeZeros(intCurrentChar)), Font, _
                    New SizeF(intPrintAreaWidth, _
                    intPrintAreaHeight), objSF, _
                    intCharsFitted, intLinesFilled)
        ev.Graphics.DrawString(Mid(strText, _
            UpgradeZeros(intCurrentChar)), Font, _
            Brushes.Black, rectPrintingArea, objSF)
        intCurrentChar += intCharsFitted
        If intCurrentChar < strText.Length Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
            intCurrentChar = 0
        End If
    End Sub
    Public Function UpgradeZeros(ByVal Input As Integer) As Integer
        If Input = 0 Then
            Return 1
        Else
            Return Input
        End If
    End Function
End Class