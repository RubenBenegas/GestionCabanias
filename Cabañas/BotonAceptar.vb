Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonAceptar


    Inherits RectangleShape

    Public Sub New()
        'Me.BackgroundImage = My.Resources.Boton
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(122, 35)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.CornerRadius = 20



    End Sub

    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        'Me.BackgroundImage = My.Resources.BotonAgregar2
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        'Me.BackgroundImage = My.Resources.BotonAgregar1
    End Sub

End Class
