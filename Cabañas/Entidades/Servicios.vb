Imports System.Data
Imports System.Data.SqlClient

Public Class Servicios
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

    Private Descripcion_ As String
    Public Property Descripcion() As String

        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
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

    Public Sub ServicioTraerTab(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ServicioTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub

    Public Function ServicioInsertar(ByVal servicio As Servicios) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ServicioInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", servicio.Id)
            objComando.Parameters.AddWithValue("@Descripcion", servicio.Descripcion)
            objComando.Parameters.AddWithValue("@Monto", servicio.Monto)

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

    Public Function ServicioModificar(ByVal servicio As Servicios) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ServicioModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", servicio.Id)
            objComando.Parameters.AddWithValue("@Descripcion", servicio.Descripcion)
            objComando.Parameters.AddWithValue("@Monto", servicio.Monto)
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

    Public Function ServicioBorrar(ByVal Id As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ServicioBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", Id)
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

    Public Function ServicioRecuperar(ByVal id As Integer) As Servicios

        Try
            abrirConexion()
            Dim servicio As New Servicios

            Dim objComando As New SqlCommand("ServicioRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", id)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                servicio.Id = objDataTable.Rows(0).Item("Id")
                servicio.Descripcion = objDataTable.Rows(0).Item("Descripcion")
                servicio.Monto = objDataTable.Rows(0).Item("Monto")

                Return servicio

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


End Class
