<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCategoria = New System.Windows.Forms.Button()
        Me.btnEliminarCategoria = New System.Windows.Forms.Button()
        Me.btnModificarCategoria = New System.Windows.Forms.Button()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCategoria = New System.Windows.Forms.Label()
        Me.btnUltimoCategoria = New System.Windows.Forms.Button()
        Me.btnSiguienteCategoria = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnPrimeroCategoria = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblDescripcionCategoria = New System.Windows.Forms.Label()
        Me.txtDescripcionCategoria = New System.Windows.Forms.TextBox()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarCategoria)
        Me.grbEdicion.Controls.Add(Me.btnEliminarCategoria)
        Me.grbEdicion.Controls.Add(Me.btnModificarCategoria)
        Me.grbEdicion.Controls.Add(Me.btnAgregarCategoria)
        Me.grbEdicion.Location = New System.Drawing.Point(285, 119)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 8
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCategoria
        '
        Me.btnBuscarCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCategoria.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarCategoria.Name = "btnBuscarCategoria"
        Me.btnBuscarCategoria.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarCategoria.TabIndex = 8
        Me.btnBuscarCategoria.Text = "Buscar"
        Me.btnBuscarCategoria.UseVisualStyleBackColor = True
        '
        'btnEliminarCategoria
        '
        Me.btnEliminarCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCategoria.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarCategoria.Name = "btnEliminarCategoria"
        Me.btnEliminarCategoria.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarCategoria.TabIndex = 7
        Me.btnEliminarCategoria.Text = "Eliminar"
        Me.btnEliminarCategoria.UseVisualStyleBackColor = True
        '
        'btnModificarCategoria
        '
        Me.btnModificarCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCategoria.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarCategoria.Name = "btnModificarCategoria"
        Me.btnModificarCategoria.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarCategoria.TabIndex = 6
        Me.btnModificarCategoria.Text = "Modificar"
        Me.btnModificarCategoria.UseVisualStyleBackColor = True
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarCategoria.TabIndex = 5
        Me.btnAgregarCategoria.Text = "Nuevo"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacion.Location = New System.Drawing.Point(13, 119)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 7
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCategoria
        '
        Me.lblRegistrosCategoria.AutoSize = True
        Me.lblRegistrosCategoria.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosCategoria.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCategoria.Name = "lblRegistrosCategoria"
        Me.lblRegistrosCategoria.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosCategoria.TabIndex = 4
        Me.lblRegistrosCategoria.Text = "x de n"
        '
        'btnUltimoCategoria
        '
        Me.btnUltimoCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCategoria.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoCategoria.Name = "btnUltimoCategoria"
        Me.btnUltimoCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoCategoria.TabIndex = 3
        Me.btnUltimoCategoria.Text = ">|"
        Me.btnUltimoCategoria.UseVisualStyleBackColor = True
        '
        'btnSiguienteCategoria
        '
        Me.btnSiguienteCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCategoria.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteCategoria.Name = "btnSiguienteCategoria"
        Me.btnSiguienteCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteCategoria.TabIndex = 2
        Me.btnSiguienteCategoria.Text = ">"
        Me.btnSiguienteCategoria.UseVisualStyleBackColor = True
        '
        'btnAnteriorCategoria
        '
        Me.btnAnteriorCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCategoria.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorCategoria.Name = "btnAnteriorCategoria"
        Me.btnAnteriorCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorCategoria.TabIndex = 1
        Me.btnAnteriorCategoria.Text = "<"
        Me.btnAnteriorCategoria.UseVisualStyleBackColor = True
        '
        'btnPrimeroCategoria
        '
        Me.btnPrimeroCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCategoria.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroCategoria.Name = "btnPrimeroCategoria"
        Me.btnPrimeroCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroCategoria.TabIndex = 0
        Me.btnPrimeroCategoria.Text = "|<"
        Me.btnPrimeroCategoria.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblDescripcionCategoria)
        Me.grbDatos.Controls.Add(Me.txtDescripcionCategoria)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(12, 13)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(588, 95)
        Me.grbDatos.TabIndex = 6
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Categoria"
        '
        'lblDescripcionCategoria
        '
        Me.lblDescripcionCategoria.AutoSize = True
        Me.lblDescripcionCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCategoria.Location = New System.Drawing.Point(15, 43)
        Me.lblDescripcionCategoria.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionCategoria.Name = "lblDescripcionCategoria"
        Me.lblDescripcionCategoria.Size = New System.Drawing.Size(102, 17)
        Me.lblDescripcionCategoria.TabIndex = 4
        Me.lblDescripcionCategoria.Text = "CATEGORIA:"
        '
        'txtDescripcionCategoria
        '
        Me.txtDescripcionCategoria.Location = New System.Drawing.Point(133, 42)
        Me.txtDescripcionCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionCategoria.Name = "txtDescripcionCategoria"
        Me.txtDescripcionCategoria.Size = New System.Drawing.Size(333, 20)
        Me.txtDescripcionCategoria.TabIndex = 3
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 207)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmCategorias"
        Me.Text = "Registro de Categorias"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarCategoria As Button
    Friend WithEvents btnEliminarCategoria As Button
    Friend WithEvents btnModificarCategoria As Button
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCategoria As Label
    Friend WithEvents btnUltimoCategoria As Button
    Friend WithEvents btnSiguienteCategoria As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnPrimeroCategoria As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblDescripcionCategoria As Label
    Friend WithEvents txtDescripcionCategoria As TextBox
End Class
