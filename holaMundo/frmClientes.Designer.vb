<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCliente = New System.Windows.Forms.Label()
        Me.btnUltimoCliente = New System.Windows.Forms.Button()
        Me.btnSiguienteCliente = New System.Windows.Forms.Button()
        Me.btnAnteriorCliente = New System.Windows.Forms.Button()
        Me.btnPrimeroCliente = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblEmailCliente)
        Me.grbDatos.Controls.Add(Me.txtEmailCliente)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.txtDireccionCliente)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtCodigoCliente)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(17, 14)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbDatos.Size = New System.Drawing.Size(587, 449)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Clientes"
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(15, 376)
        Me.lblEmailCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(58, 17)
        Me.lblEmailCliente.TabIndex = 10
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(121, 377)
        Me.txtEmailCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(333, 20)
        Me.txtEmailCliente.TabIndex = 9
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(15, 300)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(96, 17)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "TELEFONO:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(121, 301)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(111, 20)
        Me.txtTelefonoCliente.TabIndex = 7
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(15, 195)
        Me.lblDireccionCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(96, 17)
        Me.lblDireccionCliente.TabIndex = 6
        Me.lblDireccionCliente.Text = "DIRECCION:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(121, 154)
        Me.txtDireccionCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(333, 103)
        Me.txtDireccionCliente.TabIndex = 5
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(15, 94)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(79, 17)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(121, 95)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(333, 20)
        Me.txtNombreCliente.TabIndex = 3
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(121, 36)
        Me.txtCodigoCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(15, 35)
        Me.lblCodigoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(74, 17)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "CODIGO:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCliente)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCliente)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCliente)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCliente)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCliente)
        Me.grbNavegacion.Location = New System.Drawing.Point(17, 472)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCliente
        '
        Me.lblRegistrosCliente.AutoSize = True
        Me.lblRegistrosCliente.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCliente.Name = "lblRegistrosCliente"
        Me.lblRegistrosCliente.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosCliente.TabIndex = 4
        Me.lblRegistrosCliente.Text = "x de n"
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoCliente.TabIndex = 3
        Me.btnUltimoCliente.Text = ">|"
        Me.btnUltimoCliente.UseVisualStyleBackColor = True
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteCliente.TabIndex = 2
        Me.btnSiguienteCliente.Text = ">"
        Me.btnSiguienteCliente.UseVisualStyleBackColor = True
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.Text = "<"
        Me.btnAnteriorCliente.UseVisualStyleBackColor = True
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroCliente.TabIndex = 0
        Me.btnPrimeroCliente.Text = "|<"
        Me.btnPrimeroCliente.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarCliente)
        Me.grbEdicion.Controls.Add(Me.btnEliminarCliente)
        Me.grbEdicion.Controls.Add(Me.btnModificarCliente)
        Me.grbEdicion.Controls.Add(Me.btnAgregarCliente)
        Me.grbEdicion.Location = New System.Drawing.Point(289, 472)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarCliente.TabIndex = 8
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarCliente.TabIndex = 7
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarCliente.TabIndex = 6
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarCliente.TabIndex = 5
        Me.btnAgregarCliente.Text = "Nuevo"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 562)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmClientes"
        Me.Text = "Registro de Clientes"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents lblCodigoCliente As Label
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblRegistrosCliente As Label
    Friend WithEvents btnUltimoCliente As Button
    Friend WithEvents btnSiguienteCliente As Button
    Friend WithEvents btnAnteriorCliente As Button
    Friend WithEvents btnPrimeroCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
End Class
