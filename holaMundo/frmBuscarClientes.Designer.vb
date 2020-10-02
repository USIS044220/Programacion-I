<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarClientes
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
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.grdBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCliente.Location = New System.Drawing.Point(70, 32)
        Me.txtBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(654, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Location = New System.Drawing.Point(15, 32)
        Me.lblBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarCliente.TabIndex = 1
        Me.lblBuscarCliente.Text = "BUSCAR:"
        '
        'grdBuscarCliente
        '
        Me.grdBuscarCliente.AllowUserToAddRows = False
        Me.grdBuscarCliente.AllowUserToDeleteRows = False
        Me.grdBuscarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email})
        Me.grdBuscarCliente.Location = New System.Drawing.Point(18, 73)
        Me.grdBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grdBuscarCliente.Name = "grdBuscarCliente"
        Me.grdBuscarCliente.ReadOnly = True
        Me.grdBuscarCliente.RowHeadersWidth = 102
        Me.grdBuscarCliente.RowTemplate.Height = 40
        Me.grdBuscarCliente.Size = New System.Drawing.Size(706, 385)
        Me.grdBuscarCliente.TabIndex = 2
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(366, 466)
        Me.btnSeleccionarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(236, 33)
        Me.btnSeleccionarCliente.TabIndex = 3
        Me.btnSeleccionarCliente.Text = "Seleccionar Cliente"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Location = New System.Drawing.Point(604, 466)
        Me.btnCancelarCliente.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelarCliente.TabIndex = 4
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "ID"
        Me.idCliente.MinimumWidth = 12
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        Me.idCliente.Width = 350
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.MinimumWidth = 12
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 12
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.MinimumWidth = 12
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 12
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 12
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'frmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 509)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnSeleccionarCliente)
        Me.Controls.Add(Me.grdBuscarCliente)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmBuscarClientes"
        Me.Text = "Busqueda de registro de clientes"
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents grdBuscarCliente As DataGridView
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
