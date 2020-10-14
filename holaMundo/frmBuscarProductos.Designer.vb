<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProductos
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
        Me.grdBuscarProducto = New System.Windows.Forms.DataGridView()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnSeleccionarProductos = New System.Windows.Forms.Button()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBuscarProducto
        '
        Me.grdBuscarProducto.AllowUserToAddRows = False
        Me.grdBuscarProducto.AllowUserToDeleteRows = False
        Me.grdBuscarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.idCategoria, Me.categoria, Me.codigo, Me.nombre, Me.marca, Me.medidas})
        Me.grdBuscarProducto.Location = New System.Drawing.Point(22, 60)
        Me.grdBuscarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarProducto.Name = "grdBuscarProducto"
        Me.grdBuscarProducto.ReadOnly = True
        Me.grdBuscarProducto.RowHeadersWidth = 102
        Me.grdBuscarProducto.RowTemplate.Height = 40
        Me.grdBuscarProducto.Size = New System.Drawing.Size(721, 478)
        Me.grdBuscarProducto.TabIndex = 5
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Location = New System.Drawing.Point(19, 22)
        Me.lblBuscarProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarProducto.TabIndex = 4
        Me.lblBuscarProducto.Text = "BUSCAR:"
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProducto.Location = New System.Drawing.Point(74, 19)
        Me.txtBuscarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(669, 20)
        Me.txtBuscarProducto.TabIndex = 3
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(625, 540)
        Me.btnCancelarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelarProducto.TabIndex = 7
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProductos
        '
        Me.btnSeleccionarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProductos.Location = New System.Drawing.Point(387, 540)
        Me.btnSeleccionarProductos.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarProductos.Name = "btnSeleccionarProductos"
        Me.btnSeleccionarProductos.Size = New System.Drawing.Size(236, 33)
        Me.btnSeleccionarProductos.TabIndex = 6
        Me.btnSeleccionarProductos.Text = "Seleccionar Producto"
        Me.btnSeleccionarProductos.UseVisualStyleBackColor = True
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProducto"
        Me.idProducto.HeaderText = "ID"
        Me.idProducto.MinimumWidth = 12
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        Me.idProducto.Width = 350
        '
        'idCategoria
        '
        Me.idCategoria.DataPropertyName = "idCategoria"
        Me.idCategoria.HeaderText = "IDCAT"
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        Me.idCategoria.Visible = False
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "CATEGORIA"
        Me.categoria.MinimumWidth = 12
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
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
        Me.nombre.DataPropertyName = "descripcion"
        Me.nombre.HeaderText = "DESCRIPCION"
        Me.nombre.MinimumWidth = 12
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "MARCA"
        Me.marca.MinimumWidth = 12
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 150
        '
        'medidas
        '
        Me.medidas.DataPropertyName = "medidas"
        Me.medidas.HeaderText = "MEDIDAS"
        Me.medidas.MinimumWidth = 12
        Me.medidas.Name = "medidas"
        Me.medidas.ReadOnly = True
        '
        'frmBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 583)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarProductos)
        Me.Controls.Add(Me.grdBuscarProducto)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Controls.Add(Me.txtBuscarProducto)
        Me.Name = "frmBuscarProductos"
        Me.Text = "Busqueda de Productos"
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdBuscarProducto As DataGridView
    Friend WithEvents lblBuscarProducto As Label
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnSeleccionarProductos As Button
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents medidas As DataGridViewTextBoxColumn
End Class
