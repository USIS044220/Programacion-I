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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(267, 217)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(168, 44)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Mostrar Pares e impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(267, 12)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(168, 199)
        Me.lstEjercicios.TabIndex = 1
        '
        'btnParImpar
        '
        Me.btnParImpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParImpar.Location = New System.Drawing.Point(10, 161)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(75, 50)
        Me.btnParImpar.TabIndex = 2
        Me.btnParImpar.Text = "Par o Impar?"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(91, 70)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(79, 20)
        Me.txtnum.TabIndex = 3
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(38, 73)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(47, 13)
        Me.lblnum.TabIndex = 4
        Me.lblnum.Text = "Numero:"
        '
        'btnPrimo
        '
        Me.btnPrimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(85, 161)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(85, 50)
        Me.btnPrimo.TabIndex = 5
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(176, 161)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(85, 50)
        Me.btnCajero.TabIndex = 6
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 301)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicios con estructuras de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnParImpar As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents lblnum As Label
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
End Class
