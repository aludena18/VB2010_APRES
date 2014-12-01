Public Class Usuario

    Dim ruta As String
    Dim dni As String
    Dim obj As New Metodo


    Private Sub Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ruta = "..\ApresDB.mdb"
        Module1.miconexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ruta + ";Persist Security Info=False"
        miconexion.Open()
    End Sub

    Private Sub txtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57)
            Case Chr(8)
            Case Chr(13)
                identificar()
            Case Else
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub identificar()
        obj.UserDni = Me.txtDni.Text
        obj.Login(Module1.miconexion, Me.dgvTabla)
        If Me.dgvTabla.RowCount > 0 Then
            nombreUsuario = Me.dgvTabla.SelectedCells(1).Value.ToString
            Form1.Show()
        Else
            MessageBox.Show("Usuario invalido")
            Me.txtDni.Text = ""
            Me.txtDni.Focus()
        End If

    End Sub

End Class