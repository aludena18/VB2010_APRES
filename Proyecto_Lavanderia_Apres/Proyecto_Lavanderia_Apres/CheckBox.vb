Public Class CheckBox
    Dim cadenaDetalle As String


    Private Sub CheckBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChbAceptar.Click
        Dim indice As Integer
        cadenaDetalle = ""
        
        For indice = 0 To Me.CheckedListBox1.Items.Count - 1
            If Me.CheckedListBox1.GetItemCheckState(indice) Then
                Select Case Me.CheckedListBox1.GetItemChecked(indice)
                    Case indice = 0
                        cadenaDetalle = cadenaDetalle + "|Decolorido| "
                    Case indice = 1
                        cadenaDetalle = cadenaDetalle + "|Roto| "
                    Case indice = 2
                        cadenaDetalle = cadenaDetalle + "|Botones| "
                    Case indice = 3
                        cadenaDetalle = cadenaDetalle + "|Picado|"
                    Case indice = 4
                        cadenaDetalle = cadenaDetalle + "|Mancahdo| "
                    Case indice = 5
                        cadenaDetalle = cadenaDetalle + "|Gastado| "
                    Case indice = 6
                        cadenaDetalle = cadenaDetalle + "|Brillo| "
                    Case indice = 7
                        cadenaDetalle = cadenaDetalle + "|Hilos Jalados| "
                    Case Else
                        cadenaDetalle = cadenaDetalle
                End Select
            End If
        Next

        MessageBox.Show(cadenaDetalle)

    End Sub
End Class