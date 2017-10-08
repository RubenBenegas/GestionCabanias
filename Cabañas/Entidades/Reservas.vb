Imports System.Data
Imports System.Data.SqlClient
Public Class Reservas

    Inherits Conexiones

    Private Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private IdHuesped_ As Integer
    Public Property IdHuesped() As Integer
        Get
            Return IdHuesped_
        End Get
        Set(ByVal value As Integer)
            IdHuesped_ = value
        End Set
    End Property


    Private NombreHuesped_ As String
    Public Property NombreHuesped() As String
        Get
            Return NombreHuesped_
        End Get
        Set(ByVal value As String)
            NombreHuesped_ = value
        End Set
    End Property


    Private fIngreso_ As Date
    Public Property fIngreso() As Date
        Get
            Return fIngreso_
        End Get
        Set(ByVal value As Date)
            fIngreso_ = value
        End Set
    End Property

    Private fSalida_ As Date
    Public Property fSalida() As Date
        Get
            Return fSalida_
        End Get
        Set(ByVal value As Date)
            fSalida_ = value
        End Set
    End Property

    Private IdCabania_ As Integer
    Public Property IdCabania() As Integer
        Get
            Return IdCabania_
        End Get
        Set(ByVal value As Integer)
            IdCabania_ = value
        End Set
    End Property


    Private NroPasajeros_ As Integer
    Public Property NroPasajeros() As Integer
        Get
            Return NroPasajeros_
        End Get
        Set(ByVal value As Integer)
            NroPasajeros_ = value
        End Set
    End Property


    Private Senia_ As Decimal
    Public Property Senia() As Decimal
        Get
            Return Senia_
        End Get
        Set(ByVal value As Decimal)
            Senia_ = value
        End Set
    End Property

    Private ConSenia_ As Boolean
    Public Property ConSenia() As Boolean
        Get
            Return ConSenia_
        End Get
        Set(ByVal value As Boolean)
            ConSenia_ = value
        End Set
    End Property

    Private CheckIn_ As Date
    Public Property Checkin() As Date
        Get
            Return CheckIn_
        End Get
        Set(ByVal value As Date)
            CheckIn_ = value
        End Set
    End Property

    Private CheckOut_ As Date
    Public Property Checkout() As Date
        Get
            Return CheckOut_
        End Get
        Set(ByVal value As Date)
            CheckOut_ = value
        End Set
    End Property



    Private Cancelada_ As Boolean
    Public Property Cancelada() As Boolean
        Get
            Return Cancelada_
        End Get
        Set(ByVal value As Boolean)
            Cancelada_ = value
        End Set
    End Property



    Public Sub TraerTabReservas(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ReservasTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Huesped").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub


    Public Function InsertarReserva(ByVal reserva As Reservas) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdHuesped", reserva.IdHuesped)
            objComando.Parameters.AddWithValue("@fIngreso", reserva.fIngreso)
            objComando.Parameters.AddWithValue("@fSalida", reserva.fSalida)
            objComando.Parameters.AddWithValue("@IdCabania", reserva.IdCabania)
            objComando.Parameters.AddWithValue("@NroPasajeros", reserva.NroPasajeros)
            objComando.Parameters.AddWithValue("@Senia", reserva.Senia)
            objComando.Parameters.AddWithValue("@ConSenia", reserva.ConSenia)
            objComando.Parameters.AddWithValue("@Checkin", reserva.Checkin)
            objComando.Parameters.AddWithValue("@Checkout", reserva.Checkout)
            objComando.Parameters.AddWithValue("@Cancelada", reserva.Cancelada)

            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Function BorraReserva(ByVal idReserva As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function RecuperarReserva(ByVal idReserva As Integer) As Reservas

        Try
            abrirConexion()
            Dim reserva As New Reservas
            Dim objComando As New SqlCommand("ReservasRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Idreserva", idReserva)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                reserva.Id = objDataTable.Rows(0).Item("Id")
                reserva.IdHuesped = objDataTable.Rows(0).Item("IdHuesped")
                reserva.NombreHuesped = objDataTable.Rows(0).Item("Nombre")
                reserva.fIngreso = objDataTable.Rows(0).Item("fIngreso")
                reserva.fSalida = objDataTable.Rows(0).Item("fSalida")
                reserva.IdCabania = objDataTable.Rows(0).Item("IdCabania")
                reserva.NroPasajeros = objDataTable.Rows(0).Item("NroPasajeros")
                reserva.Senia = objDataTable.Rows(0).Item("Senia")
                reserva.ConSenia = objDataTable.Rows(0).Item("ConSenia")
                reserva.Checkin = objDataTable.Rows(0).Item("Checkin")
                reserva.Checkout = objDataTable.Rows(0).Item("Checkout")
                reserva.Cancelada = objDataTable.Rows(0).Item("Cancelada")
                Return reserva
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarReserva(ByVal reserva As Reservas) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdHuesped", reserva.IdHuesped)
            objComando.Parameters.AddWithValue("@fIngreso", reserva.fIngreso)
            objComando.Parameters.AddWithValue("@fSalida", reserva.fSalida)
            objComando.Parameters.AddWithValue("@IdCabania", reserva.IdCabania)
            objComando.Parameters.AddWithValue("@NroPasajeros", reserva.NroPasajeros)
            objComando.Parameters.AddWithValue("@Senia", reserva.Senia)
            objComando.Parameters.AddWithValue("@ConSenia", reserva.ConSenia)
            objComando.Parameters.AddWithValue("@Checkin", reserva.Checkin)
            objComando.Parameters.AddWithValue("@Checkout", reserva.Checkout)
            objComando.Parameters.AddWithValue("@Cancelada", reserva.Cancelada)
            objComando.Parameters.AddWithValue("@Id", reserva.Id)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function CargarComboCabania(ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasCargarComboCabania", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "TipoCabania"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Sub CantidadReservas(ByVal tabla As DataGridView)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasTraerTab", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable

            tabla.Columns("Id").Width = 50
            tabla.Columns("Huesped").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Public Function DataTableReservas() As Data.DataTable
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasDataTable", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            Return objDataTable

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Function ReservaAdicionalInsertar(ByVal idReserva As Integer, ByVal idAdicional As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservaAdicionalInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idReserva", idReserva)
            objComando.Parameters.AddWithValue("@idAdicional", idAdicional)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Sub ReservasCargarAdicionales(ByVal idReserva As Integer, ByVal tabla As DataGridView)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasCargarAdicionales", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idReserva", idReserva)

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
            'tabla.Columns("id").Visible = False
            tabla.Columns("id").Width = 30
            tabla.Columns("Adicionales").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub


    Public Function ReservaAdicionalBorrar(ByVal idAdicional As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservaAdicionalBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            'objComando.Parameters.AddWithValue("@idReserva", idReserva)
            objComando.Parameters.AddWithValue("@idAdicional", idAdicional)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function





    Public Function ReservaCostoEstadia(ByVal idReserva) As Decimal
        Try
            abrirConexion()
            Dim CostoEstadia As Decimal
            Dim objComando As New SqlCommand("ReservaCostoEstadia", objConexion)
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            CostoEstadia = objDataTable.Rows(0).Item("CostoEstadia")
            Return CostoEstadia

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ReservaCostoAdicionales(ByVal idReserva) As Decimal

        Try
            abrirConexion()
            Dim CostoAdicionales As Decimal
            Dim objComando As New SqlCommand("ReservaCostoAdicionales", objConexion)
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            CostoAdicionales = objDataTable.Rows(0).Item("CostoAdicionales")

            Return CostoAdicionales

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function





    Public Function ReservaTraerMontoDeCabania(ByVal idCabania) As Decimal

        Try
            abrirConexion()
            Dim MontoDeCabania As Decimal
            Dim objComando As New SqlCommand("ReservaTraerMontoDeCabania", objConexion)
            objComando.Parameters.AddWithValue("@idCabania", idCabania)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            MontoDeCabania = objDataTable.Rows(0).Item("Monto")
            Return MontoDeCabania

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

End Class
