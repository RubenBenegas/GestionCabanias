Imports System.Data
Imports System.Data.SqlClient

Public Class Pagos

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

    Private Fecha_ As Date
    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Private Monto_ As Decimal
    Public Property Monto() As Decimal
        Get
            Return Monto_
        End Get
        Set(ByVal value As Decimal)
            Monto_ = value
        End Set
    End Property

    Private IdReserva_ As Integer
    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property


    Public Sub PagosTraerTab(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("PagosTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("IdReserva").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub

    Public Function PagosInsertar(ByVal Pago As Pagos) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("PagosInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Fecha", Pago.Fecha)
            objComando.Parameters.AddWithValue("@Monto", Pago.Monto)
            objComando.Parameters.AddWithValue("@IdReserva", Pago.IdReserva)

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

    Public Function PagoModificar(ByVal Pago As Pagos) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ServiciosModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", Pago.Id)
            objComando.Parameters.AddWithValue("@Fecha", Pago.Fecha)
            objComando.Parameters.AddWithValue("@Monto", Pago.Monto)
            objComando.Parameters.AddWithValue("@IdReserva", Pago.IdReserva)
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

    Public Function PagosBorrar(ByVal Id As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("PagosBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("IdPagos", Id)
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

    Public Function PagosRecuperar(ByVal IdPago As Integer) As Pagos

        Try
            abrirConexion()
            Dim Pagos As New Pagos
            Dim objComando As New SqlCommand("PagosRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdPagos", IdPago)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Pagos.Id = objDataTable.Rows(0).Item("Id")
                Pagos.Fecha = objDataTable.Rows(0).Item("Fecha")
                Pagos.Monto = objDataTable.Rows(0).Item("Monto")
                Pagos.IdReserva = objDataTable.Rows(0).Item("IdReserva")
                Return Pagos
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

End Class
