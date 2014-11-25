<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NotaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaRecep = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.gbFechasHora = New System.Windows.Forms.GroupBox()
        Me.gbRecepcion = New System.Windows.Forms.GroupBox()
        Me.btnLimpiaBox4 = New System.Windows.Forms.Button()
        Me.btnLimpiaBox3 = New System.Windows.Forms.Button()
        Me.btnLimpiaBox2 = New System.Windows.Forms.Button()
        Me.btnLimpiaBox1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTablaPrenda4 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda3 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda2 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda1 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle1 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant1 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle2 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant2 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle3 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant3 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle4 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant4 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNotaId = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        NotaLabel = New System.Windows.Forms.Label()
        Me.gbDatosCliente.SuspendLayout()
        Me.gbFechasHora.SuspendLayout()
        Me.gbRecepcion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotaLabel
        '
        NotaLabel.AutoSize = True
        NotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotaLabel.Location = New System.Drawing.Point(16, 28)
        NotaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NotaLabel.Name = "NotaLabel"
        NotaLabel.Size = New System.Drawing.Size(193, 17)
        NotaLabel.TabIndex = 27
        NotaLabel.Text = "NOTA DE RECEPCION N°"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sr(a).:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(104, 33)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(395, 22)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Text = "Abel Ludeña Gutierrez"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de recepción:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(104, 65)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(395, 22)
        Me.txtDireccion.TabIndex = 6
        Me.txtDireccion.Text = "Calle Andromeda Mz B Lt 1 Urb. Matellini - Chorrillos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de entrega:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora de entrega:"
        '
        'dtpFechaRecep
        '
        Me.dtpFechaRecep.Enabled = False
        Me.dtpFechaRecep.Location = New System.Drawing.Point(171, 33)
        Me.dtpFechaRecep.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaRecep.Name = "dtpFechaRecep"
        Me.dtpFechaRecep.Size = New System.Drawing.Size(289, 22)
        Me.dtpFechaRecep.TabIndex = 9
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(171, 65)
        Me.dtpFechaEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(289, 22)
        Me.dtpFechaEntrega.TabIndex = 10
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(171, 97)
        Me.dtpHora.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(136, 22)
        Me.dtpHora.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telef.:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(104, 97)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(171, 22)
        Me.txtTelefono.TabIndex = 14
        Me.txtTelefono.Text = "999237718"
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.txtTelefono)
        Me.gbDatosCliente.Controls.Add(Me.Label6)
        Me.gbDatosCliente.Controls.Add(Me.txtDireccion)
        Me.gbDatosCliente.Controls.Add(Me.txtNombre)
        Me.gbDatosCliente.Controls.Add(Me.Label2)
        Me.gbDatosCliente.Controls.Add(Me.Label1)
        Me.gbDatosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatosCliente.ForeColor = System.Drawing.Color.Black
        Me.gbDatosCliente.Location = New System.Drawing.Point(16, 120)
        Me.gbDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDatosCliente.Size = New System.Drawing.Size(533, 137)
        Me.gbDatosCliente.TabIndex = 15
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "DATOS DEL CLIENTE"
        '
        'gbFechasHora
        '
        Me.gbFechasHora.Controls.Add(Me.dtpHora)
        Me.gbFechasHora.Controls.Add(Me.dtpFechaEntrega)
        Me.gbFechasHora.Controls.Add(Me.dtpFechaRecep)
        Me.gbFechasHora.Controls.Add(Me.Label5)
        Me.gbFechasHora.Controls.Add(Me.Label4)
        Me.gbFechasHora.Controls.Add(Me.Label3)
        Me.gbFechasHora.Location = New System.Drawing.Point(579, 120)
        Me.gbFechasHora.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFechasHora.Name = "gbFechasHora"
        Me.gbFechasHora.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFechasHora.Size = New System.Drawing.Size(491, 137)
        Me.gbFechasHora.TabIndex = 16
        Me.gbFechasHora.TabStop = False
        Me.gbFechasHora.Text = "ENTREGA Y RECEPCION"
        '
        'gbRecepcion
        '
        Me.gbRecepcion.Controls.Add(Me.btnLimpiaBox4)
        Me.gbRecepcion.Controls.Add(Me.btnLimpiaBox3)
        Me.gbRecepcion.Controls.Add(Me.btnLimpiaBox2)
        Me.gbRecepcion.Controls.Add(Me.btnLimpiaBox1)
        Me.gbRecepcion.Controls.Add(Me.TableLayoutPanel1)
        Me.gbRecepcion.Controls.Add(Me.ComboBox4)
        Me.gbRecepcion.Controls.Add(Me.ComboBox3)
        Me.gbRecepcion.Controls.Add(Me.ComboBox2)
        Me.gbRecepcion.Controls.Add(Me.ComboBox1)
        Me.gbRecepcion.Location = New System.Drawing.Point(16, 265)
        Me.gbRecepcion.Margin = New System.Windows.Forms.Padding(4)
        Me.gbRecepcion.Name = "gbRecepcion"
        Me.gbRecepcion.Padding = New System.Windows.Forms.Padding(4)
        Me.gbRecepcion.Size = New System.Drawing.Size(1053, 266)
        Me.gbRecepcion.TabIndex = 24
        Me.gbRecepcion.TabStop = False
        Me.gbRecepcion.Text = "RECEPCION"
        '
        'btnLimpiaBox4
        '
        Me.btnLimpiaBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox4.Location = New System.Drawing.Point(971, 219)
        Me.btnLimpiaBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiaBox4.Name = "btnLimpiaBox4"
        Me.btnLimpiaBox4.Size = New System.Drawing.Size(56, 24)
        Me.btnLimpiaBox4.TabIndex = 37
        Me.btnLimpiaBox4.Text = "Borrar"
        Me.btnLimpiaBox4.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox3
        '
        Me.btnLimpiaBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox3.Location = New System.Drawing.Point(971, 173)
        Me.btnLimpiaBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiaBox3.Name = "btnLimpiaBox3"
        Me.btnLimpiaBox3.Size = New System.Drawing.Size(56, 24)
        Me.btnLimpiaBox3.TabIndex = 37
        Me.btnLimpiaBox3.Text = "Borrar"
        Me.btnLimpiaBox3.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox2
        '
        Me.btnLimpiaBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox2.Location = New System.Drawing.Point(971, 127)
        Me.btnLimpiaBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiaBox2.Name = "btnLimpiaBox2"
        Me.btnLimpiaBox2.Size = New System.Drawing.Size(56, 24)
        Me.btnLimpiaBox2.TabIndex = 37
        Me.btnLimpiaBox2.Text = "Borrar"
        Me.btnLimpiaBox2.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox1
        '
        Me.btnLimpiaBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox1.Location = New System.Drawing.Point(971, 81)
        Me.btnLimpiaBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiaBox1.Name = "btnLimpiaBox1"
        Me.btnLimpiaBox1.Size = New System.Drawing.Size(56, 24)
        Me.btnLimpiaBox1.TabIndex = 37
        Me.btnLimpiaBox1.Text = "Borrar"
        Me.btnLimpiaBox1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.56604!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.43396!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 532.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle3, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle4, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant4, 2, 4)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 23)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(831, 231)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 185)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 45)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "4"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 139)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 45)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "3"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 93)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 45)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "2"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 47)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 45)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(243, 1)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 45)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "CANT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(301, 1)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(517, 45)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "DETALLE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 1)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 45)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "PRENDA"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTablaPrenda4
        '
        Me.txtTablaPrenda4.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda4.Location = New System.Drawing.Point(31, 189)
        Me.txtTablaPrenda4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaPrenda4.Multiline = True
        Me.txtTablaPrenda4.Name = "txtTablaPrenda4"
        Me.txtTablaPrenda4.Size = New System.Drawing.Size(203, 37)
        Me.txtTablaPrenda4.TabIndex = 18
        '
        'txtTablaPrenda3
        '
        Me.txtTablaPrenda3.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda3.Location = New System.Drawing.Point(31, 143)
        Me.txtTablaPrenda3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaPrenda3.Multiline = True
        Me.txtTablaPrenda3.Name = "txtTablaPrenda3"
        Me.txtTablaPrenda3.Size = New System.Drawing.Size(203, 37)
        Me.txtTablaPrenda3.TabIndex = 14
        '
        'txtTablaPrenda2
        '
        Me.txtTablaPrenda2.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda2.Location = New System.Drawing.Point(31, 97)
        Me.txtTablaPrenda2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaPrenda2.Multiline = True
        Me.txtTablaPrenda2.Name = "txtTablaPrenda2"
        Me.txtTablaPrenda2.Size = New System.Drawing.Size(203, 37)
        Me.txtTablaPrenda2.TabIndex = 10
        '
        'txtTablaPrenda1
        '
        Me.txtTablaPrenda1.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda1.Location = New System.Drawing.Point(31, 51)
        Me.txtTablaPrenda1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaPrenda1.Multiline = True
        Me.txtTablaPrenda1.Name = "txtTablaPrenda1"
        Me.txtTablaPrenda1.Size = New System.Drawing.Size(203, 37)
        Me.txtTablaPrenda1.TabIndex = 6
        Me.txtTablaPrenda1.Text = "Toallas"
        '
        'txtTablaDetalle1
        '
        Me.txtTablaDetalle1.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle1.Enabled = False
        Me.txtTablaDetalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle1.Location = New System.Drawing.Point(301, 51)
        Me.txtTablaDetalle1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaDetalle1.Multiline = True
        Me.txtTablaDetalle1.Name = "txtTablaDetalle1"
        Me.txtTablaDetalle1.Size = New System.Drawing.Size(517, 37)
        Me.txtTablaDetalle1.TabIndex = 7
        '
        'txtTablaCant1
        '
        Me.txtTablaCant1.BackColor = System.Drawing.Color.White
        Me.txtTablaCant1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant1.Location = New System.Drawing.Point(243, 51)
        Me.txtTablaCant1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaCant1.Multiline = True
        Me.txtTablaCant1.Name = "txtTablaCant1"
        Me.txtTablaCant1.Size = New System.Drawing.Size(49, 21)
        Me.txtTablaCant1.TabIndex = 8
        Me.txtTablaCant1.Text = "20"
        Me.txtTablaCant1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaDetalle2
        '
        Me.txtTablaDetalle2.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle2.Enabled = False
        Me.txtTablaDetalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle2.Location = New System.Drawing.Point(301, 97)
        Me.txtTablaDetalle2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaDetalle2.Multiline = True
        Me.txtTablaDetalle2.Name = "txtTablaDetalle2"
        Me.txtTablaDetalle2.Size = New System.Drawing.Size(517, 37)
        Me.txtTablaDetalle2.TabIndex = 11
        '
        'txtTablaCant2
        '
        Me.txtTablaCant2.BackColor = System.Drawing.Color.White
        Me.txtTablaCant2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant2.Location = New System.Drawing.Point(243, 97)
        Me.txtTablaCant2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaCant2.Multiline = True
        Me.txtTablaCant2.Name = "txtTablaCant2"
        Me.txtTablaCant2.Size = New System.Drawing.Size(49, 21)
        Me.txtTablaCant2.TabIndex = 12
        Me.txtTablaCant2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaDetalle3
        '
        Me.txtTablaDetalle3.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle3.Enabled = False
        Me.txtTablaDetalle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle3.Location = New System.Drawing.Point(301, 143)
        Me.txtTablaDetalle3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaDetalle3.Multiline = True
        Me.txtTablaDetalle3.Name = "txtTablaDetalle3"
        Me.txtTablaDetalle3.Size = New System.Drawing.Size(517, 37)
        Me.txtTablaDetalle3.TabIndex = 15
        '
        'txtTablaCant3
        '
        Me.txtTablaCant3.BackColor = System.Drawing.Color.White
        Me.txtTablaCant3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant3.Location = New System.Drawing.Point(243, 143)
        Me.txtTablaCant3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaCant3.Multiline = True
        Me.txtTablaCant3.Name = "txtTablaCant3"
        Me.txtTablaCant3.Size = New System.Drawing.Size(49, 21)
        Me.txtTablaCant3.TabIndex = 16
        Me.txtTablaCant3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaDetalle4
        '
        Me.txtTablaDetalle4.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle4.Enabled = False
        Me.txtTablaDetalle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle4.Location = New System.Drawing.Point(301, 189)
        Me.txtTablaDetalle4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaDetalle4.Multiline = True
        Me.txtTablaDetalle4.Name = "txtTablaDetalle4"
        Me.txtTablaDetalle4.Size = New System.Drawing.Size(517, 37)
        Me.txtTablaDetalle4.TabIndex = 19
        '
        'txtTablaCant4
        '
        Me.txtTablaCant4.BackColor = System.Drawing.Color.White
        Me.txtTablaCant4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant4.Location = New System.Drawing.Point(243, 189)
        Me.txtTablaCant4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTablaCant4.Multiline = True
        Me.txtTablaCant4.Name = "txtTablaCant4"
        Me.txtTablaCant4.Size = New System.Drawing.Size(49, 22)
        Me.txtTablaCant4.TabIndex = 20
        Me.txtTablaCant4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(867, 219)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox4.TabIndex = 32
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(867, 173)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox3.TabIndex = 32
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(867, 127)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox2.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"|Decolorido| ", "|Roto| ", "|Botones| ", "|Picado| ", "|Mancahdo| ", "|Gastado| ", "|Brillo| ", "|Hilos Jalados| "})
        Me.ComboBox1.Location = New System.Drawing.Point(867, 81)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox1.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1083, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ToolStripSeparator1, Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.GrabarToolStripMenuItem.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(182, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(182, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1125, 57)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(13, 12)
        Me.DataGridView1.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 49)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Usuario : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "-"
        '
        'lblNotaId
        '
        Me.lblNotaId.AutoSize = True
        Me.lblNotaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaId.Location = New System.Drawing.Point(217, 18)
        Me.lblNotaId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotaId.Name = "lblNotaId"
        Me.lblNotaId.Size = New System.Drawing.Size(97, 29)
        Me.lblNotaId.TabIndex = 36
        Me.lblNotaId.Text = "000000"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stsHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 535)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1083, 25)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripStatusLabel1.Text = "Listo"
        '
        'stsHora
        '
        Me.stsHora.Name = "stsHora"
        Me.stsHora.Size = New System.Drawing.Size(1023, 20)
        Me.stsHora.Spring = True
        Me.stsHora.Text = "hora"
        Me.stsHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1083, 25)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.WindowsApplication1.My.Resources.Resources.File_02
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Nuevo"
        Me.ToolStripButton4.ToolTipText = "Nuevo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.Disc_01
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Grabar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.CP_09
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.WindowsApplication1.My.Resources.Resources.File_23
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.ToolTipText = "Vista Previa"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.WindowsApplication1.My.Resources.Resources.P_F_18
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Imprimir"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNotaId)
        Me.GroupBox1.Controls.Add(NotaLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(750, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 57)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(88, 71)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(67, 20)
        Me.lblUsuario.TabIndex = 42
        Me.lblUsuario.Text = "Usuario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1083, 560)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbRecepcion)
        Me.Controls.Add(Me.gbFechasHora)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1101, 605)
        Me.MinimumSize = New System.Drawing.Size(1101, 605)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lavanderia APRES"
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.gbFechasHora.ResumeLayout(False)
        Me.gbFechasHora.PerformLayout()
        Me.gbRecepcion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecep As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents gbDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbFechasHora As System.Windows.Forms.GroupBox
    Friend WithEvents gbRecepcion As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtTablaCant4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaDetalle4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaPrenda4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaCant3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaDetalle3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaPrenda3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaCant2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaDetalle2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaPrenda2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaCant1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTablaPrenda1 As System.Windows.Forms.TextBox
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTablaDetalle1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnLimpiaBox1 As System.Windows.Forms.Button
    Friend WithEvents btnLimpiaBox4 As System.Windows.Forms.Button
    Friend WithEvents btnLimpiaBox3 As System.Windows.Forms.Button
    Friend WithEvents btnLimpiaBox2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNotaId As System.Windows.Forms.Label
    Friend WithEvents GrabarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label

End Class
