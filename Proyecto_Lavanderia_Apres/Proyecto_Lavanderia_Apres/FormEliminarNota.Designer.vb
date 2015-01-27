<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarNota
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
        Me.txtEliminarNota = New System.Windows.Forms.TextBox()
        Me.btnEliminarNota = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtEliminarSerie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEliminarNota
        '
        Me.txtEliminarNota.Location = New System.Drawing.Point(162, 37)
        Me.txtEliminarNota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminarNota.Name = "txtEliminarNota"
        Me.txtEliminarNota.Size = New System.Drawing.Size(103, 22)
        Me.txtEliminarNota.TabIndex = 3
        Me.txtEliminarNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEliminarNota
        '
        Me.btnEliminarNota.Location = New System.Drawing.Point(306, 34)
        Me.btnEliminarNota.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarNota.Name = "btnEliminarNota"
        Me.btnEliminarNota.Size = New System.Drawing.Size(70, 28)
        Me.btnEliminarNota.TabIndex = 1
        Me.btnEliminarNota.Text = "Eliminar"
        Me.btnEliminarNota.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEliminarSerie)
        Me.GroupBox1.Controls.Add(Me.btnEliminarNota)
        Me.GroupBox1.Controls.Add(Me.txtEliminarNota)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(398, 92)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Número de Nota de Recepción"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(437, 66)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(27, 25)
        Me.DataGridView1.TabIndex = 3
        '
        'txtEliminarSerie
        '
        Me.txtEliminarSerie.Location = New System.Drawing.Point(71, 37)
        Me.txtEliminarSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminarSerie.Name = "txtEliminarSerie"
        Me.txtEliminarSerie.Size = New System.Drawing.Size(64, 22)
        Me.txtEliminarSerie.TabIndex = 2
        Me.txtEliminarSerie.Text = "000"
        Me.txtEliminarSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "-"
        '
        'FormEliminarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 126)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEliminarNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Nota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEliminarNota As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarNota As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEliminarSerie As System.Windows.Forms.TextBox
End Class
