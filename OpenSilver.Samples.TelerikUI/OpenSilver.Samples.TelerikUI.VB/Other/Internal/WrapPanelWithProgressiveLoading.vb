﻿Imports System.Windows.Controls

Namespace Global.OpenSilver.Samples.TelerikUI.VB
    Public Class WrapPanelWithProgressiveLoading
        Inherits WrapPanel
        Public Sub New()
            ProgressiveRenderingChunkSize = 3
        End Sub
    End Class
End Namespace
