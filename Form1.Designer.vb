<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.id_cliente = New System.Windows.Forms.TextBox
        Me.nom_cliente = New System.Windows.Forms.TextBox
        Me.direccion = New System.Windows.Forms.TextBox
        Me.tel_cliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabla_cliente = New System.Windows.Forms.DataGridView
        Me.boton_guardar = New System.Windows.Forms.Button
        Me.boton_modificar = New System.Windows.Forms.Button
        Me.boton_eliminar = New System.Windows.Forms.Button
        Me.boton_nuevo = New System.Windows.Forms.Button
        CType(Me.tabla_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id_cliente
        '
        Me.id_cliente.Location = New System.Drawing.Point(348, 33)
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.ReadOnly = True
        Me.id_cliente.Size = New System.Drawing.Size(246, 20)
        Me.id_cliente.TabIndex = 0
        '
        'nom_cliente
        '
        Me.nom_cliente.Location = New System.Drawing.Point(348, 60)
        Me.nom_cliente.Name = "nom_cliente"
        Me.nom_cliente.Size = New System.Drawing.Size(246, 20)
        Me.nom_cliente.TabIndex = 1
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(348, 86)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(246, 20)
        Me.direccion.TabIndex = 2
        '
        'tel_cliente
        '
        Me.tel_cliente.Location = New System.Drawing.Point(348, 113)
        Me.tel_cliente.Name = "tel_cliente"
        Me.tel_cliente.Size = New System.Drawing.Size(246, 20)
        Me.tel_cliente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "id cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "nombre del cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "telefono"
        '
        'tabla_cliente
        '
        Me.tabla_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_cliente.Location = New System.Drawing.Point(139, 251)
        Me.tabla_cliente.Name = "tabla_cliente"
        Me.tabla_cliente.Size = New System.Drawing.Size(638, 150)
        Me.tabla_cliente.TabIndex = 8
        '
        'boton_guardar
        '
        Me.boton_guardar.Location = New System.Drawing.Point(230, 179)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(75, 23)
        Me.boton_guardar.TabIndex = 9
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'boton_modificar
        '
        Me.boton_modificar.Location = New System.Drawing.Point(348, 179)
        Me.boton_modificar.Name = "boton_modificar"
        Me.boton_modificar.Size = New System.Drawing.Size(75, 23)
        Me.boton_modificar.TabIndex = 10
        Me.boton_modificar.Text = "Modificar"
        Me.boton_modificar.UseVisualStyleBackColor = True
        '
        'boton_eliminar
        '
        Me.boton_eliminar.Location = New System.Drawing.Point(465, 179)
        Me.boton_eliminar.Name = "boton_eliminar"
        Me.boton_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.boton_eliminar.TabIndex = 11
        Me.boton_eliminar.Text = "Eliminar"
        Me.boton_eliminar.UseVisualStyleBackColor = True
        '
        'boton_nuevo
        '
        Me.boton_nuevo.Location = New System.Drawing.Point(139, 178)
        Me.boton_nuevo.Name = "boton_nuevo"
        Me.boton_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.boton_nuevo.TabIndex = 12
        Me.boton_nuevo.Text = "Nuevo"
        Me.boton_nuevo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 464)
        Me.Controls.Add(Me.boton_nuevo)
        Me.Controls.Add(Me.boton_eliminar)
        Me.Controls.Add(Me.boton_modificar)
        Me.Controls.Add(Me.boton_guardar)
        Me.Controls.Add(Me.tabla_cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tel_cliente)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.nom_cliente)
        Me.Controls.Add(Me.id_cliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tabla_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents nom_cliente As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents tel_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabla_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents boton_guardar As System.Windows.Forms.Button
    Friend WithEvents boton_modificar As System.Windows.Forms.Button
    Friend WithEvents boton_eliminar As System.Windows.Forms.Button
    Friend WithEvents boton_nuevo As System.Windows.Forms.Button

End Class
