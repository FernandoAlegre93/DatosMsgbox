<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbtn1 = New System.Windows.Forms.RadioButton()
        Me.rdbtn2 = New System.Windows.Forms.RadioButton()
        Me.cbx1 = New System.Windows.Forms.CheckBox()
        Me.cbx2 = New System.Windows.Forms.CheckBox()
        Me.cbx3 = New System.Windows.Forms.CheckBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Datetime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(235, 331)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(328, 331)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "F. Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sexo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Aficiones :"
        '
        'rdbtn1
        '
        Me.rdbtn1.AutoSize = True
        Me.rdbtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtn1.Location = New System.Drawing.Point(111, 161)
        Me.rdbtn1.Name = "rdbtn1"
        Me.rdbtn1.Size = New System.Drawing.Size(32, 17)
        Me.rdbtn1.TabIndex = 4
        Me.rdbtn1.TabStop = True
        Me.rdbtn1.Text = "F"
        Me.rdbtn1.UseVisualStyleBackColor = True
        '
        'rdbtn2
        '
        Me.rdbtn2.AutoSize = True
        Me.rdbtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtn2.Location = New System.Drawing.Point(111, 194)
        Me.rdbtn2.Name = "rdbtn2"
        Me.rdbtn2.Size = New System.Drawing.Size(35, 17)
        Me.rdbtn2.TabIndex = 5
        Me.rdbtn2.TabStop = True
        Me.rdbtn2.Text = "M"
        Me.rdbtn2.UseVisualStyleBackColor = True
        '
        'cbx1
        '
        Me.cbx1.AutoSize = True
        Me.cbx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx1.Location = New System.Drawing.Point(120, 247)
        Me.cbx1.Name = "cbx1"
        Me.cbx1.Size = New System.Drawing.Size(50, 17)
        Me.cbx1.TabIndex = 6
        Me.cbx1.Text = "Gym"
        Me.cbx1.UseVisualStyleBackColor = True
        '
        'cbx2
        '
        Me.cbx2.AutoSize = True
        Me.cbx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx2.Location = New System.Drawing.Point(120, 270)
        Me.cbx2.Name = "cbx2"
        Me.cbx2.Size = New System.Drawing.Size(47, 17)
        Me.cbx2.TabIndex = 7
        Me.cbx2.Text = "Box"
        Me.cbx2.UseVisualStyleBackColor = True
        '
        'cbx3
        '
        Me.cbx3.AutoSize = True
        Me.cbx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx3.Location = New System.Drawing.Point(120, 293)
        Me.cbx3.Name = "cbx3"
        Me.cbx3.Size = New System.Drawing.Size(75, 17)
        Me.cbx3.TabIndex = 8
        Me.cbx3.Text = "Spinning"
        Me.cbx3.UseVisualStyleBackColor = True
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(111, 63)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(285, 20)
        Me.txtApe.TabIndex = 2
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(111, 31)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(285, 20)
        Me.txtN.TabIndex = 1
        '
        'Datetime
        '
        Me.Datetime.Location = New System.Drawing.Point(111, 96)
        Me.Datetime.Name = "Datetime"
        Me.Datetime.Size = New System.Drawing.Size(285, 20)
        Me.Datetime.TabIndex = 3
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 362)
        Me.Controls.Add(Me.Datetime)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.cbx3)
        Me.Controls.Add(Me.cbx2)
        Me.Controls.Add(Me.cbx1)
        Me.Controls.Add(Me.rdbtn2)
        Me.Controls.Add(Me.rdbtn1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnReset)
        Me.Name = "Formulario"
        Me.Text = "Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbx1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents Datetime As System.Windows.Forms.DateTimePicker

End Class
