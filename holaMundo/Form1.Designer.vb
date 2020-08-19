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
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lbldesvtipica = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(32, 169)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(212, 42)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(69, 27)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(175, 20)
        Me.txtserie.TabIndex = 1
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(29, 30)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 2
        Me.lblserie.Text = "Serie:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(105, 70)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 3
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(105, 95)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaVarianza.TabIndex = 4
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(29, 70)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(39, 13)
        Me.lblMedia.TabIndex = 5
        Me.lblMedia.Text = "Media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(29, 95)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza:"
        '
        'lbldesvtipica
        '
        Me.lbldesvtipica.AutoSize = True
        Me.lbldesvtipica.Location = New System.Drawing.Point(29, 124)
        Me.lbldesvtipica.Name = "lbldesvtipica"
        Me.lbldesvtipica.Size = New System.Drawing.Size(70, 13)
        Me.lbldesvtipica.TabIndex = 7
        Me.lbldesvtipica.Text = "Desv. Tipica:"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(105, 124)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 8
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 232)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lbldesvtipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Matrices y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblserie As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lbldesvtipica As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
End Class
