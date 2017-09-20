Public Class Huecos
    Inherits Button

    Public Sub New(ByVal cantDias As Integer)
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.BackColor = Color.BlueViolet
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.Height = 32
        Me.Width = cantDias * 10
    End Sub

End Class
