﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBox
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
        Me.btnChbAceptar = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btnChbAceptar
        '
        Me.btnChbAceptar.Location = New System.Drawing.Point(156, 228)
        Me.btnChbAceptar.Name = "btnChbAceptar"
        Me.btnChbAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnChbAceptar.TabIndex = 8
        Me.btnChbAceptar.Text = "Aceptar"
        Me.btnChbAceptar.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Decolorido", "Roto", "Botones", "Picado", "Manchado", "Gastado", "Brillo", "Hilos Jalados"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 70)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(109, 124)
        Me.CheckedListBox1.TabIndex = 11
        '
        'CheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 263)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btnChbAceptar)
        Me.Name = "CheckBox"
        Me.Text = "CheckBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChbAceptar As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
