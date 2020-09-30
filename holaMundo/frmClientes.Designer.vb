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
        Me.grbDatos.Location = New System.Drawing.Point(45, 34)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(1513, 1070)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Clientes"
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(39, 897)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(135, 39)
        Me.lblEmailCliente.TabIndex = 10
        Me.lblEmailCliente.Text = "EMAIL:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(291, 899)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(881, 38)
        Me.txtEmailCliente.TabIndex = 9
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(39, 716)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(219, 39)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "TELEFONO:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(291, 718)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(289, 38)
        Me.txtTelefonoCliente.TabIndex = 7
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(39, 466)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(230, 39)
        Me.lblDireccionCliente.TabIndex = 6
        Me.lblDireccionCliente.Text = "DIRECCION:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(291, 368)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(881, 241)
        Me.txtDireccionCliente.TabIndex = 5
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(39, 225)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(183, 39)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(291, 227)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(881, 38)
        Me.txtNombreCliente.TabIndex = 3
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(291, 85)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(246, 38)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(39, 83)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(171, 39)
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
        Me.grbNavegacion.Location = New System.Drawing.Point(45, 1126)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(720, 162)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCliente
        '
        Me.lblRegistrosCliente.AutoSize = True
        Me.lblRegistrosCliente.Location = New System.Drawing.Point(228, 81)
        Me.lblRegistrosCliente.Name = "lblRegistrosCliente"
        Me.lblRegistrosCliente.Size = New System.Drawing.Size(91, 32)
        Me.lblRegistrosCliente.TabIndex = 4
        Me.lblRegistrosCliente.Text = "x de n"
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.Location = New System.Drawing.Point(604, 46)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(110, 93)
        Me.btnUltimoCliente.TabIndex = 3
        Me.btnUltimoCliente.Text = ">|"
        Me.btnUltimoCliente.UseVisualStyleBackColor = True
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(498, 46)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(110, 93)
        Me.btnSiguienteCliente.TabIndex = 2
        Me.btnSiguienteCliente.Text = ">"
        Me.btnSiguienteCliente.UseVisualStyleBackColor = True
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(112, 46)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(110, 93)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.Text = "<"
        Me.btnAnteriorCliente.UseVisualStyleBackColor = True
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(6, 46)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(110, 93)
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
        Me.grbEdicion.Location = New System.Drawing.Point(771, 1126)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(787, 162)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Location = New System.Drawing.Point(597, 46)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(175, 93)
        Me.btnBuscarCliente.TabIndex = 8
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(396, 46)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(197, 93)
        Me.btnEliminarCliente.TabIndex = 7
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(174, 46)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(216, 93)
        Me.btnModificarCliente.TabIndex = 6
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(6, 46)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(163, 93)
        Me.btnAgregarCliente.TabIndex = 5
        Me.btnAgregarCliente.Text = "Nuevo"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1636, 1341)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
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
