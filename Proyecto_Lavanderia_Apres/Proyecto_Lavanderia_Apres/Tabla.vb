Imports System.Data.OleDb

Public Class Tabla
    Dim vsql As String
    Dim obj As New Metodo

    Private Sub Tabla_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
    End Sub

    Private Sub Tabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
        Me.txtBuscarNota.Focus()
    End Sub

    Private Sub btnBuscarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNota.Click

        If Me.txtBuscarNota.Text = "" Then
            obj.CargarGrid(Module1.miconexion, Me.DataGridView1)
        Else
            obj.Id = Me.txtBuscarNota.Text
            obj.BuscarNota(Module1.miconexion, Me.DataGridView1)
            If Me.DataGridView1.RowCount > 0 Then
                'MessageBox.Show(Me.DataGridView1.RowCount.ToString)
                mensaje()
            Else
                MessageBox.Show("No existe registro de esta Nota de Entrega.")
            End If
        End If

        Me.txtBuscarNota.Text = ""
        Me.txtBuscarNota.Focus()

    End Sub

    Private Sub mensaje()
        MessageBox.Show("Nota de Entrega N°    :    " + Me.DataGridView1.SelectedCells(0).Value.ToString + vbCrLf +
                            vbCrLf +
                           "Cliente        :  " + Me.DataGridView1.SelectedCells(1).Value.ToString + vbCrLf +
                           "Dirección    :  " + Me.DataGridView1.SelectedCells(2).Value.ToString + vbCrLf +
                           "Teléfono     :  " + Me.DataGridView1.SelectedCells(3).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Fecha de Recepción   :  " + Me.DataGridView1.SelectedCells(5).Value.ToString + vbCrLf +
                           "Fecha de Entrega        :  " + Me.DataGridView1.SelectedCells(6).Value.ToString + vbCrLf +
                           "Hora de Entrega          :  " + Me.DataGridView1.SelectedCells(7).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Prenda 1      :  " + Me.DataGridView1.SelectedCells(8).Value.ToString + vbCrLf +
                           "Cantidad     :  " + Me.DataGridView1.SelectedCells(10).Value.ToString + vbCrLf +
                           "Detalle         :  " + Me.DataGridView1.SelectedCells(9).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Prenda 2      :  " + Me.DataGridView1.SelectedCells(11).Value.ToString + vbCrLf +
                           "Cantidad     :  " + Me.DataGridView1.SelectedCells(13).Value.ToString + vbCrLf +
                           "Detalle         :  " + Me.DataGridView1.SelectedCells(12).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Prenda 3      :  " + Me.DataGridView1.SelectedCells(14).Value.ToString + vbCrLf +
                           "Cantidad     :  " + Me.DataGridView1.SelectedCells(16).Value.ToString + vbCrLf +
                           "Detalle         :  " + Me.DataGridView1.SelectedCells(15).Value.ToString + vbCrLf +
                           vbCrLf +
                           "Prenda 4      :  " + Me.DataGridView1.SelectedCells(17).Value.ToString + vbCrLf +
                           "Cantidad     :  " + Me.DataGridView1.SelectedCells(19).Value.ToString + vbCrLf +
                           "Detalle         :  " + Me.DataGridView1.SelectedCells(18).Value.ToString + vbCrLf)
    End Sub

    
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        mensaje()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtBuscarNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNota.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub EliminarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarNotaToolStripMenuItem.Click
        FormEliminarNota.Show()
    End Sub

   
End Class