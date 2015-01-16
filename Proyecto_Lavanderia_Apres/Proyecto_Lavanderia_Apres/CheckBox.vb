Public Class CheckBox
    Dim cadenaDetalle As String
    Dim obj As New Metodo
    Dim indDetalle As Integer

    Private Sub CheckBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblCheckBoxList.Text = objetoPublico.LabelCheckBox
        indDetalle = objetoPublico.IndiceDetalle
    End Sub

    Private Sub btnChbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChbAceptar.Click
        Dim indice As Integer
        Dim lenCadena As Integer

        cadenaDetalle = ""
        
        For indice = 0 To Me.CheckedListBox1.Items.Count - 1
            If Me.CheckedListBox1.GetItemCheckState(indice) Then
                Select Case Me.CheckedListBox1.GetItemChecked(indice)
                    Case indice = 0
                        cadenaDetalle = cadenaDetalle + "Decolorido, "
                    Case indice = 1
                        cadenaDetalle = cadenaDetalle + "Roto, "
                    Case indice = 2
                        cadenaDetalle = cadenaDetalle + "Botones, "
                    Case indice = 3
                        cadenaDetalle = cadenaDetalle + "Picado, "
                    Case indice = 4
                        cadenaDetalle = cadenaDetalle + "Mancahdo, "
                    Case indice = 5
                        cadenaDetalle = cadenaDetalle + "Gastado, "
                    Case indice = 6
                        cadenaDetalle = cadenaDetalle + "Brillo, "
                    Case indice = 7
                        cadenaDetalle = cadenaDetalle + "Hilos Jalados, "
                    Case Else
                        cadenaDetalle = cadenaDetalle.Trim
                End Select
            End If
        Next
        lenCadena = Len(cadenaDetalle) - 2
        'MessageBox.Show(cadenaDetalle)
        Select Case indDetalle
            Case 1
                Form1.txtTablaDetalle1.Text = RSet(cadenaDetalle, lenCadena)
            Case 2
                Form1.txtTablaDetalle2.Text = RSet(cadenaDetalle, lenCadena)
            Case 3
                Form1.txtTablaDetalle3.Text = RSet(cadenaDetalle, lenCadena)
            Case 4
                Form1.txtTablaDetalle4.Text = RSet(cadenaDetalle, lenCadena)
        End Select

        Me.Close()


    End Sub
End Class