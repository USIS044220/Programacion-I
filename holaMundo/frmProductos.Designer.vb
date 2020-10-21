<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosProducto = New System.Windows.Forms.Label()
        Me.btnUltimoProducto = New System.Windows.Forms.Button()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.btnAnteriorProducto = New System.Windows.Forms.Button()
        Me.btnPrimeroProducto = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.cboCategoriaProductos = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.lblMedidasProducto = New System.Windows.Forms.Label()
        Me.txtMedidasProducto = New System.Windows.Forms.TextBox()
        Me.lblMarcaProducto = New System.Windows.Forms.Label()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.lblDescripcionProducto = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.btnBuscarCategoriaProducto = New System.Windows.Forms.Button()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProducto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProducto)
        Me.grbEdicion.Controls.Add(Me.btnModificarProducto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProducto)
        Me.grbEdicion.Location = New System.Drawing.Point(282, 400)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarProducto.TabIndex = 8
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarProducto.TabIndex = 7
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarProducto.TabIndex = 6
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarProducto.TabIndex = 5
        Me.btnAgregarProducto.Text = "Nuevo"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosProducto)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProducto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProducto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProducto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProducto)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 400)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosProducto
        '
        Me.lblRegistrosProducto.AutoSize = True
        Me.lblRegistrosProducto.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosProducto.Name = "lblRegistrosProducto"
        Me.lblRegistrosProducto.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosProducto.TabIndex = 4
        Me.lblRegistrosProducto.Text = "x de n"
        '
        'btnUltimoProducto
        '
        Me.btnUltimoProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProducto.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoProducto.Name = "btnUltimoProducto"
        Me.btnUltimoProducto.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoProducto.TabIndex = 3
        Me.btnUltimoProducto.Text = ">|"
        Me.btnUltimoProducto.UseVisualStyleBackColor = True
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteProducto.TabIndex = 2
        Me.btnSiguienteProducto.Text = ">"
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'btnAnteriorProducto
        '
        Me.btnAnteriorProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProducto.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorProducto.Name = "btnAnteriorProducto"
        Me.btnAnteriorProducto.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorProducto.TabIndex = 1
        Me.btnAnteriorProducto.Text = "<"
        Me.btnAnteriorProducto.UseVisualStyleBackColor = True
        '
        'btnPrimeroProducto
        '
        Me.btnPrimeroProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProducto.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroProducto.Name = "btnPrimeroProducto"
        Me.btnPrimeroProducto.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroProducto.TabIndex = 0
        Me.btnPrimeroProducto.Text = "|<"
        Me.btnPrimeroProducto.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.btnBuscarCategoriaProducto)
        Me.grbDatos.Controls.Add(Me.cboCategoriaProductos)
        Me.grbDatos.Controls.Add(Me.lblCategoriaProducto)
        Me.grbDatos.Controls.Add(Me.lblMedidasProducto)
        Me.grbDatos.Controls.Add(Me.txtMedidasProducto)
        Me.grbDatos.Controls.Add(Me.lblMarcaProducto)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.lblDescripcionProducto)
        Me.grbDatos.Controls.Add(Me.txtDescripcionProducto)
        Me.grbDatos.Controls.Add(Me.txtCodigoProducto)
        Me.grbDatos.Controls.Add(Me.lblCodigoProducto)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(10, 21)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(587, 377)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'cboCategoriaProductos
        '
        Me.cboCategoriaProductos.FormattingEnabled = True
        Me.cboCategoriaProductos.Location = New System.Drawing.Point(141, 51)
        Me.cboCategoriaProductos.Name = "cboCategoriaProductos"
        Me.cboCategoriaProductos.Size = New System.Drawing.Size(191, 21)
        Me.cboCategoriaProductos.TabIndex = 10
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(23, 55)
        Me.lblCategoriaProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(102, 17)
        Me.lblCategoriaProducto.TabIndex = 9
        Me.lblCategoriaProducto.Text = "CATEGORIA:"
        '
        'lblMedidasProducto
        '
        Me.lblMedidasProducto.AutoSize = True
        Me.lblMedidasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasProducto.Location = New System.Drawing.Point(23, 301)
        Me.lblMedidasProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMedidasProducto.Name = "lblMedidasProducto"
        Me.lblMedidasProducto.Size = New System.Drawing.Size(81, 17)
        Me.lblMedidasProducto.TabIndex = 8
        Me.lblMedidasProducto.Text = "MEDIDAS:"
        '
        'txtMedidasProducto
        '
        Me.txtMedidasProducto.Location = New System.Drawing.Point(141, 301)
        Me.txtMedidasProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMedidasProducto.Name = "txtMedidasProducto"
        Me.txtMedidasProducto.Size = New System.Drawing.Size(191, 20)
        Me.txtMedidasProducto.TabIndex = 7
        '
        'lblMarcaProducto
        '
        Me.lblMarcaProducto.AutoSize = True
        Me.lblMarcaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaProducto.Location = New System.Drawing.Point(23, 243)
        Me.lblMarcaProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMarcaProducto.Name = "lblMarcaProducto"
        Me.lblMarcaProducto.Size = New System.Drawing.Size(66, 17)
        Me.lblMarcaProducto.TabIndex = 6
        Me.lblMarcaProducto.Text = "MARCA:"
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(141, 240)
        Me.txtMarcaProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(191, 20)
        Me.txtMarcaProducto.TabIndex = 5
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.AutoSize = True
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(23, 180)
        Me.lblDescripcionProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(116, 17)
        Me.lblDescripcionProducto.TabIndex = 4
        Me.lblDescripcionProducto.Text = "DESCRIPCION:"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(141, 179)
        Me.txtDescripcionProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(333, 20)
        Me.txtDescripcionProducto.TabIndex = 3
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(141, 121)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoProducto.TabIndex = 1
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(23, 121)
        Me.lblCodigoProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(74, 17)
        Me.lblCodigoProducto.TabIndex = 0
        Me.lblCodigoProducto.Text = "CODIGO:"
        '
        'btnBuscarCategoriaProducto
        '
        Me.btnBuscarCategoriaProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCategoriaProducto.Location = New System.Drawing.Point(336, 48)
        Me.btnBuscarCategoriaProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarCategoriaProducto.Name = "btnBuscarCategoriaProducto"
        Me.btnBuscarCategoriaProducto.Size = New System.Drawing.Size(157, 29)
        Me.btnBuscarCategoriaProducto.TabIndex = 12
        Me.btnBuscarCategoriaProducto.Text = "Buscar Categoria"
        Me.btnBuscarCategoriaProducto.UseVisualStyleBackColor = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 480)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmProductos"
        Me.Text = "Mantenimiento de Productos"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosProducto As Label
    Friend WithEvents btnUltimoProducto As Button
    Friend WithEvents btnSiguienteProducto As Button
    Friend WithEvents btnAnteriorProducto As Button
    Friend WithEvents btnPrimeroProducto As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents cboCategoriaProductos As ComboBox
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents lblMedidasProducto As Label
    Friend WithEvents txtMedidasProducto As TextBox
    Friend WithEvents lblMarcaProducto As Label
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents lblDescripcionProducto As Label
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents btnBuscarCategoriaProducto As Button
End Class
