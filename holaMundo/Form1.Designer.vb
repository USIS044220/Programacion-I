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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPRESAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteVentasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FINANZASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EMPRESAToolStripMenuItem, Me.INVENTARIOToolStripMenuItem, Me.COMPRASToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.FINANZASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EMPRESAToolStripMenuItem
        '
        Me.EMPRESAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ToolStripMenuItem4, Me.ClientesToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.ToolStripMenuItem3, Me.ProveedoresToolStripMenuItem})
        Me.EMPRESAToolStripMenuItem.Name = "EMPRESAToolStripMenuItem"
        Me.EMPRESAToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.EMPRESAToolStripMenuItem.Text = "EMPRESA"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Formulario de Empleados"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(228, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.holaMundo.My.Resources.Resources.client
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ClientesToolStripMenuItem.Text = "Formulario de Clientes"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(228, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.holaMundo.My.Resources.Resources.provider
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'INVENTARIOToolStripMenuItem
        '
        Me.INVENTARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ConsultaDeProductosToolStripMenuItem})
        Me.INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        Me.INVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.INVENTARIOToolStripMenuItem.Text = "INVENTARIO"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.holaMundo.My.Resources.Resources.products
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ConsultaDeProductosToolStripMenuItem
        '
        Me.ConsultaDeProductosToolStripMenuItem.Name = "ConsultaDeProductosToolStripMenuItem"
        Me.ConsultaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaDeProductosToolStripMenuItem.Text = "Consulta de Productos"
        '
        'COMPRASToolStripMenuItem
        '
        Me.COMPRASToolStripMenuItem.Name = "COMPRASToolStripMenuItem"
        Me.COMPRASToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.COMPRASToolStripMenuItem.Text = "COMPRAS"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.ReporteVentasPorClienteToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'ReporteVentasPorClienteToolStripMenuItem
        '
        Me.ReporteVentasPorClienteToolStripMenuItem.Name = "ReporteVentasPorClienteToolStripMenuItem"
        Me.ReporteVentasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ReporteVentasPorClienteToolStripMenuItem.Text = "Reporte ventas por cliente"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        '
        'FINANZASToolStripMenuItem
        '
        Me.FINANZASToolStripMenuItem.Name = "FINANZASToolStripMenuItem"
        Me.FINANZASToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FINANZASToolStripMenuItem.Text = "FINANZAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.holaMundo.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 412)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sistema de Inventario y Facturacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMPRESAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents COMPRASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteVentasPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FINANZASToolStripMenuItem As ToolStripMenuItem
End Class
