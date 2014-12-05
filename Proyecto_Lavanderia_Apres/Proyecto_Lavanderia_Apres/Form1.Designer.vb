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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTablaDetalle1 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle2 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle3 = New System.Windows.Forms.TextBox()
        Me.txtTablaDetalle4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTablaPrenda1 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda2 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant2 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda3 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant3 = New System.Windows.Forms.TextBox()
        Me.txtTablaPrenda4 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant4 = New System.Windows.Forms.TextBox()
        Me.txtTablaCant1 = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'NotaLabel
        '
        NotaLabel.AutoSize = True
        NotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotaLabel.Location = New System.Drawing.Point(565, 60)
        NotaLabel.Name = "NotaLabel"
        NotaLabel.Size = New System.Drawing.Size(155, 13)
        NotaLabel.TabIndex = 27
        NotaLabel.Text = "NOTA DE RECEPCION N°"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sr(a).:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(78, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(297, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = "Abel Ludeña Gutierrez"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de recepción:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(78, 53)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(297, 20)
        Me.txtDireccion.TabIndex = 2
        Me.txtDireccion.Text = "Calle Andromeda Mz B Lt 1 Urb. Matellini - Chorrillos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de entrega:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora de entrega:"
        '
        'dtpFechaRecep
        '
        Me.dtpFechaRecep.Enabled = False
        Me.dtpFechaRecep.Location = New System.Drawing.Point(128, 27)
        Me.dtpFechaRecep.Name = "dtpFechaRecep"
        Me.dtpFechaRecep.Size = New System.Drawing.Size(218, 20)
        Me.dtpFechaRecep.TabIndex = 9
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(128, 53)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(218, 20)
        Me.dtpFechaEntrega.TabIndex = 10
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(128, 79)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(103, 20)
        Me.dtpHora.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telef.:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(78, 79)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 20)
        Me.txtTelefono.TabIndex = 3
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
        Me.gbDatosCliente.Location = New System.Drawing.Point(12, 118)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(400, 111)
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
        Me.gbFechasHora.Location = New System.Drawing.Point(434, 118)
        Me.gbFechasHora.Name = "gbFechasHora"
        Me.gbFechasHora.Size = New System.Drawing.Size(368, 111)
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
        Me.gbRecepcion.Location = New System.Drawing.Point(15, 260)
        Me.gbRecepcion.Name = "gbRecepcion"
        Me.gbRecepcion.Size = New System.Drawing.Size(790, 216)
        Me.gbRecepcion.TabIndex = 24
        Me.gbRecepcion.TabStop = False
        Me.gbRecepcion.Text = "RECEPCION"
        '
        'btnLimpiaBox4
        '
        Me.btnLimpiaBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox4.Location = New System.Drawing.Point(743, 173)
        Me.btnLimpiaBox4.Name = "btnLimpiaBox4"
        Me.btnLimpiaBox4.Size = New System.Drawing.Size(27, 20)
        Me.btnLimpiaBox4.TabIndex = 37
        Me.btnLimpiaBox4.Text = "..."
        Me.btnLimpiaBox4.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox3
        '
        Me.btnLimpiaBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox3.Location = New System.Drawing.Point(743, 136)
        Me.btnLimpiaBox3.Name = "btnLimpiaBox3"
        Me.btnLimpiaBox3.Size = New System.Drawing.Size(27, 20)
        Me.btnLimpiaBox3.TabIndex = 37
        Me.btnLimpiaBox3.Text = "..."
        Me.btnLimpiaBox3.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox2
        '
        Me.btnLimpiaBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox2.Location = New System.Drawing.Point(743, 101)
        Me.btnLimpiaBox2.Name = "btnLimpiaBox2"
        Me.btnLimpiaBox2.Size = New System.Drawing.Size(27, 20)
        Me.btnLimpiaBox2.TabIndex = 37
        Me.btnLimpiaBox2.Text = "..."
        Me.btnLimpiaBox2.UseVisualStyleBackColor = True
        '
        'btnLimpiaBox1
        '
        Me.btnLimpiaBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaBox1.Location = New System.Drawing.Point(743, 66)
        Me.btnLimpiaBox1.Name = "btnLimpiaBox1"
        Me.btnLimpiaBox1.Size = New System.Drawing.Size(27, 20)
        Me.btnLimpiaBox1.TabIndex = 37
        Me.btnLimpiaBox1.Text = "..."
        Me.btnLimpiaBox1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.56291!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.43709!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaDetalle4, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaPrenda4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTablaCant1, 0, 1)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 179)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(395, 34)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "DETALLE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTablaDetalle1
        '
        Me.txtTablaDetalle1.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle1.Enabled = False
        Me.txtTablaDetalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle1.Location = New System.Drawing.Point(317, 39)
        Me.txtTablaDetalle1.Multiline = True
        Me.txtTablaDetalle1.Name = "txtTablaDetalle1"
        Me.txtTablaDetalle1.Size = New System.Drawing.Size(395, 28)
        Me.txtTablaDetalle1.TabIndex = 7
        '
        'txtTablaDetalle2
        '
        Me.txtTablaDetalle2.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle2.Enabled = False
        Me.txtTablaDetalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle2.Location = New System.Drawing.Point(317, 74)
        Me.txtTablaDetalle2.Multiline = True
        Me.txtTablaDetalle2.Name = "txtTablaDetalle2"
        Me.txtTablaDetalle2.Size = New System.Drawing.Size(395, 28)
        Me.txtTablaDetalle2.TabIndex = 11
        '
        'txtTablaDetalle3
        '
        Me.txtTablaDetalle3.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle3.Enabled = False
        Me.txtTablaDetalle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle3.Location = New System.Drawing.Point(317, 109)
        Me.txtTablaDetalle3.Multiline = True
        Me.txtTablaDetalle3.Name = "txtTablaDetalle3"
        Me.txtTablaDetalle3.Size = New System.Drawing.Size(395, 28)
        Me.txtTablaDetalle3.TabIndex = 15
        '
        'txtTablaDetalle4
        '
        Me.txtTablaDetalle4.BackColor = System.Drawing.Color.White
        Me.txtTablaDetalle4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaDetalle4.Enabled = False
        Me.txtTablaDetalle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaDetalle4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaDetalle4.Location = New System.Drawing.Point(317, 144)
        Me.txtTablaDetalle4.Multiline = True
        Me.txtTablaDetalle4.Name = "txtTablaDetalle4"
        Me.txtTablaDetalle4.Size = New System.Drawing.Size(395, 31)
        Me.txtTablaDetalle4.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 34)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "PRENDA"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 34)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "CANT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTablaPrenda1
        '
        Me.txtTablaPrenda1.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda1.Location = New System.Drawing.Point(53, 39)
        Me.txtTablaPrenda1.Multiline = True
        Me.txtTablaPrenda1.Name = "txtTablaPrenda1"
        Me.txtTablaPrenda1.Size = New System.Drawing.Size(257, 28)
        Me.txtTablaPrenda1.TabIndex = 9
        Me.txtTablaPrenda1.Text = "Toallas"
        '
        'txtTablaPrenda2
        '
        Me.txtTablaPrenda2.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda2.Location = New System.Drawing.Point(53, 74)
        Me.txtTablaPrenda2.Multiline = True
        Me.txtTablaPrenda2.Name = "txtTablaPrenda2"
        Me.txtTablaPrenda2.Size = New System.Drawing.Size(257, 28)
        Me.txtTablaPrenda2.TabIndex = 11
        '
        'txtTablaCant2
        '
        Me.txtTablaCant2.BackColor = System.Drawing.Color.White
        Me.txtTablaCant2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant2.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant2.Location = New System.Drawing.Point(4, 74)
        Me.txtTablaCant2.Multiline = True
        Me.txtTablaCant2.Name = "txtTablaCant2"
        Me.txtTablaCant2.Size = New System.Drawing.Size(42, 28)
        Me.txtTablaCant2.TabIndex = 10
        Me.txtTablaCant2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaPrenda3
        '
        Me.txtTablaPrenda3.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda3.Location = New System.Drawing.Point(53, 109)
        Me.txtTablaPrenda3.Multiline = True
        Me.txtTablaPrenda3.Name = "txtTablaPrenda3"
        Me.txtTablaPrenda3.Size = New System.Drawing.Size(257, 28)
        Me.txtTablaPrenda3.TabIndex = 13
        '
        'txtTablaCant3
        '
        Me.txtTablaCant3.BackColor = System.Drawing.Color.White
        Me.txtTablaCant3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant3.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant3.Location = New System.Drawing.Point(4, 109)
        Me.txtTablaCant3.Multiline = True
        Me.txtTablaCant3.Name = "txtTablaCant3"
        Me.txtTablaCant3.Size = New System.Drawing.Size(42, 28)
        Me.txtTablaCant3.TabIndex = 12
        Me.txtTablaCant3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaPrenda4
        '
        Me.txtTablaPrenda4.BackColor = System.Drawing.Color.White
        Me.txtTablaPrenda4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaPrenda4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaPrenda4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaPrenda4.Location = New System.Drawing.Point(53, 144)
        Me.txtTablaPrenda4.Multiline = True
        Me.txtTablaPrenda4.Name = "txtTablaPrenda4"
        Me.txtTablaPrenda4.Size = New System.Drawing.Size(257, 31)
        Me.txtTablaPrenda4.TabIndex = 15
        '
        'txtTablaCant4
        '
        Me.txtTablaCant4.BackColor = System.Drawing.Color.White
        Me.txtTablaCant4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant4.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant4.Location = New System.Drawing.Point(4, 144)
        Me.txtTablaCant4.Multiline = True
        Me.txtTablaCant4.Name = "txtTablaCant4"
        Me.txtTablaCant4.Size = New System.Drawing.Size(42, 31)
        Me.txtTablaCant4.TabIndex = 14
        Me.txtTablaCant4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTablaCant1
        '
        Me.txtTablaCant1.BackColor = System.Drawing.Color.White
        Me.txtTablaCant1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTablaCant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCant1.ForeColor = System.Drawing.Color.Black
        Me.txtTablaCant1.Location = New System.Drawing.Point(4, 39)
        Me.txtTablaCant1.Multiline = True
        Me.txtTablaCant1.Name = "txtTablaCant1"
        Me.txtTablaCant1.Size = New System.Drawing.Size(42, 28)
        Me.txtTablaCant1.TabIndex = 8
        Me.txtTablaCant1.Text = "20"
        Me.txtTablaCant1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ToolStripSeparator1, Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GrabarToolStripMenuItem.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(844, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Usuario : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "-"
        '
        'lblNotaId
        '
        Me.lblNotaId.AutoSize = True
        Me.lblNotaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaId.Location = New System.Drawing.Point(726, 52)
        Me.lblNotaId.Name = "lblNotaId"
        Me.lblNotaId.Size = New System.Drawing.Size(76, 24)
        Me.lblNotaId.TabIndex = 36
        Me.lblNotaId.Text = "000000"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stsHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(814, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel1.Text = "Listo"
        '
        'stsHora
        '
        Me.stsHora.Name = "stsHora"
        Me.stsHora.Size = New System.Drawing.Size(767, 17)
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(814, 25)
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
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(66, 58)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 42
        Me.lblUsuario.Text = "Usuario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(814, 512)
        Me.Controls.Add(Me.lblNotaId)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(NotaLabel)
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
        Me.MaximumSize = New System.Drawing.Size(830, 550)
        Me.MinimumSize = New System.Drawing.Size(830, 550)
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblUsuario As System.Windows.Forms.Label

End Class
