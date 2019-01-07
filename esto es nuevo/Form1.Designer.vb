<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnigual = New System.Windows.Forms.Button()
        Me.btnmayor = New System.Windows.Forms.Button()
        Me.btnigualomenor = New System.Windows.Forms.Button()
        Me.btnigualomayor = New System.Windows.Forms.Button()
        Me.btndiferente = New System.Windows.Forms.Button()
        Me.btnmenor = New System.Windows.Forms.Button()
        Me.texto1 = New System.Windows.Forms.TextBox()
        Me.texto2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnigual
        '
        Me.btnigual.Location = New System.Drawing.Point(264, 172)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(123, 51)
        Me.btnigual.TabIndex = 0
        Me.btnigual.Text = "Comprobar si es igual"
        Me.btnigual.UseVisualStyleBackColor = True
        '
        'btnmayor
        '
        Me.btnmayor.Location = New System.Drawing.Point(264, 263)
        Me.btnmayor.Name = "btnmayor"
        Me.btnmayor.Size = New System.Drawing.Size(123, 51)
        Me.btnmayor.TabIndex = 1
        Me.btnmayor.Text = "Comprobar si es mayor"
        Me.btnmayor.UseVisualStyleBackColor = True
        '
        'btnigualomenor
        '
        Me.btnigualomenor.Location = New System.Drawing.Point(541, 172)
        Me.btnigualomenor.Name = "btnigualomenor"
        Me.btnigualomenor.Size = New System.Drawing.Size(121, 51)
        Me.btnigualomenor.TabIndex = 2
        Me.btnigualomenor.Text = "Igual o Menor"
        Me.btnigualomenor.UseVisualStyleBackColor = True
        '
        'btnigualomayor
        '
        Me.btnigualomayor.Location = New System.Drawing.Point(540, 263)
        Me.btnigualomayor.Name = "btnigualomayor"
        Me.btnigualomayor.Size = New System.Drawing.Size(122, 51)
        Me.btnigualomayor.TabIndex = 3
        Me.btnigualomayor.Text = "Igual o mayor"
        Me.btnigualomayor.UseVisualStyleBackColor = True
        '
        'btndiferente
        '
        Me.btndiferente.Location = New System.Drawing.Point(540, 367)
        Me.btndiferente.Name = "btndiferente"
        Me.btndiferente.Size = New System.Drawing.Size(122, 51)
        Me.btndiferente.TabIndex = 4
        Me.btndiferente.Text = "Diferente"
        Me.btndiferente.UseVisualStyleBackColor = True
        '
        'btnmenor
        '
        Me.btnmenor.Location = New System.Drawing.Point(264, 367)
        Me.btnmenor.Name = "btnmenor"
        Me.btnmenor.Size = New System.Drawing.Size(123, 51)
        Me.btnmenor.TabIndex = 5
        Me.btnmenor.Text = "Comprobar si es menor"
        Me.btnmenor.UseVisualStyleBackColor = True
        '
        'texto1
        '
        Me.texto1.Location = New System.Drawing.Point(264, 59)
        Me.texto1.Multiline = True
        Me.texto1.Name = "texto1"
        Me.texto1.Size = New System.Drawing.Size(169, 36)
        Me.texto1.TabIndex = 7
        '
        'texto2
        '
        Me.texto2.Location = New System.Drawing.Point(493, 59)
        Me.texto2.Multiline = True
        Me.texto2.Name = "texto2"
        Me.texto2.Size = New System.Drawing.Size(169, 36)
        Me.texto2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese Numero 1 "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(490, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ingrese numero 2"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Mistral", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 9)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 542)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.texto2)
        Me.Controls.Add(Me.texto1)
        Me.Controls.Add(Me.btnmenor)
        Me.Controls.Add(Me.btndiferente)
        Me.Controls.Add(Me.btnigualomayor)
        Me.Controls.Add(Me.btnigualomenor)
        Me.Controls.Add(Me.btnmayor)
        Me.Controls.Add(Me.btnigual)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnigual As Button
    Friend WithEvents btnmayor As Button
    Friend WithEvents btnigualomenor As Button
    Friend WithEvents btnigualomayor As Button
    Friend WithEvents btndiferente As Button
    Friend WithEvents btnmenor As Button
    Friend WithEvents texto1 As TextBox
    Friend WithEvents texto2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents DateTimePicker1 As DateTimePicker
End Class
