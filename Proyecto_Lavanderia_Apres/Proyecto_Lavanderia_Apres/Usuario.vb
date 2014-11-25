Public Class Usuario

    Dim ruta As String


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

        Form1.Show()
    End Sub

End Class