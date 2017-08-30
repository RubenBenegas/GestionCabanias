Public Class grafReservas

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cab As New Cabanias
        Dim res As New Reservas
        Dim dt As New Data.DataTable
        dt = res.DataTableReservas

        Dim arReservas() As Integer = {10, 2, 5, 3, 4, 5, 7, 8, 5, 1}
        Dim arHabitaciones() As Integer = {1, 1, 2, 2, 3, 4, 5, 5, 5, 2}
        Dim posX As Integer = 0
        Dim posY As Integer = 0
        Dim tamanio As Integer = 30
        Dim btnReserva As BotonReservas

        Dim flpHabitacion As FlpCabanias
        Dim arflpHabitaciones(10)
        For i = 1 To cab.CantidadCabania()
            flpHabitacion = New FlpCabanias
            flpHabitacion.BackColor = Color.DarkBlue
            flpHabitacion.Width = 591
            flpHabitacion.Height = 32
            flpHabitacion.FlowDirection = FlowDirection.LeftToRight
            arflpHabitaciones(i) = flpHabitacion
            flpContenedor.Controls.Add(arflpHabitaciones(i))
        Next

   

        For Each row As DataRow In dt.Rows
            btnReserva = New BotonReservas
            btnReserva.Left = posX
            btnReserva.Top = posY
            btnReserva.BackColor = Color.SkyBlue
            btnReserva.id = row.Item("id")
            btnReserva.Width = row.Item("dias") * 10

            'REVISAAAAAARRRRR ESTOOOOOOO  
            'flpContenedor.Controls(row.Item("IdCabania")).Controls.Add(btnReserva)
            flpContenedor.Controls.Add(btnReserva)



            btnReserva.Show()
            posY += 20
        Next

        'For i = 0 To 9
        '    btnReserva = New BotonReservas
        '    btnReserva.id = i
        '    btnReserva.Left = posX
        '    btnReserva.Top = posY
        '    btnReserva.BackColor = Color.SkyBlue
        '    btnReserva.Width = arReservas(i) * 10
        '    flpContenedor.Controls(arHabitaciones(i)).Controls.Add(btnReserva)
        '    'flpContenedor.Controls.Add(btnReserva)
        '    btnReserva.Show()
        '    posY += 20
        'Next
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmReservas.modificar = False
        frmReservas.idReserva = 0
        frmReservas.ShowDialog()
    End Sub
End Class