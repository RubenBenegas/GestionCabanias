Public Class grafReservas

    Private Sub grafReservas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = flpContenedor.Controls.Count - 1 To 0 Step -1
            flpContenedor.Controls.Item(i).Dispose()
        Next
    End Sub

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ActualizarGrafico()
        'Dim cab As New Cabanias
        'Dim dtc As New Data.DataTable
        'dtc = cab.DataTableCabanias

        'Dim res As New Reservas
        'Dim dt As New Data.DataTable
        'dt = res.DataTableReservas

        'Dim posX As Integer = 0
        'Dim posY As Integer = 0
        'Dim tamanio As Integer = 30
        'Dim btnReserva As BotonReservas

        'Dim flpHabitacion As FlpCabanias
        'Dim arflpHabitaciones(10)

        'For Each row As DataRow In dtc.Rows
        '    flpHabitacion = New FlpCabanias
        '    flpHabitacion.BackColor = Color.White
        '    flpHabitacion.Width = 591
        '    flpHabitacion.Height = 32
        '    flpHabitacion.FlowDirection = FlowDirection.LeftToRight
        '    flpHabitacion.id = row.Item("id")
        '    flpContenedor.Controls.Add(flpHabitacion)
        'Next

        'For Each row As DataRow In dt.Rows
        '    btnReserva = New BotonReservas
        '    btnReserva.Left = posX
        '    btnReserva.Top = posY
        '    btnReserva.BackColor = Color.SkyBlue
        '    btnReserva.ForeColor = Color.Transparent
        '    btnReserva.id = row.Item("id")
        '    btnReserva.Width = row.Item("dias") * 10

        '    Dim res2 As Reservas
        '    res2 = res.RecuperarReserva(btnReserva.id)
        '    btnReserva.fIngreso = res2.fIngreso
        '    btnReserva.fSalida = res2.fSalida

        '    For i As Integer = 0 To flpContenedor.Controls.Count - 1
        '        Dim idHabitacion As Integer = DirectCast(flpContenedor.Controls.Item(i), FlpCabanias).id
        '        If row.Item("idCabania") = idHabitacion Then
        '            If flpContenedor.Controls.Item(i).Controls.Count > 0 Then
        '                Dim fechaActual As Date = btnReserva.fIngreso
        '                Dim anterior As Integer = flpContenedor.Controls.Item(i).Controls.Count - 1
        '                Dim fechaAnterior As Date = DirectCast(flpContenedor.Controls.Item(i).Controls.Item(anterior), BotonReservas).fSalida
        '                Dim cantDias As Integer = DateDiff(DateInterval.Day, fechaAnterior, fechaActual)
        '                Dim hueco As New Huecos(cantDias)
        '                flpContenedor.Controls.Item(i).Controls.Add(hueco)
        '            End If
        '            flpContenedor.Controls.Item(i).Controls.Add(btnReserva)
        '            Exit For
        '        End If
        '    Next
        '    btnReserva.Show()
        '    posY += 20
        'Next
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmReservas.modificar = False
        frmReservas.idReserva = 0
        frmReservas.ShowDialog()
    End Sub



    Public Sub ActualizarGrafico()
        Dim cab As New Cabanias
        Dim dtc As New Data.DataTable
        dtc = cab.DataTableCabanias

        Dim res As New Reservas
        Dim dt As New Data.DataTable
        dt = res.DataTableReservas

        Dim posX As Integer = 0
        Dim posY As Integer = 0
        Dim tamanio As Integer = 30
        Dim btnReserva As BotonReservas

        Dim flpHabitacion As FlpCabanias
        Dim arflpHabitaciones(10)

        For Each row As DataRow In dtc.Rows
            flpHabitacion = New FlpCabanias
            flpHabitacion.BackColor = Color.White
            flpHabitacion.Width = 591
            flpHabitacion.Height = 32
            flpHabitacion.FlowDirection = FlowDirection.LeftToRight
            flpHabitacion.id = row.Item("id")
            flpContenedor.Controls.Add(flpHabitacion)
        Next

        For Each row As DataRow In dt.Rows
            btnReserva = New BotonReservas
            btnReserva.Left = posX
            btnReserva.Top = posY
            btnReserva.BackColor = Color.SkyBlue
            btnReserva.ForeColor = Color.Transparent
            btnReserva.id = row.Item("id")
            btnReserva.Width = row.Item("dias") * 10

            Dim res2 As Reservas
            res2 = res.RecuperarReserva(btnReserva.id)
            btnReserva.fIngreso = res2.fIngreso
            btnReserva.fSalida = res2.fSalida
            btnReserva.Cancelada = res2.Cancelada


            If btnReserva.Cancelada = True Then
                btnReserva.BackColor = Color.Red
            End If


            For i As Integer = 0 To flpContenedor.Controls.Count - 1
                Dim idHabitacion As Integer = DirectCast(flpContenedor.Controls.Item(i), FlpCabanias).id
                If row.Item("idCabania") = idHabitacion Then
                    If flpContenedor.Controls.Item(i).Controls.Count > 0 Then
                        Dim fechaActual As Date = btnReserva.fIngreso
                        Dim anterior As Integer = flpContenedor.Controls.Item(i).Controls.Count - 1
                        Dim fechaAnterior As Date = DirectCast(flpContenedor.Controls.Item(i).Controls.Item(anterior), BotonReservas).fSalida
                        Dim cantDias As Integer = DateDiff(DateInterval.Day, fechaAnterior, fechaActual)
                        Dim hueco As New Huecos(cantDias)
                        flpContenedor.Controls.Item(i).Controls.Add(hueco)
                    End If
                    flpContenedor.Controls.Item(i).Controls.Add(btnReserva)
                    Exit For
                End If
            Next
            btnReserva.Show()
            posY += 20
        Next
    End Sub
End Class