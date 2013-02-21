Imports System.Data
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
            Call clientes()

        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub clientes()
        Try
            Dim cliente As New SqlClient.SqlDataAdapter("muestra_cliente", conexion)
            Dim lista As New Data.DataSet
            cliente.Fill(lista)
            tabla_cliente.DataSource = lista.Tables(0) ' datagrid
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        Try
            Dim cliente As New SqlClient.SqlDataAdapter("inserta_cliente " + id_cliente.Text.Trim + ",'" + nom_cliente.Text.Trim + "'," + tel_cliente.Text.Trim + ",'" + direccion.Text.Trim + "'", conexion)
            Dim lista As New Data.DataSet
            cliente.Fill(lista)
            Call clientes()
            limpiar()
            id_cliente.ReadOnly = True
            boton_eliminar.Enabled = True
            boton_modificar.Enabled = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub boton_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modificar.Click
        Try
            Dim cliente As New SqlClient.SqlDataAdapter("modifica_cliente " + id_cliente.Text.Trim + ",'" + nom_cliente.Text.Trim + "'," + tel_cliente.Text.Trim + ",'" + direccion.Text.Trim + "'", conexion)
            Dim lista As New Data.DataSet
            cliente.Fill(lista)
            Call clientes()
            limpiar()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub tabla_cliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabla_cliente.CellClick
        Try
            id_cliente.Text = Trim(tabla_cliente.Item(0, tabla_cliente.CurrentRow.Index).Value)
            nom_cliente.Text = Trim(tabla_cliente.Item(1, tabla_cliente.CurrentRow.Index).Value)
            tel_cliente.Text = Trim(tabla_cliente.Item(2, tabla_cliente.CurrentRow.Index).Value)
            direccion.Text = Trim(tabla_cliente.Item(3, tabla_cliente.CurrentRow.Index).Value)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        
    End Sub

    Private Sub boton_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_eliminar.Click
        Try
            Dim cliente As New SqlClient.SqlDataAdapter("elimina_cliente " + id_cliente.Text.Trim, conexion)
            Dim lista As New Data.DataSet
            cliente.Fill(lista)
            Call clientes()
            limpiar()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub limpiar()
        Try
            id_cliente.Text = ""
            nom_cliente.Text = ""
            direccion.Text = ""
            tel_cliente.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub boton_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_nuevo.Click
        Try
            id_cliente.ReadOnly = False
            boton_eliminar.Enabled = False
            boton_modificar.Enabled = False
        Catch ex As Exception

        End Try

    End Sub
End Class
