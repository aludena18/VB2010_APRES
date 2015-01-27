Imports System.Data.OleDb

Public Class FormEliminarNota
    Dim vsql As String
    Dim obj As New Metodo

    Private Sub btnEliminarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarNota.Click

        If Me.txtEliminarNota.Text = "" Then
            MessageBox.Show("Debe Ingresar un Número de Nota a Eliminar.")
        Else
            obj.Id = CInt(Me.txtEliminarSerie.Text.Trim).ToString + Me.txtEliminarNota.Text.Trim
            obj.BuscarNota(Module1.miconexion, Me.DataGridView1)
            If Me.DataGridView1.RowCount > 0 Then
                obj.Eliminar(Module1.miconexion)
                MessageBox.Show("Nota de Entrega Eliminada.")
                Me.Close()
            Else
                MessageBox.Show("No existe nota a eliminar.")
                Me.txtEliminarNota.Text = ""
                Me.txtEliminarNota.Focus()
            End If
        End If

    End Sub

    Private Sub txtEliminarNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEliminarNota.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

End Class