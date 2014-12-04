Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data

Public Class Metodo
    Dim wId As String
    Dim wNombre As String
    Dim wDireccion As String
    Dim wTelefono As String
    Dim wDni As String
    Dim wRecepcion As String
    Dim wEntrega As String
    Dim wHora As String
    Dim wPrenda1 As String
    Dim wDetalle1 As String
    Dim wCantidad1 As String
    Dim wPrenda2 As String
    Dim wDetalle2 As String
    Dim wCantidad2 As String
    Dim wPrenda3 As String
    Dim wDetalle3 As String
    Dim wCantidad3 As String
    Dim wPrenda4 As String
    Dim wDetalle4 As String
    Dim wCantidad4 As String

    Dim wUserDni As String
    Dim wUserNombre As String

    Dim wChk0 As Boolean
    Dim wChk1 As Boolean
    Dim wChk2 As Boolean

    Public Property Id() As String
        Get
            Return wId
        End Get
        Set(ByVal value As String)
            wId = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return wNombre
        End Get
        Set(ByVal value As String)
            wNombre = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return wDireccion
        End Get
        Set(ByVal value As String)
            wDireccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return wTelefono
        End Get
        Set(ByVal value As String)
            wTelefono = value
        End Set
    End Property

    Public Property Dni() As String
        Get
            Return wDni
        End Get
        Set(ByVal value As String)
            wDni = value
        End Set
    End Property

    Public Property Recepcion() As String
        Get
            Return wRecepcion
        End Get
        Set(ByVal value As String)
            wRecepcion = value
        End Set
    End Property

    Public Property Entrega() As String
        Get
            Return wEntrega
        End Get
        Set(ByVal value As String)
            wEntrega = value
        End Set
    End Property

    Public Property Hora() As String
        Get
            Return wHora
        End Get
        Set(ByVal value As String)
            wHora = value
        End Set
    End Property

    Public Property Prenda1() As String
        Get
            Return wPrenda1
        End Get
        Set(ByVal value As String)
            wPrenda1 = value
        End Set
    End Property

    Public Property Detalle1() As String
        Get
            Return wDetalle1
        End Get
        Set(ByVal value As String)
            wDetalle1 = value
        End Set
    End Property

    Public Property Cantidad1() As String
        Get
            Return wCantidad1
        End Get
        Set(ByVal value As String)
            wCantidad1 = value
        End Set
    End Property

    Public Property Prenda2() As String
        Get
            Return wPrenda2
        End Get
        Set(ByVal value As String)
            wPrenda2 = value
        End Set
    End Property

    Public Property Detalle2() As String
        Get
            Return wDetalle2
        End Get
        Set(ByVal value As String)
            wDetalle2 = value
        End Set
    End Property

    Public Property Cantidad2() As String
        Get
            Return wCantidad2
        End Get
        Set(ByVal value As String)
            wCantidad2 = value
        End Set
    End Property

    Public Property Prenda3() As String
        Get
            Return wPrenda3
        End Get
        Set(ByVal value As String)
            wPrenda3 = value
        End Set
    End Property

    Public Property Detalle3() As String
        Get
            Return wDetalle3
        End Get
        Set(ByVal value As String)
            wDetalle3 = value
        End Set
    End Property

    Public Property Cantidad3() As String
        Get
            Return wCantidad3
        End Get
        Set(ByVal value As String)
            wCantidad3 = value
        End Set
    End Property

    Public Property Prenda4() As String
        Get
            Return wPrenda4
        End Get
        Set(ByVal value As String)
            wPrenda4 = value
        End Set
    End Property

    Public Property Detalle4() As String
        Get
            Return wDetalle4
        End Get
        Set(ByVal value As String)
            wDetalle4 = value
        End Set
    End Property

    Public Property Cantidad4() As String
        Get
            Return wCantidad4
        End Get
        Set(ByVal value As String)
            wCantidad4 = value
        End Set
    End Property

    Public Property UserDni() As String
        Get
            Return wUserDni
        End Get
        Set(ByVal value As String)
            wUserDni = value
        End Set
    End Property

    Public Property UserNombre() As String
        Get
            Return wUserNombre
        End Get
        Set(ByVal value As String)
            wUserNombre = value
        End Set
    End Property

    Public Property Chk0() As Boolean
        Get
            Return wChk0
        End Get
        Set(ByVal value As Boolean)
            wChk0 = value
        End Set
    End Property

    Public Property Chk1() As Boolean
        Get
            Return wChk1
        End Get
        Set(ByVal value As Boolean)
            wChk1 = value
        End Set
    End Property

    Public Property Chk2() As Boolean
        Get
            Return wChk2
        End Get
        Set(ByVal value As Boolean)
            wChk2 = value
        End Set
    End Property

    Public Sub CargarGrid(ByVal conex As OleDbConnection, ByRef MiGrid As DataGridView)

        Dim Tablita As New System.Data.DataTable()
        Dim cadena As String
        cadena = "Select * from Tabla ORDER BY Id DESC"
        'cadena = "Select max(Id) from Tabla"
        Dim tramitador As New OleDbDataAdapter(cadena, conex)
        Dim comoda As New System.Data.DataSet()
        tramitador.Fill(comoda, "Tabla")
        Tablita = comoda.Tables(0)
        MiGrid.DataSource = Tablita
        MiGrid.Columns(0).HeaderText = "Nota"
        MiGrid.Columns(0).Width = 40
        MiGrid.Columns(3).Width = 70
        MiGrid.Columns(4).Width = 70
        MiGrid.Columns(7).Width = 80
        MiGrid.Columns(10).Width = 60
        MiGrid.Columns(13).Width = 60
        MiGrid.Columns(16).Width = 60
        MiGrid.Columns(19).Width = 60
        'MiGrid.Columns(1).HeaderText = "Nombre"
        'MiGrid.Columns(2).HeaderText = "Direccion"
        'MiGrid.Columns(3).HeaderText = "Telefono"
        'MiGrid.Columns(4).HeaderText = "DNI"
        'MiGrid.Columns(5).HeaderText = "Recepcion"
        'MiGrid.Columns(6).HeaderText = "Entrega"
        'MiGrid.Columns(7).HeaderText = "Hora"
        'MiGrid.Columns(8).HeaderText = "Prenda1"
        'MiGrid.Columns(9).HeaderText = "Detalle1"
        'MiGrid.Columns(10).HeaderText = "Cantidad1"
        'MiGrid.Columns(11).HeaderText = "Prenda2"
        'MiGrid.Columns(12).HeaderText = "Detalle2"
        'MiGrid.Columns(13).HeaderText = "Cantidad2"
        'MiGrid.Columns(14).HeaderText = "Prenda3"
        'MiGrid.Columns(15).HeaderText = "Detalle3"
        'MiGrid.Columns(16).HeaderText = "Cantidad3"
        'MiGrid.Columns(17).HeaderText = "Prenda4"
        'MiGrid.Columns(18).HeaderText = "Detalle4"
        'MiGrid.Columns(19).HeaderText = "Cantidad4"

    End Sub

    Public Sub obtenerUltimoReg(ByVal conex As OleDbConnection, ByRef miGrilla As DataGridView)

        Dim Tablita As New System.Data.DataTable()
        Dim cadena As String
        'cadena = "Select * from Tabla ORDER BY Id DESC"
        cadena = "Select max(Id) from Tabla"
        Dim tramitador As New OleDbDataAdapter(cadena, conex)
        Dim comoda As New System.Data.DataSet()
        tramitador.Fill(comoda, "Tabla")
        Tablita = comoda.Tables(0)
        miGrilla.DataSource = Tablita
        miGrilla.Columns(0).HeaderText = "Nota"
        miGrilla.Columns(0).Width = 40

    End Sub

    Public Sub rellenaComboBox(ByRef comboBox As ComboBox)
        comboBox.Items.Add("|Decolorido| ")
        comboBox.Items.Add("|Roto| ")
        comboBox.Items.Add("|Botones| ")
        comboBox.Items.Add("|Picado|")
        comboBox.Items.Add("|Mancahdo| ")
        comboBox.Items.Add("|Gastado| ")
        comboBox.Items.Add("|Brillo| ")
        comboBox.Items.Add("|Hilos Jalados| ")
    End Sub

    Public Sub Ingresar(ByVal conex As OleDbConnection)

        Dim vSQL As String
        Dim comando As New OleDbCommand

        vSQL = "INSERT INTO Tabla VALUES("
        vSQL = vSQL + Me.Id + ",'"
        vSQL = vSQL + Me.Nombre + "','"
        vSQL = vSQL + Me.Direccion + "','"
        vSQL = vSQL + Me.Telefono + "','"
        vSQL = vSQL + Me.Dni + "','"
        vSQL = vSQL + Me.Recepcion + "','"
        vSQL = vSQL + Me.Entrega + "','"
        vSQL = vSQL + Me.Hora + "','"

        vSQL = vSQL + Me.Prenda1 + "','"
        vSQL = vSQL + Me.Detalle1 + "','"
        vSQL = vSQL + Me.Cantidad1 + "','"

        vSQL = vSQL + Me.Prenda2 + "','"
        vSQL = vSQL + Me.Detalle2 + "','"
        vSQL = vSQL + Me.Cantidad2 + "','"

        vSQL = vSQL + Me.Prenda3 + "','"
        vSQL = vSQL + Me.Detalle3 + "','"
        vSQL = vSQL + Me.Cantidad3 + "','"

        vSQL = vSQL + Me.Prenda4 + "','"
        vSQL = vSQL + Me.Detalle4 + "','"
        vSQL = vSQL + Me.Cantidad4 + "')"


        comando.Connection = conex
        comando.CommandText = vSQL
        comando.CommandType = CommandType.Text
        comando.ExecuteNonQuery()

    End Sub

    Public Sub BuscarNota(ByVal conex As OleDbConnection, ByRef MiGrid As DataGridView)
        Dim Tablita As New System.Data.DataTable()
        Dim cadena As String
        cadena = "Select * from Tabla WHERE Id="
        cadena = cadena + Me.wId
        'cadena = "Select max(Id) from Tabla"
        Dim tramitador As New OleDbDataAdapter(cadena, conex)
        Dim comoda As New System.Data.DataSet()
        tramitador.Fill(comoda, "Tabla")
        Tablita = comoda.Tables(0)
        MiGrid.DataSource = Tablita
        MiGrid.Columns(0).HeaderText = "Nota"
        MiGrid.Columns(0).Width = 40
        MiGrid.Columns(3).Width = 70
        MiGrid.Columns(4).Width = 70
        MiGrid.Columns(7).Width = 80
        MiGrid.Columns(10).Width = 60
        MiGrid.Columns(13).Width = 60
        MiGrid.Columns(16).Width = 60
        MiGrid.Columns(19).Width = 60
    End Sub

    Public Sub Login(ByVal conex As OleDbConnection, ByRef MiGrilla As DataGridView)
        Dim Tabla As New System.Data.DataTable()
        Dim cadena As String
        cadena = "Select * from Usuario where Id =" + Me.wUserDni
        Dim Tramitador As New OleDbDataAdapter(cadena, conex)
        Dim Comoda As New System.Data.DataSet()
        Tramitador.Fill(Comoda, "Usuario")
        Tabla = Comoda.Tables(0)
        MiGrilla.DataSource = Tabla
    End Sub

    Public Sub Eliminar(ByVal conex As OleDbConnection)

        Dim vsql As String
        Dim comando As New OleDbCommand

        vsql = "Delete from Tabla where Id="
        vsql = vsql + Me.wId

        comando.Connection = conex
        comando.CommandText = vsql
        comando.CommandType = CommandType.Text
        comando.ExecuteNonQuery()

    End Sub

End Class


