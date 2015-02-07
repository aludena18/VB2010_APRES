Imports System.Data.OleDb

Public Class Tabla
    Dim vsql As String
    Dim obj As New Metodo
    Dim cadenaDni As String
    Dim cadenaNota As String

    Private Sub Tabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
        Me.txtBuscarDni.Focus()
    End Sub

    Private Sub txtBuscarNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNota.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        Else
            cadenaNota = Me.txtBuscarNota.Text.Trim + e.KeyChar
            If Strings.Right(cadenaNota, 1) = Chr(8).ToString And Me.txtBuscarNota.Text.Length > 0 Then
                cadenaNota = Strings.Left(cadenaNota, cadenaNota.Length - 2)
            End If

            If cadenaNota = Chr(8).ToString Then
                cadenaNota = ""
            End If

            Select Case cadenaNota.Length
                Case 0
                    obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
                Case 4
                    obj.Id = CInt(Me.txtBuscarSerie.Text.Trim + cadenaNota).ToString
                    obj.BuscarNota(Module1.miconexion, Me.DataGridView1)
                Case Else
                    obj.Id = "99999999"         'va buscar un registro que nunca va existir para no perder la vista de la tabla de la BD
                    obj.BuscarNota(Module1.miconexion, Me.DataGridView1)
            End Select
        End If
    End Sub

    Private Sub txtBuscarDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarDni.KeyPress

        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        Else
            cadenaDni = Me.txtBuscarDni.Text.Trim + e.KeyChar
            obj.Dni = cadenaDni.Trim
            obj.BuscarDni(Module1.miconexion, Me.DataGridView1)
            If cadenaDni = Chr(8).ToString Then
                obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
            End If
        End If

    End Sub

    Private Sub dtpBuscarFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBuscarFecha.ValueChanged
        obj.Recepcion = Me.dtpBuscarFecha.Text.Trim
        obj.BuscarFecha(Module1.miconexion, Me.DataGridView1)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        mensaje()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarNotaToolStripMenuItem.Click
        FormEliminarNota.Show()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        actualizar()
    End Sub

    Private Sub actualizar()
        Me.txtBuscarSerie.Text = "000"
        Me.txtBuscarNota.Text = ""
        Me.txtBuscarDni.Text = ""
        obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
    End Sub

    Private Sub mensaje()
        Dim mensaje As String
        Dim precioTotal As Integer

        mensaje = "Nota de Entrega N°: " + Me.DataGridView1.SelectedCells(1).Value.ToString + vbCrLf +
                            vbCrLf +
                           "Cliente: " + Me.DataGridView1.SelectedCells(2).Value.ToString + vbCrLf +
                           "Dirección: " + Me.DataGridView1.SelectedCells(3).Value.ToString + vbCrLf +
                           "Teléfono: " + Me.DataGridView1.SelectedCells(4).Value.ToString + vbCrLf +
                           "DNI: " + Me.DataGridView1.SelectedCells(5).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Fecha de Recepción : " + Me.DataGridView1.SelectedCells(6).Value.ToString + vbCrLf +
                           "Fecha de Entrega: " + Me.DataGridView1.SelectedCells(7).Value.ToString + vbCrLf +
                           "Hora de Entrega: " + Me.DataGridView1.SelectedCells(8).Value.ToString + vbCrLf +
                           vbCrLf

        If Me.DataGridView1.SelectedCells(9).Value.ToString.Trim <> "" Then
            mensaje = mensaje + "Prenda 1: " + Me.DataGridView1.SelectedCells(9).Value.ToString + vbCrLf +
                                "Cantidad: " + Me.DataGridView1.SelectedCells(11).Value.ToString + vbCrLf +
                                "Detalle: " + Me.DataGridView1.SelectedCells(10).Value.ToString + vbCrLf +
                                "Precio: S/. " + Me.DataGridView1.SelectedCells(12).Value.ToString + vbCrLf +
                                vbCrLf
        End If

        If Me.DataGridView1.SelectedCells(13).Value.ToString.Trim <> "" Then
            mensaje = mensaje + "Prenda 2: " + Me.DataGridView1.SelectedCells(13).Value.ToString + vbCrLf +
                                "Cantidad: " + Me.DataGridView1.SelectedCells(15).Value.ToString + vbCrLf +
                                "Detalle: " + Me.DataGridView1.SelectedCells(14).Value.ToString + vbCrLf +
                                "Precio: S/. " + Me.DataGridView1.SelectedCells(16).Value.ToString + vbCrLf +
                                vbCrLf
        End If

        If Me.DataGridView1.SelectedCells(17).Value.ToString.Trim <> "" Then
            mensaje = mensaje + "Prenda 3: " + Me.DataGridView1.SelectedCells(17).Value.ToString + vbCrLf +
                                "Cantidad: " + Me.DataGridView1.SelectedCells(19).Value.ToString + vbCrLf +
                                "Detalle: " + Me.DataGridView1.SelectedCells(18).Value.ToString + vbCrLf +
                                "Precio: S/. " + Me.DataGridView1.SelectedCells(20).Value.ToString + vbCrLf +
                                vbCrLf
        End If

        If Me.DataGridView1.SelectedCells(21).Value.ToString.Trim <> "" Then
            mensaje = mensaje + "Prenda 4: " + Me.DataGridView1.SelectedCells(21).Value.ToString + vbCrLf +
                                "Cantidad: " + Me.DataGridView1.SelectedCells(23).Value.ToString + vbCrLf +
                                "Detalle: " + Me.DataGridView1.SelectedCells(22).Value.ToString + vbCrLf +
                                "Precio: S/. " + Me.DataGridView1.SelectedCells(24).Value.ToString + vbCrLf +
                                vbCrLf
        End If

        mensaje = mensaje + "PRECIO TOTAL: S/. "
        MessageBox.Show(mensaje)
    End Sub

End Class