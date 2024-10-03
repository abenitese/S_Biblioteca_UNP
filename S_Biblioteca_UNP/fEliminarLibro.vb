Imports MySql.Data.MySqlClient

Public Class fEliminarLibro

    Dim connectionString As String = "server=127.0.0.1; database=bibliotecaunp; User=root;Password="
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarLibro(txtbuscar.Text)
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' Verificar que se haya seleccionado un registro en el DataGridView
        If dgvLibros.SelectedRows.Count > 0 Then
            Dim codigo As Integer = dgvLibros.SelectedRows(0).Cells("Cod_Libro").Value

            ' Confirmar eliminación
            Dim confirmacion = MessageBox.Show("¿Estás seguro de que deseas Eliminar Libro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                EliminarLibro(codigo)
            End If
        Else
            MessageBox.Show("Por favor, selecciona un registro para Eliminar.")
        End If
    End Sub
    Sub BuscarLibro(palabraBusqueda As String)
        Try
            connection.Close()
            connection.Open()
            Dim query = "SELECT Cod_Libro,Titulo,Autor,ISBN,Genero FROM libros WHERE Titulo LIKE @busqueda"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@busqueda", "%" & palabraBusqueda & "%")

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvLibros.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Sub EliminarLibro(codLibro As Integer)
        Try
            connection.Open()
            Dim query As String = "DELETE FROM libros WHERE Cod_Libro = @Cod_Libro"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Cod_Libro", codLibro)

            Dim resultado As Integer = command.ExecuteNonQuery()
            If resultado > 0 Then
                MessageBox.Show("Eliminacion realizada exitosamente.")
                BuscarLibro(txtbuscar.Text) ' Recargar los prestamos después de devolver
            Else
                MessageBox.Show("No se pudo Realizar la Eliminacion.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error al Realizar el Eliminacion: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub fEliminarLibro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dgvLibros.DataSource = Nothing
    End Sub
End Class