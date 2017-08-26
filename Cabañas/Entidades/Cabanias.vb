Imports System.Data
Imports System.Data.SqlClient

Public Class Cabanias

    Inherits Conexiones

    Private idCabania_ As Integer
    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property


    Private idTipo_ As Integer
    Public Property idTipo() As Integer
        Get
            Return idTipo_
        End Get
        Set(ByVal value As Integer)
            idTipo_ = value
        End Set
    End Property


    Private monto_ As Decimal
    Public Property monto() As Decimal
        Get
            Return monto_
        End Get
        Set(ByVal value As Decimal)
            monto_ = value
        End Set
    End Property


    Private descripcion_ As String
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property

    Public Sub TraerTabCabania(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("CabaniasTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("TipoCabania").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrarConexion()

    End Sub

    Public Function InsertarCabania(ByVal cabania As Cabanias) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipo", cabania.idTipo)
            objComando.Parameters.AddWithValue("@Descripcion", cabania.descripcion)
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

    Public Function ModificarCabania(ByVal Cabania As Cabanias) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipo", Cabania.idTipo)
            objComando.Parameters.AddWithValue("@Descripcion", Cabania.descripcion)
            objComando.Parameters.AddWithValue("@IdCabania", Cabania.idCabania)
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

    Public Function BorrarCabania(ByVal idProducto As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCabania", idCabania)
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

    Public Function RecuperarCabania(ByVal idCabania As Integer) As Cabanias

        Try
            abrirConexion()
            Dim cabania As New Cabanias

            Dim objComando As New SqlCommand("CabaniasRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCabania", idCabania)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                cabania.idCabania = objDataTable.Rows(0).Item("Id")
                cabania.idTipo = objDataTable.Rows(0).Item("idTipo")
                cabania.monto = objDataTable.Rows(0).Item("Monto")
                cabania.descripcion = objDataTable.Rows(0).Item("Descripcion")
                Return cabania

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Sub CargarComboCabaniaEstado(ByVal ComboActual As ComboBox)

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("CabaniaCargarComboEstado", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Public Sub CargarComboCabaniaTipo(ByVal ComboActual As ComboBox)

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("CabaniaCargarComboTipo", objConexion)
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
    End Sub

    Public Function CantidadCabania() As Integer
        abrirConexion()

        Dim cantidad As New Integer
        Dim objComando As New SqlCommand("CabaniasCantidad", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        cantidad = objDataTable.Rows(0).Item("cantidad")
        Return cantidad

        cerrarConexion()

    End Function
End Class

