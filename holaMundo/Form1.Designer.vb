<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.lblInteresSimple = New System.Windows.Forms.Label()
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(147, 161)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(148, 47)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(29, 52)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(42, 13)
        Me.lblcapital.TabIndex = 1
        Me.lblcapital.Text = "Capital:"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(74, 49)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(102, 20)
        Me.txtcapital.TabIndex = 2
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(226, 49)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(55, 20)
        Me.txtinteres.TabIndex = 4
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(181, 52)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(42, 13)
        Me.lblinteres.TabIndex = 3
        Me.lblinteres.Text = "Interes:"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(373, 49)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(49, 20)
        Me.txtTiempo.TabIndex = 6
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(289, 52)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(78, 13)
        Me.lbltiempo.TabIndex = 5
        Me.lbltiempo.Text = "Tiempo (Años):"
        '
        'lblInteresSimple
        '
        Me.lblInteresSimple.AutoSize = True
        Me.lblInteresSimple.Location = New System.Drawing.Point(60, 106)
        Me.lblInteresSimple.Name = "lblInteresSimple"
        Me.lblInteresSimple.Size = New System.Drawing.Size(85, 13)
        Me.lblInteresSimple.TabIndex = 7
        Me.lblInteresSimple.Text = "Interes Simple: ?"
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(261, 106)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(107, 13)
        Me.lblinteresCompuesto.TabIndex = 8
        Me.lblinteresCompuesto.Text = "Interes Compuesto: ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 253)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.lblInteresSimple)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.lblcapital)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblcapital As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents lblinteres As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lbltiempo As Label
    Friend WithEvents lblInteresSimple As Label
    Friend WithEvents lblinteresCompuesto As Label
End Class
