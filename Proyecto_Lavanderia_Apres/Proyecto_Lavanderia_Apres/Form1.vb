Imports System.Data.OleDb
Public Class Form1
    Dim vsql As String
    Dim obj As New Metodo
    Dim cuentaNota As Integer
    Dim detalleString1 As String
    Dim detalleString2 As String
    Dim detalleString3 As String
    Dim detalleString4 As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Usuario.Hide()

        obj.obtenerUltimoReg(Module1.miconexion, Me.DataGridView1)
        ultimoRegistro = Me.DataGridView1.CurrentCell.Value
        'MessageBox.Show(ultimoRegistro)
        cuentaNota = ultimoRegistro + 1
        Me.lblNotaId.Text = cuentaNota
        Me.lblUsuario.Text = nombreUsuario
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTablaCant1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTablaCant1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTablaCant2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTablaCant2.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTablaCant3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTablaCant3.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTablaCant4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTablaCant4.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Tabla.Show()
    End Sub

    Private Sub btnLimpiaBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiaBox1.Click
        objetoPublico.LabelCheckBox = "DETALLE 1"
        objetoPublico.IndiceDetalle = 1
        CheckBox.Show()
    End Sub

    Private Sub btnLimpiaBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiaBox2.Click
        objetoPublico.LabelCheckBox = "DETALLE 2"
        objetoPublico.IndiceDetalle = 2
        CheckBox.Show()
    End Sub

    Private Sub btnLimpiaBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiaBox3.Click
        objetoPublico.LabelCheckBox = "DETALLE 3"
        objetoPublico.IndiceDetalle = 3
        CheckBox.Show()
    End Sub

    Private Sub btnLimpiaBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiaBox4.Click
        objetoPublico.LabelCheckBox = "DETALLE 4"
        objetoPublico.IndiceDetalle = 4
        CheckBox.Show()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grabarDatos()
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarToolStripMenuItem.Click
        grabarDatos()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.lblNotaId.Text = cuentaNota
        Me.gbDatosCliente.Enabled = True
        Me.gbFechasHora.Enabled = True
        Me.gbRecepcion.Enabled = True
        limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Usuario.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        stsHora.Text = Now.ToLocalTime.ToString
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        grabarDatos()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Tabla.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.lblNotaId.Text = cuentaNota
        Me.gbDatosCliente.Enabled = True
        Me.gbFechasHora.Enabled = True
        Me.gbRecepcion.Enabled = True
        limpiar()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim VerdanaSmall As New Font("Calibri", 8, GraphicsUnit.Point)
        Dim VerdanaMedium As New Font("Calibri", 10, GraphicsUnit.Point)
        Dim VerdanaLarge As New Font("Calibri", 20, FontStyle.Bold)
        Dim Arial As New Font("Arial Black", 15, GraphicsUnit.Point)

        e.Graphics.DrawImage(Form2.PictureBox1.Image, 50, 50)
        e.Graphics.DrawString("INSERGE CORP. S.A. - LAVADO AL SECO, AL AGUA Y AL PESO", VerdanaSmall, Brushes.Black, 50, 115)
        e.Graphics.DrawString("Tlf:271-1229/666-8905 Planta:251-0634 Nextel:816*4088", VerdanaSmall, Brushes.Black, 50, 127)
        e.Graphics.DrawString("Av. Velasco Astete 2034 Tienda 26", VerdanaSmall, Brushes.Black, 50, 139)

        e.Graphics.DrawString("NOTA DE RECEPCION N° 00" + Me.lblNotaId.Text, VerdanaLarge, Brushes.Black, 470, 90)
        e.Graphics.DrawString("Fecha: " + Me.dtpFechaRecep.Text, VerdanaMedium, Brushes.Black, 470, 120)

        e.Graphics.DrawLine(Pens.Black, 50, 160, 812, 160)

        e.Graphics.DrawString("Cliente: " + Me.txtNombre.Text, VerdanaMedium, Brushes.Black, 50, 170)
        e.Graphics.DrawString("Dirección: " + Me.txtDireccion.Text, VerdanaMedium, Brushes.Black, 50, 190)
        e.Graphics.DrawString("Teléfono: " + Me.txtTelefono.Text, VerdanaMedium, Brushes.Black, 50, 210)
        e.Graphics.DrawString("Fecha de Entrega: " + Me.dtpFechaEntrega.Text, VerdanaMedium, Brushes.Black, 50, 230)

        e.Graphics.DrawRectangle(Pens.Black, 50, 270, 30, 30)   'ITEM
        e.Graphics.DrawRectangle(Pens.Black, 80, 270, 250, 30)  'PRENDA 
        e.Graphics.DrawRectangle(Pens.Black, 330, 270, 50, 30)  'CANTIDAD
        e.Graphics.DrawRectangle(Pens.Black, 380, 270, 430, 30) 'DETALLE

        e.Graphics.DrawRectangle(Pens.Black, 50, 300, 30, 30)   'ITEM
        e.Graphics.DrawRectangle(Pens.Black, 80, 300, 250, 30)  'PRENDA 
        e.Graphics.DrawRectangle(Pens.Black, 330, 300, 50, 30)  'CANTIDAD
        e.Graphics.DrawRectangle(Pens.Black, 380, 300, 430, 30) 'DETALLE

        e.Graphics.DrawRectangle(Pens.Black, 50, 330, 30, 30)   'ITEM
        e.Graphics.DrawRectangle(Pens.Black, 80, 330, 250, 30)  'PRENDA 
        e.Graphics.DrawRectangle(Pens.Black, 330, 330, 50, 30)  'CANTIDAD
        e.Graphics.DrawRectangle(Pens.Black, 380, 330, 430, 30) 'DETALLE

        e.Graphics.DrawRectangle(Pens.Black, 50, 360, 30, 30)   'ITEM
        e.Graphics.DrawRectangle(Pens.Black, 80, 360, 250, 30)  'PRENDA 
        e.Graphics.DrawRectangle(Pens.Black, 330, 360, 50, 30)  'CANTIDAD
        e.Graphics.DrawRectangle(Pens.Black, 380, 360, 430, 30) 'DETALLE

        e.Graphics.DrawRectangle(Pens.Black, 50, 390, 30, 30)   'ITEM
        e.Graphics.DrawRectangle(Pens.Black, 80, 390, 250, 30)  'PRENDA 
        e.Graphics.DrawRectangle(Pens.Black, 330, 390, 50, 30)  'CANTIDAD
        e.Graphics.DrawRectangle(Pens.Black, 380, 390, 430, 30) 'DETALLE

        e.Graphics.DrawString("PRENDAS", VerdanaMedium, Brushes.Black, 160, 275)
        e.Graphics.DrawString("CANT", VerdanaMedium, Brushes.Black, 330, 275)
        e.Graphics.DrawString("DETALLE", VerdanaMedium, Brushes.Black, 560, 275)

        e.Graphics.DrawString("1", VerdanaMedium, Brushes.Black, 60, 305)
        e.Graphics.DrawString("2", VerdanaMedium, Brushes.Black, 60, 335)
        e.Graphics.DrawString("3", VerdanaMedium, Brushes.Black, 60, 365)
        e.Graphics.DrawString("4", VerdanaMedium, Brushes.Black, 60, 395)

        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 85, 305)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 85, 335)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 85, 365)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 85, 395)

        e.Graphics.DrawString(Me.txtTablaCant1.Text, VerdanaMedium, Brushes.Black, 335, 305)
        e.Graphics.DrawString(Me.txtTablaCant1.Text, VerdanaMedium, Brushes.Black, 335, 335)
        e.Graphics.DrawString(Me.txtTablaCant1.Text, VerdanaMedium, Brushes.Black, 335, 365)
        e.Graphics.DrawString(Me.txtTablaCant1.Text, VerdanaMedium, Brushes.Black, 335, 395)

        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 385, 305)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 385, 335)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 385, 365)
        e.Graphics.DrawString(Me.txtTablaPrenda1.Text, VerdanaMedium, Brushes.Black, 385, 395)



        e.Graphics.DrawString("HORARIO DE ATENCION, DE LUNES A SABADO DE 9.00AM A 8.00PM", VerdanaMedium, Brushes.Black, 50, 425)



    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub grabarDatos()
        If Me.txtNombre.Text = "" Then
            MessageBox.Show("¡Debe ingresar el nombre del cliente!")
        ElseIf Me.txtDireccion.Text = "" Then
            MessageBox.Show("¡Debe ingresar una dirección!")
        ElseIf Me.txtTelefono.Text = "" Then
            MessageBox.Show("¡Debe ingresar un número telefónico!")
        ElseIf Me.txtTablaPrenda1.Text = "" Or Me.txtTablaCant1.Text = "" Then
            MessageBox.Show("¡Debe ingresar por lo menos una prenda y su cantidad!")
        Else
            obj.Id = Me.lblNotaId.Text
            obj.Nombre = Me.txtNombre.Text
            obj.Direccion = Me.txtDireccion.Text
            obj.Telefono = Me.txtTelefono.Text
            obj.Dni = "-"
            obj.Recepcion = Me.dtpFechaRecep.Text
            obj.Entrega = Me.dtpFechaEntrega.Text
            obj.Hora = Me.dtpHora.Text

            obj.Prenda1 = Me.txtTablaPrenda1.Text
            obj.Cantidad1 = Me.txtTablaCant1.Text
            obj.Detalle1 = Me.txtTablaDetalle1.Text

            obj.Prenda2 = Me.txtTablaPrenda2.Text
            obj.Cantidad2 = Me.txtTablaCant2.Text
            obj.Detalle2 = Me.txtTablaDetalle2.Text

            obj.Prenda3 = Me.txtTablaPrenda3.Text
            obj.Cantidad3 = Me.txtTablaCant3.Text
            obj.Detalle3 = Me.txtTablaDetalle3.Text

            obj.Prenda4 = Me.txtTablaPrenda4.Text
            obj.Cantidad4 = Me.txtTablaCant4.Text
            obj.Detalle4 = Me.txtTablaDetalle4.Text

            obj.Ingresar(Module1.miconexion)
            MessageBox.Show("Datos Grabados Correctamente.")
            cuentaNota = CInt(Me.lblNotaId.Text) + 1

            Me.gbDatosCliente.Enabled = False
            Me.gbFechasHora.Enabled = False
            Me.gbRecepcion.Enabled = False

        End If
    End Sub

    Private Sub limpiar()
        Me.txtNombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtTablaPrenda1.Text = ""
        Me.txtTablaPrenda2.Text = ""
        Me.txtTablaPrenda3.Text = ""
        Me.txtTablaPrenda4.Text = ""
        Me.txtTablaCant1.Text = ""
        Me.txtTablaCant2.Text = ""
        Me.txtTablaCant3.Text = ""
        Me.txtTablaCant4.Text = ""
        Me.txtTablaDetalle1.Text = ""
        Me.txtTablaDetalle2.Text = ""
        Me.txtTablaDetalle3.Text = ""
        Me.txtTablaDetalle4.Text = ""
        Me.txtNombre.Focus()
    End Sub

    
   
End Class
