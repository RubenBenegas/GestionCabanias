Public Class BotonReservas
    Inherits Button

    Private id_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Sub New()
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.Height = 32
    End Sub

    Private Sub Reservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click

        'MessageBox.Show("Esta es la reserva: " + Str(id))

        frmReservas.modificar = True
        frmReservas.idReserva = id
        frmReservas.ShowDialog()

    End Sub

    
End Class
